using FitnessCenterApp.Data;
using FitnessCenterApp.Data.Models;
using FitnessCenterApp.Services.Data.Contracts;
using FitnessCenterApp.Web.ViewModels.FitnessEvent;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using static FitnessCenterApp.Common.ApplicationsConstants;
using static FitnessCenterApp.Common.ErrorMessages.FitnessEvent;
using static FitnessCenterApp.Common.ErrorMessages.Roles;

namespace FitnessCenterApp.Services.Data;

public class FitnessEventService : IFitnessEventService
{
    private readonly ApplicationDbContext _context;
    private readonly UserManager<IdentityUser> _userManager;

    public FitnessEventService(ApplicationDbContext context, UserManager<IdentityUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

    /// <summary>
    /// Get all fitness events with pagination
    /// </summary>
    public async Task<PaginatedFitnessEventsViewModel> GetAllFitnessEventsAsync(string? searchTerm = null, int pageNumber = 1, int pageSize = 6)
    {
        var query = _context.FitnessEvents.AsQueryable();

        if (!string.IsNullOrEmpty(searchTerm))
        {
            query = query.Where(e => e.Title.Contains(searchTerm) || e.Location.Contains(searchTerm));
        }

        var totalEvents = await query.CountAsync();
        var totalPages = (int)Math.Ceiling(totalEvents / (double)pageSize);

        var events = await query
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .Select(e => new AllFitnessEventsViewModel
            {
                Id = e.Id,
                Title = e.Title,
                ImageUrl = e.ImageUrl,
                Location = e.Location,
                StartDateTime = e.StartDate.ToString("dd/MM/yyyy HH:mm"),
                EndDateTime = e.EndDate.ToString("dd/MM/yyyy HH:mm"),
                Capacity = e.Capacity
            })
            .AsNoTracking()
            .ToListAsync();

        return new PaginatedFitnessEventsViewModel
        {
            FitnessEvents = events,
            PageNumber = pageNumber,
            PageSize = pageSize,
            TotalPages = totalPages,
            SearchQuery = searchTerm
        };
    }

    /// <summary>
    /// Get fitness event by id for editing
    /// </summary>
    public async Task<EditFitnessEventViewModel?> GetFitnessEventByIdAsync(int id)
    {
        return await _context.FitnessEvents
            .Where(e => e.Id == id)
            .Select(e => new EditFitnessEventViewModel
            {
                Id = e.Id,
                Title = e.Title,
                Description = e.Description,
                Location = e.Location,
                ImageUrl = e.ImageUrl,
                StartDate = e.StartDate.ToString("yyyy-MM-ddTHH:mm"),
                EndDate = e.EndDate.ToString("yyyy-MM-ddTHH:mm"),
                Capacity = e.Capacity
            })
            .FirstOrDefaultAsync();
    }

    /// <summary>
    /// Get fitness event details
    /// </summary>
    public async Task<FitnessEventDetailsViewModel?> GetFitnessEventDetailsAsync(int id)
    {
        return await _context.FitnessEvents
            .Where(e => e.Id == id)
            .Select(e => new FitnessEventDetailsViewModel
            {
                Id = e.Id,
                Title = e.Title,
                ImageUrl = e.ImageUrl,
                Location = e.Location,
                Description = e.Description,
                StartDateTime = e.StartDate.ToString("dd/MM/yyyy HH:mm"),
                EndDateTime = e.EndDate.ToString("dd/MM/yyyy HH:mm"),
                Capacity = e.Capacity
            })
            .FirstOrDefaultAsync();
    }

    /// <summary>
    /// Get user's fitness events
    /// </summary>
    public async Task<IEnumerable<AllFitnessEventsViewModel>> GetMyFitnessEventsAsync(string userId)
    {
        return await _context.FitnessEventRegistrations
            .Where(r => r.MemberId == userId)
            .Select(r => new AllFitnessEventsViewModel
            {
                Id = r.FitnessEvent.Id,
                Title = r.FitnessEvent.Title,
                ImageUrl = r.FitnessEvent.ImageUrl,
                Location = r.FitnessEvent.Location,
                StartDateTime = r.FitnessEvent.StartDate.ToString("dd/MM/yyyy HH:mm"),
                EndDateTime = r.FitnessEvent.EndDate.ToString("dd/MM/yyyy HH:mm"),
                Capacity = r.FitnessEvent.Capacity
            })
            .AsNoTracking()
            .ToListAsync();
    }

    /// <summary>
    /// Add fitness event to user's fitness events
    /// </summary>
    public async Task AddToMyFitnessEventsAsync(string userId, EditFitnessEventViewModel? fitnessEventViewModel)
    {
        if (fitnessEventViewModel == null)
        {
            throw new ArgumentNullException(nameof(fitnessEventViewModel));
        }

        var user = await _userManager.FindByIdAsync(userId);
        var isMember = user != null && await _userManager.IsInRoleAsync(user, MemberRole);

        if (!isMember)
        {
            throw new InvalidOperationException(OnlyMembersCanRegisterForThisEvent);
        }

        var fitnessEvent = await _context.FitnessEvents
            .Include(fe => fe.FitnessEventRegistrations)
            .FirstOrDefaultAsync(fe => fe.Id == fitnessEventViewModel.Id);

        if (fitnessEvent == null)
        {
            throw new InvalidOperationException(FitnessEventDoesNotExist);
        }

        if (fitnessEvent.FitnessEventRegistrations.Count >= fitnessEvent.Capacity)
        {
            throw new InvalidOperationException(EventFull);
        }

        var existingRegistration = await _context.FitnessEventRegistrations
            .FirstOrDefaultAsync(er => er.MemberId == userId && er.EventId == fitnessEventViewModel.Id);

        if (existingRegistration != null)
        {
            throw new InvalidOperationException(AlreadyRegisteredForEvent);
        }

        var eventRegistration = new FitnessEventRegistration
        {
            MemberId = userId,
            EventId = fitnessEventViewModel.Id,
            ModifiedOn_22180022 = DateTime.UtcNow
        };

        await _context.FitnessEventRegistrations.AddAsync(eventRegistration);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Remove fitness event from user's fitness events
    /// </summary>
    public async Task RemoveFromMyFitnessEventsAsync(string userId, EditFitnessEventViewModel? fitnessEventViewModel)
    {
        if (fitnessEventViewModel == null)
        {
            throw new ArgumentNullException(nameof(fitnessEventViewModel));
        }

        var registration = await _context.FitnessEventRegistrations
            .FirstOrDefaultAsync(er => er.MemberId == userId && er.EventId == fitnessEventViewModel.Id);

        if (registration == null)
        {
            throw new InvalidOperationException(UserNotRegisteredForEvent);
        }

        _context.FitnessEventRegistrations.Remove(registration);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Get fitness event for add
    /// </summary>
    public async Task<AddFitnessEventViewModel> GetFitnessEventForAddAsync()
    {
        var model = new AddFitnessEventViewModel
        {
            Title = string.Empty,
            Description = string.Empty,
            Location = string.Empty,
            ImageUrl = string.Empty,
            StartDate = DateTime.Now.ToString("yyyy-MM-ddTHH:mm"),
            EndDate = DateTime.Now.AddHours(1).ToString("yyyy-MM-ddTHH:mm")
        };

        return await Task.FromResult(model);
    }

    /// <summary>
    /// Add fitness event
    /// </summary>
    public async Task AddFitnessEventAsync(AddFitnessEventViewModel model, string userId)
    {
        if (model == null)
        {
            throw new ArgumentNullException(nameof(model));
        }

        var user = await _userManager.FindByIdAsync(userId);
        var isAdmin = user != null && await _userManager.IsInRoleAsync(user, AdminRole);

        if (!isAdmin)
        {
            throw new UnauthorizedAccessException(YouAreNotAuthorizedToAdd);
        }

        var startDate = DateTime.Parse(model.StartDate);
        var endDate = DateTime.Parse(model.EndDate);

        if (endDate <= startDate)
        {
            throw new InvalidOperationException(EndDateMustBeLaterThanStartDate);
        }

        var fitnessEvent = new FitnessEvent
        {
            Title = model.Title,
            Description = model.Description,
            Location = model.Location,
            ImageUrl = model.ImageUrl,
            StartDate = startDate,
            EndDate = endDate,
            Capacity = model.Capacity,
            ModifiedOn_22180022 = DateTime.UtcNow
        };

        await _context.FitnessEvents.AddAsync(fitnessEvent);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Edit fitness event
    /// </summary>
    public async Task EditFitnessEventAsync(EditFitnessEventViewModel model, string userId)
    {
        var user = await _userManager.FindByIdAsync(userId);
        var isAdmin = user != null && await _userManager.IsInRoleAsync(user, AdminRole);

        if (!isAdmin)
        {
            throw new UnauthorizedAccessException(YouAreNotAuthorizedToEdit);
        }

        var fitnessEvent = await _context.FitnessEvents.FindAsync(model.Id);

        if (fitnessEvent == null)
        {
            throw new InvalidOperationException(FitnessEventDoesNotExist);
        }

        var startDate = DateTime.Parse(model.StartDate);
        var endDate = DateTime.Parse(model.EndDate);

        if (endDate <= startDate)
        {
            throw new InvalidOperationException(EndDateMustBeLaterThanStartDate);
        }

        if (startDate < DateTime.Now)
        {
            throw new InvalidOperationException(StartDateCannotBeInThePast);
        }

        fitnessEvent.Title = model.Title;
        fitnessEvent.Description = model.Description;
        fitnessEvent.Location = model.Location;
        fitnessEvent.ImageUrl = model.ImageUrl;
        fitnessEvent.StartDate = startDate;
        fitnessEvent.EndDate = endDate;
        fitnessEvent.Capacity = model.Capacity;
        fitnessEvent.ModifiedOn_22180022 = DateTime.UtcNow;

        _context.FitnessEvents.Update(fitnessEvent);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Get fitness event for delete
    /// </summary>
    public async Task<DeleteFitnessEventViewModel?> GetFitnessEventForDeleteAsync(int id)
    {
        return await _context.FitnessEvents
            .Where(fe => fe.Id == id)
            .Select(fe => new DeleteFitnessEventViewModel
            {
                Id = fe.Id,
                Title = fe.Title,
                Description = fe.Description
            })
            .FirstOrDefaultAsync();
    }

    /// <summary>
    /// Delete fitness event
    /// </summary>
    public async Task DeleteFitnessEventAsync(int id, string userId)
    {
        var user = await _userManager.FindByIdAsync(userId);
        var isAdmin = user != null && await _userManager.IsInRoleAsync(user, AdminRole);

        if (!isAdmin)
        {
            throw new UnauthorizedAccessException(YouAreNotAuthorizedToDelete);
        }

        var fitnessEvent = await _context.FitnessEvents.FindAsync(id);

        if (fitnessEvent != null)
        {
            _context.FitnessEvents.Remove(fitnessEvent);
            await _context.SaveChangesAsync();
        }
        else
        {
            throw new InvalidOperationException(FitnessEventDoesNotExist);
        }
    }
}
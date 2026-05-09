using FitnessCenterApp.Data;
using FitnessCenterApp.Data.Models;
using FitnessCenterApp.Services.Data.Contracts;
using FitnessCenterApp.Web.ViewModels.FitnessEvent;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using static FitnessCenterApp.Common.ApplicationsConstants;
using static FitnessCenterApp.Common.ErrorMessages.FitnessEvent;
using static FitnessCenterApp.Common.ErrorMessages.Roles;
using static FitnessCenterApp.Common.ErrorMessages.ConcurrencyControl;
using static FitnessCenterApp.Common.EntityValidationConstants.FitnessEvent;
using static FitnessCenterApp.Common.ErrorMessages.General;

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

    /// <inheritdoc />
    public async Task<PaginatedFitnessEventsViewModel> GetAllFitnessEventsAsync(string? searchTerm = null, string? sortOrder = null, int pageNumber = 1, int pageSize = 6)
    {
        var query = _context.FitnessEvents.AsQueryable();

        if (!string.IsNullOrEmpty(searchTerm))
        {
            query = query.Where(e => e.Title.Contains(searchTerm) || e.Location.Contains(searchTerm));
        }

        query = sortOrder switch
        {
            "date_asc" => query.OrderBy(e => e.StartDate),
            "date_desc" => query.OrderByDescending(e => e.StartDate),
            "title_asc" => query.OrderBy(e => e.Title),
            "title_desc" => query.OrderByDescending(e => e.Title),
            _ => query.OrderByDescending(e => e.Id)
        };

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
                StartDateTime = e.StartDate.ToString(DateTimeFormat),
                EndDateTime = e.EndDate.ToString(DateTimeFormat),
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

    /// <inheritdoc />
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
                Capacity = e.Capacity,
                ModifiedOn_22180022 = e.ModifiedOn_22180022
            })
            .FirstOrDefaultAsync();
    }

    /// <inheritdoc />
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
                StartDateTime = e.StartDate.ToString(DateTimeFormat),
                EndDateTime = e.EndDate.ToString(DateTimeFormat),
                Capacity = e.Capacity
            })
            .FirstOrDefaultAsync();
    }

    /// <inheritdoc />
    public async Task<IEnumerable<AllFitnessEventsViewModel>> GetMyFitnessEventsAsync(string userId)
    {
        if (string.IsNullOrEmpty(userId)) throw new InvalidOperationException(UserIdCannotBeEmpty);

        return await _context.FitnessEventRegistrations
            .Where(r => r.MemberId == userId)
            .Select(r => new AllFitnessEventsViewModel
            {
                Id = r.FitnessEvent.Id,
                Title = r.FitnessEvent.Title,
                ImageUrl = r.FitnessEvent.ImageUrl,
                Location = r.FitnessEvent.Location,
                StartDateTime = r.FitnessEvent.StartDate.ToString(DateTimeFormat),
                EndDateTime = r.FitnessEvent.EndDate.ToString(DateTimeFormat),
                Capacity = r.FitnessEvent.Capacity
            })
            .AsNoTracking()
            .ToListAsync();
    }

    /// <inheritdoc />
    public async Task AddToMyFitnessEventsAsync(string userId, EditFitnessEventViewModel? fitnessEventViewModel)
    {
        if (string.IsNullOrEmpty(userId)) throw new InvalidOperationException(UserIdCannotBeEmpty);

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

    /// <inheritdoc />
    public async Task RemoveFromMyFitnessEventsAsync(string userId, EditFitnessEventViewModel? fitnessEventViewModel)
    {
        if (string.IsNullOrEmpty(userId)) throw new InvalidOperationException(UserIdCannotBeEmpty);

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

    /// <inheritdoc />
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

    /// <inheritdoc />
    public async Task AddFitnessEventAsync(AddFitnessEventViewModel model, string userId)
    {
        if (string.IsNullOrEmpty(userId)) throw new InvalidOperationException(UserIdCannotBeEmpty);

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

    /// <inheritdoc />
    public async Task EditFitnessEventAsync(EditFitnessEventViewModel model, string userId)
    {
        if (string.IsNullOrEmpty(userId)) throw new InvalidOperationException(UserIdCannotBeEmpty);

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

        _context.Entry(fitnessEvent).Property(e => e.ModifiedOn_22180022).OriginalValue = model.ModifiedOn_22180022;

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

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            throw new InvalidOperationException(ConcurrencyControlMessage);
        }
    }

    /// <inheritdoc />
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

    /// <inheritdoc />
    public async Task DeleteFitnessEventAsync(int id, string userId)
    {
        if (string.IsNullOrEmpty(userId)) throw new InvalidOperationException(UserIdCannotBeEmpty);

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
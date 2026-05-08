using FitnessCenterApp.Data;
using FitnessCenterApp.Data.Models;
using FitnessCenterApp.Services.Data.Contracts;
using FitnessCenterApp.Web.ViewModels.SpaProcedure;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using static FitnessCenterApp.Common.ApplicationsConstants;
using static FitnessCenterApp.Common.ErrorMessages.SpaProcedure;
using static FitnessCenterApp.Common.ErrorMessages.Roles;
using static FitnessCenterApp.Common.ErrorMessages.ConcurrencyControl;
using static FitnessCenterApp.Common.EntityValidationConstants.SpaProcedure;

namespace FitnessCenterApp.Services.Data;

public class SpaProcedureService : ISpaProcedureService
{
    private readonly ApplicationDbContext _context;
    private readonly UserManager<IdentityUser> _userManager;

    public SpaProcedureService(ApplicationDbContext context, UserManager<IdentityUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

    /// <inheritdoc />
    public async Task<PaginatedSpaProceduresViewModel> GetAllSpaProceduresPaginationAsync(string? searchQuery = null, string? sortOrder = null, int pageNumber = 1, int pageSize = 4)
    {
        var query = _context.SpaProcedures.AsQueryable();

        if (!string.IsNullOrEmpty(searchQuery))
        {
            query = query.Where(sp => sp.Name.Contains(searchQuery) || sp.Description.Contains(searchQuery));
        }

        var totalProcedures = await query.CountAsync();
        var totalPages = (int)Math.Ceiling(totalProcedures / (double)pageSize);

        var spaProcedures = await query
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .Select(sp => new AllSpaProceduresViewModel
            {
                Id = sp.Id,
                Name = sp.Name,
                Description = sp.Description,
                ImageUrl = sp.ImageUrl,
                Capacity = sp.Capacity,
                AppointmentDateTime = sp.AppointmentDateTime.ToString(AppointmentDateTimeFormat)
            })
            .AsNoTracking()
            .ToListAsync();

        return new PaginatedSpaProceduresViewModel
        {
            SpaProcedures = spaProcedures,
            PageNumber = pageNumber,
            PageSize = pageSize,
            TotalPages = totalPages,
            SearchQuery = searchQuery
        };
    }

    /// <inheritdoc />
    public async Task<IEnumerable<AllSpaProceduresViewModel>> GetAllSpaProceduresAsync(string? searchQuery = null, int? minDuration = null, int? maxDuration = null, string? sortOrder = null)
    {
        var query = _context.SpaProcedures.AsQueryable();

        if (!string.IsNullOrEmpty(searchQuery))
        {
            query = query.Where(sp => sp.Name.Contains(searchQuery) || sp.Description.Contains(searchQuery));
        }

        if (minDuration.HasValue)
        {
            query = query.Where(sp => sp.Duration >= minDuration.Value);
        }

        if (maxDuration.HasValue)
        {
            query = query.Where(sp => sp.Duration <= maxDuration.Value);
        }

        return await query
            .Select(sp => new AllSpaProceduresViewModel
            {
                Id = sp.Id,
                Name = sp.Name,
                Description = sp.Description,
                ImageUrl = sp.ImageUrl,
                Capacity = sp.Capacity,
                AppointmentDateTime = sp.AppointmentDateTime.ToString(AppointmentDateTimeFormat)
            })
            .AsNoTracking()
            .ToListAsync();
    }

    /// <inheritdoc />
    public async Task<EditSpaProcedureViewModel?> GetSpaProceduresByIdAsync(int id)
    {
        return await _context.SpaProcedures
            .Where(sp => sp.Id == id)
            .Select(sp => new EditSpaProcedureViewModel
            {
                Id = sp.Id,
                Name = sp.Name,
                ImageUrl = sp.ImageUrl,
                Description = sp.Description,
                Price = sp.Price,
                Duration = sp.Duration,
                Capacity = sp.Capacity,
                ModifiedOn_22180022 = sp.ModifiedOn_22180022
            })
            .FirstOrDefaultAsync();
    }

    /// <inheritdoc />
    public async Task<SpaProcedureDetailsViewModel?> GetSpaProceduresDetailsAsync(int id)
    {
        return await _context.SpaProcedures
            .Where(x => x.Id == id)
            .Select(x => new SpaProcedureDetailsViewModel
            {
                Id = x.Id,
                Name = x.Name,
                ImageUrl = x.ImageUrl,
                Description = x.Description,
                Price = x.Price,
                Duration = x.Duration,
                Capacity = x.Capacity
            })
            .FirstOrDefaultAsync();
    }

    /// <inheritdoc />
    public async Task<IEnumerable<AllSpaProceduresViewModel>> GetMySpaProceduresAsync(string userId)
    {
        return await _context.SpaRegistrations
            .Where(sr => sr.MemberId == userId)
            .Select(sr => new AllSpaProceduresViewModel
            {
                Id = sr.SpaProcedureId,
                Name = sr.SpaProcedure.Name,
                ImageUrl = sr.SpaProcedure.ImageUrl,
                Description = sr.SpaProcedure.Description,
                Capacity = sr.SpaProcedure.Capacity,
                AppointmentDateTime = sr.SpaProcedure.AppointmentDateTime.ToString(AppointmentDateTimeFormat)
            })
            .AsNoTracking()
            .ToListAsync();
    }

    /// <inheritdoc />
    public async Task AddToMySpaAppointmentsAsync(string userId, EditSpaProcedureViewModel spaProcedure, DateTime appointmentDateTime)
    {
        if (appointmentDateTime < DateTime.Now)
        {
            throw new InvalidOperationException(PastAppointmentDate);
        }

        TimeSpan timeOfDay = appointmentDateTime.TimeOfDay;
        TimeSpan startTime = new TimeSpan(9, 0, 0);
        TimeSpan endTime = new TimeSpan(18, 0, 0);

        if (timeOfDay < startTime || timeOfDay > endTime)
        {
            throw new InvalidOperationException("Appointments can only be booked between 09:00 and 18:00.");
        }

        var user = await _userManager.FindByIdAsync(userId);
        if (user == null || !await _userManager.IsInRoleAsync(user, MemberRole))
        {
            throw new InvalidOperationException(OnlyMembersCanBookSpaProcedures);
        }

        var procedureEntity = await _context.SpaProcedures
            .Include(sp => sp.SpaRegistrations)
            .FirstOrDefaultAsync(sp => sp.Id == spaProcedure.Id);

        if (procedureEntity == null)
        {
            throw new InvalidOperationException(SpaProcedureNotFound);
        }

        if (procedureEntity.SpaRegistrations.Count >= procedureEntity.Capacity)
        {
            throw new InvalidOperationException(SpaProcedureFull);
        }

        var existingRegistration = await _context.SpaRegistrations
            .FirstOrDefaultAsync(sr => sr.MemberId == userId && sr.SpaProcedureId == spaProcedure.Id);

        if (existingRegistration != null)
        {
            throw new InvalidOperationException(AlreadyBookedAppointment);
        }

        var spaRegistration = new SpaRegistration
        {
            MemberId = userId,
            SpaProcedureId = spaProcedure.Id,
            ModifiedOn_22180022 = DateTime.UtcNow
        };

        await _context.SpaRegistrations.AddAsync(spaRegistration);

        procedureEntity.AppointmentDateTime = appointmentDateTime;
        procedureEntity.ModifiedOn_22180022 = DateTime.UtcNow;

        await _context.SaveChangesAsync();
    }

    /// <inheritdoc />
    public async Task RemoveFromMySpaAppointmentsAsync(string userId, EditSpaProcedureViewModel spaProcedure)
    {
        var registration = await _context.SpaRegistrations
            .FirstOrDefaultAsync(sr => sr.MemberId == userId && sr.SpaProcedureId == spaProcedure.Id);

        if (registration == null)
        {
            throw new InvalidOperationException(SpaAppointmentNotBooked);
        }

        _context.SpaRegistrations.Remove(registration);
        await _context.SaveChangesAsync();
    }

    /// <inheritdoc />
    public async Task<AddSpaProcedureViewModel> GetSpaProcedureForAddAsync()
    {
        var model = new AddSpaProcedureViewModel
        {
            Name = string.Empty,
            ImageUrl = string.Empty,
            Description = string.Empty,
            Duration = 0,
            Price = 0.0m,
            Capacity = 1
        };

        return await Task.FromResult(model);
    }

    /// <inheritdoc />
    public async Task AddSpaProcedureAsync(AddSpaProcedureViewModel model, string userId)
    {
        var user = await _userManager.FindByIdAsync(userId);
        var isAdmin = user != null && await _userManager.IsInRoleAsync(user, AdminRole);

        if (!isAdmin)
        {
            throw new UnauthorizedAccessException(YouAreNotAuthorizedToAdd);
        }

        var spaProcedure = new SpaProcedure
        {
            Name = model.Name,
            ImageUrl = model.ImageUrl,
            Description = model.Description,
            Duration = model.Duration,
            Price = model.Price,
            Capacity = model.Capacity,
            AppointmentDateTime = DateTime.UtcNow,
            ModifiedOn_22180022 = DateTime.UtcNow
        };

        await _context.SpaProcedures.AddAsync(spaProcedure);
        await _context.SaveChangesAsync();
    }

    /// <inheritdoc />
    public async Task EditSpaProcedureAsync(EditSpaProcedureViewModel model, string userId)
    {
        var user = await _userManager.FindByIdAsync(userId);
        var isAdmin = user != null && await _userManager.IsInRoleAsync(user, AdminRole);

        if (!isAdmin)
        {
            throw new UnauthorizedAccessException(YouAreNotAuthorizedToEdit);
        }

        var spaProcedure = await _context.SpaProcedures.FindAsync(model.Id);

        if (spaProcedure == null)
        {
            throw new InvalidOperationException(SpaProcedureNotFound);
        }

        _context.Entry(spaProcedure).Property(sp => sp.ModifiedOn_22180022).OriginalValue = model.ModifiedOn_22180022;

        spaProcedure.Name = model.Name;
        spaProcedure.ImageUrl = model.ImageUrl;
        spaProcedure.Description = model.Description;
        spaProcedure.Duration = model.Duration;
        spaProcedure.Price = model.Price;
        spaProcedure.Capacity = model.Capacity;
        spaProcedure.ModifiedOn_22180022 = DateTime.UtcNow;

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
    public async Task<DeleteSpaProcedureViewModel?> GetSpaProcedureForDeleteAsync(int id)
    {
        return await _context.SpaProcedures
            .Where(sp => sp.Id == id)
            .Select(sp => new DeleteSpaProcedureViewModel
            {
                Id = sp.Id,
                Name = sp.Name,
                Description = sp.Description
            })
            .FirstOrDefaultAsync();
    }

    /// <inheritdoc />
    public async Task DeleteSpaProcedureAsync(int id, string userId)
    {
        var user = await _userManager.FindByIdAsync(userId);
        var isAdmin = user != null && await _userManager.IsInRoleAsync(user, AdminRole);

        if (!isAdmin)
        {
            throw new UnauthorizedAccessException(YouAreNotAuthorizedToDelete);
        }

        var spaProcedure = await _context.SpaProcedures.FirstOrDefaultAsync(sp => sp.Id == id);

        if (spaProcedure == null)
        {
            throw new InvalidOperationException(SpaProcedureNotFound);
        }

        _context.SpaProcedures.Remove(spaProcedure);
        await _context.SaveChangesAsync();
    }
}
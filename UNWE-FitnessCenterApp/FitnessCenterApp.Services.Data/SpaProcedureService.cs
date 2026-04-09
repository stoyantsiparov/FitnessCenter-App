using FitnessCenterApp.Data;
using FitnessCenterApp.Data.Models;
using FitnessCenterApp.Services.Data.Contracts;
using FitnessCenterApp.Web.ViewModels.SpaProcedure;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using static FitnessCenterApp.Common.ApplicationsConstants;
using static FitnessCenterApp.Common.ErrorMessages.SpaProcedure;
using static FitnessCenterApp.Common.ErrorMessages.Roles;

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

    /// <summary>
    /// Get all spa procedures with pagination
    /// </summary>
    public async Task<PaginatedSpaProceduresViewModel> GetAllSpaProceduresPaginationAsync(string? searchQuery = null, int pageNumber = 1, int pageSize = 4)
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
                AppointmentDateTime = sp.AppointmentDateTime.ToString("dd/MM/yyyy HH:mm")
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

    /// <summary>
    /// Get all spa procedures with filters (Search, Min/Max Duration)
    /// </summary>
    public async Task<IEnumerable<AllSpaProceduresViewModel>> GetAllSpaProceduresAsync(string? searchQuery = null, int? minDuration = null, int? maxDuration = null)
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
                AppointmentDateTime = sp.AppointmentDateTime.ToString("dd/MM/yyyy HH:mm")
            })
            .AsNoTracking()
            .ToListAsync();
    }

    /// <summary>
    /// Get spa procedure by id for editing
    /// </summary>
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
                Capacity = sp.Capacity
            })
            .FirstOrDefaultAsync();
    }

    /// <summary>
    /// Get spa procedure details
    /// </summary>
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

    /// <summary>
    /// Get user's spa procedures
    /// </summary>
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
                AppointmentDateTime = sr.SpaProcedure.AppointmentDateTime.ToString("dd/MM/yyyy HH:mm")
            })
            .AsNoTracking()
            .ToListAsync();
    }

    /// <summary>
    /// Add spa procedure to user's appointments
    /// </summary>
    public async Task AddToMySpaAppointmentsAsync(string userId, EditSpaProcedureViewModel spaProcedure, DateTime appointmentDateTime)
    {
        if (appointmentDateTime < DateTime.Now)
        {
            throw new InvalidOperationException(PastAppointmentDate);
        }

        var user = await _userManager.FindByIdAsync(userId);
        if (user == null || !await _userManager.IsInRoleAsync(user, MemberRole))
        {
            throw new InvalidOperationException(OnlyMembersCanBookSpaProcedures);
        }

        // Зареждаме процедурата заедно с текущите регистрации за да проверим капацитета
        var procedureEntity = await _context.SpaProcedures
            .Include(sp => sp.SpaRegistrations)
            .FirstOrDefaultAsync(sp => sp.Id == spaProcedure.Id);

        if (procedureEntity == null)
        {
            throw new InvalidOperationException(SpaProcedureNotFound);
        }

        // Проверка за КАПАЦИТЕТ
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
            ModifiedOn_22180022 = DateTime.UtcNow // Задължителното поле!
        };

        await _context.SpaRegistrations.AddAsync(spaRegistration);

        // Както в оригиналния ти проект, обновяваме датата на самата процедура
        procedureEntity.AppointmentDateTime = appointmentDateTime;

        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Remove spa procedure from user's appointments
    /// </summary>
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

    /// <summary>
    /// Get spa procedure for add
    /// </summary>
    public async Task<AddSpaProcedureViewModel> GetSpaProcedureForAddAsync()
    {
        var model = new AddSpaProcedureViewModel
        {
            Name = string.Empty,
            ImageUrl = string.Empty,
            Description = string.Empty,
            Duration = 0,
            Price = 0.0m
        };

        return await Task.FromResult(model);
    }

    /// <summary>
    /// Add spa procedure
    /// </summary>
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

    /// <summary>
    /// Edit spa procedure
    /// </summary>
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

        spaProcedure.Name = model.Name;
        spaProcedure.ImageUrl = model.ImageUrl;
        spaProcedure.Description = model.Description;
        spaProcedure.Duration = model.Duration;
        spaProcedure.Price = model.Price;
        spaProcedure.Capacity = model.Capacity;
        spaProcedure.ModifiedOn_22180022 = DateTime.UtcNow;

        _context.SpaProcedures.Update(spaProcedure);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Get spa procedure for delete
    /// </summary>
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

    /// <summary>
    /// Delete spa procedure
    /// </summary>
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
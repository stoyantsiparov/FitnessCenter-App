using FitnessCenterApp.Data;
using FitnessCenterApp.Data.Models;
using FitnessCenterApp.Services.Data.Contracts;
using FitnessCenterApp.Web.ViewModels.SpaProcedure;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using static FitnessCenterApp.Common.ApplicationsConstants;
using static FitnessCenterApp.Common.EntityValidationConstants.SpaProcedure;
using static FitnessCenterApp.Common.ErrorMessages.ConcurrencyControl;
using static FitnessCenterApp.Common.ErrorMessages.General;
using static FitnessCenterApp.Common.ErrorMessages.Roles;
using static FitnessCenterApp.Common.ErrorMessages.SpaProcedure;

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
    public async Task<PaginatedSpaProceduresViewModel> GetAllSpaProceduresPaginationAsync(string? searchQuery = null, string? sortOrder = null, int pageNumber = DefaultPageNumber, int pageSize = DefaultEntitiesPerPage)
    {
        var query = _context.SpaProcedures.AsQueryable();

        if (!string.IsNullOrEmpty(searchQuery))
        {
            query = query.Where(sp => sp.Name.Contains(searchQuery) || sp.Description.Contains(searchQuery));
        }

        query = sortOrder switch
        {
            "name_asc" => query.OrderBy(sp => sp.Name),
            "name_desc" => query.OrderByDescending(sp => sp.Name),
            _ => query.OrderByDescending(sp => sp.Id)
        };

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
                ParticipantsCount = sp.SpaRegistrations.Count(),
                UserIds = sp.SpaRegistrations.Select(r => r.MemberId).ToList()
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

        query = sortOrder switch
        {
            "name_asc" => query.OrderBy(sp => sp.Name),
            "name_desc" => query.OrderByDescending(sp => sp.Name),
            _ => query.OrderByDescending(sp => sp.Id)
        };

        return await query
            .Select(sp => new AllSpaProceduresViewModel
            {
                Id = sp.Id,
                Name = sp.Name,
                Description = sp.Description,
                ImageUrl = sp.ImageUrl,
                Capacity = sp.Capacity,
                ParticipantsCount = sp.SpaRegistrations.Count(),
                UserIds = sp.SpaRegistrations.Select(r => r.MemberId).ToList()
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
        if (string.IsNullOrEmpty(userId)) throw new InvalidOperationException(UserIdCannotBeEmpty);

        var now = DateTime.Now;

        return await _context.SpaRegistrations
            .Where(sr => sr.MemberId == userId && sr.AppointmentDateTime.AddMinutes(sr.SpaProcedure.Duration) >= now)
            .Select(sr => new AllSpaProceduresViewModel
            {
                Id = sr.SpaProcedureId,
                Name = sr.SpaProcedure.Name,
                ImageUrl = sr.SpaProcedure.ImageUrl,
                Description = sr.SpaProcedure.Description,
                Capacity = sr.SpaProcedure.Capacity,
                AppointmentDateTime = sr.AppointmentDateTime.ToString(AppointmentDateTimeFormat)
            })
            .AsNoTracking()
            .ToListAsync();
    }

    /// <inheritdoc />
    public async Task AddToMySpaAppointmentsAsync(string userId, EditSpaProcedureViewModel spaProcedure, DateTime appointmentDateTime)
    {
        if (string.IsNullOrEmpty(userId)) throw new InvalidOperationException(UserIdCannotBeEmpty);

        var now = DateTime.Now;

        if (appointmentDateTime < now)
        {
            throw new InvalidOperationException(PastAppointmentDate);
        }

        if (appointmentDateTime > now.AddDays(7))
        {
            throw new InvalidOperationException(CannotBookMoreThanOneWeekAhead);
        }

        var procedureEntity = await _context.SpaProcedures
            .FirstOrDefaultAsync(sp => sp.Id == spaProcedure.Id);

        if (procedureEntity == null) throw new InvalidOperationException(SpaProcedureNotFound);

        var appointmentEndTime = appointmentDateTime.AddMinutes(procedureEntity.Duration);

        var openTime = new TimeSpan(9, 0, 0);
        var closeTime = new TimeSpan(18, 0, 0);
        if (appointmentDateTime.TimeOfDay < openTime || appointmentEndTime.TimeOfDay > closeTime)
        {
            throw new InvalidOperationException(OutsideWorkingHours);
        }

        var user = await _userManager.FindByIdAsync(userId);
        if (user == null || !await _userManager.IsInRoleAsync(user, MemberRole))
        {
            throw new InvalidOperationException(OnlyMembersCanBookSpaProcedures);
        }

        var userRegistration = await _context.MembershipRegistrations
            .Include(r => r.MembershipType)
            .FirstOrDefaultAsync(r => r.MemberId == userId);

        if (userRegistration == null)
        {
            throw new InvalidOperationException(MustHaveActiveMembership);
        }

        int allowedPerWeek = userRegistration.MembershipType.AllowedSpaProceduresPerWeek;
        if (allowedPerWeek == 0)
        {
            throw new InvalidOperationException(MembershipDoesNotIncludeSpa);
        }

        DateTime today = appointmentDateTime.Date;
        int diff = (7 + (today.DayOfWeek - DayOfWeek.Monday)) % 7;
        DateTime startOfWeek = today.AddDays(-1 * diff).Date;
        DateTime endOfWeek = startOfWeek.AddDays(7).AddTicks(-1);

        int existingBookingsThisWeek = await _context.SpaRegistrations
            .Where(sr => sr.MemberId == userId &&
                         sr.AppointmentDateTime >= startOfWeek &&
                         sr.AppointmentDateTime <= endOfWeek)
            .CountAsync();

        if (existingBookingsThisWeek >= allowedPerWeek)
        {
            throw new InvalidOperationException(string.Format(WeeklySpaLimitReached, allowedPerWeek));
        }

        var hasBookedThisWeek = await _context.SpaRegistrations
            .AnyAsync(r => r.MemberId == userId &&
                           r.SpaProcedureId == spaProcedure.Id &&
                           r.AppointmentDateTime >= appointmentDateTime.AddDays(-7) &&
                           r.AppointmentDateTime <= appointmentDateTime.AddDays(7));

        if (hasBookedThisWeek)
        {
            throw new InvalidOperationException(AlreadyBookedThisTypeForWeek);
        }

        var searchMinDate = appointmentDateTime.AddDays(-1);
        var searchMaxDate = appointmentDateTime.AddDays(1);

        var userRegistrations = await _context.SpaRegistrations
            .Include(r => r.SpaProcedure)
            .Where(r => r.MemberId == userId &&
                        r.AppointmentDateTime >= searchMinDate &&
                        r.AppointmentDateTime <= searchMaxDate)
            .ToListAsync();

        foreach (var reg in userRegistrations)
        {
            var regStart = reg.AppointmentDateTime;
            var regEnd = regStart.AddMinutes(reg.SpaProcedure.Duration);

            var regStartWithBuffer = regStart.AddMinutes(-30);
            var regEndWithBuffer = regEnd.AddMinutes(30);

            if (appointmentDateTime < regEndWithBuffer && appointmentEndTime > regStartWithBuffer)
            {
                throw new InvalidOperationException(OverlappingAppointmentWithBuffer);
            }
        }

        var overlappingGlobalBookings = await _context.SpaRegistrations
            .Include(r => r.SpaProcedure)
            .Where(r => r.SpaProcedureId == spaProcedure.Id &&
                        r.AppointmentDateTime >= searchMinDate &&
                        r.AppointmentDateTime <= searchMaxDate)
            .ToListAsync();

        int activeConcurrentSessions = 0;
        foreach (var booking in overlappingGlobalBookings)
        {
            var bookingEnd = booking.AppointmentDateTime.AddMinutes(booking.SpaProcedure.Duration);

            if (appointmentDateTime < bookingEnd && appointmentEndTime > booking.AppointmentDateTime)
            {
                activeConcurrentSessions++;
            }
        }

        if (activeConcurrentSessions >= procedureEntity.Capacity)
        {
            throw new InvalidOperationException(SpaProcedureFullAtThisTime);
        }

        var spaRegistration = new SpaRegistration
        {
            MemberId = userId,
            SpaProcedureId = spaProcedure.Id,
            AppointmentDateTime = appointmentDateTime,
            ModifiedOn_22180022 = DateTime.UtcNow
        };

        await _context.SpaRegistrations.AddAsync(spaRegistration);
        await _context.SaveChangesAsync();
    }

    /// <inheritdoc />
    public async Task RemoveFromMySpaAppointmentsAsync(string userId, EditSpaProcedureViewModel spaProcedure)
    {
        if (string.IsNullOrEmpty(userId)) throw new InvalidOperationException(UserIdCannotBeEmpty);

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
        if (string.IsNullOrEmpty(userId)) throw new InvalidOperationException(UserIdCannotBeEmpty);

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
            ModifiedOn_22180022 = DateTime.UtcNow
        };

        await _context.SpaProcedures.AddAsync(spaProcedure);
        await _context.SaveChangesAsync();
    }

    /// <inheritdoc />
    public async Task EditSpaProcedureAsync(EditSpaProcedureViewModel model, string userId)
    {
        if (string.IsNullOrEmpty(userId)) throw new InvalidOperationException(UserIdCannotBeEmpty);

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
        if (string.IsNullOrEmpty(userId)) throw new InvalidOperationException(UserIdCannotBeEmpty);

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

    /// <inheritdoc />
    public async Task<SpaParticipantsViewModel?> GetSpaParticipantsAsync(int procedureId)
    {
        var spaProcedure = await _context.SpaProcedures
            .Include(sp => sp.SpaRegistrations)
            .FirstOrDefaultAsync(sp => sp.Id == procedureId);

        if (spaProcedure == null) return null;

        var participantsList = new List<SpaParticipantViewModel>();
        var now = DateTime.Now;

        var activeRegistrations = spaProcedure.SpaRegistrations
            .Where(r => r.AppointmentDateTime.AddMinutes(spaProcedure.Duration) >= now);

        foreach (var registration in activeRegistrations)
        {
            var user = await _userManager.FindByIdAsync(registration.MemberId);
            if (user != null)
            {
                participantsList.Add(new SpaParticipantViewModel
                {
                    UserId = user.Id,
                    Email = user.Email ?? UnknownEmail,
                    AppointmentTime = registration.AppointmentDateTime.ToString(AppointmentDateTimeFormat)
                });
            }
        }

        return new SpaParticipantsViewModel
        {
            ProcedureId = spaProcedure.Id,
            ProcedureName = spaProcedure.Name,
            Capacity = spaProcedure.Capacity,
            CurrentParticipantsCount = participantsList.Count,
            Participants = participantsList
        };
    }

    /// <inheritdoc />
    public async Task RemoveParticipantFromSpaAdminAsync(int procedureId, string userId)
    {
        if (string.IsNullOrEmpty(userId)) throw new InvalidOperationException(UserIdCannotBeEmpty);

        var registration = await _context.SpaRegistrations
            .FirstOrDefaultAsync(r => r.SpaProcedureId == procedureId && r.MemberId == userId);

        if (registration == null)
        {
            throw new InvalidOperationException(SpaAppointmentNotBooked);
        }

        _context.SpaRegistrations.Remove(registration);
        await _context.SaveChangesAsync();
    }
}
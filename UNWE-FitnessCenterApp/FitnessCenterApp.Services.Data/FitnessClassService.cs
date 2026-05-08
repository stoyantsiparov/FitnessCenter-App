using FitnessCenterApp.Data;
using FitnessCenterApp.Data.Models;
using FitnessCenterApp.Services.Data.Contracts;
using FitnessCenterApp.Web.ViewModels.FitnessClass;
using FitnessCenterApp.Web.ViewModels.Instructor;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using static FitnessCenterApp.Common.ApplicationsConstants;
using static FitnessCenterApp.Common.ErrorMessages.FitnessClass;
using static FitnessCenterApp.Common.ErrorMessages.Roles;
using static FitnessCenterApp.Common.ErrorMessages.ConcurrencyControl;
using static FitnessCenterApp.Common.EntityValidationConstants.FitnessClass;

namespace FitnessCenterApp.Services.Data;

public class FitnessClassService : IFitnessClassService
{
    private readonly ApplicationDbContext _context;
    private readonly UserManager<IdentityUser> _userManager;

    public FitnessClassService(ApplicationDbContext context, UserManager<IdentityUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

    /// <inheritdoc />
    public async Task<IEnumerable<AllFitnessClassesViewModel>> GetAllClassesAsync(string? searchQuery = null, int? minDuration = null, int? maxDuration = null, string? sortOrder = null)
    {
        var query = _context.FitnessClasses.AsQueryable();

        if (!string.IsNullOrEmpty(searchQuery)) query = query.Where(c => c.Name.Contains(searchQuery));
        if (minDuration.HasValue) query = query.Where(c => c.Duration >= minDuration.Value);
        if (maxDuration.HasValue) query = query.Where(c => c.Duration <= maxDuration.Value);

        return await query
            .Select(c => new AllFitnessClassesViewModel
            {
                Id = c.Id,
                Name = c.Name,
                ImageUrl = c.ImageUrl,
                Schedule = c.ScheduleDateTime.ToString(ScheduleDateTimeFormat),
                Duration = c.Duration,
                Capacity = c.Capacity
            })
            .AsNoTracking()
            .ToListAsync();
    }

    /// <inheritdoc />
    public async Task<PaginatedFitnessClassesViewModel> GetAllClassesPaginationAsync(string? searchQuery = null, int? minDuration = null, int? maxDuration = null, string? sortOrder = null, int pageNumber = 1, int pageSize = 6)
    {
        var query = _context.FitnessClasses.AsQueryable();

        if (!string.IsNullOrEmpty(searchQuery)) query = query.Where(c => c.Name.Contains(searchQuery));
        if (minDuration.HasValue) query = query.Where(c => c.Duration >= minDuration.Value);
        if (maxDuration.HasValue) query = query.Where(c => c.Duration <= maxDuration.Value);

        int totalClasses = await query.CountAsync();
        int totalPages = (int)Math.Ceiling(totalClasses / (double)pageSize);

        var classes = await query
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .Select(c => new AllFitnessClassesViewModel
            {
                Id = c.Id,
                Name = c.Name,
                ImageUrl = c.ImageUrl,
                Schedule = c.ScheduleDateTime.ToString(ScheduleDateTimeFormat),
                Duration = c.Duration,
                Capacity = c.Capacity
            })
            .AsNoTracking()
            .ToListAsync();

        return new PaginatedFitnessClassesViewModel
        {
            FitnessClasses = classes,
            PageNumber = pageNumber,
            PageSize = pageSize,
            TotalPages = totalPages,
            SearchQuery = searchQuery,
            MinDuration = minDuration,
            MaxDuration = maxDuration
        };
    }

    /// <inheritdoc />
    public async Task<EditFitnessClassViewModel?> GetClassByIdAsync(int id)
    {
        return await _context.FitnessClasses
            .Where(c => c.Id == id)
            .Select(c => new EditFitnessClassViewModel
            {
                Id = c.Id,
                Name = c.Name,
                Description = c.Description,
                Price = c.Price,
                ImageUrl = c.ImageUrl,
                Schedule = c.ScheduleDateTime.ToString("yyyy-MM-ddTHH:mm"),
                Duration = c.Duration,
                Capacity = c.Capacity,
                InstructorId = c.InstructorId,
                ModifiedOn_22180022 = c.ModifiedOn_22180022
            })
            .FirstOrDefaultAsync();
    }

    /// <inheritdoc />
    public async Task<FitnessClassDetailsViewModel?> GetClassDetailsAsync(int id)
    {
        return await _context.FitnessClasses
            .Where(c => c.Id == id)
            .Select(c => new FitnessClassDetailsViewModel
            {
                Id = c.Id,
                Name = c.Name,
                Description = c.Description,
                Price = c.Price,
                ImageUrl = c.ImageUrl,
                Schedule = c.ScheduleDateTime.ToString(ScheduleDateTimeFormat),
                Duration = c.Duration,
                Capacity = c.Capacity,
                Instructor = new InstructorInfoViewModel
                {
                    FirstName = c.Instructor.FirstName,
                    LastName = c.Instructor.LastName,
                    Specialization = c.Instructor.Specialization,
                    Bio = c.Instructor.Bio,
                    ImageUrl = c.Instructor.ImageUrl
                }
            })
            .FirstOrDefaultAsync();
    }

    /// <inheritdoc />
    public async Task<IEnumerable<AllFitnessClassesViewModel>> GetMyClassesAsync(string userId)
    {
        return await _context.FitnessClassRegistrations
            .Where(cr => cr.MemberId == userId)
            .Select(cr => new AllFitnessClassesViewModel
            {
                Id = cr.FitnessClass.Id,
                Name = cr.FitnessClass.Name,
                ImageUrl = cr.FitnessClass.ImageUrl,
                Schedule = cr.FitnessClass.ScheduleDateTime.ToString(ScheduleDateTimeFormat),
                Duration = cr.FitnessClass.Duration,
                Capacity = cr.FitnessClass.Capacity
            })
            .AsNoTracking()
            .ToListAsync();
    }

    /// <inheritdoc />
    public async Task AddToMyClassesAsync(string userId, EditFitnessClassViewModel? classesViewModel)
    {
        if (string.IsNullOrEmpty(userId)) throw new InvalidOperationException(UserIdCannotBeEmpty);
        if (classesViewModel == null) throw new ArgumentNullException(nameof(classesViewModel), ClassViewModelCannotBeNull);

        var user = await _userManager.FindByIdAsync(userId);
        var isMember = user != null && await _userManager.IsInRoleAsync(user, MemberRole);

        if (!isMember)
        {
            throw new InvalidOperationException(OnlyMembersCanRegisterForThisClass);
        }

        var fitnessClass = await _context.FitnessClasses
            .Include(c => c.FitnessClassRegistrations)
            .FirstOrDefaultAsync(c => c.Id == classesViewModel.Id);

        if (fitnessClass == null) throw new InvalidOperationException(FitnessClassDoesNotExist);

        if (fitnessClass.FitnessClassRegistrations.Count >= fitnessClass.Capacity)
        {
            throw new InvalidOperationException(ClassFull);
        }

        var alreadyRegistered = await _context.FitnessClassRegistrations
            .AnyAsync(cr => cr.MemberId == userId && cr.FitnessClassId == classesViewModel.Id);

        if (alreadyRegistered) throw new InvalidOperationException(AlreadyRegisteredForClass);

        var registration = new FitnessClassRegistration
        {
            MemberId = userId,
            FitnessClassId = classesViewModel.Id,
            ModifiedOn_22180022 = DateTime.UtcNow
        };

        await _context.FitnessClassRegistrations.AddAsync(registration);
        await _context.SaveChangesAsync();
    }

    /// <inheritdoc />
    public async Task RemoveFromMyClassesAsync(string userId, EditFitnessClassViewModel? classesViewModel)
    {
        if (string.IsNullOrEmpty(userId)) throw new InvalidOperationException(UserIdCannotBeEmpty);
        if (classesViewModel == null) throw new ArgumentNullException(nameof(classesViewModel), ClassViewModelCannotBeNull);

        var registration = await _context.FitnessClassRegistrations
            .FirstOrDefaultAsync(cr => cr.MemberId == userId && cr.FitnessClassId == classesViewModel.Id);

        if (registration == null) throw new InvalidOperationException(UserNotRegisteredForClass);

        _context.FitnessClassRegistrations.Remove(registration);
        await _context.SaveChangesAsync();
    }

    /// <inheritdoc />
    public async Task<AddFitnessClassViewModel> GetClassForAddAsync()
    {
        var instructors = await _context.Instructors
            .Select(i => new AllInstructorsViewModel
            {
                Id = i.Id,
                FirstName = i.FirstName,
                LastName = i.LastName
            })
            .ToListAsync();

        return new AddFitnessClassViewModel { Instructors = instructors };
    }

    /// <inheritdoc />
    public async Task AddClassAsync(AddFitnessClassViewModel model, string userId)
    {
        if (string.IsNullOrEmpty(userId)) throw new InvalidOperationException(UserIdCannotBeEmpty);
        if (model == null) throw new ArgumentNullException(nameof(model), ClassViewModelCannotBeNull);

        var user = await _userManager.FindByIdAsync(userId);
        var isAdmin = user != null && await _userManager.IsInRoleAsync(user, AdminRole);

        if (!isAdmin)
        {
            throw new UnauthorizedAccessException(YouAreNotAuthorizedToAdd);
        }

        if (string.IsNullOrWhiteSpace(model.Name) || string.IsNullOrWhiteSpace(model.Schedule))
        {
            throw new InvalidOperationException(ClassNameAndScheduleAreRequired);
        }

        if (!DateTime.TryParse(model.Schedule, out DateTime parsedSchedule))
        {
            throw new InvalidOperationException(InvalidScheduleFormat);
        }

        var classExists = await _context.FitnessClasses
            .AnyAsync(c => c.Name == model.Name && c.ScheduleDateTime == parsedSchedule);

        if (classExists)
        {
            throw new InvalidOperationException(ClassWithTheSameNameAndScheduleAlreadyExists);
        }

        var fitnessClass = new FitnessClass
        {
            Name = model.Name,
            Description = model.Description,
            Price = model.Price,
            ImageUrl = model.ImageUrl,
            ScheduleDateTime = parsedSchedule,
            Duration = model.Duration,
            Capacity = model.Capacity,
            InstructorId = model.InstructorId,
            ModifiedOn_22180022 = DateTime.UtcNow
        };

        await _context.FitnessClasses.AddAsync(fitnessClass);
        await _context.SaveChangesAsync();
    }

    /// <inheritdoc />
    public async Task EditClassAsync(EditFitnessClassViewModel model, string userId)
    {
        if (string.IsNullOrEmpty(userId)) throw new InvalidOperationException(UserIdCannotBeEmpty);
        if (model == null) throw new ArgumentNullException(nameof(model), ClassViewModelCannotBeNull);

        var user = await _userManager.FindByIdAsync(userId);
        var isAdmin = user != null && await _userManager.IsInRoleAsync(user, AdminRole);

        if (!isAdmin)
        {
            throw new UnauthorizedAccessException(YouAreNotAuthorizedToEdit);
        }

        if (string.IsNullOrWhiteSpace(model.Name) || string.IsNullOrWhiteSpace(model.Schedule))
        {
            throw new InvalidOperationException(ClassNameAndScheduleAreRequired);
        }

        if (!DateTime.TryParse(model.Schedule, out DateTime parsedSchedule))
        {
            throw new InvalidOperationException(InvalidScheduleFormat);
        }

        var classExists = await _context.FitnessClasses
            .AnyAsync(c => c.Name == model.Name && c.ScheduleDateTime == parsedSchedule && c.Id != model.Id);

        if (classExists)
        {
            throw new InvalidOperationException(ClassWithTheSameNameAndScheduleAlreadyExists);
        }

        var fitnessClass = await _context.FitnessClasses.FindAsync(model.Id);
        if (fitnessClass == null) throw new InvalidOperationException(ClassNotFound);

        _context.Entry(fitnessClass).Property(c => c.ModifiedOn_22180022).OriginalValue = model.ModifiedOn_22180022;

        fitnessClass.Name = model.Name;
        fitnessClass.Description = model.Description;
        fitnessClass.Price = model.Price;
        fitnessClass.ImageUrl = model.ImageUrl;
        fitnessClass.ScheduleDateTime = parsedSchedule;
        fitnessClass.Duration = model.Duration;
        fitnessClass.Capacity = model.Capacity;
        fitnessClass.InstructorId = model.InstructorId;
        fitnessClass.ModifiedOn_22180022 = DateTime.UtcNow;

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
    public async Task<DeleteFitnessClassViewModel?> GetClassForDeleteAsync(int id)
    {
        return await _context.FitnessClasses
            .Where(c => c.Id == id)
            .Select(c => new DeleteFitnessClassViewModel
            {
                Id = c.Id,
                Name = c.Name,
                Description = c.Description
            })
            .FirstOrDefaultAsync();
    }

    /// <inheritdoc />
    public async Task DeleteClassAsync(int id, string userId)
    {
        if (string.IsNullOrEmpty(userId)) throw new InvalidOperationException(UserIdCannotBeEmpty);

        var user = await _userManager.FindByIdAsync(userId);
        var isAdmin = user != null && await _userManager.IsInRoleAsync(user, AdminRole);

        if (!isAdmin)
        {
            throw new UnauthorizedAccessException(YouAreNotAuthorizedToDelete);
        }

        var fitnessClass = await _context.FitnessClasses.FindAsync(id);
        if (fitnessClass != null)
        {
            _context.FitnessClasses.Remove(fitnessClass);
            await _context.SaveChangesAsync();
        }
    }
}
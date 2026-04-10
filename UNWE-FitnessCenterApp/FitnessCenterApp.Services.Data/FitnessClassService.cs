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

    /// <summary>
    /// Get all fitness classes with optional filters
    /// </summary>
    public async Task<IEnumerable<AllFitnessClassesViewModel>> GetAllClassesAsync(string? searchQuery = null, int? minDuration = null, int? maxDuration = null)
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
                Schedule = c.ScheduleDateTime.ToString("dd/MM/yyyy HH:mm"),
                Duration = c.Duration
            })
            .AsNoTracking()
            .ToListAsync();
    }

    /// <summary>
    /// Get all fitness classes with pagination
    /// </summary>
    public async Task<PaginatedFitnessClassesViewModel> GetAllClassesPaginationAsync(string? searchQuery, int pageNumber, int pageSize)
    {
        var query = _context.FitnessClasses.AsQueryable();

        if (!string.IsNullOrEmpty(searchQuery)) query = query.Where(c => c.Name.Contains(searchQuery));

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
                Schedule = c.ScheduleDateTime.ToString("dd/MM/yyyy HH:mm"),
                Duration = c.Duration
            })
            .AsNoTracking()
            .ToListAsync();

        return new PaginatedFitnessClassesViewModel
        {
            FitnessClasses = classes,
            PageNumber = pageNumber,
            PageSize = pageSize,
            TotalPages = totalPages,
            SearchQuery = searchQuery
        };
    }

    /// <summary>
    /// Get fitness class by id for editing
    /// </summary>
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
                InstructorId = c.InstructorId
            })
            .FirstOrDefaultAsync();
    }

    /// <summary>
    /// Get fitness class details
    /// </summary>
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
                Schedule = c.ScheduleDateTime.ToString("dd/MM/yyyy HH:mm"),
                Duration = c.Duration,
                Capacity = c.Capacity,
                InstructorFullName = c.Instructor.FirstName + " " + c.Instructor.LastName
            })
            .FirstOrDefaultAsync();
    }

    /// <summary>
    /// Get user's registered fitness classes
    /// </summary>
    public async Task<IEnumerable<AllFitnessClassesViewModel>> GetMyClassesAsync(string userId)
    {
        return await _context.FitnessClassRegistrations
            .Where(cr => cr.MemberId == userId)
            .Select(cr => new AllFitnessClassesViewModel
            {
                Id = cr.FitnessClass.Id,
                Name = cr.FitnessClass.Name,
                ImageUrl = cr.FitnessClass.ImageUrl,
                Schedule = cr.FitnessClass.ScheduleDateTime.ToString("dd/MM/yyyy HH:mm"),
                Duration = cr.FitnessClass.Duration
            })
            .AsNoTracking()
            .ToListAsync();
    }

    /// <summary>
    /// Add fitness class to user's registered classes
    /// </summary>
    public async Task AddToMyClassesAsync(string userId, EditFitnessClassViewModel? classesViewModel)
    {
        if (classesViewModel == null) throw new ArgumentNullException(nameof(classesViewModel));

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

    /// <summary>
    /// Remove fitness class from user's registered classes
    /// </summary>
    public async Task RemoveFromMyClassesAsync(string userId, EditFitnessClassViewModel? classesViewModel)
    {
        if (classesViewModel == null) throw new ArgumentNullException(nameof(classesViewModel));

        var registration = await _context.FitnessClassRegistrations
            .FirstOrDefaultAsync(cr => cr.MemberId == userId && cr.FitnessClassId == classesViewModel.Id);

        if (registration == null) throw new InvalidOperationException(UserNotRegisteredForClass);

        _context.FitnessClassRegistrations.Remove(registration);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Get fitness class for add
    /// </summary>
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

    /// <summary>
    /// Add new fitness class
    /// </summary>
    public async Task AddClassAsync(AddFitnessClassViewModel model, string userId)
    {
        var user = await _userManager.FindByIdAsync(userId);
        var isAdmin = user != null && await _userManager.IsInRoleAsync(user, AdminRole);

        if (!isAdmin)
        {
            throw new UnauthorizedAccessException(YouAreNotAuthorizedToAdd);
        }

        var fitnessClass = new FitnessClass
        {
            Name = model.Name,
            Description = model.Description,
            Price = model.Price,
            ImageUrl = model.ImageUrl,
            ScheduleDateTime = DateTime.Parse(model.Schedule),
            Duration = model.Duration,
            Capacity = model.Capacity,
            InstructorId = model.InstructorId,
            ModifiedOn_22180022 = DateTime.UtcNow
        };

        await _context.FitnessClasses.AddAsync(fitnessClass);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Edit existing fitness class
    /// </summary>
    public async Task EditClassAsync(EditFitnessClassViewModel model, string userId)
    {
        var user = await _userManager.FindByIdAsync(userId);
        var isAdmin = user != null && await _userManager.IsInRoleAsync(user, AdminRole);

        if (!isAdmin)
        {
            throw new UnauthorizedAccessException(YouAreNotAuthorizedToEdit);
        }

        var fitnessClass = await _context.FitnessClasses.FindAsync(model.Id);
        if (fitnessClass == null) throw new InvalidOperationException(ClassNotFound);

        fitnessClass.Name = model.Name;
        fitnessClass.Description = model.Description;
        fitnessClass.Price = model.Price;
        fitnessClass.ImageUrl = model.ImageUrl;
        fitnessClass.ScheduleDateTime = DateTime.Parse(model.Schedule);
        fitnessClass.Duration = model.Duration;
        fitnessClass.Capacity = model.Capacity;
        fitnessClass.InstructorId = model.InstructorId;
        fitnessClass.ModifiedOn_22180022 = DateTime.UtcNow;

        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Get fitness class for delete
    /// </summary>
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

    /// <summary>
    /// Delete fitness class
    /// </summary>
    public async Task DeleteClassAsync(int id, string userId)
    {
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
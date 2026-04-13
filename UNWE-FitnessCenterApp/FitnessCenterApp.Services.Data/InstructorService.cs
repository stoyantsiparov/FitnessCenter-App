using FitnessCenterApp.Data;
using FitnessCenterApp.Data.Models;
using FitnessCenterApp.Services.Data.Contracts;
using FitnessCenterApp.Web.ViewModels.Instructor;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using static FitnessCenterApp.Common.ApplicationsConstants;
using static FitnessCenterApp.Common.ErrorMessages.Instructor;
using static FitnessCenterApp.Common.ErrorMessages.Roles;

namespace FitnessCenterApp.Services.Data;

public class InstructorService : IInstructorService
{
    private readonly ApplicationDbContext _context;
    private readonly UserManager<IdentityUser> _userManager;

    public InstructorService(ApplicationDbContext context, UserManager<IdentityUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

    /// <summary>
    /// Get all instructors with pagination and search. (Used by Public UI)
    /// </summary>
    public async Task<PaginatedInstructorsViewModel> GetAllInstructorsPaginationAsync(string? searchQuery = null, int pageNumber = 1, int pageSize = 3)
    {
        var query = _context.Instructors.AsQueryable();

        if (!string.IsNullOrEmpty(searchQuery))
        {
            query = query.Where(i =>
                i.FirstName.Contains(searchQuery) ||
                i.LastName.Contains(searchQuery) ||
                i.Specialization.Contains(searchQuery));
        }

        var totalInstructors = await query.CountAsync();
        var totalPages = (int)Math.Ceiling(totalInstructors / (double)pageSize);

        var instructors = await query
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .Select(i => new AllInstructorsViewModel
            {
                Id = i.Id,
                FirstName = i.FirstName,
                LastName = i.LastName,
                ImageUrl = i.ImageUrl,
                Specialization = i.Specialization
            })
            .AsNoTracking()
            .ToListAsync();

        return new PaginatedInstructorsViewModel
        {
            Instructors = instructors,
            PageNumber = pageNumber,
            PageSize = pageSize,
            TotalPages = totalPages,
            SearchQuery = searchQuery
        };
    }

    /// <summary>
    /// Get all instructors without pagination. (Used by Admin Area)
    /// </summary>
    public async Task<IEnumerable<AllInstructorsViewModel>> GetAllInstructorsAsync()
    {
        return await _context.Instructors
            .Select(i => new AllInstructorsViewModel
            {
                Id = i.Id,
                FirstName = i.FirstName,
                LastName = i.LastName,
                ImageUrl = i.ImageUrl,
                Specialization = i.Specialization
            })
            .AsNoTracking()
            .ToListAsync();
    }

    /// <summary>
    /// Get instructor by id for editing.
    /// </summary>
    public async Task<EditInstructorViewModel?> GetInstructorByIdAsync(int id)
    {
        return await _context.Instructors
            .Where(i => i.Id == id)
            .Select(i => new EditInstructorViewModel
            {
                Id = i.Id,
                FirstName = i.FirstName,
                LastName = i.LastName,
                ImageUrl = i.ImageUrl,
                Bio = i.Bio,
                Specialization = i.Specialization
            })
            .FirstOrDefaultAsync();
    }

    /// <summary>
    /// Get instructor details by id.
    /// </summary>
    public async Task<InstructorDetailsViewModel?> GetInstructorDetailsAsync(int id)
    {
        return await _context.Instructors
            .Where(i => i.Id == id)
            .Select(i => new InstructorDetailsViewModel
            {
                Id = i.Id,
                FirstName = i.FirstName,
                LastName = i.LastName,
                ImageUrl = i.ImageUrl,
                Bio = i.Bio,
                Specialization = i.Specialization
            })
            .FirstOrDefaultAsync();
    }

    /// <summary>
    /// Get empty instructor model for adding.
    /// </summary>
    public async Task<AddInstructorViewModel> GetInstructorForAddAsync()
    {
        var model = new AddInstructorViewModel
        {
            FirstName = string.Empty,
            LastName = string.Empty,
            ImageUrl = string.Empty,
            Bio = string.Empty,
            Specialization = string.Empty
        };

        return await Task.FromResult(model);
    }

    /// <summary>
    /// Add a new instructor to the database.
    /// </summary>
    public async Task AddInstructorAsync(AddInstructorViewModel model, string userId)
    {
        var user = await _userManager.FindByIdAsync(userId);

        if (user == null || !await _userManager.IsInRoleAsync(user, AdminRole))
        {
            throw new InvalidOperationException(YouAreNotAuthorizedToAdd);
        }

        var instructor = new Instructor
        {
            FirstName = model.FirstName,
            LastName = model.LastName,
            ImageUrl = model.ImageUrl,
            Bio = model.Bio,
            Specialization = model.Specialization,
            ModifiedOn_22180022 = DateTime.UtcNow
        };

        await _context.Instructors.AddAsync(instructor);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Edit an existing instructor.
    /// </summary>
    public async Task EditInstructorAsync(EditInstructorViewModel model, string userId)
    {
        var user = await _userManager.FindByIdAsync(userId);

        if (user == null || !await _userManager.IsInRoleAsync(user, AdminRole))
        {
            throw new InvalidOperationException(YouAreNotAuthorizedToEdit);
        }

        var instructor = await _context.Instructors.FindAsync(model.Id);

        if (instructor == null)
        {
            throw new InvalidOperationException(InstructorNotFound);
        }

        instructor.FirstName = model.FirstName;
        instructor.LastName = model.LastName;
        instructor.ImageUrl = model.ImageUrl;
        instructor.Bio = model.Bio;
        instructor.Specialization = model.Specialization;
        instructor.ModifiedOn_22180022 = DateTime.UtcNow;

        _context.Instructors.Update(instructor);
        await _context.SaveChangesAsync();
    }

    /// <summary>
    /// Get instructor model for confirmation before deleting.
    /// </summary>
    public async Task<DeleteInstructorViewModel?> GetInstructorForDeleteAsync(int id)
    {
        return await _context.Instructors
            .Where(i => i.Id == id)
            .Select(i => new DeleteInstructorViewModel
            {
                Id = i.Id,
                FirstName = i.FirstName,
                LastName = i.LastName,
            })
            .FirstOrDefaultAsync();
    }

    /// <summary>
    /// Delete instructor from the database.
    /// </summary>
    public async Task DeleteInstructorAsync(int id, string userId)
    {
        var user = await _userManager.FindByIdAsync(userId);

        if (user == null || !await _userManager.IsInRoleAsync(user, AdminRole))
        {
            throw new InvalidOperationException(YouAreNotAuthorizedToDelete);
        }

        var instructor = await _context.Instructors.FirstOrDefaultAsync(i => i.Id == id);

        if (instructor == null)
        {
            throw new InvalidOperationException(InstructorNotFound);
        }

        _context.Instructors.Remove(instructor);
        await _context.SaveChangesAsync();
    }
}
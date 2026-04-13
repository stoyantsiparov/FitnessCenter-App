using FitnessCenterApp.Services.Data.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static FitnessCenterApp.Common.ApplicationsConstants;

namespace FitnessCenterApp.Web.Controllers;

public class InstructorController : BaseController
{
    private readonly IInstructorService _instructorService;

    public InstructorController(IInstructorService instructorService)
    {
        _instructorService = instructorService;
    }

    [AllowAnonymous]
    public async Task<IActionResult> Index(string? searchQuery = null, int pageNumber = DefaultPageNumber, int pageSize = DefaultEntitiesPerPage)
    {
        var model = await _instructorService.GetAllInstructorsPaginationAsync(searchQuery, pageNumber, pageSize);

        return View(model);
    }

    [AllowAnonymous]
    public async Task<IActionResult> Details(int id)
    {
        if (id <= 0)
        {
            return RedirectToAction(nameof(Index));
        }

        var model = await _instructorService.GetInstructorDetailsAsync(id);

        if (model == null)
        {
            return RedirectToAction(nameof(Index));
        }

        return View(model);
    }
}
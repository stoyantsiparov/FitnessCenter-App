using FitnessCenterApp.Services.Data.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static FitnessCenterApp.Common.ErrorMessages.FitnessClass;
using static FitnessCenterApp.Common.SuccessfulValidationMessages.FitnessClass;
using static FitnessCenterApp.Common.ApplicationsConstants;

namespace FitnessCenterApp.Web.Controllers;

public class FitnessClassController : BaseController
{
    private readonly IFitnessClassService _fitnessClassService;

    public FitnessClassController(IFitnessClassService fitnessClassService)
    {
        _fitnessClassService = fitnessClassService;
    }

    [AllowAnonymous]
    public async Task<IActionResult> Index(string? searchQuery = null, int? minDuration = null, int? maxDuration = null, int pageNumber = DefaultPageNumber, int pageSize = DefaultEntitiesPerPage)
    {
        // Ensure page number and page size are valid
        var model = await _fitnessClassService.GetAllClassesPaginationAsync(searchQuery, minDuration, maxDuration, pageNumber, pageSize);

        return View(model);
    }

    public async Task<IActionResult> MyClasses()
    {
        var userId = GetUserId();
        var model = await _fitnessClassService.GetMyClassesAsync(userId);

        return View(model);
    }

    [AllowAnonymous]
    public async Task<IActionResult> Details(int id)
    {
        var model = await _fitnessClassService.GetClassDetailsAsync(id);

        if (model == null)
        {
            TempData["ErrorMessage"] = FitnessClassDoesNotExist;
            return RedirectToAction(nameof(Index));
        }

        return View(model);
    }

    public async Task<IActionResult> AddToMyClasses(int id)
    {
        var model = await _fitnessClassService.GetClassByIdAsync(id);

        if (model == null)
        {
            TempData["ErrorMessage"] = FitnessClassDoesNotExist;
            return RedirectToAction(nameof(Details), new { id });
        }

        var userId = GetUserId();

        try
        {
            await _fitnessClassService.AddToMyClassesAsync(userId, model);
            TempData["SuccessMessage"] = ClassAddedSuccessfully;
        }
        catch (InvalidOperationException ex)
        {
            TempData["ErrorMessage"] = ex.Message;
            return RedirectToAction(nameof(Details), new { id });
        }

        return RedirectToAction(nameof(MyClasses));
    }

    public async Task<IActionResult> RemoveFromMyClasses(int id)
    {
        var model = await _fitnessClassService.GetClassByIdAsync(id);

        if (model == null)
        {
            TempData["ErrorMessage"] = UserNotRegisteredForClass;
            return RedirectToAction(nameof(MyClasses));
        }

        var userId = GetUserId();

        try
        {
            await _fitnessClassService.RemoveFromMyClassesAsync(userId, model);
            TempData["SuccessMessage"] = ClassAppointmentRemovedSuccessfully;
        }
        catch (InvalidOperationException ex)
        {
            TempData["ErrorMessage"] = ex.Message;
            return RedirectToAction(nameof(MyClasses));
        }

        return RedirectToAction(nameof(MyClasses));
    }
}
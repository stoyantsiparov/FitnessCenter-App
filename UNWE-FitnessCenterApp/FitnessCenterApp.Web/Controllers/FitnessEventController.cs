using System.Globalization;
using FitnessCenterApp.Services.Data.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static FitnessCenterApp.Common.ErrorMessages.FitnessEvent;
using static FitnessCenterApp.Common.SuccessfulValidationMessages.FitnessEvent;
using static FitnessCenterApp.Common.ApplicationsConstants;
using static FitnessCenterApp.Common.EntityValidationConstants;

namespace FitnessCenterApp.Web.Controllers;

public class FitnessEventController : BaseController
{
    private readonly IFitnessEventService _fitnessEventService;

    public FitnessEventController(IFitnessEventService fitnessEventService)
    {
        _fitnessEventService = fitnessEventService;
    }

    [AllowAnonymous]
    public async Task<IActionResult> Index(string? searchQuery = null, string? sortOrder = null, int pageNumber = DefaultPageNumber, int pageSize = DefaultEntitiesPerPage)
    {
        ViewData["CurrentSort"] = sortOrder;

        var model = await _fitnessEventService.GetAllFitnessEventsAsync(searchQuery, sortOrder, pageNumber, pageSize);

        return View(model);
    }

    [AllowAnonymous]
    public async Task<IActionResult> Archive()
    {
        var model = await _fitnessEventService.GetPastFitnessEventsAsync();
        return View(model);
    }

    public async Task<IActionResult> MyFitnessEvents()
    {
        var userId = GetUserId();
        var model = await _fitnessEventService.GetMyFitnessEventsAsync(userId);

        return View(model);
    }

    [AllowAnonymous]
    public async Task<IActionResult> Details(int id)
    {
        var model = await _fitnessEventService.GetFitnessEventDetailsAsync(id);

        if (model == null)
        {
            TempData["ErrorMessage"] = FitnessEventDoesNotExist;
            return RedirectToAction(nameof(Index));
        }

        DateTime endDateTime = DateTime.ParseExact(model.EndDateTime, FitnessEvent.DateTimeFormat, CultureInfo.InvariantCulture);

        if (endDateTime < DateTime.Now)
        {
            TempData["ErrorMessage"] = EventHasEnded;
            return RedirectToAction(nameof(Index));
        }

        return View(model);
    }

    public async Task<IActionResult> AddToMyFitnessEvents(int id)
    {
        var model = await _fitnessEventService.GetFitnessEventByIdAsync(id);

        if (model == null)
        {
            TempData["ErrorMessage"] = FitnessEventDoesNotExist;
            return RedirectToAction(nameof(Details), new { id });
        }

        var userId = GetUserId();

        try
        {
            await _fitnessEventService.AddToMyFitnessEventsAsync(userId, model);
            TempData["SuccessMessage"] = FitnessEventBookedSuccessfully;
        }
        catch (InvalidOperationException ex)
        {
            TempData["ErrorMessage"] = ex.Message;
            return RedirectToAction(nameof(Details), new { id });
        }

        return RedirectToAction(nameof(MyFitnessEvents));
    }

    public async Task<IActionResult> RemoveFromMyFitnessEvents(int id)
    {
        var model = await _fitnessEventService.GetFitnessEventByIdAsync(id);

        if (model == null)
        {
            TempData["ErrorMessage"] = UserNotRegisteredForEvent;
            return RedirectToAction(nameof(MyFitnessEvents));
        }

        var userId = GetUserId();

        try
        {
            await _fitnessEventService.RemoveFromMyFitnessEventsAsync(userId, model);
            TempData["SuccessMessage"] = FitnessEventRemovedSuccessfully;
        }
        catch (InvalidOperationException ex)
        {
            TempData["ErrorMessage"] = ex.Message;
            return RedirectToAction(nameof(MyFitnessEvents));
        }

        return RedirectToAction(nameof(MyFitnessEvents));
    }
}
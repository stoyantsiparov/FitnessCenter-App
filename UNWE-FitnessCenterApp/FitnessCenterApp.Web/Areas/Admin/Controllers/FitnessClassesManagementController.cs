using FitnessCenterApp.Services.Data.Contracts;
using FitnessCenterApp.Web.Controllers;
using FitnessCenterApp.Web.ViewModels.FitnessClass;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static FitnessCenterApp.Common.ApplicationsConstants;
using static FitnessCenterApp.Common.SuccessfulValidationMessages.FitnessClass;
using static FitnessCenterApp.Common.ErrorMessages.FitnessClass;

namespace FitnessCenterApp.Web.Areas.Admin.Controllers;

[Area(AdminRole)]
[Authorize(Roles = AdminRole)]
public class FitnessClassesManagementController : BaseController
{
    private readonly IFitnessClassService _fitnessClassService;

    public FitnessClassesManagementController(IFitnessClassService fitnessClassService)
    {
        _fitnessClassService = fitnessClassService;
    }

    public async Task<IActionResult> Index()
    {
        var classes = await _fitnessClassService.GetAllClassesAsync();
        return View(classes);
    }

    [HttpGet]
    public async Task<IActionResult> Add()
    {
        var model = await _fitnessClassService.GetClassForAddAsync();
        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> Add(AddFitnessClassViewModel model)
    {
        if (!ModelState.IsValid)
        {
            TempData["ErrorMessage"] = InvalidData;
            var instructors = await _fitnessClassService.GetClassForAddAsync();
            model.Instructors = instructors.Instructors;
            return View(model);
        }

        var userId = GetUserId();
        await _fitnessClassService.AddClassAsync(model, userId);

        TempData["SuccessMessage"] = ClassAddedSuccessfully;
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> Edit(int id)
    {
        var model = await _fitnessClassService.GetClassByIdAsync(id);

        if (model != null)
        {
            var instructors = await _fitnessClassService.GetClassForAddAsync();
            model.Instructors = instructors.Instructors;
            return View(model);
        }

        TempData["ErrorMessage"] = ClassNotFound;
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public async Task<IActionResult> Edit(EditFitnessClassViewModel model)
    {
        if (!ModelState.IsValid)
        {
            TempData["ErrorMessage"] = InvalidData;
            var instructors = await _fitnessClassService.GetClassForAddAsync();
            model.Instructors = instructors.Instructors;
            return View(model);
        }

        var userId = GetUserId();
        await _fitnessClassService.EditClassAsync(model, userId);

        TempData["SuccessMessage"] = ClassUpdatedSuccessfully;
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> Delete(int id)
    {
        var model = await _fitnessClassService.GetClassForDeleteAsync(id);

        if (model != null)
        {
            return View(model);
        }

        TempData["ErrorMessage"] = ClassNotFound;
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public async Task<IActionResult> Delete(DeleteFitnessClassViewModel model)
    {
        var userId = GetUserId();
        await _fitnessClassService.DeleteClassAsync(model.Id, userId);

        TempData["SuccessMessage"] = ClassDeletedSuccessfully;
        return RedirectToAction(nameof(Index));
    }
}
using FitnessCenterApp.Services.Data.Contracts;
using FitnessCenterApp.Web.Controllers;
using FitnessCenterApp.Web.ViewModels.SpaProcedure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using static FitnessCenterApp.Common.ApplicationsConstants;
using static FitnessCenterApp.Common.SuccessfulValidationMessages.SpaProcedure;
using static FitnessCenterApp.Common.ErrorMessages.SpaProcedure;
using static FitnessCenterApp.Common.ExportConstants;
using static FitnessCenterApp.Common.ExportConstants.SpaProcedure;

namespace FitnessCenterApp.Web.Areas.Admin.Controllers;

[Area(AdminRole)]
[Authorize(Roles = AdminRole)]
public class SpaProceduresManagementController : BaseController
{
    private readonly ISpaProcedureService _spaService;

    public SpaProceduresManagementController(ISpaProcedureService spaService)
    {
        _spaService = spaService;
    }

    public async Task<IActionResult> Index()
    {
        var spaProcedures = await _spaService.GetAllSpaProceduresAsync();
        return View(spaProcedures);
    }

    [HttpGet]
    public async Task<IActionResult> Add()
    {
        var model = await _spaService.GetSpaProcedureForAddAsync();
        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> Add(AddSpaProcedureViewModel model)
    {
        if (!ModelState.IsValid)
        {
            TempData["ErrorMessage"] = InvalidData;
            return View(model);
        }

        try
        {
            var userId = GetUserId();
            await _spaService.AddSpaProcedureAsync(model, userId);

            TempData["SuccessMessage"] = SpaProcedureAddedSuccessfully;
            return RedirectToAction(nameof(Index));
        }
        catch (InvalidOperationException ex)
        {
            TempData["ErrorMessage"] = ex.Message;
            return View(model);
        }
    }

    [HttpGet]
    public async Task<IActionResult> Edit(int id)
    {
        var model = await _spaService.GetSpaProceduresByIdAsync(id);

        if (model != null)
        {
            return View(model);
        }

        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public async Task<IActionResult> Edit(EditSpaProcedureViewModel model)
    {
        if (!ModelState.IsValid)
        {
            TempData["ErrorMessage"] = InvalidData;
            return View(model);
        }

        try
        {
            var userId = GetUserId();
            await _spaService.EditSpaProcedureAsync(model, userId);

            TempData["SuccessMessage"] = SpaProcedureUpdatedSuccessfully;
            return RedirectToAction(nameof(Index));
        }
        catch (InvalidOperationException ex)
        {
            TempData["ErrorMessage"] = ex.Message;
            return View(model);
        }
    }

    [HttpGet]
    public async Task<IActionResult> Delete(int id)
    {
        var model = await _spaService.GetSpaProcedureForDeleteAsync(id);

        if (model != null)
        {
            return View(model);
        }

        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public async Task<IActionResult> Delete(DeleteSpaProcedureViewModel model)
    {
        try
        {
            var userId = GetUserId();
            await _spaService.DeleteSpaProcedureAsync(model.Id, userId);

            TempData["SuccessMessage"] = SpaProcedureDeletedSuccessfully;
        }
        catch (InvalidOperationException ex)
        {
            TempData["ErrorMessage"] = ex.Message;
        }

        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> Participants(int id)
    {
        var model = await _spaService.GetSpaParticipantsAsync(id);

        if (model == null)
        {
            TempData["ErrorMessage"] = SpaProcedureNotFound;
            return RedirectToAction(nameof(Index));
        }

        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> RemoveParticipant(int procedureId, string userId)
    {
        try
        {
            await _spaService.RemoveParticipantFromSpaAdminAsync(procedureId, userId);
            TempData["SuccessMessage"] = ParticipantRemovedSuccessfully;
        }
        catch (InvalidOperationException ex)
        {
            TempData["ErrorMessage"] = ex.Message;
        }

        return RedirectToAction(nameof(Participants), new { id = procedureId });
    }

    public async Task<IActionResult> ExportSpaProceduresToCsv()
    {
        var procedures = await _spaService.GetAllSpaProceduresAsync();
        var builder = new StringBuilder();

        builder.Append('\uFEFF');
        builder.AppendLine(ExportHeader);

        foreach (var procedure in procedures)
        {
            var name = $"\"{procedure.Name?.Replace("\"", "\"\"")}\"";
            builder.AppendLine($"{name},{procedure.Capacity},{procedure.ParticipantsCount}");
        }

        return File(Encoding.UTF8.GetBytes(builder.ToString()), CsvContentType, ExportFileName);
    }
}
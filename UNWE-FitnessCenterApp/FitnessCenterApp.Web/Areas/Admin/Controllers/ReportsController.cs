using System.Text;
using FitnessCenterApp.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using static FitnessCenterApp.Common.ApplicationsConstants;
using static FitnessCenterApp.Common.ExportConstants;
using static FitnessCenterApp.Common.ExportConstants.Reports;

namespace FitnessCenterApp.Web.Areas.Admin.Controllers;

[Area(AdminRole)]
[Authorize(Roles = AdminRole)]
public class ReportsController : Controller
{
    private readonly ApplicationDbContext _context;

    public ReportsController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<IActionResult> Index(DateTime? fromDate, DateTime? toDate)
    {
        // Default to a 60-day window if no dates are provided
        var start = fromDate ?? DateTime.Today.AddDays(-30);
        var end = toDate ?? DateTime.Today.AddDays(30);

        ViewBag.FromDate = start.ToString("yyyy-MM-dd");
        ViewBag.ToDate = end.ToString("yyyy-MM-dd");

        // Fetch Classes Data
        var classesReport = await _context.FitnessClasses
            .Where(c => c.ScheduleDateTime >= start && c.ScheduleDateTime <= end)
            .Select(c => new
            {
                c.Name,
                Schedule = c.ScheduleDateTime,
                c.Capacity,
                Registered = c.FitnessClassRegistrations.Count,
                Revenue = c.Price * c.FitnessClassRegistrations.Count
            }).ToListAsync();

        ViewBag.ClassesReport = classesReport;
        ViewBag.ClassLabels = classesReport.Select(c => c.Name).ToArray();
        ViewBag.ClassData = classesReport.Select(c => c.Capacity > 0 ? Math.Round(((double)c.Registered / c.Capacity) * 100) : 0).ToArray();

        // Fetch Events Data
        var eventsReport = await _context.FitnessEvents
            .Where(e => e.StartDate >= start && e.StartDate <= end)
            .Select(e => new
            {
                e.Title,
                e.StartDate,
                e.Capacity,
                Registered = e.FitnessEventRegistrations.Count
            }).ToListAsync();

        ViewBag.EventsReport = eventsReport;
        ViewBag.EventLabels = eventsReport.Select(e => e.Title).ToArray();
        ViewBag.EventData = eventsReport.Select(e => e.Capacity > 0 ? Math.Round(((double)e.Registered / e.Capacity) * 100) : 0).ToArray();

        // Fetch Spa Data
        var spaReport = await _context.SpaProcedures
            .Select(sp => new
            {
                sp.Name,
                sp.Capacity,
                sp.Price,
                TotalBookings = sp.SpaRegistrations.Count(r => r.AppointmentDateTime >= start && r.AppointmentDateTime <= end),
                Revenue = sp.Price * sp.SpaRegistrations.Count(r => r.AppointmentDateTime >= start && r.AppointmentDateTime <= end)
            }).ToListAsync();

        ViewBag.SpaReport = spaReport;
        ViewBag.SpaLabels = spaReport.Select(s => s.Name).ToArray();
        ViewBag.SpaData = spaReport.Select(s => s.Capacity > 0 ? Math.Round(((double)s.TotalBookings / s.Capacity) * 100) : 0).ToArray();

        return View();
    }

    [HttpPost]
    public async Task<IActionResult> ExportClassesReport(DateTime fromDate, DateTime toDate)
    {
        var data = await _context.FitnessClasses
            .Where(c => c.ScheduleDateTime >= fromDate && c.ScheduleDateTime <= toDate)
            .Select(c => new
            {
                c.Name,
                c.ScheduleDateTime,
                c.Capacity,
                Registered = c.FitnessClassRegistrations.Count,
                Revenue = c.Price * c.FitnessClassRegistrations.Count
            })
            .ToListAsync();

        var builder = new StringBuilder();
        builder.Append('\uFEFF');
        builder.AppendLine(ClassesReportHeader);

        foreach (var item in data)
        {
            builder.AppendLine($"\"{item.Name}\",\"{item.ScheduleDateTime}\",{item.Capacity},{item.Registered},{item.Revenue}");
        }

        return File(Encoding.UTF8.GetBytes(builder.ToString()), CsvContentType, ClassesReportFileName);
    }

    [HttpPost]
    public async Task<IActionResult> ExportEventsReport(DateTime fromDate, DateTime toDate)
    {
        var data = await _context.FitnessEvents
            .Where(e => e.StartDate >= fromDate && e.StartDate <= toDate)
            .Select(e => new
            {
                e.Title,
                e.StartDate,
                e.Capacity,
                Registered = e.FitnessEventRegistrations.Count
            })
            .ToListAsync();

        var builder = new StringBuilder();
        builder.Append('\uFEFF');
        builder.AppendLine(EventsReportHeader);

        foreach (var item in data)
        {
            builder.AppendLine($"\"{item.Title}\",\"{item.StartDate}\",{item.Capacity},{item.Registered}");
        }

        return File(Encoding.UTF8.GetBytes(builder.ToString()), CsvContentType, EventsReportFileName);
    }

    [HttpPost]
    public async Task<IActionResult> ExportSpaReport(DateTime fromDate, DateTime toDate)
    {
        var data = await _context.SpaProcedures
            .Select(sp => new
            {
                sp.Name,
                sp.Capacity,
                TotalBookings = sp.SpaRegistrations.Count(r => r.AppointmentDateTime >= fromDate && r.AppointmentDateTime <= toDate),
                Revenue = sp.Price * sp.SpaRegistrations.Count(r => r.AppointmentDateTime >= fromDate && r.AppointmentDateTime <= toDate)
            })
            .ToListAsync();

        var builder = new StringBuilder();
        builder.Append('\uFEFF');
        builder.AppendLine(SpaReportHeader);

        foreach (var item in data)
        {
            builder.AppendLine($"\"{item.Name}\",{item.Capacity},{item.TotalBookings},{item.Revenue}");
        }

        return File(Encoding.UTF8.GetBytes(builder.ToString()), CsvContentType, SpaReportFileName);
    }
}
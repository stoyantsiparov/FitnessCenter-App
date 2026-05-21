using FitnessCenterApp.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FitnessCenterApp.Web.Controllers;

public class HomeController : Controller
{
    private readonly ApplicationDbContext _context;

    public HomeController(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var now = DateTime.Now;

        ViewBag.MembersCount = await _context.MembershipRegistrations.CountAsync();

        ViewBag.ClassesCount = await _context.FitnessClasses
            .CountAsync(c => c.ScheduleDateTime.AddMinutes(c.Duration) >= now);

        ViewBag.EventsCount = await _context.FitnessEvents
            .CountAsync(e => e.EndDate >= now);

        ViewBag.SpaCount = await _context.SpaProcedures.CountAsync();

        return View();
    }

    public IActionResult Error(int? statusCode = null)
    {
        if (statusCode == 404)
        {
            return View("Error404");
        }

        return View("Error500");
    }
}
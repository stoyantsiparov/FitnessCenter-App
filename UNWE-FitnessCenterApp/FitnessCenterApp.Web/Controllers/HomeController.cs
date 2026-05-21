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
        // Count total members, classes, events, and spa procedures for dashboard display
        ViewBag.MembersCount = await _context.MembershipRegistrations.CountAsync();
        ViewBag.ClassesCount = await _context.FitnessClasses.CountAsync();
        ViewBag.EventsCount = await _context.FitnessEvents.CountAsync();
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
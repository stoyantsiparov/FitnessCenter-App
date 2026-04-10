using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static FitnessCenterApp.Common.ApplicationsConstants;

namespace FitnessCenterApp.Web.Areas.Admin.Controllers;

[Area(AdminRole)]
[Authorize(Roles = AdminRole)]
public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
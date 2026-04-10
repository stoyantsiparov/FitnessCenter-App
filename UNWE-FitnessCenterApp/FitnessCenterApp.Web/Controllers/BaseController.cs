using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FitnessCenterApp.Web.Controllers;

[Authorize]
public class BaseController : Controller
{
    protected string GetUserId()
    {
        string userId = string.Empty;

        if (User != null)
        {
            userId = User.FindFirstValue(ClaimTypes.NameIdentifier) ?? string.Empty;
        }
        return userId;
    }
}
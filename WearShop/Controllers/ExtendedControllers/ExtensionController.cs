using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using WearShop.Models.Error;

namespace WearShop.Controllers.ExtendedControllers;

public class ExtensionController : Controller
{
    public IActionResult NotifyErrorPage(string errorMessage)
    {
        return View("ErrorCustom", new CustomErrorViewModel()
        {
            Message = errorMessage,
        });
    }

    private string GetUserClaimValue(string claimType) => User.Claims.FirstOrDefault(c => c.Type == claimType)?.Value ?? string.Empty;

    private string GetCurrentUserRole() => GetUserClaimValue(ClaimTypes.Role);
    
    private string GetCurrentUserId() => GetUserClaimValue(ClaimTypes.NameIdentifier);
    
    private string GetCurrentUserLogin() => User.Identity?.Name ?? string.Empty;
}
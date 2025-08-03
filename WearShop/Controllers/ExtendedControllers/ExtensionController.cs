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
}
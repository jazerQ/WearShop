using DataAccess.Entities.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WearShop.Controllers.ExtendedControllers;

namespace WearShop.Controllers;

public class AccountController(
    UserManager<User> _userManager,
    SignInManager<User> _signInManager) : ExtensionController
{
    [HttpGet("/[controller]/register")]
    public IActionResult Register()
    {
        return View("Register");
    }
}
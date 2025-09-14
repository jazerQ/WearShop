using DataAccess.Entities.Users;
using Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using WearShop.Controllers.ExtendedControllers;
using WearShop.Models.Account;

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

    [HttpPost("/[controller]/register")]
    public async Task<IActionResult> Register(RegisterUserRequest request)
    {
        // var user = new User
        // {
        //     UserName = request.Username,
        //     Email = request.Email,
        // };
        //
        // //добавляем пользователя
        // var result = await _userManager.CreateAsync(user, request.Password);

        // if (result.Succeeded)
        // {
            // установка куки
            //await _signInManager.SignInAsync(user, false);
            return Json(new { redirect = $"/account/check?number={Guid.NewGuid().ToString()}" });
    }

    [HttpGet("[controller]/check")]
    public IActionResult Check([FromQuery] string number)
    {
        return View("ListenCode", new ListenCodeViewModel()
        {
            Email = "saltanhayrliev@gmail.com"
        });
    }
}
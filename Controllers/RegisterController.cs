using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ASPNetCore_pr4.Models;

namespace ASPNetCore_pr4.Controllers;

public class RegisterController : Controller
{
    AppDbContent db;
    public RegisterController(AppDbContent context)
    {
    db = context;
    }

    [HttpPost]
    public IActionResult SignIN(Users user)
    {
        bool UserExists = db.Users.Any(x => x.login == user.login && x.password == user.password);
        if (UserExists)
        {
            return RedirectToAction("ShowMessages", "Messages", new { login = user.login });
        }
        ViewBag.ErrorMessage = "Неверный логин и/или пароль";
        return View();
    }

    public IActionResult SignIN(){
        return View();
    }

    [HttpPost]
    public IActionResult Register(Users user)
    {
        bool UserExists = db.Users.Any(x => x.login == user.login);

        if (UserExists)
        {
            ViewBag.ErrorMessage = "Пользователь с таким логином уже существует";
            return View("Register", user);
        }
        else
        {
            db.Users.Add(user);
            db.SaveChangesAsync();

            return RedirectToAction("SignIn");
        }
    }

    public IActionResult SignUp(){
        return View();
    }



    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
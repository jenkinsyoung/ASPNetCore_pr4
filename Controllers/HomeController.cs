using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ASPNetCore_pr4.Models;

namespace ASPNetCore_pr4.Controllers;

public class HomeController : Controller
{
    AppDbContent db;
    public HomeController(AppDbContent context)
    {
    db = context;
    }
    public IActionResult Index()
    {
        return View(db.Users);
    }

    public IActionResult SingIN()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

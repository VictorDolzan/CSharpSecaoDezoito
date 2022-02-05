using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CSharpSecaoDezoito.Models;
using CSharpSecaoDezoito.Models.ViewModels;

namespace CSharpSecaoDezoito.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewData["Message"] = "Sales Web MVC App from C# Course";
        ViewData["Developer"] = "Victor Dolsan";
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

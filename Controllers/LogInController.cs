using Microsoft.AspNetCore.Mvc;

namespace MahalCoffee.Controllers;

public class LogInController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}
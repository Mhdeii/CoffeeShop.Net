using Microsoft.AspNetCore.Mvc;

namespace MahalCoffee_CSC400.Controllers;

public class AdminController : Controller
{
    
    
    public IActionResult Dashboard()
    {
        return View();
    } 
}
using Microsoft.AspNetCore.Mvc;

namespace mednik.Controllers;

public class HomeController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}
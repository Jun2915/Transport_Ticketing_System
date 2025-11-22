using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ASS_WMS.Controllers;

public class HomeController : Controller
{
    //GET: Home/Index
    public IActionResult Index()
    {
        return View();
    }

    //GET: Home/Customer
    //[Authorize(Roles = "Customer")]
    public IActionResult Customer()
    {
        return View();
    }

    //GET: Home/Admin
    //[Authorize(Roles = "Admin")]
    public IActionResult Admin()
    {
        return View();
    }
}
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


}
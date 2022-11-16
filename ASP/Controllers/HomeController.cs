using ASP.Entities;
using ASP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ASP.Controllers
{
    public class HomeController : Controller
    {
       
         public IActionResult Index()
         {
            return View();
         }

    }
}

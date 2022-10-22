using ASP.Entities;
using ASP.FakeRepo;
using ASP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ASP.Controllers
{
    public class HomeController : Controller
    {
       
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(PersonAddViewModel viewModel1)
        {
            if (ModelState.IsValid)
            {
                var person = viewModel1.Person;
                FakeRepository.People.Add(person);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        public IActionResult Index()
        {
            var data = FakeRepository.People;
            var viewModel = new PersonListViewModel { People=data };
            return View(viewModel);
        }

    }
}

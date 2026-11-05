using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class SneakerController : Controller
    {
        private static List<Sneaker> _sneakers = new List<Sneaker>();

        public IActionResult Index()
        {
            return View(_sneakers);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Sneaker sneaker)
        {
            if (ModelState.IsValid)
            {
                sneaker.Id = _sneakers.Count + 1;
                _sneakers.Add(sneaker);
                return RedirectToAction("Index");
            }
            return View(sneaker); 
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using MovieApp.Models;

namespace MovieApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
          return View(ProductRepository.Movies);
        }

        public IActionResult Details(int id)
        {
          return View(ProductRepository.GetById(id));
        }

        public IActionResult Contact()
        {
          return View();
        }
    }
}
using System.Diagnostics;
using CRUD.Context;
using CRUD.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public string[] listofData = { "one", "two", "three" };




        private readonly  CategoryContext _ct;
        
        public HomeController(ILogger<HomeController> logger, CategoryContext ct)
        {
            _logger = logger;
            _ct = ct;
        }

        
        public IActionResult Index()
        {
            List<string> cats = new List<string>();
            foreach (var c in _ct.Categories)
            {
               cats.Add(c.Name);
            }

            
            ViewBag.listofData = cats;
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
}

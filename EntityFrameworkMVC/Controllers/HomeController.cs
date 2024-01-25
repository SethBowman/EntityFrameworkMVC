using EntityFrameworkMVC.Data;
using EntityFrameworkMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace EntityFrameworkMVC.Controllers
{
    public class HomeController : Controller
    {        
        private readonly Testdb _data;
        public HomeController(Testdb data)
        {
            _data = data;
        }       
        public IActionResult Index()
        {
            var users = _data.Users.ToList();
            return View(users);
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

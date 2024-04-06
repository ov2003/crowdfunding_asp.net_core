using crowdfunding.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace crowdfunding.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult homepage()
        {
            return View();
        }
        public IActionResult user_login()
        {
            return View();
        }
        public IActionResult News()
        {
            return View();
        }
        public IActionResult Payment()
        {
            return View();
        }   
        public IActionResult Contact()
        {
            return View();
        } 
        public IActionResult Fundraiser()
        {
            return View();
        } 
        public IActionResult Ngo()
        {
            return View();
        }
        public IActionResult Paymentmethod()
        {
            return View();
        } 
        public IActionResult Sign_up()
        {
            return View();
        }
        public IActionResult Success()
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

using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace PocketWord.Controllers
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
        public IActionResult Apple()
        {
            return View();
        }
        public IActionResult Hakkimda()
        {
            return View();
        }
        public IActionResult Huawei()
        {
            return View();
        }
        public IActionResult Iletisim()
        {
            return View();
        }
        public IActionResult Samsung()
        {
            return View();
        }
        public IActionResult Gizlilik()
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

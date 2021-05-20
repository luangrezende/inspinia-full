using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Project.Portal.Road.Controllers
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
            ViewData["SubTitle"] = "Welcome ao projeto rodoviário";
            ViewData["Message"] = "Esta é uma aplicação de gerenciamento de motoristas";

            return View();
        }
    }
}

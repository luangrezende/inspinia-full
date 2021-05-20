using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Portal.Road.Controllers
{
    public class ErrorController : Controller
    {
        [Route("/Error/{statusCode}")]
        public IActionResult Index(int statusCode)
        {
            return statusCode switch
            {
                404 => RedirectToAction("PageNotFound"),
                500 => RedirectToAction("InternalServerError"),
                _ => View(),
            };
        }

        public IActionResult PageNotFound()
        {
            return View();
        }

        public IActionResult InternalServerError()
        {
            return View();
        }
    }
}

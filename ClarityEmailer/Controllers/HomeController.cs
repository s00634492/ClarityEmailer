using Microsoft.AspNetCore.Mvc;
using ClarityEmailer.Models;

namespace ClarityEmailer.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

    }
}

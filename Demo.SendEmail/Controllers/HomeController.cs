using AspCore_Email.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AspCore_Email.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

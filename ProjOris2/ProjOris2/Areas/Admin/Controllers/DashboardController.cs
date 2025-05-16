using Microsoft.AspNetCore.Mvc;

namespace ProjOris2.Controllers;
    [Area("Admin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Policy;
using TeachAnnouncement.Models;
using static TeachAnnouncement.Models.AdmAnnoViewModel;

namespace TeachAnnouncement.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

   //     public IActionResult Index()
   //     {
			//return View();
   //     }

		public IActionResult Index()
		{
            return View();
		}

		public IActionResult Privacy(String chartid)
        {

			ViewBag.chartid = chartid;
			return RedirectToAction("Query","AdmAnno", chartid);
			//return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
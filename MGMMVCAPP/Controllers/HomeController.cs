using System.Diagnostics;
using Common;
using MGMMVCAPP.Models;
using Microsoft.AspNetCore.Mvc;

namespace MGMMVCAPP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICityStationInfo _cityStationInfo;

        public HomeController(ILogger<HomeController> logger, ICityStationInfo cityStationInfo)
        {
            _logger = logger;
            _cityStationInfo = cityStationInfo;
        }

        public IActionResult Index()
        {
            var allStations = _cityStationInfo.GetAllStations().OrderBy(x => x.il).Take(100).ToList();

            return View(allStations);
        }

        public IActionResult Privacy()
        {

            return View();
        }

        public IActionResult DetailsPartial(int id)
        {
            var model = _cityStationInfo.GetCityStationInfo(id); 
            if (model == null) return NotFound();

            return PartialView("_DetailsPartial", model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

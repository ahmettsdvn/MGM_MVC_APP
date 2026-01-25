using Common;
using Common.DTO;
using Common.Stations;
using MGMMVCAPP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;
using static System.Collections.Specialized.BitVector32;

namespace MGMMVCAPP.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICityStationInfo _cityStationInfo;

        private readonly int PAGE_SIZE = 50;

        public HomeController(ILogger<HomeController> logger, ICityStationInfo cityStationInfo)
        {
            _logger = logger;
            _cityStationInfo = cityStationInfo;
        }

        public IActionResult Index(int page = 1)
        {
            // page 1'den baþlasýn
            if (page < 1) page = 1;

            // toplam kayýt sayýsý
            int totalCount = _cityStationInfo.GetAllStations().Count;

            // veri alýndý viewa gönderildi
            var allStations = _cityStationInfo
                .GetAllStations()
                .OrderBy(x => x.il)
                .Skip((page - 1) * PAGE_SIZE)
                .Take(PAGE_SIZE)
                .ToList();

            // viev Model DTO
            var vm = new PagedResult<AllStations>
            {
                Items = allStations,
                Page = page,
                PageSize = PAGE_SIZE,
                TotalCount = totalCount
            };

            return View(vm);
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

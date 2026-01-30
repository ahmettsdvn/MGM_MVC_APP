using Common;
using Common.DTO;
using Common.Stations;
using MGMMVCAPP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services.Helper.TurkeyCityDistrict;
using System.Diagnostics;
using System.Threading.Tasks;
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

        public async Task<IActionResult> Index(int page = 1, int? cityId = null, string? districtName = null)
        {
            // page 1'den ba�las�n
            if (page < 1) page = 1;

            var query = _cityStationInfo.GetAllStations().AsQueryable();

            if (cityId.HasValue)
                query = query.Where(x => x.ilPlaka == cityId.Value);

            if (!string.IsNullOrWhiteSpace(districtName))
                query = query.Where(x => x.ilce.ToLower() == districtName.ToLower());

            // toplam kay�t say�s�
            int totalCount = query.Count();

            // veri al�nd� viewa g�nderildi
            var allStations = query
                .OrderBy(x => x.il)
                .Skip((page - 1) * PAGE_SIZE)
                .Take(PAGE_SIZE)
                .ToList();

            CityDistrictDTO parameters = new CityDistrictDTO
            {
                CityList = TurkeyCityDistrictHelper.GetTurkeyCity(),
            };

            // viev Model DTO
            var vm = new PagedResult<AllStations, CityDistrictDTO>
            {
                Items = allStations,
                Page = page,
                PageSize = PAGE_SIZE,
                TotalCount = totalCount,
                OtherParams = parameters
            };

            return View(vm);
        }

        [HttpGet]
        public IActionResult GetDistricts(int cityId)
        {
            var districts = TurkeyCityDistrictHelper.GetDistrictByCityCode(cityId); 

            return Json(districts);
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

using Common;
using Common.DTO;
using Common.LastStatus;
using Common.Stations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services.Helper.TurkeyCityDistrict;

namespace MGMMVCAPP.Controllers
{
    public class LastStatusController : Controller
    {
        private readonly ILastStatusInfo _lastStatusInfo;
        private readonly ICityStationInfo _cityStationInfo;

        public LastStatusController(ILastStatusInfo lastStatusInfo, ICityStationInfo cityStationInfo)
        {
            _lastStatusInfo = lastStatusInfo;
            _cityStationInfo = cityStationInfo;
        }

        // GET: LastStatusController
        public ActionResult Index(string cityName = "İSTANBUL", string districtName ="SULTANBEYLİ")
        {
            CityStationInfo station = _cityStationInfo.GetDistrictStationInfo(cityName, districtName);

            int centerId = 0;

            if (station != null)
            {
                centerId = station.merkezId;
            }
    
            LastStatusInfo lastStatus = new LastStatusInfo();

            if(centerId != 0)
            {
                lastStatus = _lastStatusInfo.GetLastStatusInfo(centerId);
            }

            CityDistrictDTO parameters = new CityDistrictDTO
            {
                CityList = TurkeyCityDistrictHelper.GetTurkeyCity(),
                CityName = cityName,
                DistrictName = districtName
            };

            var lastStatusList = new List<LastStatusInfo>();

            lastStatusList.Add(lastStatus);

            var vm = new PagedResult<LastStatusInfo, CityDistrictDTO>
            {
                Items = lastStatusList,
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

    }
}

using Common;
using Common.DTO;
using Common.LastStatus;
using Common.Stations;
using Common.Weather;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Services.Helper.TurkeyCityDistrict;

namespace MGMMVCAPP.Controllers
{
    public class Day5Controller : Controller
    {
        private readonly IWeatherForecast _weatherForecast;
        private readonly ICityStationInfo _cityStationInfo;

        public Day5Controller(IWeatherForecast weatherForecast, ICityStationInfo cityStationInfo)
        {
            _weatherForecast = weatherForecast;
            _cityStationInfo = cityStationInfo;
        }

        // GET: Day5Controller
        public ActionResult Index(string cityName = "İSTANBUL", string districtName ="SULTANBEYLİ")
        {
            CityStationInfo station = _cityStationInfo.GetDistrictStationInfo(cityName, districtName);

            int stationId = 0;

            if (station != null)
            {
                stationId = station.gunlukTahminIstNo;
            }

            DailyWeatherForecast dailyWeatherForecast = new DailyWeatherForecast();

            if(stationId != 0)
            {
                dailyWeatherForecast = _weatherForecast.GetDailyWeatherForecast(stationId);
            }

            CityDistrictDTO parameters = new CityDistrictDTO
            {
                CityList = TurkeyCityDistrictHelper.GetTurkeyCity(),
                CityName = cityName,
                DistrictName = districtName
            };

            var day5List = new List<DailyWeatherForecast>();

            day5List.Add(dailyWeatherForecast == null ? new DailyWeatherForecast(): dailyWeatherForecast);

            var vm = new PagedResult<DailyWeatherForecast, CityDistrictDTO>
            {
                Items = day5List,
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

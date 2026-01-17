using Common;
using Common.Settings;
using Common.Settings.Constants;
using Common.Stations;
using Services.Infrastructre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CityStationInfoService : ICityStationInfo
    {
        private readonly BaseHttpClient _client;

        public CityStationInfoService(BaseHttpClient client)
        {
            _client = client;
        }

        public List<AllStations> GetAllStations()
        {
            var result = _client.GetAsync<List<AllStations>>(UriHelper.MGM_TUM_ISTASYONLAR(), MGMHttpHeaders.MGM_HEADERS);

            return result.Result;
        }

        public CityStationInfo GetCityStationInfo(string cityName)
        {
            var result = _client.GetAsync<CityStationInfo>(UriHelper.MGM_API_IL_ISTASYON_BILGILERI(cityName), MGMHttpHeaders.MGM_HEADERS);

            return result.Result;    
        }

        public CityStationInfo GetCityStationInfo(int stationCode)
        {
            throw new NotImplementedException();
        }

        public List<CityStationInfo> GetCityStationInfoList()
        {
            throw new NotImplementedException();
        }

        public CityStationInfo GetDistrictStationInfo(string districtName)
        {
            throw new NotImplementedException();
        }

        public CityStationInfo GetDistrictStationInfo(int stationCode)
        {
            throw new NotImplementedException();
        }
    }
}

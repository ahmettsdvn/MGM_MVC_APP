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
            List<AllStations> stations = GetAllStations().Where(i => i.istNo == stationCode).ToList();
            CityStationInfo package = new CityStationInfo();

            if(stations.Count> 0)   
            {
                AllStations station = stations.First();//stations[0];

                package.il = station.il;
                package.ilce = station.ilce;
                package.ilPlaka = station.ilPlaka;
                package.boylam = (decimal)station.boylam;
                package.enlem = (decimal)station.enlem;
                package.yukseklik = station.yukseklik;
            }
            return package;
        }

        public List<CityStationInfo> GetCityStationInfoList()
        {
            var result = _client.GetAsync<List<CityStationInfo>>(UriHelper.MGM_API_ILLER_URL(), MGMHttpHeaders.MGM_HEADERS).Result;
            return result;
        }

        public CityStationInfo GetDistrictStationInfo(string cityName, string districtName)
        {
            var result = _client.GetAsync<CityStationInfo>(UriHelper.MGM_API_IL_ILCE_ISTASYON_BILGILERI(cityName, districtName), MGMHttpHeaders.MGM_HEADERS).Result;

            return result;
        }

        public CityStationInfo GetDistrictStationInfo(int stationCode)
        {
            List<AllStations> stations = GetAllStations().Where(i => i.istNo == stationCode).ToList();
            CityStationInfo package = new CityStationInfo();

            if (stations.Count > 0)
            {
                AllStations station = stations.First();//stations[0];

                package.il = station.il;
                package.ilce = station.ilce;
                package.ilPlaka = station.ilPlaka;
                package.boylam = (decimal)station.boylam;
                package.enlem = (decimal)station.enlem;
                package.yukseklik = station.yukseklik;
            }
            return package;
        }
    }
}

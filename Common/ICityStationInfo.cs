using Common.Stations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    /// <summary>
    /// 81 il istasyonlarının bilgilerini tutan interface
    /// </summary>
    public interface ICityStationInfo
    {
        /// <summary>
        /// 81 il istasyonlarının bilgilerini döner
        /// </summary>
        /// <returns></returns>
        List<CityStationInfo> GetCityStationInfoList();

        /// <summary>
        /// Verilen ilin istasyon bilgilerini döner
        /// </summary>
        /// <param name="cityName"></param>
        /// <returns></returns>
        CityStationInfo GetCityStationInfo(string cityName);

        /// <summary>
        /// Verilen ilin istasyon bilgilerini döner
        /// </summary>
        /// <param name="stationCode"></param>
        /// <returns></returns>
        CityStationInfo GetCityStationInfo(int stationCode);

        /// <summary>
        /// Verilen ilçenin istasyon bilgilerini döner
        /// </summary>
        /// <param name="cityName"></param>
        /// <returns></returns>
        CityStationInfo GetDistrictStationInfo(string districtName);

        /// <summary>
        /// Verilen ilçenin istasyon bilgilerini döner
        /// </summary>
        /// <param name="stationCode"></param>
        /// <returns></returns>
        CityStationInfo GetDistrictStationInfo(int stationCode);

        /// <summary>
        /// Tüm istasyonlar
        /// </summary>
        /// <param name="stationCode"></param>
        /// <returns></returns>
        List<AllStations> GetAllStations();

    }
}

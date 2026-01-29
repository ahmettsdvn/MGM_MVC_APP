using Common.Weather;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    /// <summary>
    /// hava tahmin bilgilerini tutan arayüz
    /// </summary>
    public interface IWeatherForecast
    {
        /// <summary>
        /// Belirtilen istasyon 5 günlük tahminler/gunluk
        /// </summary>
        /// <param name="stationId"></param>
        /// <returns></returns>
        DailyWeatherForecast GetDailyWeatherForecast(int stationId);


        /// <summary>
        /// Belirtilen istasyon için saatlik hava durumu ve sıcaklık
        /// </summary>
        /// <param name="stationId"></param>
        /// <returns></returns>
        HourlyWeatherForecast GetHourlyWeatherForecast(int stationId);
    }
}

using Common;
using Common.Weather;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    internal class WeatherForecastServices : IWeatherForecast
    {
        public DailyWeatherForecast GetDailyWeatherForecast(int stationId)
        {
            throw new NotImplementedException();
        }

        public HourlyWeatherForecast GetHourlyWeatherForecast(int stationId)
        {
            throw new NotImplementedException();
        }
    }
}

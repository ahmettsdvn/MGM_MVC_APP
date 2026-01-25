using Common;
using Common.Settings;
using Common.Settings.Constants;
using Common.Weather;
using Services.Infrastructre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class WeatherForecastServices : IWeatherForecast
    {
        private readonly BaseHttpClient _client;

        public WeatherForecastServices(BaseHttpClient client)
        {
            _client = client;
        }

        public DailyWeatherForecast GetDailyWeatherForecast(int stationId)
        {
            var result = _client.GetAsync<DailyWeatherForecast>(UriHelper.MGM_API_GUNLUK_HAVA_DURUMU(stationId), MGMHttpHeaders.MGM_HEADERS).Result;
            return result;
        }

        public HourlyWeatherForecast GetHourlyWeatherForecast(int stationId)
        {
            var result = _client.GetAsync<HourlyWeatherForecast>(UriHelper.MGM_API_SAATLIK_HAVA_DURUMU(stationId), MGMHttpHeaders.MGM_HEADERS).Result;
            return result;  
        }
    }
}

using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Weerbericht.Models;

namespace Weerbericht.Services
{
    public class WeatherService
    {
        private readonly HttpClient _httpClient;

        public WeatherService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Weather> GetWeatherDataAsync()
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync("https://api.open-meteo.com/v1/forecast?latitude=52.25&longitude=5.75&daily=weather_code,temperature_2m_max,temperature_2m_min,rain_sum,showers_sum,snowfall_sum,wind_speed_10m_max,wind_direction_10m_dominant&timezone=auto&forecast_days=14");

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    Weather weather = JsonConvert.DeserializeObject<Weather>(json)!;
                    return weather;
                }
                else
                {
                    throw new Exception($"Failed to retrieve weather data. Status code: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving weather data.", ex);
            }
        }
    }
}


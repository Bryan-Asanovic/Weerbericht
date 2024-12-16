using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Weerbericht.Models
{
    public class DailyWeather
    {
        [JsonProperty("time")]
        public List<string>? Time { get; set; }

        [JsonProperty("weather_code")]
        public List<string>? Weathercode { get; set; }

        [JsonProperty("temperature_2m_max")]
        public List<double>? MaxTemperatures { get; set; }

        [JsonProperty("temperature_2m_min")]
        public List<double>? MinTemperatures { get; set; }

        [JsonProperty("rain_sum")]
        public List<double>? RainSums { get; set; }

        [JsonProperty("showers_sum")]
        public List<double>? ShowerSums { get; set; }

        [JsonProperty("snowfall_sum")]
        public List<double>? SnowfallSums { get; set; }

        [JsonProperty("wind_speed_10m_max")]
        public List<double>? MaxWindSpeeds { get; set; }

        [JsonProperty("wind_direction_10m_dominant")]
        public List<double>? WindDirection { get; set; }

        public int GetChanceOfRain(int dayIndex)
        {
            if (RainSums == null || ShowerSums == null || RainSums.Count <= dayIndex || ShowerSums.Count <= dayIndex)
            {
                return 0;
            }

            double rainSum = RainSums[dayIndex];
            double showersSum = ShowerSums[dayIndex];

            int totalDays = RainSums.Count;
            int daysWithRain = (rainSum > 0) ? 1 : 0;
            int daysWithShowers = (showersSum > 0) ? 1 : 0;

            double chanceOfRain = ((double)(daysWithRain + daysWithShowers) / totalDays) * 100;

            return (int)Math.Round(chanceOfRain, MidpointRounding.AwayFromZero);
        }

    }
}
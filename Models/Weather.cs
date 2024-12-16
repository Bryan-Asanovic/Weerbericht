using Newtonsoft.Json;
using System.Collections.Generic;
namespace Weerbericht.Models
{
    public class Weather
    {
        [JsonProperty("daily")]
        public DailyWeather? Daily { get; set; }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection;
using System.Text.Json;
using Weerbericht.Models;
using Weerbericht.Services;

namespace Weerbericht.Pages;

public class IndexModel : PageModel
{
    private readonly WeatherService _weatherService;
    public Weather WeatherData { get; private set; }

    public IndexModel(WeatherService weatherService)
    {
        _weatherService = weatherService;
    }

    public async Task OnGetAsync()
    {
        WeatherData = await _weatherService.GetWeatherDataAsync();
    }
}

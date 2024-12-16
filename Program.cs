using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Weerbericht.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services
     .AddRazorPages()
     .AddRazorPagesOptions(opt => opt.RootDirectory = "/Pages");
builder.Services.AddHttpClient<WeatherService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();

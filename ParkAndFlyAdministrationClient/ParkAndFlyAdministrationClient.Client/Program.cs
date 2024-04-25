using Blazored.SessionStorage;
using dymaptic.GeoBlazor.Core;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ParkAndFlyAdministrationClient.Data.Services;
using Radzen;
using System.Text.Json;

namespace ParkAndFlyAdministrationClient.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.Services.AddBlazoredSessionStorage(config => {
                config.JsonSerializerOptions.DictionaryKeyPolicy = JsonNamingPolicy.CamelCase;
                config.JsonSerializerOptions.IgnoreNullValues = true;
                config.JsonSerializerOptions.IgnoreReadOnlyProperties = true;
                config.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
                config.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.CamelCase;
                config.JsonSerializerOptions.ReadCommentHandling = JsonCommentHandling.Skip;
                config.JsonSerializerOptions.WriteIndented = false;
                }
            );

            builder.Services.AddGeoBlazor(builder.Configuration);
            builder.Services.AddSingleton(sp => new HttpClient { BaseAddress = new Uri(builder.Configuration["FrontendUrl"] ?? "https://localhost:5002") });
            builder.Services.AddSingleton<IParkingService, ParkingService>();
            builder.Services.AddSingleton<IReservationService, ReservationService>(); builder.Services.AddSingleton<IParkingService, ParkingService>();
            builder.Services.AddSingleton<ICarServcie, CarService>();
            builder.Services.AddSingleton<ICustomerService, CustomerService>();

            builder.Services.AddScoped<DialogService>();

            await builder.Build().RunAsync();
        }
    }
}

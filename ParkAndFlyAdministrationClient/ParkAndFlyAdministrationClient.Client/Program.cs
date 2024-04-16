using dymaptic.GeoBlazor.Core;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ParkAndFlyAdministrationClient.Data.Services;

namespace ParkAndFlyAdministrationClient.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.Services.AddGeoBlazor(builder.Configuration);
            builder.Services.AddSingleton(sp => new HttpClient { BaseAddress = new Uri(builder.Configuration["FrontendUrl"] ?? "https://localhost:5002") });
            builder.Services.AddSingleton<IParkingService, ParkingService>();
            builder.Services.AddSingleton<IReservationService, ReservationService>();

            await builder.Build().RunAsync();
        }
    }
}

using dymaptic.GeoBlazor.Core;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace ParkAndFlyAdministrationClient.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.Services.AddGeoBlazor(builder.Configuration);

            await builder.Build().RunAsync();
        }
    }
}

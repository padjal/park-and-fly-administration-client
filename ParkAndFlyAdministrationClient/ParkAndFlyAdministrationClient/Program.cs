using dymaptic.GeoBlazor.Core;
using ParkAndFlyAdministrationClient.Client.Pages;
using ParkAndFlyAdministrationClient.Components;
using ParkAndFlyAdministrationClient.Data.Services;
using Radzen;

namespace ParkAndFlyAdministrationClient
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents()
                .AddInteractiveWebAssemblyComponents();

            builder.Services.AddGeoBlazor(builder.Configuration);

            builder.Services.AddRadzenComponents();

            builder.Services.AddSingleton<IParkingService, ParkingService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode()
                .AddInteractiveWebAssemblyRenderMode()
                .AddAdditionalAssemblies(typeof(Client._Imports).Assembly);

            app.Run();
        }
    }
}

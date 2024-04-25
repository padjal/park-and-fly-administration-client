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

            builder.Services.AddSingleton(sp =>
                new HttpClient
                {
                    BaseAddress = new Uri("http://18.130.140.171:8080")
                });

            builder.Services.AddSingleton<IParkingService, ParkingService>();
            builder.Services.AddSingleton<IReservationService, ReservationService>();
            builder.Services.AddSingleton<ICustomerService, CustomerService>();
            builder.Services.AddSingleton<ICarServcie, CarService>();

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

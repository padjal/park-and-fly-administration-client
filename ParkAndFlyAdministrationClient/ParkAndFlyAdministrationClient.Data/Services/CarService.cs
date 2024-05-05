using ParkAndFlyAdministrationClient.Data.Models;
using System.Net.Http.Json;

namespace ParkAndFlyAdministrationClient.Data.Services
{
    public class CarService(HttpClient httpClient) : ICarServcie
    {
        public async Task<List<Car>> GetCarsByUserAsync(string userId)
        {
            await Task.Delay(1000);

            //return await httpClient.GetFromJsonAsync<List<Car>>("cars") ?? new List<Car>();

            return new List<Car> { 
                new Car() {Number = "CA7622HE", Brand="Toyota", Model ="Rav4", Color="Gray" },
                new Car() {Number = "CA7642HE", Brand="Toyota", Model ="Rav4", Color="Gray" },
                new Car() {Number = "CA3456HE", Brand="Toyota", Model ="Rav4", Color="Gray" },
                new Car() {Number = "CA2367HE", Brand="Toyota", Model ="Rav4", Color="Gray" },
                new Car() {Number = "CA2346HE", Brand="Toyota", Model ="Rav4", Color="Gray" },
                new Car() {Number = "CA7656HE", Brand="Toyota", Model ="Rav4", Color="Gray" },
                new Car() {Number = "CA2234HE", Brand="Toyota", Model ="Rav4", Color="Gray" },
            };
        }
    }
}

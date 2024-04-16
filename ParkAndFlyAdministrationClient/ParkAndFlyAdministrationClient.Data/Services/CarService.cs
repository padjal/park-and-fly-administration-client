using ParkAndFlyAdministrationClient.Data.Models;

namespace ParkAndFlyAdministrationClient.Data.Services
{
    public class CarService : ICarServcie
    {
        public async Task<List<Car>> GetCarsByUserAsync(string userId)
        {
            await Task.Delay(1000);

            return new List<Car> { new Car() {Number = "CA7622HE", Brand="Toyota", Model ="Rav4", Color="Gray" },
            new Car() {Number = "CA7622HE", Brand="Toyota", Model ="Rav4", Color="Gray" },
            new Car() {Number = "CA7622HE", Brand="Toyota", Model ="Rav4", Color="Gray" },
            new Car() {Number = "CA7622HE", Brand="Toyota", Model ="Rav4", Color="Gray" },
            new Car() {Number = "CA7622HE", Brand="Toyota", Model ="Rav4", Color="Gray" },
            new Car() {Number = "CA7622HE", Brand="Toyota", Model ="Rav4", Color="Gray" },
            new Car() {Number = "CA7622HE", Brand="Toyota", Model ="Rav4", Color="Gray" },};
        }
    }
}

using ParkAndFlyAdministrationClient.Data.Models;

namespace ParkAndFlyAdministrationClient.Data.Services
{
    public interface ICarServcie
    {
        public Task<List<Car>> GetCarsByUserAsync(string userId);
        public Task<List<Car>> GetAllCars();
    }
}

using ParkAndFlyAdministrationClient.Data.Models;

namespace ParkAndFlyAdministrationClient.Data.Services
{
    public interface ICustomerService
    {
        public Task<List<Customer>> GetAllAsync();

        public Task<List<Customer>> GetCustomersFromParkingAsync(string parkingId);

        public Task<Customer> GetCustomerAsync(string customerId);
    }
}

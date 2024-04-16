using ParkAndFlyAdministrationClient.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkAndFlyAdministrationClient.Data.Services
{
    public interface ICustomerService
    {
        public Task<List<Customer>> GetAllAsync();

        public Task<List<Customer>> GetCustomersFromParkingAsync(string parkingId);

        public Task<Customer> GetCustomerAsync(string customerId);
    }
}

using ParkAndFlyAdministrationClient.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkAndFlyAdministrationClient.Data.Services
{
    public class CustomerService : ICustomerService
    {
        public async Task<List<Customer>> GetAllAsync()
        {
            await Task.Delay(1000);

            return new List<Customer>()
            {
                new Customer(){Id="2342342", Birthday=DateTime.Now, Email="padjal@example.com", Name="Pavel", Surname="Dzhalev", PhoneNumber="0892342345"},
                new Customer(){Id="2342342", Birthday=DateTime.Now, Email="padjal@example.com", Name="Pavel", Surname="Dzhalev", PhoneNumber="0892342345"},
                new Customer(){Id="2342342", Birthday=DateTime.Now, Email="padjal@example.com", Name="Pavel", Surname="Dzhalev", PhoneNumber="0892342345"},
                new Customer(){Id="2342342", Birthday=DateTime.Now, Email="padjal@example.com", Name="Pavel", Surname="Dzhalev", PhoneNumber="0892342345"},
                new Customer(){Id="2342342", Birthday=DateTime.Now, Email="padjal@example.com", Name="Pavel", Surname="Dzhalev", PhoneNumber="0892342345"},
                new Customer(){Id="2342342", Birthday=DateTime.Now, Email="padjal@example.com", Name="Pavel", Surname="Dzhalev", PhoneNumber="0892342345"},
            };
        }

        public async Task<Customer> GetCustomerAsync(string customerId)
        {
            await Task.Delay(1000);

            return new Customer() { Id = "2342342", Birthday = DateTime.Now, Email = "padjal@example.com", Name = "Pavel", Surname = "Dzhalev", PhoneNumber = "0892342345" }
        }

        public async Task<List<Customer>> GetCustomersFromParkingAsync(string parkingId)
        {
            await Task.Delay(1000);

            return new List<Customer>()
            {
                new Customer(){Id="2342342", Birthday=DateTime.Now, Email="padjal@example.com", Name="Pavel", Surname="Dzhalev", PhoneNumber="0892342345"},
                new Customer(){Id="2342342", Birthday=DateTime.Now, Email="padjal@example.com", Name="Pavel", Surname="Dzhalev", PhoneNumber="0892342345"},
                new Customer(){Id="2342342", Birthday=DateTime.Now, Email="padjal@example.com", Name="Pavel", Surname="Dzhalev", PhoneNumber="0892342345"},
                new Customer(){Id="2342342", Birthday=DateTime.Now, Email="padjal@example.com", Name="Pavel", Surname="Dzhalev", PhoneNumber="0892342345"},
                new Customer(){Id="2342342", Birthday=DateTime.Now, Email="padjal@example.com", Name="Pavel", Surname="Dzhalev", PhoneNumber="0892342345"},
                new Customer(){Id="2342342", Birthday=DateTime.Now, Email="padjal@example.com", Name="Pavel", Surname="Dzhalev", PhoneNumber="0892342345"},
            };
        }
    }
}

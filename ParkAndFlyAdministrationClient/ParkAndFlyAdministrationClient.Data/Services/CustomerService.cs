using ParkAndFlyAdministrationClient.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ParkAndFlyAdministrationClient.Data.Services
{
    public class CustomerService(HttpClient httpClient) : ICustomerService
    {
        public async Task<List<Customer>> GetAllAsync()
        {
            //return await httpClient.GetFromJsonAsync<List<Customer>>("customers") ?? new List<Customer>();

            await Task.Delay(1000);

            return new List<Customer>()
            {
                new Customer(){Id="2342342", Birthday=DateTime.Now, Email="padjal@example.com", Name="Pavel", Surname="Dzhalev", PhoneNumber="0892342345"},
                new Customer(){Id="2342342", Birthday=DateTime.Now, Email="padjal@example.com", Name="Johny", Surname="Depp", PhoneNumber="0892342345"},
                new Customer(){Id="2342342", Birthday=DateTime.Now, Email="padjal@example.com", Name="James", Surname="Hype", PhoneNumber="0892342345"},
                new Customer(){Id="2342342", Birthday=DateTime.Now, Email="padjal@example.com", Name="George", Surname="Doyd", PhoneNumber="0892342345"},
                new Customer(){Id="2342342", Birthday=DateTime.Now, Email="padjal@example.com", Name="Valentin", Surname="Kiprov", PhoneNumber="0892342345"},
                new Customer(){Id="2342342", Birthday=DateTime.Now, Email="padjal@example.com", Name="Mario", Surname="Bush", PhoneNumber="0892342345"},
            };
        }

        public async Task<Customer> GetCustomerAsync(string customerId)
        {
            await Task.Delay(1000);

            return new Customer() { Id = "2342342", Birthday = DateTime.Now, Email = "padjal@example.com", Name = "Pavel", Surname = "Dzhalev", PhoneNumber = "0892342345" };
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

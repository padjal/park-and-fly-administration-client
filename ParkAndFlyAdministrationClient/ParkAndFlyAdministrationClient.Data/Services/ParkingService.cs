using ParkAndFlyAdministrationClient.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ParkAndFlyAdministrationClient.Data.Services
{
    public class ParkingService(HttpClient httpClient) : IParkingService
    {
        public async Task<bool> AddParkingAsync(Parking parking)
        {
            //var response = await _httpClient.GetAsync("api/v1/parking");

            await Task.Delay(3000);

            throw new NotImplementedException();
        }

        public async Task<List<Parking>> GetParkingsAsync()
        {
            await Task.Delay(300);

            return new List<Parking>() { new Parking() {Name = "New parking 1" }, new Parking() { Name = "New parking 2" } };
        }
    }
}

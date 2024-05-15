using ParkAndFlyAdministrationClient.Client.Data.Response;
using ParkAndFlyAdministrationClient.Data.Auth;
using ParkAndFlyAdministrationClient.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
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
            var response = await httpClient.GetAsync("api/v1/parking");

            var parkings = JsonSerializer.Deserialize<List<Parking>>(await response.Content.ReadAsStringAsync(), new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            if (response.IsSuccessStatusCode)
            {
                return parkings;
            }

            return [] ;
        }
    }
}

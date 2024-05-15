using ParkAndFlyAdministrationClient.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ParkAndFlyAdministrationClient.Data.Services
{
    public class ReservationService(HttpClient httpClient) : IReservationService
    {
        public Task<bool> AddReservation(ReservationRequest reservation)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Reservation>> GetAllReservationsAsync()
        {
            var response = await httpClient.GetAsync("api/v1/reservation");

            if(response.IsSuccessStatusCode)
            {
                return JsonSerializer.Deserialize<List<Reservation>>(await response.Content.ReadAsStringAsync(), new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            }

            return [];
        }

        public Task<List<Reservation>> GetReservationsAsync(string parkingId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> RemoveReservation(string ReservationId)
        {
            throw new NotImplementedException();
        }
    }
}

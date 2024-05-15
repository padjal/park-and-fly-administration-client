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

        public async Task<List<Reservation>> GetReservationsAsync(string parkingId)
        {
            var response = await httpClient.GetAsync($"api/v1/reservation?parkingId={parkingId}");

            return response.IsSuccessStatusCode ? 
                JsonSerializer.Deserialize<List<Reservation>>(await response.Content.ReadAsStringAsync(), new JsonSerializerOptions { PropertyNameCaseInsensitive = true }) :
                [];
        }

        public async Task<List<Reservation>> GetCurrentReservationsAsync(string parkingId)
        {
            var response = await httpClient.GetAsync($"api/v1/reservation/current/?parkingId={parkingId}&now={DateTime.Now.ToString("u")}");

            return response.IsSuccessStatusCode ?
                JsonSerializer.Deserialize<List<Reservation>>(await response.Content.ReadAsStringAsync(), new JsonSerializerOptions { PropertyNameCaseInsensitive = true }) :
                [];
        }

        public async Task<List<Reservation>> GetUpcommingReservationsAsync(string parkingId)
        {
            var response = await httpClient.GetAsync($"api/v1/reservation?parkingId={parkingId}&startTime={DateTime.Now.ToString("u")}");

            return response.IsSuccessStatusCode ?
                JsonSerializer.Deserialize<List<Reservation>>(await response.Content.ReadAsStringAsync(), new JsonSerializerOptions { PropertyNameCaseInsensitive = true }) :
                [];
        }

        public Task<bool> RemoveReservation(string ReservationId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Reservation>> GetReservationsForTheMonthAsync(string parkingId)
        {
            var response = await httpClient.GetAsync($"api/v1/reservation?parkingId={parkingId}&startTime={GetFirstDayOfMonth().ToString("u")}&endTime={GetLastDayOfMonth().ToString("u")}");

            return response.IsSuccessStatusCode ?
                JsonSerializer.Deserialize<List<Reservation>>(await response.Content.ReadAsStringAsync(), new JsonSerializerOptions { PropertyNameCaseInsensitive = true }) :
                [];
        }

        private DateTime GetFirstDayOfMonth()
        {
            DateTime currentDate = DateTime.Now;

            // Get the first day of the current month
            DateTime firstDayOfMonth = new DateTime(currentDate.Year, currentDate.Month, 1);

            return firstDayOfMonth;
        }

        private DateTime GetLastDayOfMonth()
        {
            // Get the current date
            DateTime currentDate = DateTime.Now;

            // Get the last day of the current month
            return new DateTime(currentDate.Year, currentDate.Month, DateTime.DaysInMonth(currentDate.Year, currentDate.Month));
        }
    }
}

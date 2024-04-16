using ParkAndFlyAdministrationClient.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkAndFlyAdministrationClient.Data.Services
{
    public class ReservationService : IReservationService
    {
        public Task<bool> AddReservation(ReservationRequest reservation)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Reservation>> GetAllReservationsAsync()
        {
            await Task.Delay(1000);

            return new List<Reservation>() { 
            new Reservation{Id = "2w34234", From=DateTime.Now, To=DateTime.Now, CarNumber="CA7177HE" },
            new Reservation{Id = "2w34234", From=DateTime.Now, To=DateTime.Now, CarNumber="CA7177HE" },
            new Reservation{Id = "2w34234", From=DateTime.Now, To=DateTime.Now, CarNumber="CA7177HE" },
            new Reservation{Id = "2w34234", From=DateTime.Now, To=DateTime.Now, CarNumber="CA7177HE" },
            new Reservation{Id = "2w34234", From=DateTime.Now, To=DateTime.Now, CarNumber="CA7177HE" }};
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

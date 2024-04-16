using ParkAndFlyAdministrationClient.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkAndFlyAdministrationClient.Data.Services
{
    public interface IReservationService
    {
        Task<List<Reservation>> GetReservationsAsync(string parkingId);

        Task<List<Reservation>> GetAllReservationsAsync();

        Task<bool> RemoveReservation (string ReservationId);

        Task<bool> AddReservation(ReservationRequest reservation);
    }
}

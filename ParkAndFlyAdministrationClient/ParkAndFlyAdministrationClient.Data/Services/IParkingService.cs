using ParkAndFlyAdministrationClient.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkAndFlyAdministrationClient.Data.Services
{
    public interface IParkingService
    {
        Task<List<Parking>> GetParkingsAsync();
        Task<Parking> GetParkingById(int parkingId);

        Task<bool> AddParkingAsync(Parking parking);
    }
}

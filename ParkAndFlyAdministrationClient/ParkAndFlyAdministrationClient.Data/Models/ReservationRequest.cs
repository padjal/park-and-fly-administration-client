using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkAndFlyAdministrationClient.Data.Models
{
    public record ReservationRequest
    {
        public string CarNumber { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkAndFlyAdministrationClient.Data.Models
{
    public class Reservation
    {   
        public String Id { get; set; }
        public string CarId { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}

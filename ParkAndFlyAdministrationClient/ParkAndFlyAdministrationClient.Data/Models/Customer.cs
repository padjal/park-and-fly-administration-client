using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkAndFlyAdministrationClient.Data.Models
{
    public record Customer
    {
        public String Id { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public String Email { get; set; }
        public DateTime Birthday { get; set; }
        public String PhoneNumber { get; set; }
    }
}

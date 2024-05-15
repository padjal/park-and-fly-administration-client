namespace ParkAndFlyAdministrationClient.Data.Models
{
    public class Customer
    {
        public String Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String UserName { get; set; }
        public String Email { get; set; }
        public DateTime? Birthday { get; set; }
        public String? PhoneNumber { get; set; }
    }
}

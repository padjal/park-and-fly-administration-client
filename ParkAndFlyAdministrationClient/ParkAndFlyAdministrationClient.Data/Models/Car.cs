namespace ParkAndFlyAdministrationClient.Data.Models
{
    public record Car
    {
        public string Number { get; set; }
        public string Color { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
    }
}

﻿namespace ParkAndFlyAdministrationClient.Client.Data.Requests
{
    public record LoginDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}

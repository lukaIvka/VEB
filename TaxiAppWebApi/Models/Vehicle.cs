﻿namespace TaxiAppWebApi.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string LicensePlate { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int DriverId { get; set; }

        public User Driver { get; set; }
    }

}

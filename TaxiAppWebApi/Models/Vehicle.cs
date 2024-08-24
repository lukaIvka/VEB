namespace TaxiAppWebApi.Models
{
    public class Vehicle
    {

        public string Id { get; set; }
        public string LicensePlate { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string DriverId { get; set; }

        public User Driver { get; set; }
        public Vehicle(string id, string licensePlate, string make, string model, int year, string driverId, User driver)
        {
            Id = id;
            LicensePlate = licensePlate;
            Make = make;
            Model = model;
            Year = year;
            DriverId = driverId;
            Driver = driver;
        }
        public Vehicle() { }
    }

}

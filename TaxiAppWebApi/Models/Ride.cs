namespace TaxiAppWebApi.Models
{
    public class Ride
    {

        public string Id { get; set; }
        public string DriverId { get; set; }
        public string PassengerId { get; set; }
        public string StartLocationId { get; set; }
        public string EndLocationId { get; set; }
        public float Price { get; set; }
        public statusType Status { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }

        public User Driver { get; set; }
        public User Passenger { get; set; }
        public Location StartLocation { get; set; }
        public Location EndLocation { get; set; }
        public Ride(string id, string driverId, string passengerId, string startLocationId, string endLocationId, float price, statusType status, DateTime startTime, DateTime? endTime, User driver, User passenger, Location startLocation, Location endLocation)
        {
            Id = id;
            DriverId = driverId;
            PassengerId = passengerId;
            StartLocationId = startLocationId;
            EndLocationId = endLocationId;
            Price = price;
            Status = status;
            StartTime = startTime;
            EndTime = endTime;
            Driver = driver;
            Passenger = passenger;
            StartLocation = startLocation;
            EndLocation = endLocation;
        }

        public Ride()
        {
        }
    }

}

namespace TaxiAppWebApi.Models
{
    public class Ride
    {
        public int Id { get; set; }
        public int DriverId { get; set; }
        public int PassengerId { get; set; }
        public int StartLocationId { get; set; }
        public int EndLocationId { get; set; }
        public float Price { get; set; }
        public statusType Status { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }

        public User Driver { get; set; }
        public User Passenger { get; set; }
        public Location StartLocation { get; set; }
        public Location EndLocation { get; set; }
    }

}

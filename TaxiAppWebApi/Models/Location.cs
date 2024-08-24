namespace TaxiAppWebApi.Models
{
    public class Location
    {

        public string Id { get; set; }
        public string Address { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public Location(string id, string address, double latitude, double longitude)
        {
            Id = id;
            Address = address;
            Latitude = latitude;
            Longitude = longitude;
        }

        public Location()
        {
        }
    }

}
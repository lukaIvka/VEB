namespace TaxiAppWebApi.Models
{
    public class Analytics
    {

        public string Id { get; set; }
        public int TotalRides { get; set; }
        public int TotalUsers { get; set; }
        public decimal TotalRevenue { get; set; }
        public DateTime GeneratedAt { get; set; }
        public Analytics(string id, int totalRides, int totalUsers, decimal totalRevenue, DateTime generatedAt)
        {
            Id = id;
            TotalRides = totalRides;
            TotalUsers = totalUsers;
            TotalRevenue = totalRevenue;
            GeneratedAt = generatedAt;
        }

        public Analytics()
        {
        }
    }

}

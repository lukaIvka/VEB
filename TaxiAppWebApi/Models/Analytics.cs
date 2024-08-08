namespace TaxiAppWebApi.Models
{
    public class Analytics
    {
        public int Id { get; set; }
        public int TotalRides { get; set; }
        public int TotalUsers { get; set; }
        public decimal TotalRevenue { get; set; }
        public DateTime GeneratedAt { get; set; }
    }

}

namespace TaxiAppWebApi.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public int RideId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public statusType Status { get; set; }
        public Ride Ride { get; set; }
    }

}

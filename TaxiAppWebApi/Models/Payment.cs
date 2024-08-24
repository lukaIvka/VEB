namespace TaxiAppWebApi.Models
{
    public class Payment
    {

        public string Id { get; set; }
        public string RideId { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public statusType Status { get; set; }
        public Ride Ride { get; set; }
        public Payment(string id, string rideId, decimal amount, DateTime paymentDate, statusType status, Ride ride)
        {
            Id = id;
            RideId = rideId;
            Amount = amount;
            PaymentDate = paymentDate;
            Status = status;
            Ride = ride;
        }

        public Payment()
        {
        }
    }

}

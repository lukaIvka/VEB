namespace TaxiAppWebApi.Models
{
    public class Notification
    {

        public string Id { get; set; }
        public string UserId { get; set; }
        public string Message { get; set; }
        public DateTime SentAt { get; set; }
        public User User { get; set; }
        public Notification(string id, string userId, string message, DateTime sentAt, User user)
        {
            Id = id;
            UserId = userId;
            Message = message;
            SentAt = sentAt;
            User = user;
        }
        public Notification() { }
    }

}

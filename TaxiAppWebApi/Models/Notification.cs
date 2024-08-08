﻿namespace TaxiAppWebApi.Models
{
    public class Notification
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Message { get; set; }
        public DateTime SentAt { get; set; }
        public User User { get; set; }
    }

}

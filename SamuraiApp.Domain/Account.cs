using System;

namespace AtmApp.Domain
{
    public class Account
    {
        public int Id { get; set; }
        public float Balance { get; set; }
        public User User { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}

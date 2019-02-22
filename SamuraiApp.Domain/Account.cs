using System;

namespace AtmApp.Domain
{
    public class Account
    {
        public Account ()
        {
            Balance = 0;
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }
        public int Id { get; set; }
        public float Balance { get; set; }
        public User User { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}

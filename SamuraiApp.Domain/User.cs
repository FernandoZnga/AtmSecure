using System;
using System.Collections.Generic;

namespace AtmApp.Domain
{
    public class User
    {
        public User()
        {
            Accounts = new List<Account>();
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }
        public List<Account> Accounts { get; set; }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}

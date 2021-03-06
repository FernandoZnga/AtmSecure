﻿using AtmApp.Data;
using AtmApp.Domain;
using System.Linq;

namespace AtmApp.Backend
{
    public class hash
    {
        private static AtmContext _context = new AtmContext();

        static void Main(string[] args)
        {
        }
        public Hash GetHash = new Hash();

        public bool CreateUser(string firstName, string lastName, string userName, string passWord)
        {
            var user = new User();
            user.FirstName = firstName;
            user.LastName = lastName;
            user.UserName = userName;
            user.PassWord = GetHash.SHA256String(passWord);

            var account = new Account();
            account.User = user;

            using (var context = new AtmContext())
            {
                try
                {
                    //context.GetService<ILoggerFactory>().AddProvider(new MyLoggerProvider());
                    context.Users.Add(user);
                    context.Accounts.Add(account);
                    return true;
                }
                catch
                {
                    return false;
                }
                finally
                {
                    context.SaveChanges();
                }
            }
        }
        public bool PerformLogin(string userName, string passWord)
        {
            var user = new User();
            user = _context.Users.FirstOrDefault(s => s.UserName == userName);
            if (user.PassWord == GetHash.SHA256String(passWord))
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}

using AtmApp.Data;
using AtmApp.Domain;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtmApp.UI
{
    internal class Program
    {
        private static AtmContext _context = new AtmContext();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }

        public static bool InsertNewUser(string firstName, string lastName, string userName, string passWord)
        {
            var user = new User
            {
                FirstName = firstName,
                LastName = lastName,
                UserName = userName,
                PassWord = passWord,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
            var account = new Account
            {
                Balance = 0,
                User = user,
                CreatedAt = DateTime.Now,
                UpdatedAt = DateTime.Now
            };
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
        public static User PerformLogin(string username)
        {
            var users = new User();
            return users = _context.Users.FirstOrDefault(s => s.UserName == username);
        }
    }
}

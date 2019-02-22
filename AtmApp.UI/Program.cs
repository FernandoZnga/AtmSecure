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

        public bool InsertNewUser(User user, Account account)
        {
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
        public User PerformLogin(string username)
        {
            var users = new User();
            return users = _context.Users.FirstOrDefault(s => s.UserName == username);
        }
    }
}

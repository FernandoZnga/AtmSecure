using System;
using System.Linq;
using System.Windows.Forms;
using AtmApp.Backend;
namespace AtmApp.UI
{
    internal class Program
    {
        //private static AtmContext _context = new AtmContext();
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
        public bool HandleNewUser(string firstName, string lastName, string userName, string passWord)
        {
            var executionOk = new bool();
            var handle = new AtmApp.Backend.Program();
            return executionOk = handle.CreateUser(firstName, lastName, userName, passWord);
        }
        public bool HandleLogin(string userName, string passWord)
        {
            var executionOk = new bool();
            var handle = new AtmApp.Backend.Program();
            return executionOk = handle.PerformLogin(userName, passWord);
        }
    }
}

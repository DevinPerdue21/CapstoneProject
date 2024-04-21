using FinalCapstone.Database;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalCapstone
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //string constr = ConfigurationManager.ConnectionStrings["localdb"].ConnectionString;
            //DBQueries dBQueries = new DBQueries(constr);
            //dBQueries.CreateDatabase();
            Application.Run(new Login());
        }
    }
}

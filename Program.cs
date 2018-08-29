using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHSU_ELO_Project
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            SQLCode sql = new SQLCode();

            // Check for valid connection
            if(sql.isServerConnected() == false)
            {
                MessageBox.Show("No connection to database.", "Elode", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                Application.Exit();
            }
            // Check for latest version
            else if (sql.checkVersion() != 5)
            {
                MessageBox.Show("Your client is not the latest version. Please update to the latest version of the software.", "Elode", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                Application.Exit();
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainWindow());
            }

        }
    }
}

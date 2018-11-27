﻿using System;
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
            if(sql.isServerConnected() == true)
            {
                MessageBox.Show("No connection to database.\nServer IP Address may need to be updated\nor the internet is out\nor the power is out", "Elode", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            // Check for latest version
            else if (sql.checkVersion() != 11)
            {
                if(MessageBox.Show("Your client is not the latest version. Click \"OK\" to update to the latest version of the software.", "Elode", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    System.Diagnostics.Process.Start("https://drive.google.com/file/d/0B-YWY2xC-C_uSTZBWDBfZnV0OTA/view");
                }
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
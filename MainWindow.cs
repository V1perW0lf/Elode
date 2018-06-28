using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RiotSharp;

namespace SHSU_ELO_Project
{

    public partial class MainWindow : Form
    {

        SQLCode sql = new SQLCode();

        public string username = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void _1v1Button_Click(object sender, EventArgs e)
        {
            Hide();
            OneVOne one = new OneVOne();
            one.Show();
        }

        private void _3v3Button_Click(object sender, EventArgs e)
        {
            Hide();
            ThreeVThree three = new ThreeVThree();
            three.Show();
        }

        private void _5v5Button_Click(object sender, EventArgs e)
        {
            Hide();
            FiveVFive five = new FiveVFive();
            five.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            Hide();
            Login log = new Login();
            log.Show();
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}

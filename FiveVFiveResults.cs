using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHSU_ELO_Project
{
    public partial class FiveVFiveResults : Form
    {
        public int changeRate = 0;
        public string teamOneName = "";
        public string teamTwoName = "";

        public FiveVFiveResults()
        {
            InitializeComponent();
        }

        private void FiveVFiveResults_Load(object sender, EventArgs e)
        {
            t1ChangeLabel.Text = teamOneName + " score has changed by " + changeRate.ToString();
            t1ChangeLabel.Location = new Point(300 - t1ChangeLabel.Size.Width / 2, 154);

            t2ChangeLabel.Text = teamTwoName + " score has changed by " + (-changeRate).ToString();
            t2ChangeLabel.Location = new Point(300 - t2ChangeLabel.Size.Width / 2, 354);
        }

        private void FiveVFiveResults_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();
            FiveVFive five = new FiveVFive();
            five.Show();
        }
    }
}

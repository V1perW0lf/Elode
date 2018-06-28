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
    public partial class View5v5Team : Form
    {

        SQLCode sql = new SQLCode();

        public string teamName = "";

        public View5v5Team()
        {
            InitializeComponent();
        }

        private void View5v5Team_Load(object sender, EventArgs e)
        {
            coachLabel.Text = sql.findCoach5v5(teamName);

            p1Label.Text = sql.findTeamMember5v5(teamName, "p1username");
            p2Label.Text = sql.findTeamMember5v5(teamName, "p2username");
            p3Label.Text = sql.findTeamMember5v5(teamName, "p3username");
            p4Label.Text = sql.findTeamMember5v5(teamName, "p4username");
            p5Label.Text = sql.findTeamMember5v5(teamName, "p5username");

            p1Elo.Text = sql.findElo(p1Label.Text).ToString();
            p2Elo.Text = sql.findElo(p2Label.Text).ToString();
            p3Elo.Text = sql.findElo(p3Label.Text).ToString();
            p4Elo.Text = sql.findElo(p4Label.Text).ToString();
            p5Elo.Text = sql.findElo(p5Label.Text).ToString();

            coachElo.Text = sql.findCoachElo(coachLabel.Text).ToString();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();
            FiveVFive five = new FiveVFive();
            five.Show();
        }

        private void View5v5Team_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}

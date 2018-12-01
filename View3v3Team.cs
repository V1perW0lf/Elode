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
    public partial class View3v3Team : Form
    {

        SQLCode sql = new SQLCode();
        public string teamName = "";

        public View3v3Team()
        {
            InitializeComponent();
            coachElo.Hide();
            coachLabel.Hide();
        }

        private void View3v3Team_Load(object sender, EventArgs e)
        {
            //coachLabel.Text = sql.findCoach3v3(teamName);
            teamLabel.Text = teamName;

            p1Label.Text = sql.findTeamMember3v3(teamName, "p1username");
            p2Label.Text = sql.findTeamMember3v3(teamName, "p2username");
            p3Label.Text = sql.findTeamMember3v3(teamName, "p3username");

            p1Elo.Text = sql.findElo(p1Label.Text).ToString();
            p2Elo.Text = sql.findElo(p2Label.Text).ToString();
            p3Elo.Text = sql.findElo(p3Label.Text).ToString();

            teamEloLabel.Text = ((sql.findElo(p1Label.Text) + sql.findElo(p2Label.Text) + sql.findElo(p3Label.Text)) / 3).ToString();

            //coachElo.Text = sql.findCoachElo(coachLabel.Text).ToString();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();
            ThreeVThree three = new ThreeVThree();
            three.Show();
        }

        private void View3v3Team_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

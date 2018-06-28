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
    public partial class ThreeVThreeBattle : Form
    {

        SQLCode sql = new SQLCode();

        public string teamOneName = "";
        public string teamTwoName = "";

        string t1CoachName = "";
        string t2CoachName = "";

        string t1p1 = "";
        string t1p2 = "";
        string t1p3 = "";

        string t2p1 = "";
        string t2p2 = "";
        string t2p3 = "";

        double teamOneAvg = 0;
        double teamTwoAvg = 0;

        double t1Exponent = 0;
        double t2Exponent = 0;

        double t1Expected = 0;
        double t2Expected = 0;

        //possibly used to show old vs new elo on fivevfiveresults window
        /*double t1Elo = 0;
        double t2Elo = 0;

        double t1OldElo = 0;
        double t2OldElo = 0;*/

        double changeRate = 0;
        int intChangeRate = 0;

        public ThreeVThreeBattle()
        {
            InitializeComponent();
        }

        private void ThreeVThreeBattle_Load(object sender, EventArgs e)
        {
            team1Button.Text = teamOneName;
            team2Button.Text = teamTwoName;
            t1CoachName = sql.findCoach3v3(teamOneName);
            t2CoachName = sql.findCoach3v3(teamTwoName);
        }

        private void caclulateTeamAverages()
        {
            t1p1 = sql.findPlayerOne3v3(teamOneName);
            t1p2 = sql.findPlayerTwo3v3(teamOneName);
            t1p3 = sql.findPlayerThree3v3(teamOneName);

            t2p1 = sql.findPlayerOne3v3(teamTwoName);
            t2p2 = sql.findPlayerTwo3v3(teamTwoName);
            t2p3 = sql.findPlayerThree3v3(teamTwoName);

            teamOneAvg = Math.Round(((double)sql.findElo(t1p1) + (double)sql.findElo(t1p2)
                + (double)sql.findElo(t1p3)) / 3.0);

            teamTwoAvg = Math.Round(((double)sql.findElo(t2p1) + (double)sql.findElo(t2p2)
                + (double)sql.findElo(t2p3)) / 3.0);
        }

        private void updateTeamOneElos()
        {
            intChangeRate = (int)changeRate;
            sql.updateElo(t1p1, sql.findElo(t1p1) + intChangeRate);
            sql.updateElo(t1p2, sql.findElo(t1p2) + intChangeRate);
            sql.updateElo(t1p3, sql.findElo(t1p3) + intChangeRate);
            sql.updateCoachElo(t1CoachName, sql.findCoachElo(t1CoachName) + intChangeRate);
        }

        private void updateTeamTwoElos()
        {
            intChangeRate = (int)changeRate;
            sql.updateElo(t2p1, sql.findElo(t2p1) + intChangeRate);
            sql.updateElo(t2p2, sql.findElo(t2p2) + intChangeRate);
            sql.updateElo(t2p3, sql.findElo(t2p3) + intChangeRate);
            sql.updateCoachElo(t2CoachName, sql.findCoachElo(t2CoachName) + intChangeRate);
        }

        private void team1Button_Click(object sender, EventArgs e)
        {
            caclulateTeamAverages();

            t1Exponent = Math.Pow(10, ((teamTwoAvg - teamOneAvg) / 400));
            t1Expected = 1 / (1 + t1Exponent);
            changeRate = Math.Round(32 * (1 - t1Expected));

            updateTeamOneElos();

            changeRate = -changeRate;

            updateTeamTwoElos();

            Hide();
            ThreeVThreeResults results = new ThreeVThreeResults();
            results.changeRate = (int)-changeRate;
            results.teamOneName = teamOneName;
            results.teamTwoName = teamTwoName;
            results.Show();
        }

        private void team2Button_Click(object sender, EventArgs e)
        {
            caclulateTeamAverages();

            t2Exponent = Math.Pow(10, ((teamOneAvg - teamTwoAvg) / 400));
            t2Expected = 1 / (1 + t2Exponent);
            changeRate = Math.Round(32 * (1 - t2Expected));

            updateTeamTwoElos();

            changeRate = -changeRate;

            updateTeamOneElos();

            Hide();
            ThreeVThreeResults results = new ThreeVThreeResults();
            results.changeRate = (int)changeRate;
            results.teamOneName = teamOneName;
            results.teamTwoName = teamTwoName;
            results.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();
            ThreeVThree three = new ThreeVThree();
            three.Show();
        }

        private void ThreeVThreeBattle_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}

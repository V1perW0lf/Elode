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
    public partial class FiveVFiveBattle : Form
    {

        SQLCode sql = new SQLCode();

        public string teamOneName = "";
        public string teamTwoName = "";

        string t1CoachName = "";
        string t2CoachName = "";

        string t1p1 = "";
        string t1p2 = "";
        string t1p3 = "";
        string t1p4 = "";
        string t1p5 = "";

        string t2p1 = "";
        string t2p2 = "";
        string t2p3 = "";
        string t2p4 = "";
        string t2p5 = "";

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

        public FiveVFiveBattle()
        {
            InitializeComponent();
        }

        private void FiveVFiveBattle_Load(object sender, EventArgs e)
        {
            team1Button.Text = teamOneName;
            team2Button.Text = teamTwoName;
            t1CoachName = sql.findCoach5v5(teamOneName);
            t2CoachName = sql.findCoach5v5(teamTwoName);
        }

        private void caclulateTeamAverages()
        {
            t1p1 = sql.findPlayerOne5v5(teamOneName);
            t1p2 = sql.findPlayerTwo5v5(teamOneName);
            t1p3 = sql.findPlayerThree5v5(teamOneName);
            t1p4 = sql.findPlayerFour5v5(teamOneName);
            t1p5 = sql.findPlayerFive5v5(teamOneName);

            t2p1 = sql.findPlayerOne5v5(teamTwoName);
            t2p2 = sql.findPlayerTwo5v5(teamTwoName);
            t2p3 = sql.findPlayerThree5v5(teamTwoName);
            t2p4 = sql.findPlayerFour5v5(teamTwoName);
            t2p5 = sql.findPlayerFive5v5(teamTwoName);

            teamOneAvg = Math.Round(((double)sql.findElo(t1p1) + (double)sql.findElo(t1p2) 
                + (double)sql.findElo(t1p3) + (double)sql.findElo(t1p4) 
                + (double)sql.findElo(t1p5)) / 5.0);

            teamTwoAvg = Math.Round(((double)sql.findElo(t2p1) + (double)sql.findElo(t2p2)
                + (double)sql.findElo(t2p3) + (double)sql.findElo(t2p4)
                + (double)sql.findElo(t2p5)) / 5.0);
        }

        private void updateTeamOneElos()
        {
            intChangeRate = (int)changeRate;
            sql.updateElo(t1p1, sql.findElo(t1p1) + intChangeRate);
            sql.updateElo(t1p2, sql.findElo(t1p2) + intChangeRate);
            sql.updateElo(t1p3, sql.findElo(t1p3) + intChangeRate);
            sql.updateElo(t1p4, sql.findElo(t1p4) + intChangeRate);
            sql.updateElo(t1p5, sql.findElo(t1p5) + intChangeRate);
            sql.updateCoachElo(t1CoachName, sql.findCoachElo(t1CoachName) + intChangeRate);
        }

        private void updateTeamTwoElos()
        {
            intChangeRate = (int)changeRate;
            sql.updateElo(t2p1, sql.findElo(t2p1) + intChangeRate);
            sql.updateElo(t2p2, sql.findElo(t2p2) + intChangeRate);
            sql.updateElo(t2p3, sql.findElo(t2p3) + intChangeRate);
            sql.updateElo(t2p4, sql.findElo(t2p4) + intChangeRate);
            sql.updateElo(t2p5, sql.findElo(t2p5) + intChangeRate);
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
            FiveVFiveResults results = new FiveVFiveResults();
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
            FiveVFiveResults results = new FiveVFiveResults();
            results.changeRate = (int)changeRate;
            results.teamOneName = teamOneName;
            results.teamTwoName = teamTwoName;
            results.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();
            FiveVFive five = new FiveVFive();
            five.Show();
        }

        private void FiveVFiveBattle_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

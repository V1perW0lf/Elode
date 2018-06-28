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
    public partial class OneVOneBattle : Form
    {

        SQLCode sql = new SQLCode();

        public string player1 = "";
        public string player2 = "";

        double p1Expected = 0;
        double p2Expected = 0;

        double p1OldElo = 0;
        double p2OldElo = 0;

        double p1Elo = 0;
        double p2Elo = 0;

        double p1Exponent = 0;
        double p2Exponent = 0;

        double changeRate = 0;

        public OneVOneBattle()
        {
            InitializeComponent();
        }

        private void OneVOneBattle_Load(object sender, EventArgs e)
        {
            player1Button.Text = player1;
            player2Button.Text = player2;
        }

        private void player1Button_Click(object sender, EventArgs e)
        {
            p1OldElo = sql.findElo(player1);
            p2OldElo = sql.findElo(player2);

            p1Exponent = Math.Pow(10, ((p2OldElo - p1OldElo) / 400));
            p1Expected = 1 / (1 + p1Exponent);
            changeRate = Math.Round(32 * (1 - p1Expected));
            p1Elo = p1OldElo + changeRate;

            sql.updateElo(player1, (int)p1Elo);

            changeRate = -changeRate;

            p2Elo = p2OldElo + changeRate;

            sql.updateElo(player2, (int)p2Elo);

            Hide();
            OneVOneResults results = new OneVOneResults();
            results.player1 = player1;
            results.player2 = player2;
            results.p1Old = p1OldElo.ToString();
            results.p2Old = p2OldElo.ToString();
            results.p1New = p1Elo.ToString();
            results.p2New = p2Elo.ToString();
            results.Show();
        }

        private void player2Button_Click(object sender, EventArgs e)
        {
            p1OldElo = sql.findElo(player1);
            p2OldElo = sql.findElo(player2);

            p2Exponent = Math.Pow(10, ((p1OldElo - p2OldElo) / 400));
            p2Expected = 1 / (1 + p2Exponent);
            changeRate = Math.Round(32 * (1 - p2Expected));
            p2Elo = p2OldElo + changeRate;

            sql.updateElo(player2, (int)p2Elo);

            changeRate = -changeRate;

            p1Elo = p1OldElo + changeRate;

            sql.updateElo(player1, (int)p1Elo);

            Hide();
            OneVOneResults results = new OneVOneResults();
            results.player1 = player1;
            results.player2 = player2;
            results.p1Old = p1OldElo.ToString();
            results.p2Old = p2OldElo.ToString();
            results.p1New = p1Elo.ToString();
            results.p2New = p2Elo.ToString();
            results.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();
            OneVOne one = new OneVOne();
            one.Show();
        }

        private void OneVOneBattle_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}

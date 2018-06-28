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
    public partial class OneVOneResults : Form
    {

        public string player1 = "";
        public string player2 = "";

        public string p1Old = "";
        public string p2Old = "";

        public string p1New = "";
        public string p2New = "";

        public OneVOneResults()
        {
            InitializeComponent();
        }

        private void OneVOneResults_Load(object sender, EventArgs e)
        {
            player1Label.Text = player1;
            player2Label.Text = player2;
            p1OldElo.Text = p1Old;
            p2OldElo.Text = p2Old;
            p1NewElo.Text = p1New;
            p2NewElo.Text = p2New;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Hide();
            OneVOne one = new OneVOne();
            one.Show();
        }

        private void OneVOneResults_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

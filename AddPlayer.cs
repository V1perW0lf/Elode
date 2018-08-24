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
    public partial class AddPlayer : Form
    {

        SQLCode sql = new SQLCode();

        public AddPlayer()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();
            OneVOne one = new OneVOne();
            one.Show();
        }

        private void addPlayerButton_Click(object sender, EventArgs e)
        {

            //var api = RiotApi.GetInstance("RGAPI-C3673AEB-F562-4992-9629-3C47741A6A86");
            errorLabel.Text = "";

            try
            {

                //var summoner = api.GetSummoner(RiotSharp.Region.na, playerUsernameBox.Text);

                try
                {
                    int count = sql.count("players", "username", "");
                    sql.addPlayer(playerUsernameBox.Text, count);

                    errorLabel.Text = "Player successfully added";
                    errorLabel.Location = new Point((ActiveForm.Width - errorLabel.Width) / 2, 390);
                }
                catch
                {
                    errorLabel.Text = "Player already exists in database";
                    errorLabel.Location = new Point((ActiveForm.Width - errorLabel.Width) / 2, 390);
                }
                
            }
            catch
            {
                errorLabel.Text = "Username incorrect";
                errorLabel.Location = new Point((ActiveForm.Width - errorLabel.Width) / 2, 390);
            }

        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}

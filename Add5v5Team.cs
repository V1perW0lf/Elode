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
    public partial class Add5v5Team : Form
    {

        string coachName = "";
        SQLCode sql = new SQLCode();

        public Add5v5Team()
        {
            InitializeComponent();
            coachNameLabel.Hide();
            coachNameBox.Hide();

            List<string> playerList = sql.populatePlayerBox();
            for (int i = 0; i < playerList.Count; i++)
            {
                playerListBox.Items.Add(playerList[i]);
            }
        }

        private void Add5V5Team_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private Boolean checkForValidInput()
        {

            if (teamNameBox.Text == "")
            {
                errorLabel.Text = "Please enter a team name";
                errorLabel.Location = new Point((ActiveForm.Width - errorLabel.Width) / 2, 465);
                addingLabel.Text = "";
                return true;
            }
            else if (teamNameBox.Text.Length > 15)
            {
                errorLabel.Text = "Team names but be 15 characters or less";
                errorLabel.Location = new Point((ActiveForm.Width - errorLabel.Width) / 2, 465);
                addingLabel.Text = "";
                return true;
            }
            else if (coachNameBox.Text.Length > 15)
            {
                errorLabel.Text = "Coach names but be 15 characters or less";
                errorLabel.Location = new Point((ActiveForm.Width - errorLabel.Width) / 2, 465);
                addingLabel.Text = "";
                return true;
            }
            else if (sql.findTeam5v5(teamNameBox.Text).ToLower() == teamNameBox.Text.ToLower())
            {
                errorLabel.Text = "A team with that name already exists";
                errorLabel.Location = new Point((ActiveForm.Width - errorLabel.Width) / 2, 465);
                addingLabel.Text = "";
                return true;
            }
            else if (playerListBox.CheckedItems.Count != 5)
            {
                errorLabel.Text = "You must have exactly 5 names checked";
                errorLabel.Location = new Point((ActiveForm.Width - errorLabel.Width) / 2, 465);
                return true;
            }

            return false;

        }

        private void removeEloFromCheckBoxString()
        {

            int countTeam = sql.count("teams5v5", "id", "");

            try
            {

                string p1 = "";
                string p2 = "";
                string p3 = "";
                string p4 = "";
                string p5 = "";

                foreach (string s in playerListBox.CheckedItems)
                {
                    string removedElo = "";

                    if (s.Contains("   "))
                    {
                        removedElo = s.Substring(s.IndexOf("   ") + 3);
                    }
                    else
                    {
                        removedElo = s.Substring(s.IndexOf(" ") + 1);
                    }
                    if (p1 == "")
                    {
                        p1 = removedElo;
                    }
                    else if (p2 == "")
                    {
                        p2 = removedElo;
                    }
                    else if (p3 == "")
                    {
                        p3 = removedElo;
                    }
                    else if (p4 == "")
                    {
                        p4 = removedElo;
                    }
                    else if (p5 == "")
                    {
                        p5 = removedElo;
                    }
                }

                sql.add5v5Team(countTeam, teamNameBox.Text, coachNameBox.Text, p1, p2, p3, p4, p5);

            }
            catch
            {
                errorLabel.Text = "Team name already exists";
                errorLabel.Location = new Point((ActiveForm.Width - errorLabel.Width) / 2, 465);
                addingLabel.Text = "";
            }

            errorLabel.Text = "Team successfully added";
            errorLabel.Location = new Point((ActiveForm.Width - errorLabel.Width) / 2, 465);
            addingLabel.Text = "";

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();
            FiveVFive five = new FiveVFive();
            five.Show();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            coachName = coachNameBox.Text;

            errorLabel.Text = "";

            if (!checkForValidInput())
            {
                removeEloFromCheckBoxString();
            }        

        }

    }
}

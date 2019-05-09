using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SHSU_ELO_Project
{
    public partial class Add3v3Team : Form
    {

        string coachName = "";
        SQLCode sql = new SQLCode();

        public Add3v3Team()
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

        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();
            ThreeVThree three = new ThreeVThree();
            three.Show();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            coachName = coachNameBox.Text;

            //var api = RiotApi.GetInstance("RGAPI-C3673AEB-F562-4992-9629-3C47741A6A86");

            errorLabel.Text = "";
            //addingLabel.Text = "Adding...";

            //If input is valid, attempt to add team
            if (!checkForValidInput())
            {
                removeEloFromCheckBoxString();
            }
            
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
                errorLabel.Text = "Coach names must be 15 characters or less";
                errorLabel.Location = new Point((ActiveForm.Width - errorLabel.Width) / 2, 465);
                addingLabel.Text = "";
                return true;
            }
            else if (sql.findTeam3v3(teamNameBox.Text).ToLower() == teamNameBox.Text.ToLower())
            {
                errorLabel.Text = "A team with that name already exists";
                errorLabel.Location = new Point((ActiveForm.Width - errorLabel.Width) / 2, 465);
                addingLabel.Text = "";
                return true;
            }
            else if (playerListBox.CheckedItems.Count != 3)
            {
                errorLabel.Text = "You must have exactly 3 names checked";
                errorLabel.Location = new Point((ActiveForm.Width - errorLabel.Width) / 2, 465);
                return true;
            }

            return false;

        }

        private void removeEloFromCheckBoxString()
        {

            int countTeam = sql.count("teams3v3", "id", "");

            try
            {
                string p1 = "";
                string p2 = "";
                string p3 = "";

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
                }

                sql.add3v3Team(countTeam, teamNameBox.Text, coachNameBox.Text, p1, p2, p3);

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

        private void Add3v3Team_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

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
        string space = " ";
        SQLCode sql = new SQLCode();

        public Add5v5Team()
        {
            InitializeComponent();
            coachNameLabel.Hide();
            coachNameBox.Hide();
            List<string> playerList = sql.populatePlayerBox();
            for (int i = 0; i < playerList.Count; i++)
            {
                //DO THIS BETTER PLEASE
                if (sql.findElo(playerList[i]).ToString().Length < 4)
                {
                    space = "   ";
                }
                else
                {
                    space = " ";
                }
                playerListBox.Items.Add(sql.findElo(playerList[i]) + space + playerList[i]);
            }
        }

        private void Add5V5Team_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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

            //var api = RiotApi.GetInstance("RGAPI-C3673AEB-F562-4992-9629-3C47741A6A86");

            errorLabel.Text = "";
            //addingLabel.Text = "Adding...";

            if (teamNameBox.Text == "")
            {
                errorLabel.Text = "Please enter a team name";
                errorLabel.Location = new Point((ActiveForm.Width - errorLabel.Width) / 2, 465);
                addingLabel.Text = "";
            }
            /*else if (coachNameBox.Text == "")
            {
                errorLabel.Text = "Please enter a coach name";
                errorLabel.Location = new Point((ActiveForm.Width - errorLabel.Width) / 2, 433);
                addingLabel.Text = "";
            }*/
            else if (teamNameBox.Text.Length > 15)
            {
                errorLabel.Text = "Team names but be 15 characters or less";
                errorLabel.Location = new Point((ActiveForm.Width - errorLabel.Width) / 2, 465);
                addingLabel.Text = "";
            }
            else if (coachNameBox.Text.Length > 15)
            {
                errorLabel.Text = "Coach names but be 15 characters or less";
                errorLabel.Location = new Point((ActiveForm.Width - errorLabel.Width) / 2, 465);
                addingLabel.Text = "";
            }
            else if (sql.findTeam5v5(teamNameBox.Text).ToLower() == teamNameBox.Text.ToLower())
            {
                errorLabel.Text = "A team with that name already exists";
                errorLabel.Location = new Point((ActiveForm.Width - errorLabel.Width) / 2, 465);
                addingLabel.Text = "";
            }
            else if (playerListBox.CheckedItems.Count != 5)
            {
                errorLabel.Text = "You must have exactly 5 names checked";
                errorLabel.Location = new Point((ActiveForm.Width - errorLabel.Width) / 2, 465);
            }
            /*else if (p1usernameBox.Text == "" || p2usernameBox.Text == "" || p3usernameBox.Text == "" || p4usernameBox.Text == "" || p5usernameBox.Text == "")
            {
                errorLabel.Text = "Please enter usernames for all players";
                errorLabel.Location = new Point((ActiveForm.Width - errorLabel.Width) / 2, 433);
                addingLabel.Text = "";
            }
            else if (p1usernameBox.Text == p2usernameBox.Text || p1usernameBox.Text == p3usernameBox.Text || p1usernameBox.Text == p4usernameBox.Text ||
                p1usernameBox.Text == p5usernameBox.Text || p2usernameBox.Text == p3usernameBox.Text || p2usernameBox.Text == p4usernameBox.Text ||
                p2usernameBox.Text == p5usernameBox.Text || p3usernameBox.Text == p4usernameBox.Text || p3usernameBox.Text == p5usernameBox.Text)
            {
                errorLabel.Text = "You cannot have multiples of the same player";
                errorLabel.Location = new Point((ActiveForm.Width - errorLabel.Width) / 2, 433);
                addingLabel.Text = "";
            }*/
            else
            {

                /*try
                {
                    var summoner1 = api.GetSummoner(RiotSharp.Region.na, p1usernameBox.Text);
                }
                catch
                {
                    errorLabel.Text = "Player(s) 1 ";
                }

                try
                {
                    var summoner2 = api.GetSummoner(RiotSharp.Region.na, p2usernameBox.Text);
                }
                catch
                {
                    if (errorLabel.Text == "")
                    {
                        errorLabel.Text = "Player(s) 2 ";
                    }
                    else
                    {
                        errorLabel.Text = errorLabel.Text + ", 2 ";
                    }
                }

                try
                {
                    var summoner3 = api.GetSummoner(RiotSharp.Region.na, p3usernameBox.Text);
                }
                catch
                {
                    if (errorLabel.Text == "")
                    {
                        errorLabel.Text = "Player(s) 3 ";
                    }
                    else
                    {
                        errorLabel.Text = errorLabel.Text + ", 3 ";
                    }
                }

                try
                {
                    var summoner4 = api.GetSummoner(RiotSharp.Region.na, p4usernameBox.Text);
                }
                catch
                {
                    if (errorLabel.Text == "")
                    {
                        errorLabel.Text = "Player(s) 4 ";
                    }
                    else
                    {
                        errorLabel.Text = errorLabel.Text + ", 4 ";
                    }
                }

                try
                {
                    var summoner5 = api.GetSummoner(RiotSharp.Region.na, p5usernameBox.Text);
                }
                catch
                {
                    if (errorLabel.Text == "")
                    {
                        errorLabel.Text = "Player(s) 5 ";
                    }
                    else
                    {
                        errorLabel.Text = errorLabel.Text + ", 5 ";
                    }
                }*/

                if (errorLabel.Text != "")
                {

                    if (errorLabel.Text.Length > 12)
                    {
                        errorLabel.Text = errorLabel.Text + "were not found";
                        errorLabel.Location = new Point((ActiveForm.Width - errorLabel.Width) / 2, 465);
                        addingLabel.Text = "";
                    }
                    else
                    {
                        errorLabel.Text = errorLabel.Text + "was not found";
                        errorLabel.Location = new Point((ActiveForm.Width - errorLabel.Width) / 2, 465);
                        addingLabel.Text = "";
                    }

                }
                else
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
                            //SUPER HACKY PLEASE FIX
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

                    try
                    {
                        //int countCoaches = sql.count("coaches", "coachName", "");
                        //sql.addCoach(coachNameBox.Text, countCoaches);
                    }
                    catch
                    {
                        //nothing goes here
                    }
                    

                    /*if (sql.findPlayer(p1usernameBox.Text.ToLower()) != p1usernameBox.Text.ToLower())
                    {
                        int count = sql.count("players", "username", "");
                        sql.addPlayer(p1usernameBox.Text.ToLower(), count);
                    }

                    if (sql.findPlayer(p2usernameBox.Text.ToLower()) != p2usernameBox.Text.ToLower())
                    {
                        int count = sql.count("players", "username", "");
                        sql.addPlayer(p2usernameBox.Text.ToLower(), count);
                    }

                    if (sql.findPlayer(p3usernameBox.Text.ToLower()) != p3usernameBox.Text.ToLower())
                    {
                        int count = sql.count("players", "username", "");
                        sql.addPlayer(p3usernameBox.Text.ToLower(), count);
                    }

                    if (sql.findPlayer(p4usernameBox.Text.ToLower()) != p4usernameBox.Text.ToLower())
                    {
                        int count = sql.count("players", "username", "");
                        sql.addPlayer(p4usernameBox.Text.ToLower(), count);
                    }

                    if (sql.findPlayer(p5usernameBox.Text.ToLower()) != p5usernameBox.Text.ToLower())
                    {
                        int count = sql.count("players", "username", "");
                        sql.addPlayer(p5usernameBox.Text.ToLower(), count);
                    }*/

                    errorLabel.Text = "Team successfully added";
                    errorLabel.Location = new Point((ActiveForm.Width - errorLabel.Width) / 2, 465);
                    addingLabel.Text = "";

                }

            }

        }

    }
}

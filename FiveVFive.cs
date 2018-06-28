﻿using System;
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
    public partial class FiveVFive : Form
    {

        SQLCode sql = new SQLCode();

        public FiveVFive()
        {
            InitializeComponent();

            List<string> teamList = sql.populate5v5TeamListBox();

            for (int i = 0; i < teamList.Count; i++)
            {
                teamListBox.Items.Add(teamList[i]);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();
            MainWindow main = new MainWindow();
            main.Show();
        }

        private void addTeamButton_Click(object sender, EventArgs e)
        {
            Hide();
            Add5v5Team five = new Add5v5Team();
            five.Show();
        }

        private void battleTeamButton_Click(object sender, EventArgs e)
        {
            if (teamListBox.CheckedItems.Count == 2)
            {
                Hide();
                FiveVFiveBattle battle = new FiveVFiveBattle();
                foreach (string s in teamListBox.CheckedItems)
                {
                    if (battle.teamOneName == "")
                    {
                        battle.teamOneName = s;
                    }
                    else
                    {
                        battle.teamTwoName = s;
                    }
                }
                battle.Show();
            }
            else if (teamListBox.CheckedItems.Count < 2)
            {
                errorLabel.Text = "Please select two teams";
                errorLabel.Location = new Point(((viewTeamButton.Location.X + viewTeamButton.Size.Width + addTeamButton.Location.X) / 2) - errorLabel.Size.Width / 2, 34);
            }
            else
            {
                errorLabel.Text = "Only two teams can battle at once";
                errorLabel.Location = new Point(((viewTeamButton.Location.X + viewTeamButton.Size.Width + addTeamButton.Location.X) / 2) - errorLabel.Size.Width / 2, 34);
            }
        }

        private void teamListBox__SelectedIndexChanged(object sender, EventArgs e)
        {
            teamListBox.ClearSelected();
        }

        private void viewTeamButton_Click(object sender, EventArgs e)
        {
            if (teamListBox.CheckedItems.Count == 1)
            {
                Hide();
                View5v5Team view = new View5v5Team();
                foreach (string s in teamListBox.CheckedItems)
                {
                    view.teamName = s;
                }
                view.Show();
            }
            else if (teamListBox.CheckedItems.Count < 1)
            {
                errorLabel.Text = "Please select one team";
                errorLabel.Location = new Point(((viewTeamButton.Location.X + viewTeamButton.Size.Width + addTeamButton.Location.X) / 2) - errorLabel.Size.Width / 2, 34);
            }
            else
            {
                errorLabel.Text = "Only one teams's Elo can be viewed at a time";
                errorLabel.Location = new Point(((viewTeamButton.Location.X + viewTeamButton.Size.Width + addTeamButton.Location.X) / 2) - errorLabel.Size.Width / 2, 34);
            }
        }

        private void FiveVFive_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}

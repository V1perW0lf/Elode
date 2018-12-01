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
    public partial class ThreeVThree : Form
    {

        SQLCode sql = new SQLCode();

        public ThreeVThree()
        {
            InitializeComponent();

            List<string> teamList = sql.populate3v3TeamListBox();

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

        private void viewTeamButton_Click(object sender, EventArgs e)
        {
            if (teamListBox.CheckedItems.Count == 1)
            {
                Hide();
                View3v3Team view = new View3v3Team();
                foreach (string s in teamListBox.CheckedItems)
                {
                    view.teamName = s;
                }
                view.Show();
            }
            else if (teamListBox.CheckedItems.Count < 1)
            {
                errorLabel.Text = "Please select one team";
                errorLabel.Location = new Point(((viewTeamButton.Location.X + viewTeamButton.Size.Width + addTeamButton.Location.X) / 2) - errorLabel.Size.Width / 2, 466);
            }
            else
            {
                errorLabel.Text = "Only one teams's Elo can be viewed at a time";
                errorLabel.Location = new Point(((viewTeamButton.Location.X + viewTeamButton.Size.Width + addTeamButton.Location.X) / 2) - errorLabel.Size.Width / 2, 466);
            }
        }

        private void addTeamButton_Click(object sender, EventArgs e)
        {
            Hide();
            Add3v3Team three = new Add3v3Team();
            three.Show();
        }

        private void battleButton_Click(object sender, EventArgs e)
        {
            if (teamListBox.CheckedItems.Count == 2)
            {
                Hide();
                ThreeVThreeBattle battle = new ThreeVThreeBattle();
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
                errorLabel.Location = new Point(((viewTeamButton.Location.X + viewTeamButton.Size.Width + addTeamButton.Location.X) / 2) - errorLabel.Size.Width / 2, 466);
            }
            else
            {
                errorLabel.Text = "Only two teams can battle at once";
                errorLabel.Location = new Point(((viewTeamButton.Location.X + viewTeamButton.Size.Width + addTeamButton.Location.X) / 2) - errorLabel.Size.Width / 2, 466);
            }
        }

        private void teamListBox__SelectedIndexChanged(object sender, EventArgs e)
        {
            teamListBox.ClearSelected();
        }

        private void ThreeVThree_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (teamListBox.CheckedItems.Count >= 1)
            {
                //View3v3Team view = new View3v3Team();
                //view.Show();
                foreach (string s in teamListBox.CheckedItems)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete the " + s + " team?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        sql.delete3v3Team(s);
                    }
                    else if (result == DialogResult.No)
                    {
                        //Do nothing
                    }
                    
                }
                teamListBox.Items.Clear();
                List<string> teamList = sql.populate3v3TeamListBox();
                for (int i = 0; i < teamList.Count; i++)
                {
                    teamListBox.Items.Add(teamList[i]);
                }

            }
            else if (teamListBox.CheckedItems.Count < 1)
            {
                errorLabel.Text = "Please select at least one team";
                errorLabel.Location = new Point(((viewTeamButton.Location.X + viewTeamButton.Size.Width + addTeamButton.Location.X) / 2) - errorLabel.Size.Width / 2, 466);
            }

        }
    }
}

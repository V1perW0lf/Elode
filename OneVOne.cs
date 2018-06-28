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
    public partial class OneVOne : Form
    {

        SQLCode sql = new SQLCode();

        public OneVOne()
        {
            InitializeComponent();
            List<string> playerList = sql.populatePlayerBox();
            for (int i = 0; i < playerList.Count; i++)
            {
                playerListBox.Items.Add(playerList[i]);
            }
        }

        private void addPlayerButton_Click(object sender, EventArgs e)
        {
            Hide();
            AddPlayer add = new AddPlayer();
            add.Show();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();
            MainWindow main = new MainWindow();
            main.Show();
        }

        private void battleButton_Click(object sender, EventArgs e)
        {
            if (playerListBox.CheckedItems.Count == 2)
            {
                Hide();
                OneVOneBattle battle = new OneVOneBattle();
                foreach (string s in playerListBox.CheckedItems)
                {
                    if(battle.player1 == "")
                    {
                        battle.player1 = s;
                    }
                    else
                    {
                        battle.player2 = s;
                    }
                }
                battle.Show();
            }
            else if (playerListBox.CheckedItems.Count < 2)
            {
                errorLabel.Text = "Please select two players";
                errorLabel.Location = new Point(((viewPlayerButton.Location.X + viewPlayerButton.Size.Width + addPlayerButton.Location.X) / 2) - errorLabel.Size.Width / 2, 34);
            }
            else
            {
                errorLabel.Text = "Only two players can battle at once";
                errorLabel.Location = new Point(((viewPlayerButton.Location.X + viewPlayerButton.Size.Width + addPlayerButton.Location.X) / 2) - errorLabel.Size.Width / 2, 34);
            }
        }

        private void playerListBox__SelectedIndexChanged(object sender, EventArgs e)
        {
            playerListBox.ClearSelected();
        }

        private void viewPlayerButton_Click(object sender, EventArgs e)
        {
            if(playerListBox.CheckedItems.Count == 1)
            {
                Hide();
                ViewPlayer view = new ViewPlayer();
                foreach (string s in playerListBox.CheckedItems)
                {
                    view.playerUsername = s;
                }
                view.Show();
            }
            else if (playerListBox.CheckedItems.Count < 1)
            {
                errorLabel.Text = "Please select one player";
                errorLabel.Location = new Point(((viewPlayerButton.Location.X + viewPlayerButton.Size.Width + addPlayerButton.Location.X) / 2) - errorLabel.Size.Width / 2, 34);
            }
            else
            {
                errorLabel.Text = "Only one player's Elo can be viewed at a time";
                errorLabel.Location = new Point(((viewPlayerButton.Location.X + viewPlayerButton.Size.Width + addPlayerButton.Location.X) / 2) - errorLabel.Size.Width / 2, 34);
            }
        }

        private void OneVOne_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}

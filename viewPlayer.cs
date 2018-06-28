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
    public partial class ViewPlayer : Form
    {

        SQLCode sql = new SQLCode();

        public string playerUsername = "";

        public ViewPlayer()
        {
            InitializeComponent();
        }

        private void viewPlayer_Load(object sender, EventArgs e)
        {
            playerUsernameLabel.Text = playerUsername;
            playerUsernameLabel.Location = new Point((600 - playerUsernameLabel.Width) / 2, 217);

            eloLabel.Text = sql.findElo(playerUsername).ToString();
            eloLabel.Location = new Point((600 - eloLabel.Width) / 2, 262);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();
            OneVOne one = new OneVOne();
            one.Show();
        }

        private void ViewPlayer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

    }
}

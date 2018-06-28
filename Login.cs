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
using EncryptStringSample;
using MySql.Data.MySqlClient;

namespace SHSU_ELO_Project
{

    public partial class Login : Form
    {

        SQLCode sql = new SQLCode();

        public string username = "";

        // Key chosen to encrypt passwords
        private string key = "iRwXrvccYD9vTx3LyOOd";

        public Login()
        {
            InitializeComponent();
            passwordBox.UseSystemPasswordChar = true;
            AcceptButton = loginButton;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            Hide();
            Register reg = new Register();
            reg.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            errorLabel.Text = "Logging in...";
            errorLabel.Location = new Point((ActiveForm.Width - errorLabel.Width) / 2, passwordBox.Location.Y + passwordBox.Height + 13);

            if (usernameBox.TextLength > 0 && passwordBox.TextLength > 0) {

                if (sql.isServerConnected())
                {

                    if (sql.findPass(usernameBox.Text) != "")
                    {

                        try
                        {
                            // Searches for username entered and then decrypts password from database file
                            string decryptedPassword = StringCipher.Decrypt(sql.findPass(usernameBox.Text), key);

                            // Checks decrypted password against password entered
                            if (decryptedPassword == passwordBox.Text)
                            {
                                username = usernameBox.Text;
                                MainWindow main = new MainWindow();
                                main.username = username;
                                Hide();
                                main.Show();
                            }
                            else
                            {
                                errorLabel.Text = "Wrong username or password!";
                                errorLabel.Location = new Point((ActiveForm.Width - errorLabel.Width) / 2, passwordBox.Location.Y + passwordBox.Height + 13);
                            }
                        }
                        catch (MySqlException ex)
                        {
                            errorLabel.Text = ex.Message;
                            errorLabel.Location = new Point((ActiveForm.Width - errorLabel.Width) / 2, passwordBox.Location.Y + passwordBox.Height + 13);
                        }

                    }
                    else
                    {
                        errorLabel.Text = "Wrong username or password!";
                        errorLabel.Location = new Point((ActiveForm.Width - errorLabel.Width) / 2, passwordBox.Location.Y + passwordBox.Height + 13);
                    }

                }
                else
                {
                    errorLabel.Text = "No connection to database";
                    errorLabel.Location = new Point((ActiveForm.Width - errorLabel.Width) / 2, passwordBox.Location.Y + passwordBox.Height + 13);
                }

            }
            else
            {
                errorLabel.Text = "Username or password field empty";
                errorLabel.Location = new Point((ActiveForm.Width - errorLabel.Width) / 2, passwordBox.Location.Y + passwordBox.Height + 13);
            }

        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (passwordBox.UseSystemPasswordChar == true)
            {
                passwordBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordBox.UseSystemPasswordChar = true;
            }
        }

    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using EncryptStringSample;

namespace SHSU_ELO_Project
{
    public partial class Register : Form
    {

        SQLCode sql = new SQLCode();

        // Key chosen to encrypt passwords
        private readonly string key = "iRwXrvccYD9vTx3LyOOd";

        public Register()
        {
            InitializeComponent();
            passwordBox1.UseSystemPasswordChar = true;
            passwordBox2.UseSystemPasswordChar = true;
            AcceptButton = registerButton;
        }

        private void registerButton_Click(object sender, EventArgs e) 
        {

            errorLabel.Text = "Registering...";
            errorLabel.Location = new Point((ActiveForm.Width - errorLabel.Width) / 2, passwordBox2.Location.Y + passwordBox2.Height + 13);

            if (usernameBox.Text.Length < 4 || usernameBox.Text.Length > 24)
            { 
                errorLabel.Text = "Username must be between 4 and 24 characters long";
                errorLabel.Location = new Point((ActiveForm.Width - errorLabel.Width) / 2, passwordBox2.Location.Y + passwordBox2.Height + 13);
            }
            else if (passwordBox1.Text != passwordBox2.Text)
            {
                errorLabel.Text = "Passwords do not match!";
                errorLabel.Location = new Point((ActiveForm.Width - errorLabel.Width) / 2, passwordBox2.Location.Y + passwordBox2.Height + 13);
            }
            else if (passwordBox1.Text.Length < 6 || passwordBox1.Text.Length > 16)
            {
                errorLabel.Text = "Password must be between 6 and 16 characters long";
                errorLabel.Location = new Point((ActiveForm.Width - errorLabel.Width) / 2, passwordBox2.Location.Y + passwordBox2.Height + 13);
            } 
            else if (sql.isServerConnected() == false)
            {
                errorLabel.Text = "No connection to database";
                errorLabel.Location = new Point((ActiveForm.Width - errorLabel.Width) / 2, passwordBox2.Location.Y + passwordBox2.Height + 13);
            }
            else
            {
                // Passwords match, so encrypt chosen password and add user to database
                try
                {

                    string encryptedPass = StringCipher.Encrypt(passwordBox1.Text, key);
                    sql.addUser(usernameBox.Text, encryptedPass);
                    errorLabel.Text = "Successfully registered";
                    errorLabel.Location = new Point((ActiveForm.Width - errorLabel.Width) / 2, passwordBox2.Location.Y + passwordBox2.Height + 13);
                    backButton.Focus();

                }
                // If username exists already, tell user
                catch (MySqlException ex)
                {
                    if(ex.Number == 1062)
                    {
                        errorLabel.Text = "Username already taken";
                        errorLabel.Location = new Point((ActiveForm.Width - errorLabel.Width) / 2, passwordBox2.Location.Y + passwordBox2.Height + 13);
                    }
               
                }

            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Hide();
            Login log = new Login();
            log.Show();
        }


        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}

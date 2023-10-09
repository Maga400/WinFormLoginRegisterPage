using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asd
{
    public partial class LoginForm : Form
    {
        class Login
        {

            public string Username { get; set; }
            public string Password { get; set; }
            public Login(string username, string password)
            {
                Username = username;
                Password = password;
            }
        }
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void passwordCheckBoxLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (passwordCheckBoxLogin.Checked)
            {

                passwordTextBoxLogin.PasswordChar = '\0';

            }
            else
            {
                passwordTextBoxLogin.PasswordChar = '*';


            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form1 registerForm = new Form1();
            registerForm.Show();
            this.Hide();
        }



        private void clearButton_Click(object sender, EventArgs e)
        {
            passwordTextBoxLogin.Clear();
            usernameTextBox.Clear();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string loginsJson = File.ReadAllText("Logins.json");
            var logins = JsonSerializer.Deserialize<List<Login>>(loginsJson);

            int checkPassword = 0;
            int checkUsername = 0;
            if (usernameTextBox.Text.Length != 0 && passwordTextBoxLogin.Text.Length != 0)
            {
                for (int i = 0; i < logins.Count; i++)
                {
                    if (usernameTextBox.Text == logins[i].Username && passwordTextBoxLogin.Text == logins[i].Password)
                    {
                        checkPassword++;
                        checkUsername++;
                        MessageBox.Show("Siz artiq login oldunuz", "Information!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        ChoiceForm choiceForm = new ChoiceForm();
                        choiceForm.Show();
                    }

                    else if (usernameTextBox.Text == logins[i].Username)
                    {
                        checkUsername++;
                    }

                    else if (passwordTextBoxLogin.Text == logins[i].Password)
                    {
                        checkPassword++;
                    }
                }

                if (checkUsername == 0)
                {

                    MessageBox.Show("Invalid username!!!Daxil etdiyiniz  username yanlisdir", "WARNING!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else if (checkPassword == 0)
                {
                    MessageBox.Show("Invalid password!!!Daxil etdiyiniz password yanlisdir", "WARNING!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

            else if (usernameTextBox.Text.Length == 0)
            {
                MessageBox.Show("Invalid username!!!Sizin usernameniz bosdur", "WARNING!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else if (passwordTextBoxLogin.Text.Length == 0)
            {
                MessageBox.Show("Invalid password!!!Sizin passwordunuz bosdur", "WARNING!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
    }
}


using System.Text.Json;
namespace asd
{
    public partial class Form1 : Form
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
        public Form1()
        {
            InitializeComponent();
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.Checked)
            {
                confirmPasswordTextBox.PasswordChar = '\0';
                passwordTextBox.PasswordChar = '\0';

            }
            else
            {
                confirmPasswordTextBox.PasswordChar = '*';
                passwordTextBox.PasswordChar = '*';

            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            passwordTextBox.Clear();
            confirmPasswordTextBox.Clear();
            usernameTextBox.Clear();
        }

        List<Login> logins = new List<Login>();
        private void registerButton_Click(object sender, EventArgs e)
        {
            if (File.Exists("Logins.json"))
            {
                string loginJson = File.ReadAllText("Logins.json");
                var logins2 = JsonSerializer.Deserialize<List<Login>>(loginJson);

                logins = logins2;
            }


            if (usernameTextBox.Text.Length >= 3 && passwordTextBox.Text.Length >= 8 && confirmPasswordTextBox.Text.Length >= 8
                && confirmPasswordTextBox.Text == passwordTextBox.Text)
            {
                MessageBox.Show("Sizin registirasiyaniz qeyde alindi", "INFORMATION!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Login newLogin = new Login(usernameTextBox.Text, passwordTextBox.Text);

                logins.Add(newLogin);

                string loginsJson = JsonSerializer.Serialize(logins);
                File.WriteAllText("Logins.json", loginsJson);

                Thread.Sleep(1000);
                passwordTextBox.Clear();
                confirmPasswordTextBox.Clear();
                usernameTextBox.Clear();
            }

            else if (usernameTextBox.Text.Length < 3)
            {
                MessageBox.Show("Invalid username!!!Sizin usernameniz minumum 3 herf olmadir", "WARNING!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (passwordTextBox.Text.Length < 8)
            {
                MessageBox.Show("Invalid password!!!Sizin passwordunuz minumum 8 herf olmadir", "WARNING!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (confirmPasswordTextBox.Text.Length < 8)
            {
                MessageBox.Show("Invalid confirm password!!!Sizin confirm passwordunuz minumum 8 herf olmadir", "WARNING!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (confirmPasswordTextBox.Text != passwordTextBox.Text)
            {
                MessageBox.Show("Invalid confirm password!!!Sizin confirm passwordunuzla passwordunuz eyni olmalidir", "WARNING!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
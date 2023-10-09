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
    public partial class LoginViewForm : Form
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
        public LoginViewForm()
        {
            InitializeComponent();
            InitializeListView();
        }


        private void InitializeListView()
        {
            string loginsJson = File.ReadAllText("Logins.json");
            var logins = JsonSerializer.Deserialize<List<Login>>(loginsJson);

            ListView listView = new ListView();
            listView.Location = new Point(30, 62);
            listView.Size = new Size(300, 300);

            listView.View = View.Details;
            listView.Columns.Add("Email", 150);
            listView.Columns.Add("Password", 150);

            for (int i = 0; i < logins.Count; i++)
            {
                string[] item = { logins[i].Username, logins[i].Password };
                listView.Items.Add(new ListViewItem(item));
            }
            this.Controls.Add(listView);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}

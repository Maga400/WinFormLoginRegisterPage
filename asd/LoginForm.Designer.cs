namespace asd
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            button1 = new Button();
            label6 = new Label();
            label5 = new Label();
            clearButton = new Button();
            loginButton = new Button();
            passwordCheckBoxLogin = new CheckBox();
            passwordTextBoxLogin = new TextBox();
            label3 = new Label();
            usernameTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(250, 1);
            button1.Name = "button1";
            button1.Size = new Size(39, 35);
            button1.TabIndex = 78;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Nirmala UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(116, 86, 174);
            label6.Location = new Point(97, 417);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(101, 17);
            label6.TabIndex = 77;
            label6.Text = "Create Account";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(65, 389);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(147, 17);
            label5.TabIndex = 76;
            label5.Text = "Dont Have an Account";
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.White;
            clearButton.Cursor = Cursors.Hand;
            clearButton.FlatStyle = FlatStyle.Flat;
            clearButton.ForeColor = Color.FromArgb(116, 86, 174);
            clearButton.Location = new Point(38, 341);
            clearButton.Margin = new Padding(2, 3, 2, 3);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(216, 35);
            clearButton.TabIndex = 75;
            clearButton.Text = "CLEAR";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(116, 86, 174);
            loginButton.Cursor = Cursors.Hand;
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(38, 285);
            loginButton.Margin = new Padding(2, 3, 2, 3);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(216, 35);
            loginButton.TabIndex = 74;
            loginButton.Text = "LOGIN";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // passwordCheckBoxLogin
            // 
            passwordCheckBoxLogin.AutoSize = true;
            passwordCheckBoxLogin.Cursor = Cursors.Hand;
            passwordCheckBoxLogin.FlatStyle = FlatStyle.Flat;
            passwordCheckBoxLogin.Font = new Font("Nirmala UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            passwordCheckBoxLogin.Location = new Point(134, 247);
            passwordCheckBoxLogin.Margin = new Padding(2, 3, 2, 3);
            passwordCheckBoxLogin.Name = "passwordCheckBoxLogin";
            passwordCheckBoxLogin.Size = new Size(121, 21);
            passwordCheckBoxLogin.TabIndex = 68;
            passwordCheckBoxLogin.Text = "Show Password";
            passwordCheckBoxLogin.UseVisualStyleBackColor = true;
            passwordCheckBoxLogin.CheckedChanged += passwordCheckBoxLogin_CheckedChanged;
            // 
            // passwordTextBoxLogin
            // 
            passwordTextBoxLogin.BackColor = Color.FromArgb(230, 231, 233);
            passwordTextBoxLogin.BorderStyle = BorderStyle.None;
            passwordTextBoxLogin.Font = new Font("MS UI Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBoxLogin.Location = new Point(38, 213);
            passwordTextBoxLogin.Margin = new Padding(2, 3, 2, 3);
            passwordTextBoxLogin.Multiline = true;
            passwordTextBoxLogin.Name = "passwordTextBoxLogin";
            passwordTextBoxLogin.PasswordChar = '*';
            passwordTextBoxLogin.Size = new Size(216, 28);
            passwordTextBoxLogin.TabIndex = 73;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 187);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 72;
            label3.Text = "Password";
            // 
            // usernameTextBox
            // 
            usernameTextBox.BackColor = Color.FromArgb(230, 231, 233);
            usernameTextBox.BorderStyle = BorderStyle.None;
            usernameTextBox.Font = new Font("MS UI Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTextBox.Location = new Point(39, 152);
            usernameTextBox.Margin = new Padding(2, 3, 2, 3);
            usernameTextBox.Multiline = true;
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(216, 28);
            usernameTextBox.TabIndex = 71;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 127);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 70;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(31, 63);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(194, 34);
            label1.TabIndex = 69;
            label1.Text = "Get Started";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(290, 494);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(clearButton);
            Controls.Add(loginButton);
            Controls.Add(passwordCheckBoxLogin);
            Controls.Add(passwordTextBoxLogin);
            Controls.Add(label3);
            Controls.Add(usernameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label6;
        private Label label5;
        private Button clearButton;
        private Button loginButton;
        private CheckBox passwordCheckBoxLogin;
        private TextBox passwordTextBoxLogin;
        private Label label3;
        private TextBox usernameTextBox;
        private Label label2;
        private Label label1;
    }
}
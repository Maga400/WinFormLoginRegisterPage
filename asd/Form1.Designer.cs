namespace asd
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            confirmPasswordTextBox = new TextBox();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            clearButton = new Button();
            registerButton = new Button();
            showPasswordCheckBox = new CheckBox();
            passwordTextBox = new TextBox();
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
            button1.Location = new Point(250, 2);
            button1.Name = "button1";
            button1.Size = new Size(39, 35);
            button1.TabIndex = 72;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // confirmPasswordTextBox
            // 
            confirmPasswordTextBox.BackColor = Color.FromArgb(230, 231, 233);
            confirmPasswordTextBox.BorderStyle = BorderStyle.None;
            confirmPasswordTextBox.Font = new Font("MS UI Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            confirmPasswordTextBox.Location = new Point(39, 240);
            confirmPasswordTextBox.Margin = new Padding(2, 3, 2, 3);
            confirmPasswordTextBox.Multiline = true;
            confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            confirmPasswordTextBox.PasswordChar = '*';
            confirmPasswordTextBox.Size = new Size(216, 28);
            confirmPasswordTextBox.TabIndex = 71;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 214);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(127, 20);
            label4.TabIndex = 70;
            label4.Text = "Confrim Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Nirmala UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(116, 86, 174);
            label6.Location = new Point(99, 446);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(97, 17);
            label6.TabIndex = 69;
            label6.Text = "Back to LOGIN";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(67, 418);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(163, 17);
            label5.TabIndex = 68;
            label5.Text = "Already Have an Account";
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.White;
            clearButton.Cursor = Cursors.Hand;
            clearButton.FlatStyle = FlatStyle.Flat;
            clearButton.ForeColor = Color.FromArgb(116, 86, 174);
            clearButton.Location = new Point(40, 370);
            clearButton.Margin = new Padding(2, 3, 2, 3);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(216, 35);
            clearButton.TabIndex = 67;
            clearButton.Text = "CLEAR";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.FromArgb(116, 86, 174);
            registerButton.Cursor = Cursors.Hand;
            registerButton.FlatAppearance.BorderSize = 0;
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.ForeColor = Color.White;
            registerButton.Location = new Point(40, 314);
            registerButton.Margin = new Padding(2, 3, 2, 3);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(216, 35);
            registerButton.TabIndex = 66;
            registerButton.Text = "REGISTER";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // showPasswordCheckBox
            // 
            showPasswordCheckBox.AutoSize = true;
            showPasswordCheckBox.Cursor = Cursors.Hand;
            showPasswordCheckBox.FlatStyle = FlatStyle.Flat;
            showPasswordCheckBox.Font = new Font("Nirmala UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            showPasswordCheckBox.Location = new Point(136, 276);
            showPasswordCheckBox.Margin = new Padding(2, 3, 2, 3);
            showPasswordCheckBox.Name = "showPasswordCheckBox";
            showPasswordCheckBox.Size = new Size(121, 21);
            showPasswordCheckBox.TabIndex = 60;
            showPasswordCheckBox.Text = "Show Password";
            showPasswordCheckBox.UseVisualStyleBackColor = true;
            showPasswordCheckBox.CheckedChanged += showPasswordCheckBox_CheckedChanged;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.FromArgb(230, 231, 233);
            passwordTextBox.BorderStyle = BorderStyle.None;
            passwordTextBox.Font = new Font("MS UI Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(39, 183);
            passwordTextBox.Margin = new Padding(2, 3, 2, 3);
            passwordTextBox.Multiline = true;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(216, 28);
            passwordTextBox.TabIndex = 65;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(39, 157);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 64;
            label3.Text = "Password";
            // 
            // usernameTextBox
            // 
            usernameTextBox.BackColor = Color.FromArgb(230, 231, 233);
            usernameTextBox.BorderStyle = BorderStyle.None;
            usernameTextBox.Font = new Font("MS UI Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            usernameTextBox.Location = new Point(40, 122);
            usernameTextBox.Margin = new Padding(2, 3, 2, 3);
            usernameTextBox.Multiline = true;
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(216, 28);
            usernameTextBox.TabIndex = 63;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 97);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 62;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(32, 33);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(194, 34);
            label1.TabIndex = 61;
            label1.Text = "Get Started";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(290, 494);
            Controls.Add(button1);
            Controls.Add(confirmPasswordTextBox);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(clearButton);
            Controls.Add(registerButton);
            Controls.Add(showPasswordCheckBox);
            Controls.Add(passwordTextBox);
            Controls.Add(label3);
            Controls.Add(usernameTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox confirmPasswordTextBox;
        private Label label4;
        private Label label6;
        private Label label5;
        private Button clearButton;
        private Button registerButton;
        private CheckBox showPasswordCheckBox;
        private TextBox passwordTextBox;
        private Label label3;
        private TextBox usernameTextBox;
        private Label label2;
        private Label label1;
    }
}
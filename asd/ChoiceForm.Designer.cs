namespace asd
{
    partial class ChoiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChoiceForm));
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Stencil", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton1.ForeColor = Color.DarkBlue;
            radioButton1.Location = new Point(80, 127);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(228, 37);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Show Logins";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Stencil", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton2.ForeColor = Color.DarkBlue;
            radioButton2.Location = new Point(80, 189);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(250, 37);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Delete Logins";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Stencil", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton3.ForeColor = Color.DarkBlue;
            radioButton3.Location = new Point(80, 243);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(241, 37);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Change Login";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Thistle;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Stencil", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(-597, -225);
            label2.Name = "label2";
            label2.Size = new Size(190, 27);
            label2.TabIndex = 81;
            label2.Text = "BACK TO LOGIN";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Thistle;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Stencil", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(109, 339);
            label1.Name = "label1";
            label1.Size = new Size(190, 27);
            label1.TabIndex = 82;
            label1.Text = "BACK TO LOGIN";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 79);
            label3.Name = "label3";
            label3.Size = new Size(401, 20);
            label3.TabIndex = 83;
            label3.Text = "Secimlerden birin secin zehmet olmasa";
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Location = new Point(393, 2);
            button1.Name = "button1";
            button1.Size = new Size(39, 35);
            button1.TabIndex = 84;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ChoiceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(433, 419);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Name = "ChoiceForm";
            Text = "ChoiceForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private Label label2;
        private Label label1;
        private Label label3;
        private Button button1;
    }
}
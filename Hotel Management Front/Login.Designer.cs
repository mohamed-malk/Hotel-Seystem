namespace Hotel_System_Front
{
    partial class Login
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            Username = new TextBox();
            Login1 = new Button();
            Password = new TextBox();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            label7 = new Label();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(103, 177, 198);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-19, -36);
            panel1.Name = "panel1";
            panel1.Size = new Size(349, 531);
            panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.WhatsApp_Image_2024_02_06_at_11_05_12_PM_removebg_preview;
            pictureBox1.Location = new Point(31, 127);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(299, 295);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(378, 103);
            label4.Name = "label4";
            label4.Size = new Size(112, 47);
            label4.TabIndex = 8;
            label4.Text = "Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.MenuHighlight;
            label3.Location = new Point(378, 362);
            label3.Name = "label3";
            label3.Size = new Size(127, 15);
            label3.TabIndex = 7;
            label3.Text = "Forgot Your Password?";
            // 
            // Username
            // 
            Username.BorderStyle = BorderStyle.None;
            Username.Location = new Point(396, 213);
            Username.Multiline = true;
            Username.Name = "Username";
            Username.PlaceholderText = "Enter UserName";
            Username.Size = new Size(315, 30);
            Username.TabIndex = 2;
            // 
            // Login1
            // 
            Login1.BackColor = Color.FromArgb(103, 177, 198);
            Login1.FlatAppearance.BorderSize = 2;
            Login1.FlatStyle = FlatStyle.Popup;
            Login1.ForeColor = SystemColors.ActiveCaptionText;
            Login1.Location = new Point(589, 362);
            Login1.Name = "Login1";
            Login1.Size = new Size(105, 37);
            Login1.TabIndex = 6;
            Login1.Text = "Login";
            Login1.UseVisualStyleBackColor = false;
            Login1.Click += button1_Click;
            // 
            // Password
            // 
            Password.BorderStyle = BorderStyle.None;
            Password.Location = new Point(395, 294);
            Password.Multiline = true;
            Password.Name = "Password";
            Password.PasswordChar = '*';
            Password.PlaceholderText = "Enter Password";
            Password.Size = new Size(315, 34);
            Password.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(679, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(127, 101);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(509, 411);
            label6.Name = "label6";
            label6.Size = new Size(93, 14);
            label6.TabIndex = 11;
            label6.Text = "Not a Member ?";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.MenuHighlight;
            label7.Location = new Point(608, 410);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 12;
            label7.Text = "Sign Up";
            label7.Click += label7_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(103, 177, 198);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(393, 245);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 3);
            panel2.TabIndex = 13;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(103, 177, 198);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 3);
            panel3.TabIndex = 14;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(103, 177, 198);
            panel4.Location = new Point(393, 319);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 3);
            panel4.TabIndex = 14;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.username;
            pictureBox3.Location = new Point(352, 216);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(37, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.password;
            pictureBox4.Location = new Point(355, 291);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(34, 29);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(Username);
            Controls.Add(Login1);
            Controls.Add(Password);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox Username;
        private TextBox Password;
        private Button Login1;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label6;
        private Label label7;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
    }
}

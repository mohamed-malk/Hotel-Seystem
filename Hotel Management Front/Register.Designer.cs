namespace Hotel_System_Front
{
    partial class Register
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            UserName = new TextBox();
            SignUp = new Button();
            Password = new TextBox();
            pictureBox2 = new PictureBox();
            linkLabel1 = new LinkLabel();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            pictureBox6 = new PictureBox();
            ConfirmPassword = new TextBox();
            pictureBox7 = new PictureBox();
            Email = new TextBox();
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            errorProvider4 = new ErrorProvider(components);
            errorProvider5 = new ErrorProvider(components);
            panel6 = new Panel();
            NationalId = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider5).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(103, 177, 198);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-59, -40);
            panel1.Name = "panel1";
            panel1.Size = new Size(349, 531);
            panel1.TabIndex = 12;
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
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.MenuHighlight;
            label5.Location = new Point(579, 405);
            label5.Name = "label5";
            label5.Size = new Size(37, 15);
            label5.TabIndex = 21;
            label5.Text = "Login";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(338, 66);
            label4.Name = "label4";
            label4.Size = new Size(150, 47);
            label4.TabIndex = 19;
            label4.Text = "Sign Up";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.MenuHighlight;
            label3.Location = new Point(338, 358);
            label3.Name = "label3";
            label3.Size = new Size(129, 15);
            label3.TabIndex = 18;
            label3.Text = "Forgot Your PassWord?";
            // 
            // UserName
            // 
            UserName.BorderStyle = BorderStyle.None;
            UserName.Location = new Point(346, 163);
            UserName.Multiline = true;
            UserName.Name = "UserName";
            UserName.PlaceholderText = "Enter UserName";
            UserName.Size = new Size(243, 34);
            UserName.TabIndex = 13;
            // 
            // SignUp
            // 
            SignUp.BackColor = Color.FromArgb(103, 177, 198);
            SignUp.ForeColor = SystemColors.ActiveCaptionText;
            SignUp.Location = new Point(543, 351);
            SignUp.Name = "SignUp";
            SignUp.Size = new Size(105, 37);
            SignUp.TabIndex = 17;
            SignUp.Text = "SignUp";
            SignUp.UseVisualStyleBackColor = false;
            SignUp.Click += button1_Click;
            // 
            // Password
            // 
            Password.BorderStyle = BorderStyle.None;
            Password.Location = new Point(346, 247);
            Password.Multiline = true;
            Password.Name = "Password";
            Password.PasswordChar = '*';
            Password.PlaceholderText = "Enter Password";
            Password.Size = new Size(243, 34);
            Password.TabIndex = 14;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(679, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(127, 101);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.DisabledLinkColor = Color.Silver;
            linkLabel1.Font = new Font("Mongolian Baiti", 9.75F);
            linkLabel1.LinkColor = Color.DimGray;
            linkLabel1.Location = new Point(427, 406);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(146, 14);
            linkLabel1.TabIndex = 26;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Already Have an Account";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.username;
            pictureBox3.Location = new Point(305, 155);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(37, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 27;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.password;
            pictureBox4.Location = new Point(307, 244);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(34, 29);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 28;
            pictureBox4.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(103, 177, 198);
            panel3.Location = new Point(347, 193);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 3);
            panel3.TabIndex = 30;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(103, 177, 198);
            panel4.Location = new Point(346, 278);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 3);
            panel4.TabIndex = 15;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(103, 177, 198);
            panel5.Location = new Point(346, 324);
            panel5.Name = "panel5";
            panel5.Size = new Size(300, 3);
            panel5.TabIndex = 30;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(307, 290);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(34, 29);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 31;
            pictureBox6.TabStop = false;
            // 
            // ConfirmPassword
            // 
            ConfirmPassword.BorderStyle = BorderStyle.None;
            ConfirmPassword.Location = new Point(346, 293);
            ConfirmPassword.Multiline = true;
            ConfirmPassword.Name = "ConfirmPassword";
            ConfirmPassword.PasswordChar = '*';
            ConfirmPassword.PlaceholderText = "Confirm Password";
            ConfirmPassword.Size = new Size(243, 34);
            ConfirmPassword.TabIndex = 29;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(305, 198);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(34, 35);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 32;
            pictureBox7.TabStop = false;
            // 
            // Email
            // 
            Email.BorderStyle = BorderStyle.None;
            Email.Location = new Point(346, 206);
            Email.Multiline = true;
            Email.Name = "Email";
            Email.PlaceholderText = "Enter Email";
            Email.Size = new Size(243, 34);
            Email.TabIndex = 31;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            errorProvider5.ContainerControl = this;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(103, 177, 198);
            panel6.Location = new Point(346, 238);
            panel6.Name = "panel6";
            panel6.Size = new Size(300, 3);
            panel6.TabIndex = 16;
            // 
            // NationalId
            // 
            NationalId.Location = new Point(346, 129);
            NationalId.Name = "NationalId";
            NationalId.PlaceholderText = "NationalId";
            NationalId.Size = new Size(280, 23);
            NationalId.TabIndex = 33;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(NationalId);
            Controls.Add(panel6);
            Controls.Add(pictureBox7);
            Controls.Add(panel5);
            Controls.Add(Email);
            Controls.Add(pictureBox6);
            Controls.Add(ConfirmPassword);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(UserName);
            Controls.Add(SignUp);
            Controls.Add(Password);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox UserName;
        private Button SignUp;
        private TextBox Password;
        private PictureBox pictureBox2;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private PictureBox pictureBox6;
        private TextBox ConfirmPassword;
        private PictureBox pictureBox7;
        private TextBox Email;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
        private ErrorProvider errorProvider4;
        private ErrorProvider errorProvider5;
        private Panel panel6;
        private TextBox NationalId;
    }
}
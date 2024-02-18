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
            label2 = new Label();
            label1 = new Label();
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
            pictureBox6 = new PictureBox();
            ConfirmPassword = new TextBox();
            pictureBox7 = new PictureBox();
            Email = new TextBox();
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            errorProvider4 = new ErrorProvider(components);
            errorProvider5 = new ErrorProvider(components);
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
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-67, -53);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(399, 726);
            panel1.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MV Boli", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(138, 595);
            label2.Name = "label2";
            label2.Size = new Size(190, 52);
            label2.TabIndex = 19;
            label2.Text = "SYSTEM";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(138, 98);
            label1.Name = "label1";
            label1.Size = new Size(241, 58);
            label1.TabIndex = 18;
            label1.Text = "HOTEL   ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.WhatsApp_Image_2024_02_06_at_11_05_12_PM_removebg_preview;
            pictureBox1.Location = new Point(79, 216);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(287, 346);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(103, 177, 198);
            label5.Location = new Point(687, 617);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 21;
            label5.Text = "Login";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Script", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(103, 177, 198);
            label4.Location = new Point(568, 45);
            label4.Name = "label4";
            label4.Size = new Size(212, 73);
            label4.TabIndex = 19;
            label4.Text = "Sign Up";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(103, 177, 198);
            label3.Location = new Point(351, 480);
            label3.Name = "label3";
            label3.Size = new Size(160, 20);
            label3.TabIndex = 18;
            label3.Text = "Forgot Your PassWord?";
            // 
            // UserName
            // 
            UserName.BackColor = SystemColors.Control;
            UserName.BorderStyle = BorderStyle.None;
            UserName.Location = new Point(403, 217);
            UserName.Margin = new Padding(3, 4, 3, 4);
            UserName.Multiline = true;
            UserName.Name = "UserName";
            UserName.PlaceholderText = "Enter UserName";
            UserName.Size = new Size(353, 50);
            UserName.TabIndex = 13;
            // 
            // SignUp
            // 
            SignUp.BackColor = Color.FromArgb(103, 177, 198);
            SignUp.ForeColor = SystemColors.ActiveCaptionText;
            SignUp.Location = new Point(571, 536);
            SignUp.Margin = new Padding(3, 4, 3, 4);
            SignUp.Name = "SignUp";
            SignUp.Size = new Size(209, 49);
            SignUp.TabIndex = 17;
            SignUp.Text = "SignUp";
            SignUp.UseVisualStyleBackColor = false;
            SignUp.Click += button1_Click;
            // 
            // Password
            // 
            Password.BackColor = SystemColors.Control;
            Password.BorderStyle = BorderStyle.None;
            Password.Location = new Point(403, 354);
            Password.Margin = new Padding(3, 4, 3, 4);
            Password.Multiline = true;
            Password.Name = "Password";
            Password.PasswordChar = '*';
            Password.PlaceholderText = "Enter Password";
            Password.Size = new Size(353, 45);
            Password.TabIndex = 14;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(833, -2);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(145, 135);
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
            linkLabel1.Location = new Point(482, 620);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(199, 18);
            linkLabel1.TabIndex = 26;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Already Have an Account?";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Gainsboro;
            pictureBox3.Image = Properties.Resources.username;
            pictureBox3.Location = new Point(358, 217);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(42, 41);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 27;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Gainsboro;
            pictureBox4.Image = Properties.Resources.password;
            pictureBox4.Location = new Point(358, 360);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(39, 39);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 28;
            pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Gainsboro;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(358, 433);
            pictureBox6.Margin = new Padding(3, 4, 3, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(39, 39);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 31;
            pictureBox6.TabStop = false;
            // 
            // ConfirmPassword
            // 
            ConfirmPassword.BackColor = SystemColors.ButtonFace;
            ConfirmPassword.BorderStyle = BorderStyle.None;
            ConfirmPassword.Location = new Point(403, 431);
            ConfirmPassword.Margin = new Padding(3, 4, 3, 4);
            ConfirmPassword.Multiline = true;
            ConfirmPassword.Name = "ConfirmPassword";
            ConfirmPassword.PasswordChar = '*';
            ConfirmPassword.PlaceholderText = "Confirm Password";
            ConfirmPassword.Size = new Size(353, 41);
            ConfirmPassword.TabIndex = 29;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.Gainsboro;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(358, 287);
            pictureBox7.Margin = new Padding(3, 4, 3, 4);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(39, 47);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 32;
            pictureBox7.TabStop = false;
            // 
            // Email
            // 
            Email.BackColor = SystemColors.Control;
            Email.BorderStyle = BorderStyle.None;
            Email.Location = new Point(403, 287);
            Email.Margin = new Padding(3, 4, 3, 4);
            Email.Multiline = true;
            Email.Name = "Email";
            Email.PlaceholderText = "Enter Email";
            Email.Size = new Size(353, 47);
            Email.TabIndex = 31;
            Email.TextChanged += Email_TextChanged;
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
            // NationalId
            // 
            NationalId.BackColor = SystemColors.Menu;
            NationalId.Location = new Point(533, 163);
            NationalId.Margin = new Padding(3, 4, 3, 4);
            NationalId.Name = "NationalId";
            NationalId.PlaceholderText = "NationalId";
            NationalId.Size = new Size(319, 27);
            NationalId.TabIndex = 33;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(974, 656);
            Controls.Add(NationalId);
            Controls.Add(pictureBox7);
            Controls.Add(Email);
            Controls.Add(pictureBox6);
            Controls.Add(ConfirmPassword);
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
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            Load += Register_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Label label1;
        private Label label2;
    }
}
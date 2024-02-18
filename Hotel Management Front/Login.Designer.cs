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
            label2 = new Label();
            label1 = new Label();
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
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(103, 177, 198);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-22, -48);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(399, 708);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MV Boli", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(109, 587);
            label2.Name = "label2";
            label2.Size = new Size(190, 52);
            label2.TabIndex = 17;
            label2.Text = "SYSTEM";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(123, 83);
            label1.Name = "label1";
            label1.Size = new Size(241, 58);
            label1.TabIndex = 17;
            label1.Text = "HOTEL   ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.WhatsApp_Image_2024_02_06_at_11_05_12_PM_removebg_preview;
            pictureBox1.Location = new Point(34, 178);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(342, 393);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Script", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(103, 177, 198);
            label4.Location = new Point(553, 140);
            label4.Name = "label4";
            label4.Size = new Size(161, 73);
            label4.TabIndex = 8;
            label4.Text = "Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(103, 177, 198);
            label3.Location = new Point(403, 391);
            label3.Name = "label3";
            label3.Size = new Size(158, 20);
            label3.TabIndex = 7;
            label3.Text = "Forgot Your Password?";
            // 
            // Username
            // 
            Username.BackColor = Color.FromArgb(224, 224, 224);
            Username.BorderStyle = BorderStyle.None;
            Username.Location = new Point(451, 271);
            Username.Margin = new Padding(3, 4, 3, 4);
            Username.Multiline = true;
            Username.Name = "Username";
            Username.PlaceholderText = "            Enter UserName";
            Username.Size = new Size(376, 48);
            Username.TabIndex = 2;
            Username.TextChanged += Username_TextChanged;
            // 
            // Login1
            // 
            Login1.BackColor = Color.FromArgb(103, 177, 198);
            Login1.FlatAppearance.BorderSize = 2;
            Login1.FlatStyle = FlatStyle.Popup;
            Login1.ForeColor = SystemColors.ActiveCaptionText;
            Login1.Location = new Point(566, 427);
            Login1.Margin = new Padding(3, 4, 3, 4);
            Login1.Name = "Login1";
            Login1.Size = new Size(190, 46);
            Login1.TabIndex = 6;
            Login1.Text = "Login";
            Login1.UseVisualStyleBackColor = false;
            Login1.Click += button1_Click;
            // 
            // Password
            // 
            Password.BackColor = Color.FromArgb(224, 224, 224);
            Password.BorderStyle = BorderStyle.None;
            Password.Location = new Point(451, 341);
            Password.Margin = new Padding(3, 4, 3, 4);
            Password.Multiline = true;
            Password.Name = "Password";
            Password.PasswordChar = '*';
            Password.PlaceholderText = "             Enter Password";
            Password.Size = new Size(376, 46);
            Password.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(726, -9);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(190, 127);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Silver;
            label6.Location = new Point(523, 549);
            label6.Name = "label6";
            label6.Size = new Size(121, 18);
            label6.TabIndex = 11;
            label6.Text = "Not a Member ?";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(103, 177, 198);
            label7.Location = new Point(642, 546);
            label7.Name = "label7";
            label7.Size = new Size(61, 20);
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
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.WhiteSmoke;
            pictureBox3.Image = Properties.Resources.username;
            pictureBox3.Location = new Point(403, 271);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(42, 48);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.WhiteSmoke;
            pictureBox4.Image = Properties.Resources.password;
            pictureBox4.Location = new Point(406, 341);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(39, 46);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(914, 600);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(Username);
            Controls.Add(Login1);
            Controls.Add(Password);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
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
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label2;
    }
}

namespace Hotel_System_Front
{
    partial class MyProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyProfile));
            pictureBox6 = new PictureBox();
            label8 = new Label();
            panel2 = new Panel();
            pictureBox8 = new PictureBox();
            label7 = new Label();
            pictureBox7 = new PictureBox();
            panelContainer2 = new Panel();
            pictureBox4 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.room;
            pictureBox6.Location = new Point(11, 365);
            pictureBox6.Margin = new Padding(3, 4, 3, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(53, 68);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 100;
            pictureBox6.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("MV Boli", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(393, 55);
            label8.Name = "label8";
            label8.Size = new Size(651, 62);
            label8.TabIndex = 104;
            label8.Text = "Hotel Management System";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(103, 177, 198);
            panel2.Controls.Add(pictureBox8);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(0, 860);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(274, 105);
            panel2.TabIndex = 101;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(213, 12);
            pictureBox8.Margin = new Padding(3, 4, 3, 4);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(49, 49);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 15;
            pictureBox8.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20.25F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(91, 12);
            label7.Name = "label7";
            label7.Size = new Size(127, 46);
            label7.TabIndex = 14;
            label7.Text = "Logout";
            label7.Click += label7_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.White;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(1175, -2);
            pictureBox7.Margin = new Padding(3, 4, 3, 4);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(144, 164);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 103;
            pictureBox7.TabStop = false;
            // 
            // panelContainer2
            // 
            panelContainer2.BackColor = Color.White;
            panelContainer2.Location = new Point(274, 155);
            panelContainer2.Margin = new Padding(3, 4, 3, 4);
            panelContainer2.Name = "panelContainer2";
            panelContainer2.Size = new Size(1253, 851);
            panelContainer2.TabIndex = 102;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(11, 555);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(55, 71);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 118;
            pictureBox4.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(103, 177, 198);
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(103, 177, 198);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Mongolian Baiti", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(97, 187);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(165, 71);
            button1.TabIndex = 119;
            button1.Text = "My Profile";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(103, 177, 198);
            button2.FlatAppearance.BorderColor = Color.White;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(103, 177, 198);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Mongolian Baiti", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(79, 555);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(195, 80);
            button2.TabIndex = 120;
            button2.Text = "FeedBack";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(103, 177, 198);
            button4.FlatAppearance.BorderColor = Color.White;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(103, 177, 198);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Mongolian Baiti", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(121, 365);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(123, 68);
            button4.TabIndex = 122;
            button4.Text = "Rooms";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // MyProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(103, 177, 198);
            ClientSize = new Size(1312, 935);
            Controls.Add(button2);
            Controls.Add(button4);
            Controls.Add(pictureBox4);
            Controls.Add(button1);
            Controls.Add(pictureBox6);
            Controls.Add(label8);
            Controls.Add(panel2);
            Controls.Add(pictureBox7);
            Controls.Add(panelContainer2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MyProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyProfile";
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox6;
        private Label label2;
        private Label label8;
        private Panel panel2;
        private PictureBox pictureBox8;
        private Label label7;
        private Label label1;
        private PictureBox pictureBox7;
        private Label label4;
        private Label label9;
        private Panel panel4;
        private Panel panelContainer2;
        private PictureBox pictureBox4;
        private Button button1;
        private Button button2;
        private Button button4;
        private Label label6;
    }
}
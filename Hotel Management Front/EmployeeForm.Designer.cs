namespace Hotel_System_Front
{
    partial class EmployeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            label8 = new Label();
            panel2 = new Panel();
            pictureBox8 = new PictureBox();
            label7 = new Label();
            pictureBox7 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox5 = new PictureBox();
            panelContainer3 = new Panel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Baskerville Old Face", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(273, 63);
            label8.Name = "label8";
            label8.Size = new Size(549, 53);
            label8.TabIndex = 92;
            label8.Text = "Hotel Management System";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(103, 177, 198);
            panel2.Controls.Add(pictureBox8);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(-1, 869);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(274, 105);
            panel2.TabIndex = 87;
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
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(1087, 17);
            pictureBox7.Margin = new Padding(3, 4, 3, 4);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(145, 135);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 91;
            pictureBox7.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = Properties.Resources.customers;
            pictureBox9.Location = new Point(11, 249);
            pictureBox9.Margin = new Padding(3, 4, 3, 4);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(61, 72);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 95;
            pictureBox9.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(15, 328);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(57, 67);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 80;
            pictureBox5.TabStop = false;
            // 
            // panelContainer3
            // 
            panelContainer3.BackColor = Color.FromArgb(224, 224, 224);
            panelContainer3.Location = new Point(273, 164);
            panelContainer3.Margin = new Padding(3, 4, 3, 4);
            panelContainer3.Name = "panelContainer3";
            panelContainer3.Size = new Size(1253, 851);
            panelContainer3.TabIndex = 88;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(16, 168);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(56, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 96;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(103, 177, 198);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 20.25F);
            button1.Location = new Point(78, 164);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(195, 80);
            button1.TabIndex = 97;
            button1.Text = "Profile";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.FlatAppearance.BorderColor = Color.White;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(103, 177, 198);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 20.25F);
            button3.Location = new Point(78, 241);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(195, 80);
            button3.TabIndex = 99;
            button3.Text = "Clients";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.FlatAppearance.BorderColor = Color.White;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(103, 177, 198);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 20.25F);
            button4.Location = new Point(78, 320);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(195, 80);
            button4.TabIndex = 100;
            button4.Text = "Reservation";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1247, 935);
            Controls.Add(button4);
            Controls.Add(pictureBox1);
            Controls.Add(button3);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox5);
            Controls.Add(panelContainer3);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EmployeeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee";
            Load += EmployeeForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label8;
        private Panel panel2;
        private PictureBox pictureBox8;
        private Label label7;
        private PictureBox pictureBox7;
        private PictureBox pictureBox9;
        private PictureBox pictureBox5;
        private Panel panelContainer3;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button3;
        private Button button4;
    }
}
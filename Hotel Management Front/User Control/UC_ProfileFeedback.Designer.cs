namespace Hotel_System_Front.User_Control
{
    partial class UC_ProfileFeedback
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            textBox1 = new TextBox();
            label10 = new Label();
            trackBar2 = new TrackBar();
            trackBar1 = new TrackBar();
            label6 = new Label();
            label3 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(103, 177, 198);
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(524, 538);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(321, 65);
            button1.TabIndex = 47;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(390, 392);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(362, 68);
            textBox1.TabIndex = 46;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(170, 372);
            label10.Name = "label10";
            label10.Size = new Size(171, 46);
            label10.TabIndex = 45;
            label10.Text = "Comment";
            // 
            // trackBar2
            // 
            trackBar2.BackColor = Color.Gray;
            trackBar2.Location = new Point(390, 284);
            trackBar2.Margin = new Padding(3, 4, 3, 4);
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(362, 56);
            trackBar2.TabIndex = 44;
            // 
            // trackBar1
            // 
            trackBar1.BackColor = Color.Gray;
            trackBar1.Location = new Point(390, 191);
            trackBar1.Margin = new Padding(3, 4, 3, 4);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(362, 56);
            trackBar1.TabIndex = 43;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(170, 284);
            label6.Name = "label6";
            label6.Size = new Size(217, 46);
            label6.TabIndex = 42;
            label6.Text = "Food Quality";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(174, 191);
            label3.Name = "label3";
            label3.Size = new Size(131, 46);
            label3.TabIndex = 41;
            label3.Text = "Service";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(350, 24);
            label9.Name = "label9";
            label9.Size = new Size(321, 54);
            label9.TabIndex = 40;
            label9.Text = "My FeedBack";
            // 
            // UC_ProfileFeedback
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label10);
            Controls.Add(trackBar2);
            Controls.Add(trackBar1);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label9);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UC_ProfileFeedback";
            Size = new Size(1253, 851);
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label10;
        private TrackBar trackBar2;
        private TrackBar trackBar1;
        private Label label6;
        private Label label3;
        private Label label9;
    }
}

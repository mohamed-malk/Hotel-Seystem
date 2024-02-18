namespace Hotel_System_Front.User_Control
{
    partial class Reports
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
            label9 = new Label();
            outLb = new Label();
            label5 = new Label();
            actualLb = new Label();
            label3 = new Label();
            totalLb = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(393, 24);
            label9.Name = "label9";
            label9.Size = new Size(195, 54);
            label9.TabIndex = 33;
            label9.Text = "Reports";
            // 
            // outLb
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(136, 161);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(889, 236);
            dataGridView1.TabIndex = 34;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Myanmar Text", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(51, 644);
            label5.Name = "label5";
            label5.Size = new Size(187, 53);
            label5.TabIndex = 39;
            label5.Text = "Out Income";
            // 
            // actualLb
            // 
            actualLb.AutoSize = true;
            actualLb.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 161);
            actualLb.Location = new Point(292, 554);
            actualLb.Name = "actualLb";
            actualLb.Size = new Size(87, 36);
            actualLb.TabIndex = 38;
            actualLb.Text = "1000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Myanmar Text", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(51, 554);
            label3.Name = "label3";
            label3.Size = new Size(224, 53);
            label3.TabIndex = 37;
            label3.Text = "Actual Income";
            // 
            // totalLb
            // 
            totalLb.AutoSize = true;
            totalLb.Font = new Font("Segoe UI Variable Text", 18F, FontStyle.Bold, GraphicsUnit.Point, 161);
            totalLb.Location = new Point(292, 454);
            totalLb.Name = "totalLb";
            totalLb.Size = new Size(81, 40);
            totalLb.TabIndex = 36;
            totalLb.Text = "1000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Myanmar Text", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 454);
            label1.Name = "label1";
            label1.Size = new Size(207, 53);
            label1.TabIndex = 35;
            label1.Text = "Total Income";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(126, 173);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(889, 236);
            dataGridView1.TabIndex = 34;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(outLb);
            Controls.Add(label5);
            Controls.Add(actualLb);
            Controls.Add(label3);
            Controls.Add(totalLb);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(label9);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Reports";
            Size = new Size(1253, 851);
            Load += UC_Feedback_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private Label outLb;
        private Label label5;
        private Label actualLb;
        private Label label3;
        private Label totalLb;
        private Label label1;
        private DataGridView dataGridView1;
    }
}

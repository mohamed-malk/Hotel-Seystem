namespace Hotel_System_Front.User_Control
{
    partial class UC_EmployeeProfile
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
            dataGridView1 = new DataGridView();
            button2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Baskerville Old Face", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(368, 18);
            label9.Name = "label9";
            label9.Size = new Size(184, 43);
            label9.TabIndex = 63;
            label9.Text = "My Profile";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(113, 102);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(681, 215);
            dataGridView1.TabIndex = 64;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(103, 177, 198);
            button2.Location = new Point(520, 347);
            button2.Name = "button2";
            button2.Size = new Size(90, 34);
            button2.TabIndex = 66;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(103, 177, 198);
            button1.Location = new Point(307, 347);
            button1.Name = "button1";
            button1.Size = new Size(90, 34);
            button1.TabIndex = 65;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            // 
            // UC_EmployeeProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label9);
            Name = "UC_EmployeeProfile";
            Size = new Size(1096, 638);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private DataGridView dataGridView1;
        private Button button2;
        private Button button1;
    }
}

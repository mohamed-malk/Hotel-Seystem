namespace Hotel_System_Front.User_Control
{
    partial class Uc_ProfileRooms
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
            button2 = new Button();
            dataGridView2 = new DataGridView();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(103, 177, 198);
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(650, 493);
            button2.Name = "button2";
            button2.Size = new Size(159, 43);
            button2.TabIndex = 44;
            button2.Text = "Go to Checkout";
            button2.UseVisualStyleBackColor = false;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(128, 408);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(679, 66);
            dataGridView2.TabIndex = 43;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Baskerville Old Face", 27.75F, FontStyle.Bold);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(83, 359);
            label5.Name = "label5";
            label5.Size = new Size(218, 43);
            label5.TabIndex = 42;
            label5.Text = "Your Rooms";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(128, 168);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(679, 150);
            dataGridView1.TabIndex = 41;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Baskerville Old Face", 27.75F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(83, 116);
            label3.Name = "label3";
            label3.Size = new Size(284, 43);
            label3.TabIndex = 40;
            label3.Text = "Available Rooms";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Baskerville Old Face", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(349, 18);
            label9.Name = "label9";
            label9.Size = new Size(299, 43);
            label9.TabIndex = 39;
            label9.Text = "Book Your Room";
            // 
            // Uc_ProfileRooms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(button2);
            Controls.Add(dataGridView2);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label9);
            Name = "Uc_ProfileRooms";
            Size = new Size(1096, 638);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private DataGridView dataGridView2;
        private Label label5;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label9;
    }
}

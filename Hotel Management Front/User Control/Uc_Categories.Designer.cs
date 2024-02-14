namespace Hotel_System_Front.User_Control
{
    partial class Uc_Categories
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            textBox2 = new TextBox();
            button4 = new Button();
            update = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            RoomId = new DataGridViewTextBoxColumn();
            RoomType = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            textBox1 = new TextBox();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(516, 150);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Cost";
            textBox2.Size = new Size(133, 29);
            textBox2.TabIndex = 58;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(103, 177, 198);
            button4.Location = new Point(606, 207);
            button4.Name = "button4";
            button4.Size = new Size(90, 34);
            button4.TabIndex = 57;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = false;
            // 
            // update
            // 
            update.BackColor = Color.FromArgb(103, 177, 198);
            update.Location = new Point(483, 207);
            update.Name = "update";
            update.Size = new Size(90, 34);
            update.TabIndex = 56;
            update.Text = "Update";
            update.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(103, 177, 198);
            button2.Location = new Point(364, 207);
            button2.Name = "button2";
            button2.Size = new Size(90, 34);
            button2.TabIndex = 55;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(103, 177, 198);
            button1.Location = new Point(241, 207);
            button1.Name = "button1";
            button1.Size = new Size(90, 34);
            button1.TabIndex = 54;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { RoomId, RoomType, Status });
            dataGridView1.Location = new Point(325, 279);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(343, 49);
            dataGridView1.TabIndex = 53;
            // 
            // RoomId
            // 
            dataGridViewCellStyle2.BackColor = Color.FromArgb(103, 177, 198);
            RoomId.DefaultCellStyle = dataGridViewCellStyle2;
            RoomId.HeaderText = "Id";
            RoomId.Name = "RoomId";
            // 
            // RoomType
            // 
            RoomType.HeaderText = "Type";
            RoomType.Name = "RoomType";
            // 
            // Status
            // 
            Status.HeaderText = "Cost";
            Status.Name = "Status";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(314, 150);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Category Name";
            textBox1.Size = new Size(133, 29);
            textBox1.TabIndex = 52;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Baskerville Old Face", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(372, 18);
            label9.Name = "label9";
            label9.Size = new Size(289, 43);
            label9.TabIndex = 51;
            label9.Text = "Room Categories";
            // 
            // Uc_Categories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(textBox2);
            Controls.Add(button4);
            Controls.Add(update);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(label9);
            Name = "Uc_Categories";
            Size = new Size(1096, 638);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private Button button4;
        private Button update;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn RoomId;
        private DataGridViewTextBoxColumn RoomType;
        private DataGridViewTextBoxColumn Status;
        private TextBox textBox1;
        private Label label9;
    }
}

namespace Hotel_System_Front.User_Control
{
    partial class UC_Rooms
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
            button4 = new Button();
            update = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            RoomId = new DataGridViewTextBoxColumn();
            RoomType = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(103, 177, 198);
            button4.Location = new Point(579, 208);
            button4.Name = "button4";
            button4.Size = new Size(90, 34);
            button4.TabIndex = 50;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = false;
            // 
            // update
            // 
            update.BackColor = Color.FromArgb(103, 177, 198);
            update.Location = new Point(456, 208);
            update.Name = "update";
            update.Size = new Size(90, 34);
            update.TabIndex = 49;
            update.Text = "Update";
            update.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(103, 177, 198);
            button2.Location = new Point(337, 208);
            button2.Name = "button2";
            button2.Size = new Size(90, 34);
            button2.TabIndex = 48;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(103, 177, 198);
            button1.Location = new Point(214, 208);
            button1.Name = "button1";
            button1.Size = new Size(90, 34);
            button1.TabIndex = 47;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { RoomId, RoomType, Status });
            dataGridView1.Location = new Point(298, 280);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(342, 87);
            dataGridView1.TabIndex = 46;
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
            Status.HeaderText = "Status";
            Status.Name = "Status";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(592, 151);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(133, 23);
            comboBox2.TabIndex = 45;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(413, 152);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(133, 23);
            comboBox1.TabIndex = 44;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(228, 151);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "ID";
            textBox1.Size = new Size(133, 29);
            textBox1.TabIndex = 43;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Baskerville Old Face", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(361, 15);
            label9.Name = "label9";
            label9.Size = new Size(261, 43);
            label9.TabIndex = 42;
            label9.Text = "Manage Rooms";
            // 
            // UC_Rooms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(button4);
            Controls.Add(update);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label9);
            Name = "UC_Rooms";
            Size = new Size(1096, 638);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button4;
        private Button update;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn RoomId;
        private DataGridViewTextBoxColumn RoomType;
        private DataGridViewTextBoxColumn Status;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label9;
    }
}

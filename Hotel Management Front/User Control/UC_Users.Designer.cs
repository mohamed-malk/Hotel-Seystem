namespace Hotel_System_Front.User_Control
{
    partial class UC_Users
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
            textBox1 = new TextBox();
            label9 = new Label();
            textBox3 = new TextBox();
            Column6 = new DataGridViewTextBoxColumn();
            RoomId = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(621, 141);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Password";
            textBox2.Size = new Size(133, 29);
            textBox2.TabIndex = 70;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(103, 177, 198);
            button4.Location = new Point(703, 198);
            button4.Name = "button4";
            button4.Size = new Size(90, 34);
            button4.TabIndex = 69;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = false;
            // 
            // update
            // 
            update.BackColor = Color.FromArgb(103, 177, 198);
            update.Location = new Point(580, 198);
            update.Name = "update";
            update.Size = new Size(90, 34);
            update.TabIndex = 68;
            update.Text = "Update";
            update.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(103, 177, 198);
            button2.Location = new Point(461, 198);
            button2.Name = "button2";
            button2.Size = new Size(90, 34);
            button2.TabIndex = 67;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(103, 177, 198);
            button1.Location = new Point(338, 198);
            button1.Name = "button1";
            button1.Size = new Size(90, 34);
            button1.TabIndex = 66;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column6, RoomId, Column2, Column3, Column4, name, Column1 });
            dataGridView1.Location = new Point(180, 258);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(744, 51);
            dataGridView1.TabIndex = 65;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(207, 140);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "UserName";
            textBox1.Size = new Size(133, 29);
            textBox1.TabIndex = 63;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Baskerville Old Face", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(372, 18);
            label9.Name = "label9";
            label9.Size = new Size(308, 43);
            label9.TabIndex = 62;
            label9.Text = "Manage Employee";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(343, 141);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Name";
            textBox3.Size = new Size(133, 29);
            textBox3.TabIndex = 72;
            // 
            // Column6
            // 
            Column6.HeaderText = "UserId";
            Column6.Name = "Column6";
            // 
            // RoomId
            // 
            dataGridViewCellStyle2.BackColor = Color.FromArgb(103, 177, 198);
            RoomId.DefaultCellStyle = dataGridViewCellStyle2;
            RoomId.HeaderText = "UserName";
            RoomId.Name = "RoomId";
            // 
            // Column2
            // 
            Column2.HeaderText = "Name";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Email";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Adreess";
            Column4.Name = "Column4";
            // 
            // name
            // 
            name.HeaderText = "Password";
            name.Name = "name";
            // 
            // Column1
            // 
            Column1.HeaderText = "Salary";
            Column1.Name = "Column1";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(68, 140);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "UserID";
            textBox4.Size = new Size(133, 29);
            textBox4.TabIndex = 73;
            // 
            // textBox5
            // 
            textBox5.AcceptsReturn = true;
            textBox5.Location = new Point(482, 141);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Email";
            textBox5.Size = new Size(133, 29);
            textBox5.TabIndex = 74;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(760, 140);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Address";
            textBox6.Size = new Size(133, 29);
            textBox6.TabIndex = 75;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(899, 141);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.PlaceholderText = "Salary";
            textBox7.Size = new Size(133, 29);
            textBox7.TabIndex = 76;
            // 
            // UC_Users
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button4);
            Controls.Add(update);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(label9);
            Name = "UC_Users";
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
        private TextBox textBox1;
        private Label label9;
        private TextBox textBox3;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn RoomId;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn Column1;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
    }
}

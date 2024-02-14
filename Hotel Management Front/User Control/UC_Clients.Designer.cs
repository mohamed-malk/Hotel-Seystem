namespace Hotel_System_Front.User_Control
{
    partial class UC_Clients
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            button4 = new Button();
            update = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            label9 = new Label();
            textBox6 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            RoomId = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            gender = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Location = new Point(212, 142);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Email";
            textBox3.Size = new Size(133, 29);
            textBox3.TabIndex = 62;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(372, 142);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Phone";
            textBox2.Size = new Size(133, 29);
            textBox2.TabIndex = 61;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(103, 177, 198);
            button4.Location = new Point(627, 206);
            button4.Name = "button4";
            button4.Size = new Size(90, 34);
            button4.TabIndex = 60;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = false;
            // 
            // update
            // 
            update.BackColor = Color.FromArgb(103, 177, 198);
            update.Location = new Point(504, 206);
            update.Name = "update";
            update.Size = new Size(90, 34);
            update.TabIndex = 59;
            update.Text = "Update";
            update.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(103, 177, 198);
            button2.Location = new Point(385, 206);
            button2.Name = "button2";
            button2.Size = new Size(90, 34);
            button2.TabIndex = 58;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(103, 177, 198);
            button1.Location = new Point(262, 206);
            button1.Name = "button1";
            button1.Size = new Size(90, 34);
            button1.TabIndex = 57;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { RoomId, Column2, Column3, name, Email, Phone, gender, Column1 });
            dataGridView1.Location = new Point(97, 263);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(841, 87);
            dataGridView1.TabIndex = 56;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(682, 87);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Name";
            textBox1.Size = new Size(133, 29);
            textBox1.TabIndex = 54;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Baskerville Old Face", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(372, 18);
            label9.Name = "label9";
            label9.Size = new Size(260, 43);
            label9.TabIndex = 53;
            label9.Text = "Manage Clients";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(212, 87);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "ClientId";
            textBox6.Size = new Size(133, 29);
            textBox6.TabIndex = 76;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female" });
            comboBox1.Location = new Point(534, 148);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(133, 23);
            comboBox1.TabIndex = 77;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Male", "Female" });
            comboBox2.Location = new Point(682, 148);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(133, 23);
            comboBox2.TabIndex = 78;
            // 
            // RoomId
            // 
            dataGridViewCellStyle3.BackColor = Color.FromArgb(103, 177, 198);
            RoomId.DefaultCellStyle = dataGridViewCellStyle3;
            RoomId.HeaderText = "Id";
            RoomId.Name = "RoomId";
            RoomId.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "UserName";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Password";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // name
            // 
            name.HeaderText = "Name";
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // Phone
            // 
            Phone.HeaderText = "Phone";
            Phone.Name = "Phone";
            Phone.ReadOnly = true;
            // 
            // gender
            // 
            gender.HeaderText = "Gender";
            gender.Name = "gender";
            gender.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Membership";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(372, 87);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "UserName";
            textBox4.Size = new Size(133, 29);
            textBox4.TabIndex = 79;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(534, 87);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Password";
            textBox5.Size = new Size(133, 29);
            textBox5.TabIndex = 80;
            // 
            // UC_Clients
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox6);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button4);
            Controls.Add(update);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(label9);
            Name = "UC_Clients";
            Size = new Size(1096, 638);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox3;
        private TextBox textBox2;
        private Button button4;
        private Button update;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label9;
        private TextBox textBox6;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private DataGridViewTextBoxColumn RoomId;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn gender;
        private DataGridViewTextBoxColumn Column1;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}

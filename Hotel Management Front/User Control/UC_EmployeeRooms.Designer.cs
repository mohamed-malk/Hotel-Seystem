namespace Hotel_System_Front.User_Control
{
    partial class UC_EmployeeRooms
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
            button4 = new Button();
            update = new Button();
            button2 = new Button();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            label9 = new Label();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(103, 177, 198);
            button4.Location = new Point(567, 204);
            button4.Name = "button4";
            button4.Size = new Size(90, 34);
            button4.TabIndex = 58;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = false;
            // 
            // update
            // 
            update.BackColor = Color.FromArgb(103, 177, 198);
            update.Location = new Point(444, 204);
            update.Name = "update";
            update.Size = new Size(90, 34);
            update.TabIndex = 57;
            update.Text = "Update";
            update.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(103, 177, 198);
            button2.Location = new Point(325, 204);
            button2.Name = "button2";
            button2.Size = new Size(90, 34);
            button2.TabIndex = 56;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(103, 177, 198);
            button1.Location = new Point(202, 204);
            button1.Name = "button1";
            button1.Size = new Size(90, 34);
            button1.TabIndex = 55;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(286, 276);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(342, 87);
            dataGridView1.TabIndex = 54;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(619, 142);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(133, 23);
            comboBox2.TabIndex = 53;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(122, 142);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Number";
            textBox1.Size = new Size(133, 29);
            textBox1.TabIndex = 51;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Baskerville Old Face", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(358, 18);
            label9.Name = "label9";
            label9.Size = new Size(261, 43);
            label9.TabIndex = 50;
            label9.Text = "Manage Rooms";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(282, 142);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Rate";
            textBox2.Size = new Size(133, 29);
            textBox2.TabIndex = 59;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(444, 142);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(133, 23);
            comboBox1.TabIndex = 60;
            // 
            // UC_EmployeeRooms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(button4);
            Controls.Add(update);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox2);
            Controls.Add(textBox1);
            Controls.Add(label9);
            Name = "UC_EmployeeRooms";
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
        private ComboBox comboBox2;
        private TextBox textBox1;
        private Label label9;
        private TextBox textBox2;
        private ComboBox comboBox1;
    }
}

﻿namespace Hotel_System_Front.User_Control
{
    partial class Uc_Reservation
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
            dataGridView1 = new DataGridView();
            Column5 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            button2 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column5, Column1, Column2, Column6, Column3, Column4 });
            dataGridView1.Location = new Point(132, 284);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(644, 46);
            dataGridView1.TabIndex = 80;
            // 
            // Column5
            // 
            Column5.HeaderText = "BookId";
            Column5.Name = "Column5";
            // 
            // Column1
            // 
            Column1.HeaderText = "Room";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Client";
            Column2.Name = "Column2";
            // 
            // Column6
            // 
            Column6.HeaderText = "BookDate";
            Column6.Name = "Column6";
            // 
            // Column3
            // 
            Column3.HeaderText = "Duration";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Amount";
            Column4.Name = "Column4";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(103, 177, 198);
            button2.Location = new Point(463, 202);
            button2.Name = "button2";
            button2.Size = new Size(87, 34);
            button2.TabIndex = 79;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(103, 177, 198);
            button1.Location = new Point(317, 202);
            button1.Name = "button1";
            button1.Size = new Size(87, 34);
            button1.TabIndex = 78;
            button1.Text = "Book";
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(734, 149);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Amount";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 77;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(600, 150);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Duration";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 76;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(372, 149);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 75;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(212, 149);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 73;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(47, 149);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 74;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Baskerville Old Face", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(372, 18);
            label9.Name = "label9";
            label9.Size = new Size(202, 43);
            label9.TabIndex = 72;
            label9.Text = "Reservation";
            // 
            // Uc_Reservation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(comboBox2);
            Controls.Add(label9);
            Name = "Uc_Reservation";
            Size = new Size(1096, 638);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button button2;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label9;
    }
}

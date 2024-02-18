namespace Hotel_System_Front.User_Control
{
    partial class UC_EmployeeClient
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
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox1 = new TextBox();
            label9 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            address = new TextBox();
            Age = new TextBox();
            Nationality = new TextBox();
            button1 = new Button();
            gender = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox5
            // 
            textBox5.Location = new Point(617, 151);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Password";
            textBox5.Size = new Size(151, 37);
            textBox5.TabIndex = 94;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(249, 151);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "National ID";
            textBox6.Size = new Size(151, 37);
            textBox6.TabIndex = 90;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(786, 151);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Name";
            textBox1.Size = new Size(151, 37);
            textBox1.TabIndex = 82;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(425, 24);
            label9.Name = "label9";
            label9.Size = new Size(361, 54);
            label9.TabIndex = 81;
            label9.Text = "Manage Clients";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(432, 151);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "UserName";
            textBox4.Size = new Size(151, 37);
            textBox4.TabIndex = 93;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(249, 224);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Email";
            textBox3.Size = new Size(151, 37);
            textBox3.TabIndex = 89;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(432, 224);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Phone";
            textBox2.Size = new Size(151, 37);
            textBox2.TabIndex = 88;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(141, 498);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(961, 211);
            dataGridView1.TabIndex = 83;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // address
            // 
            address.Location = new Point(967, 151);
            address.Margin = new Padding(3, 4, 3, 4);
            address.Multiline = true;
            address.Name = "address";
            address.PlaceholderText = "address";
            address.Size = new Size(151, 37);
            address.TabIndex = 95;
            // 
            // Age
            // 
            Age.Location = new Point(819, 224);
            Age.Margin = new Padding(3, 4, 3, 4);
            Age.Multiline = true;
            Age.Name = "Age";
            Age.PlaceholderText = "Age";
            Age.Size = new Size(151, 37);
            Age.TabIndex = 96;
            // 
            // Nationality
            // 
            Nationality.Location = new Point(617, 224);
            Nationality.Margin = new Padding(3, 4, 3, 4);
            Nationality.Multiline = true;
            Nationality.Name = "Nationality";
            Nationality.PlaceholderText = "Nationality";
            Nationality.Size = new Size(151, 37);
            Nationality.TabIndex = 97;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(103, 177, 198);
            button1.Location = new Point(455, 405);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(378, 45);
            button1.TabIndex = 84;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // gender
            // 
            gender.AutoSize = true;
            gender.Location = new Point(644, 237);
            gender.Name = "gender";
            gender.Size = new Size(63, 24);
            gender.TabIndex = 98;
            gender.TabStop = true;
            gender.Text = "Male";
            gender.UseVisualStyleBackColor = true;
            // 
            // UC_EmployeeClient
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(Nationality);
            Controls.Add(Age);
            Controls.Add(address);
            Controls.Add(textBox5);
            Controls.Add(textBox6);
            Controls.Add(textBox1);
            Controls.Add(label9);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UC_EmployeeClient";
            Size = new Size(1253, 851);
            Load += UC_EmployeeClient_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox1;
        private Label label9;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private TextBox address;
        private TextBox Age;
        private TextBox Nationality;
        private Button button1;
        private RadioButton gender;
    }
}

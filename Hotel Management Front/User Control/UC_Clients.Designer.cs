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
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            Age = new TextBox();
            address = new TextBox();
            Nationality = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox3
            // 
            textBox3.Location = new Point(38, 356);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Email";
            textBox3.Size = new Size(151, 37);
            textBox3.TabIndex = 62;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(38, 450);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Phone";
            textBox2.Size = new Size(151, 37);
            textBox2.TabIndex = 61;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(103, 177, 198);
            button4.Location = new Point(1055, 300);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(103, 45);
            button4.TabIndex = 60;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = false;
            // 
            // update
            // 
            update.BackColor = Color.FromArgb(103, 177, 198);
            update.Location = new Point(788, 300);
            update.Margin = new Padding(3, 4, 3, 4);
            update.Name = "update";
            update.Size = new Size(103, 45);
            update.TabIndex = 59;
            update.Text = "Update";
            update.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(103, 177, 198);
            button2.Location = new Point(542, 300);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(103, 45);
            button2.TabIndex = 58;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(103, 177, 198);
            button1.Location = new Point(361, 300);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(103, 45);
            button1.TabIndex = 57;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(286, 421);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(973, 237);
            dataGridView1.TabIndex = 56;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(38, 188);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "UserName";
            textBox1.Size = new Size(151, 37);
            textBox1.TabIndex = 54;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(542, 18);
            label9.Name = "label9";
            label9.Size = new Size(361, 54);
            label9.TabIndex = 53;
            label9.Text = "Manage Clients";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(38, 264);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "ClientId";
            textBox6.Size = new Size(151, 37);
            textBox6.TabIndex = 76;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Male", "Female" });
            comboBox1.Location = new Point(454, 188);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 77;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Male", "Female" });
            comboBox2.Location = new Point(837, 176);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 78;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(38, 116);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "UserName";
            textBox4.Size = new Size(151, 37);
            textBox4.TabIndex = 79;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(38, 536);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Password";
            textBox5.Size = new Size(151, 37);
            textBox5.TabIndex = 80;
            // 
            // Age
            // 
            Age.Location = new Point(38, 621);
            Age.Margin = new Padding(3, 4, 3, 4);
            Age.Multiline = true;
            Age.Name = "Age";
            Age.PlaceholderText = "Age";
            Age.Size = new Size(151, 37);
            Age.TabIndex = 81;
            // 
            // address
            // 
            address.Location = new Point(38, 743);
            address.Margin = new Padding(3, 4, 3, 4);
            address.Multiline = true;
            address.Name = "address";
            address.PlaceholderText = "address";
            address.Size = new Size(151, 37);
            address.TabIndex = 82;
            // 
            // Nationality
            // 
            Nationality.Location = new Point(38, 685);
            Nationality.Margin = new Padding(3, 4, 3, 4);
            Nationality.Multiline = true;
            Nationality.Name = "Nationality";
            Nationality.PlaceholderText = "Nationality";
            Nationality.Size = new Size(151, 37);
            Nationality.TabIndex = 83;
            // 
            // UC_Clients
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(Nationality);
            Controls.Add(address);
            Controls.Add(Age);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "UC_Clients";
            Size = new Size(1471, 865);
            Load += UC_Clients_Load;
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
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox Age;
        private TextBox address;
        private TextBox Nationality;
    }
}

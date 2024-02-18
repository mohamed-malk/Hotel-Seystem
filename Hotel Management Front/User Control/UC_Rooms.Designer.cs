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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            numTxt = new TextBox();
            label9 = new Label();
            rateTxt = new TextBox();
            typeRm = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(103, 177, 198);
            button1.Location = new Point(413, 278);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(240, 45);
            button1.TabIndex = 47;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(119, 388);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(810, 211);
            dataGridView1.TabIndex = 46;
            // 
            // numTxt
            // 
            numTxt.Location = new Point(258, 184);
            numTxt.Margin = new Padding(3, 4, 3, 4);
            numTxt.Multiline = true;
            numTxt.Name = "numTxt";
            numTxt.PlaceholderText = "Num";
            numTxt.Size = new Size(151, 37);
            numTxt.TabIndex = 43;
            numTxt.TextChanged += numTxt_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Baskerville Old Face", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(413, 20);
            label9.Name = "label9";
            label9.Size = new Size(326, 53);
            label9.TabIndex = 42;
            label9.Text = "Manage Rooms";
            // 
            // rateTxt
            // 
            rateTxt.Location = new Point(468, 193);
            rateTxt.Margin = new Padding(3, 4, 3, 4);
            rateTxt.Multiline = true;
            rateTxt.Name = "rateTxt";
            rateTxt.PlaceholderText = "Rate";
            rateTxt.Size = new Size(151, 37);
            rateTxt.TabIndex = 51;
            // 
            // typeRm
            // 
            typeRm.FormattingEnabled = true;
            typeRm.Location = new Point(698, 193);
            typeRm.Margin = new Padding(3, 4, 3, 4);
            typeRm.Name = "typeRm";
            typeRm.Size = new Size(151, 28);
            typeRm.TabIndex = 52;
            // 
            // UC_Rooms
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(typeRm);
            Controls.Add(rateTxt);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(numTxt);
            Controls.Add(label9);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UC_Rooms";
            Size = new Size(1253, 851);
            Load += UC_Rooms_Load;
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
        private TextBox rateTxt;
        private Label label9;
        private TextBox numTxt;
        private ComboBox typeRm;
    }
}

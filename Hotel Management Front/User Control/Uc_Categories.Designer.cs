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
            costTxt = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label9 = new Label();
            typeRm = new ComboBox();
            numTxt = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // costTxt
            // 
            costTxt.Location = new Point(620, 200);
            costTxt.Margin = new Padding(3, 4, 3, 4);
            costTxt.Multiline = true;
            costTxt.Name = "costTxt";
            costTxt.PlaceholderText = "Cost";
            costTxt.Size = new Size(151, 37);
            costTxt.TabIndex = 58;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(103, 177, 198);
            button1.Location = new Point(380, 282);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(199, 45);
            button1.TabIndex = 54;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(260, 384);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(428, 194);
            dataGridView1.TabIndex = 53;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Baskerville Old Face", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(425, 24);
            label9.Name = "label9";
            label9.Size = new Size(358, 53);
            label9.TabIndex = 51;
            label9.Text = "Room Categories";
            // 
            // typeRm
            // 
            typeRm.FormattingEnabled = true;
            typeRm.Location = new Point(411, 209);
            typeRm.Name = "typeRm";
            typeRm.Size = new Size(168, 28);
            typeRm.TabIndex = 59;
            // 
            // numTxt
            // 
            numTxt.Location = new Point(215, 200);
            numTxt.Margin = new Padding(3, 4, 3, 4);
            numTxt.Multiline = true;
            numTxt.Name = "numTxt";
            numTxt.PlaceholderText = "Number";
            numTxt.Size = new Size(151, 37);
            numTxt.TabIndex = 60;
            // 
            // Uc_Categories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            Controls.Add(numTxt);
            Controls.Add(typeRm);
            Controls.Add(costTxt);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label9);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Uc_Categories";
            Size = new Size(1253, 851);
            Load += Uc_Categories_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox costTxt;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label9;
        private ComboBox typeRm;
        private TextBox numTxt;
    }
}

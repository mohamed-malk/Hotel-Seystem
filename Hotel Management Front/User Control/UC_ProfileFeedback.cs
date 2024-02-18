using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Hotel_System_Front.User_Control
{
    public partial class UC_ProfileFeedback : UserControl
    {
        public UC_ProfileFeedback()
        {
            InitializeComponent();
        }
        private void ClearFeedbackForm()
        {
            textBox1.Clear();
            trackBar1.Value = 0;
            trackBar2.Value = 0;
            // Clear other controls as needed
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(@"Feedback submitted successfully!",
                    @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearFeedbackForm();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

            }
        }
    }
}

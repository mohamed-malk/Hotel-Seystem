using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_System_Front.User_Control
{
    public partial class UC_Feedback : UserControl
    {
        public UC_Feedback()
        {
            InitializeComponent();
        }

        private void UC_Feedback_Load(object sender, EventArgs e)
        {
            InformationRepo informationRepo = new InformationRepo();
            dataGridView1.DataSource = informationRepo.Report(DateTime.Now.Month);


        }
    }
}

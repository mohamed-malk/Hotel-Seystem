using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotel_System.Models;

namespace Hotel_System_Front.User_Control
{
    public partial class UC_MyProfile : UserControl
    {
        private Client _currentClient;
        public UC_MyProfile(Client client)
        {
            InitializeComponent();
            _currentClient = client;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UC_MyProfile_Load(object sender, EventArgs e) =>
            dataGridView1.DataSource =
                new List<Client> { _currentClient };
    }
}

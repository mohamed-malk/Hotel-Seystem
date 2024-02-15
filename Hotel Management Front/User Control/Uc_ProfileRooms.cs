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
    public partial class Uc_ProfileRooms : UserControl
    {
        RoomRepo roomRepo = new RoomRepo();
        Client cc = new Client();
        public Uc_ProfileRooms(Client client)
        {
            InitializeComponent();
            cc = client;

        }



        private void Uc_ProfileRooms_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = roomRepo.GetAvailableRooms();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            UC_ProfileReservation profileReservation = new UC_ProfileReservation();
            MyProfile Profile = new MyProfile(cc);

            var result = MessageBox.Show("Confirmed?", "confirmed", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
              
                Profile.addUserControl(profileReservation);
                this.Hide();
                Profile.ShowDialog();
               
            }

        }
    }
}

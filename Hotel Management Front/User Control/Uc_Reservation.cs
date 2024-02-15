using Hotel_System_Back.Models;
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
    public partial class Uc_Reservation : UserControl
    {
        ReservationRepo reserve = new ReservationRepo();
        RoomRepo RoomReserve = new RoomRepo(); 
        ClientRepo ClientRepo = new ClientRepo();
        public Uc_Reservation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //     int clientId, int roomId,
            //float amount, DateTime startDate, DateTime endDate

            int clientid = int.Parse(comboBox2.SelectedItem.ToString());
            int roomid = int.Parse(comboBox1.SelectedItem.ToString());
            float amount = float.Parse(textBox2.Text);
            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;

            
            reserve.ReserveRoom(clientid, roomid, amount, startDate, endDate);

            MessageBox.Show(clientid.ToString());
        }

        private void Uc_Reservation_Load(object sender, EventArgs e)
        {

          

             var rooms = RoomReserve.GetAvailableRooms();
            foreach (Room room in rooms)
            {

                comboBox1.Items.Add(room.Id);
               
               
            }
            
            var clients = ClientRepo.GetAll();
            foreach( Client client in clients)
            {
                comboBox2.Items.Add(client.Id);
               
            }

            dataGridView1.DataSource = reserve.GetReservationList();
        }
    }
}

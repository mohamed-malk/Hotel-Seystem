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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Hotel_System_Front.User_Control
{
    public partial class UC_EmployeeReservation : UserControl
    {
        ReservationRepo reserve = new ReservationRepo();
        RoomRepo RoomReserve = new RoomRepo();
        ClientRepo ClientRepo = new ClientRepo();

        int clientid ;
        int roomid ;
        float amount;
        DateTime startDate;
        DateTime endDate;
        public UC_EmployeeReservation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             clientid = int.Parse(comboBox2.SelectedItem.ToString());
             roomid = int.Parse(comboBox1.SelectedItem.ToString());
             amount = float.Parse(textBox2.Text);
             startDate = dateTimePicker1.Value;
             endDate = dateTimePicker2.Value;


            reserve.ReserveRoom(clientid, roomid, amount, startDate, endDate);
            dataGridView1.DataSource = reserve.GetReservationList();
            // MessageBox.Show(clientid.ToString());
        }

        private void UC_EmployeeReservation_Load(object sender, EventArgs e)
        {

            var rooms = RoomReserve.GetAvailableRooms();
            foreach (Room room in rooms)
            {

                comboBox1.Items.Add(room.Id);


            }

            var clients = ClientRepo.GetAll();
            foreach (Client client in clients)
            {
                comboBox2.Items.Add(client.Id);

            }

            dataGridView1.DataSource = reserve.GetReservationList();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            reserve.GetReservation(clientid, roomid, startDate);
            reserve.CancelReservation(clientid, roomid, startDate);
        }
    }
}

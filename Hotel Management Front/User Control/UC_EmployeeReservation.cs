
namespace Hotel_System_Front.User_Control
{
    public partial class UC_EmployeeReservation : UserControl
    {
        ReservationRepo reserve = new ReservationRepo();
        RoomRepo RoomReserve = new RoomRepo();
        ClientRepo ClientRepo = new ClientRepo();

        int clientid;
        int roomid;
        float amount;
        DateTime startDate;
        DateTime endDate;
        public UC_EmployeeReservation()
        {
            InitializeComponent();
        }
        private void UpdateGridView() =>
            dataGridView1.DataSource = reserve.GetReservationsView();

        private void button1_Click(object sender, EventArgs e)
        {
            clientid = int.Parse(comboBox2.SelectedItem.ToString());
            roomid = int.Parse(comboBox1.SelectedItem.ToString());
            amount = float.Parse(textBox2.Text);
            startDate = dateTimePicker1.Value;
            endDate = dateTimePicker2.Value;

            reserve.ReserveRoom(clientid, roomid, amount, startDate, endDate);

            UpdateGridView();
        }

        private void UC_EmployeeReservation_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();

            var rooms = RoomReserve.GetAvailableRooms();
            foreach (Room room in rooms) comboBox1.Items.Add(room.Id);

            var clients = ClientRepo.GetAll();
            foreach (ClientView client in clients) comboBox2.Items.Add(client.Id);

            UpdateGridView();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            DialogResult result = MessageBox.Show(
                @"Are you sure?", @"Confirmation", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                reserve.CancelReservation(
                    (int)row.Cells[PropertiesNames.ClientId.ToString()].Value,
                    (int)row.Cells[PropertiesNames.RoomId.ToString()].Value,
                    (DateTime)row.Cells[PropertiesNames.ReservationDate.ToString()].Value);
                UpdateGridView();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

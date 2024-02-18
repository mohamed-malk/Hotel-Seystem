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
            try
            {
                dataGridView1.DataSource = roomRepo.GetAvailableRooms();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                UC_ProfileReservation profileReservation = new UC_ProfileReservation();
                MyProfile Profile = new MyProfile(cc);

                var result = MessageBox.Show("Confirmed?", "confirmed", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {

                    Profile.addUserControl(profileReservation);
                    Hide();
                    Profile.ShowDialog();

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

            }
        }
    }
}

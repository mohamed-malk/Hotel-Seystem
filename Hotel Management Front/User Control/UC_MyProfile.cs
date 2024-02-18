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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

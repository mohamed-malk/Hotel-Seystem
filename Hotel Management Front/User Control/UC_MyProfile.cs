using Hotel_System_Back.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Net;
using Hotel_System_Back.Models;

namespace Hotel_System_Front.User_Control
{
    public partial class UC_MyProfile : UserControl
    {
        private Client _currentClient;
        private ClientRepo _currentRepo;
        public UC_MyProfile(Client client)
        {
            InitializeComponent();
            _currentClient = client;
            _currentRepo = new ClientRepo();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UC_MyProfile_Load(object sender, EventArgs e) =>
            dataGridView1.DataSource =
        new List<Client> { _currentClient };

        private void button1_Click(object sender, EventArgs e)
        {
            _currentRepo.Update(_currentClient.Id, new Dictionary<PropertiesNames, object>
            {
                [PropertiesNames.Address] = address.Text,
                [PropertiesNames.Password] = password.Text,
                [PropertiesNames.Name] = name.Text,
                [PropertiesNames.Nationality] = nationality.Text
            }); 
            dataGridView1.DataSource =
                new List<Client> { _currentClient };
        }
    }
}

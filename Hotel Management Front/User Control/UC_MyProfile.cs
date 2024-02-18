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

        private void FillNull()
        {
            password.Text = password.Text.Length == 0 ? 
                _currentClient.Password : password.Text;

            ageTxt.Text = ageTxt.Text.Length == 0 ?
                _currentClient.Age.ToString() : ageTxt.Text;

            name.Text = name.Text.Length == 0 ?
                _currentClient.Name : name.Text;

            nationality.Text = nationality.Text.Length == 0 ?
                _currentClient.Nationality : nationality.Text;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                FillNull();
                _currentClient = _currentRepo.Update(_currentClient.Id, new Dictionary<PropertiesNames, object>
                {
                    [PropertiesNames.Age] = int.Parse(ageTxt.Text),
                    [PropertiesNames.Password] = password.Text,
                    [PropertiesNames.Name] = name.Text,
                    [PropertiesNames.Nationality] = nationality.Text
                });
                dataGridView1.DataSource =
                    new List<Client> { _currentClient };
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}

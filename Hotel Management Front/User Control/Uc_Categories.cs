namespace Hotel_System_Front.User_Control
{
    public partial class Uc_Categories : UserControl
    {
        private readonly RoomRepo _roomRepo;
        public Uc_Categories()
        {
            InitializeComponent();
            _roomRepo = new RoomRepo();
        }

        private List<RoomType> GetTypes() =>
        [
            Hotel_System_Back.Models.RoomType.Single,
            Hotel_System_Back.Models.RoomType.Double,
            Hotel_System_Back.Models.RoomType.Triple
        ];
        private void LoadData() =>
            dataGridView1.DataSource = _roomRepo.GetRoomList();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _roomRepo.Add(new Room
                {
                    Number = int.Parse(numTxt.Text),
                    IsAvailable = true,
                    Type = (RoomType)typeRm.SelectedValue!
                });

                LoadData();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        private void Uc_Categories_Load(object sender, EventArgs e)
        {
            try
            {
                typeRm.DataSource = GetTypes();
                LoadData();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }
        }
    }
}

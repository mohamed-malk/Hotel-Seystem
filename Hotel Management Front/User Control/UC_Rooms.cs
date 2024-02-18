namespace Hotel_System_Front.User_Control
{
    public partial class UC_Rooms : UserControl
    {
        private readonly RoomRepo _roomRepo;
        public UC_Rooms()
        {
            InitializeComponent();
            _roomRepo = new RoomRepo();
        }
        private List<RoomType> GetTypes() =>
        [
            RoomType.Single, RoomType.Double,
                RoomType.Triple
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
                    Type = (RoomType)typeRm.SelectedValue!,
                    Rate = int.Parse(rateTxt.Text)
                });

                LoadData();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void numTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void UC_Rooms_Load(object sender, EventArgs e)
        {
            try
            {
                typeRm.DataSource = GetTypes();
                LoadData();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }

}

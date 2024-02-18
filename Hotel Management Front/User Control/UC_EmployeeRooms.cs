namespace Hotel_System_Front.User_Control
{
    public partial class UC_EmployeeRooms : UserControl
    {
        public UC_EmployeeRooms()
        {
            InitializeComponent();
            comboBox2.Items.Add("True");
            comboBox2.Items.Add("False");
            comboBox1.Items.Add("Single");
            comboBox1.Items.Add("Double");
            comboBox1.Items.Add("Trible");
        }
        RoomRepo room2 = new RoomRepo();
        private void button1_Click(object sender, EventArgs e)
        {
            string type;
            int Number = int.Parse(textBox1.Text);
            int Rate = int.Parse(textBox2.Text);
            if (comboBox2.Text == "Single")
            {
                type = "1";

            }
            else if (comboBox2.Text == "Double")
            {
                type = "2";
            }
            else
            {
                type = "3";
            }

            RoomType type2 = (RoomType)Enum.Parse(typeof(RoomType), type);


            bool IsAvailable = comboBox2.Text == "False" ? true : false;
            Room r2 = new Room()
            {
                Number = Number,
                Rate = Rate,
                Type = type2,

            };
            room2.Add(r2); ;
            //ClientRepo ClientRepo = new ClientRepo();

            dataGridView1.DataSource = new List<Room> { r2};
        }
    }
}

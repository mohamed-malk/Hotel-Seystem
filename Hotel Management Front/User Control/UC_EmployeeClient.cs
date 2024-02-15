namespace Hotel_System_Front.User_Control
{
    public partial class UC_EmployeeClient : UserControl
    {
        private int id = -1;
        public UC_EmployeeClient()
        {
            InitializeComponent();
            comboBox1.Items.Add("Famael,f");
            comboBox1.Items.Add("male,m");
        }
        private readonly ClientRepo _clientRepo = new ClientRepo();

        private void UpdateGrid() =>
            dataGridView1.DataSource = _clientRepo.GetAll();

        private void button1_Click(object sender, EventArgs e)
        {
            string Nid = textBox6.Text;
            string name = textBox4.Text;
            string username = textBox1.Text;
            string password = textBox5.Text;
            string email = textBox3.Text;
            string Address = address.Text;
            int age = int.Parse(Age.Text);


            bool gender = comboBox1.Text == @"Famael,f";
            string nationaltiy = Nationality.Text;

            if (id != -1)
            {
                _clientRepo.Update(id, new Dictionary<PropertiesNames, object>
                {
                    [PropertiesNames.Address] = Address,
                    [PropertiesNames.Age] = age,
                    [PropertiesNames.Gender] = gender,
                    [PropertiesNames.Email] = email,
                    [PropertiesNames.Nationality] = nationaltiy,
                    [PropertiesNames.Password] = password,
                    [PropertiesNames.UserName] = username,
                    [PropertiesNames.Name] = name
                });
                button1.Text = @"Add";
                id = -1;
            }
            else
                _clientRepo.Add(new Client
                {
                    Name = name,
                    NId = Nid,
                    Address = Address,
                    Age = age,
                    Email = email,
                    Gender = gender,
                    UserName = username,
                    Password = password,
                    Nationality = nationaltiy
                });

            UpdateGrid();
        }

        private void UC_EmployeeClient_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                @"Update Yes or Delete No?", @"Question",
                MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                textBox6.Text = dataGridView1.Rows[e.RowIndex]
                    .Cells[PropertiesNames.NId.ToString()].Value.ToString();
                
                textBox4.Text = dataGridView1.Rows[e.RowIndex]
                    .Cells[PropertiesNames.Name.ToString()].Value.ToString();
                
                textBox1.Text = dataGridView1.Rows[e.RowIndex]
                    .Cells[PropertiesNames.UserName.ToString()].Value.ToString();
                
                textBox5.Text= dataGridView1.Rows[e.RowIndex]
                    .Cells[PropertiesNames.Password.ToString()].Value.ToString();
                
                textBox3.Text = dataGridView1.Rows[e.RowIndex]
                    .Cells[PropertiesNames.Email.ToString()].Value.ToString();
                
                address.Text = dataGridView1.Rows[e.RowIndex]
                    .Cells[PropertiesNames.Address.ToString()].Value.ToString();
                
                Age.Text = dataGridView1.Rows[e.RowIndex]
                    .Cells[PropertiesNames.Age.ToString()].Value.ToString();

                id = (int)dataGridView1
                    .Rows[e.RowIndex]
                    .Cells[PropertiesNames.Id.ToString()].Value;
                button1.Text = @"Update";
            }
            else if(result == DialogResult.No)
            {
                _clientRepo.Delete((int)dataGridView1
                    .Rows[e.RowIndex]
                    .Cells[PropertiesNames.Id.ToString()].Value);
            }

            UpdateGrid();
        }
    }
}


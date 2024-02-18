namespace Hotel_System_Front.User_Control
{
    public partial class UC_EmployeeClient : UserControl
    {

        private readonly ClientRepo _clientRepo;
        private int id = -1;
        private readonly int _empId;
        public UC_EmployeeClient(int empId)
        {
            InitializeComponent();
            _clientRepo = new ClientRepo();
            _empId = empId;
        }

        private void UpdateGrid() =>
            dataGridView1.DataSource = _clientRepo.GetAll();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Nid = textBox6.Text;
                string name = textBox4.Text;
                string username = textBox1.Text;
                string password = textBox5.Text;
                string email = textBox3.Text;
                string Address = address.Text;
                int age = int.Parse(Age.Text);

                string nationaltiy = Nationality.Text;

                if (id != -1)
                {
                    _clientRepo.Update(id, new Dictionary<PropertiesNames, object>
                    {
                        [PropertiesNames.Address] = Address,
                        [PropertiesNames.Age] = age,
                        [PropertiesNames.Gender] = gender.Checked,
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
                        Gender = gender.Checked,
                        UserName = username,
                        Password = password,
                        Nationality = nationaltiy
                    });

                UpdateGrid();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void UC_EmployeeClient_Load(object sender, EventArgs e)
        {
            try
            {
                UpdateGrid();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_empId == Employee.ManagerId)
            {
                try
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

                        textBox5.Text = dataGridView1.Rows[e.RowIndex]
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
                    else if (result == DialogResult.No)
                    {
                        _clientRepo.Delete((int)dataGridView1
                            .Rows[e.RowIndex]
                            .Cells[PropertiesNames.Id.ToString()].Value);
                    }

                    UpdateGrid();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            else
            {
                MessageBox.Show(@"You are not allowed to delete or edit Clients");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


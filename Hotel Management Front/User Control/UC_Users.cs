namespace Hotel_System_Front.User_Control
{
    public partial class UC_Users : UserControl
    {
        private readonly EmployeeRepo _employeeRepo;
        private int id = -1;
        public UC_Users()
        {
            InitializeComponent();
            _employeeRepo = new EmployeeRepo();
        }

        private void UpdateGrid()
        {
            dataGridView1.DataSource = _employeeRepo.GetAllShow();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string Nid = textBox4.Text;
                string name = textBox1.Text;
                string username = textBox3.Text;
                string password = textBox2.Text;
                string email = textBox5.Text;
                int age = int.Parse(textBox8.Text);
                int attend = int.Parse(textBox10.Text);
                string Address = textBox6.Text;
                float salary = float.Parse(textBox7.Text);


                if (id != -1)
                {
                    _employeeRepo.Update(id, new Dictionary<PropertiesNames, object>
                    {
                        [PropertiesNames.Address] = Address,
                        [PropertiesNames.Age] = age,
                        [PropertiesNames.Gender] = gender.Checked,
                        [PropertiesNames.Email] = email,
                        [PropertiesNames.Attend] = attend,
                        [PropertiesNames.Salary] = salary,
                        [PropertiesNames.Password] = password,
                        [PropertiesNames.UserName] = username,
                        [PropertiesNames.Name] = name
                    });
                    button1.Text = @"Add";
                    id = -1;
                }
                else
                    _employeeRepo.Add(new Employee
                    {
                        Name = name,
                        NId = Nid,
                        Address = Address,
                        Age = age,
                        Email = email,
                        Gender = gender.Checked,
                        UserName = username,
                        Password = password,
                        Salary = salary,
                        Attend = attend
                    });

                UpdateGrid();
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

                    textBox10.Text = dataGridView1.Rows[e.RowIndex]
                        .Cells[PropertiesNames.Attend.ToString()].Value.ToString();

                    textBox8.Text = dataGridView1.Rows[e.RowIndex]
                        .Cells[PropertiesNames.Age.ToString()].Value.ToString();

                    textBox7.Text = dataGridView1.Rows[e.RowIndex]
                        .Cells[PropertiesNames.Salary.ToString()].Value.ToString();

                    id = (int)dataGridView1
                        .Rows[e.RowIndex]
                        .Cells[PropertiesNames.Id.ToString()].Value;
                    button1.Text = @"Update";
                }
                else if (result == DialogResult.No)
                {
                    _employeeRepo.Delete((int)dataGridView1
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

        private void UC_Users_Load(object sender, EventArgs e)
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
    }
}

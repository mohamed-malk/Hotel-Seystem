using Hotel_System_Back.Services;

namespace Hotel_System_Front.User_Control
{
    public partial class UC_EmployeeProfile : UserControl
    {
        readonly Employee _employee;
        readonly EmployeeRepo _employeeRepo;
        public UC_EmployeeProfile(Employee employee)
        {
            InitializeComponent();
            _employeeRepo = new();
            _employee = employee;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  _employee = u.UpdateProfile(employee);
            // dataGridView1.DataSource = new List<Employee> { _employee };
        }

        private void UC_EmployeeProfile_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new List<Employee> { _employee };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _employeeRepo.Update(_employee);
        }
    }
}

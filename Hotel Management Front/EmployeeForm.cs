using Hotel_System_Front.User_Control;

namespace Hotel_System_Front
{
    public partial class EmployeeForm : Form
    {
        Employee _employee;
        public EmployeeForm(Employee employee)
        {
            InitializeComponent();
            _employee = employee;
            UC_EmployeeProfile uc = new UC_EmployeeProfile(_employee);
            addUserControl(uc);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer3.Controls.Clear();
            panelContainer3.Controls.Add(userControl);
            userControl.BringToFront();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UC_EmployeeProfile uc = new UC_EmployeeProfile(_employee);
            addUserControl(uc);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            UC_EmployeeRooms uc = new UC_EmployeeRooms();
            addUserControl(uc);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UC_EmployeeClient uc = new UC_EmployeeClient();
            addUserControl(uc);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UC_EmployeeReservation uc = new UC_EmployeeReservation();
            addUserControl(uc);

        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login secondForm = new Login();
            secondForm.ShowDialog();
            this.Show();
        }
    }
}

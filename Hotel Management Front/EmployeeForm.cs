using Hotel_System_Front.User_Control;

namespace Hotel_System_Front
{
    public partial class EmployeeForm : Form
    {
        Employee _employee;
        public EmployeeForm(Employee employee)
        {
            InitializeComponent();
            try
            {
                _employee = employee;
                UC_EmployeeProfile uc = new UC_EmployeeProfile(_employee);
                addUserControl(uc);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

            }
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
            try
            {
                UC_EmployeeProfile uc = new UC_EmployeeProfile(_employee);
                addUserControl(uc);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                UC_EmployeeClient uc = new UC_EmployeeClient();
                addUserControl(uc);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                UC_EmployeeReservation uc = new UC_EmployeeReservation();
                addUserControl(uc);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Login secondForm = new Login();
                secondForm.ShowDialog();
                //this.Show();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

            }
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Exit();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }
    }
}

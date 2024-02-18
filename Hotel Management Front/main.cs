using Hotel_System_Front.User_Control;

namespace Hotel_System_Front
{
    public partial class main : Form
    {
        Employee _employee;
        public main(Employee employee)
        {
            InitializeComponent();
            _employee = employee;

            try
            {
                UC_Dasboard db = new UC_Dasboard(_employee);
                addUserControl(db);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                UC_Rooms uc = new UC_Rooms();
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
                UC_EmployeeClient uc = new UC_EmployeeClient(_employee.Id);
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
                UC_Users uc = new UC_Users();
                addUserControl(uc);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Uc_Reservation uc = new Uc_Reservation();
                addUserControl(uc);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Reports uc = new Reports();
                addUserControl(uc);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                UC_Dasboard uc = new UC_Dasboard(_employee);
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
    }
}

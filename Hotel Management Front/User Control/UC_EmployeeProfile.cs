namespace Hotel_System_Front.User_Control
{
    public partial class UC_EmployeeProfile : UserControl
    {
        Employee _employee;
        public UC_EmployeeProfile(Employee employee)
        {
            InitializeComponent();

            _employee = employee;
        }
    }
}

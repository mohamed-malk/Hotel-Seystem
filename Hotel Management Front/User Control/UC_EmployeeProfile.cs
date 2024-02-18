namespace Hotel_System_Front.User_Control
{
    public partial class UC_EmployeeProfile : UserControl
    {
        readonly Employee _employee;
        readonly EmployeeRepo _employeeRepo;
        
        public UC_EmployeeProfile(Employee employee)
        {
            InitializeComponent();
            
            _employeeRepo = new EmployeeRepo();
            _employee = employee;
            
        }

        private void UpdateView()
        {
            EmployeeView employeeView = _employeeRepo.GetByIdView(_employee.Id)!.Value;
            
            dataGridView1.DataSource = new List<EmployeeView>
                {  employeeView};
        }

        private void UC_EmployeeProfile_Load(object sender, EventArgs e)
        {
            try
            {
                UpdateView();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

            }
        }
    }
}

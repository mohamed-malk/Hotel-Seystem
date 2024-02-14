namespace Hotel_System_Front
{
    public partial class Login : Form
    {
        PersonRepo personRepo = new ClientRepo();
        public Login()
        {
            InitializeComponent();
            Login1.Click += button1_Click;

        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register secondForm = new Register();
            secondForm.ShowDialog();
            // Show the second form
            this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(Username.Text.Trim()))

            {
                errorProvider1.SetError(Username, "User is required");
                return; }
            else
            {
                errorProvider1.SetError(Username, string.Empty);
            }

            if (string.IsNullOrEmpty(Password.Text.Trim()))

            {
                errorProvider1.SetError(Password, "Please Enter Password");
                return;
            }
            else
            {
                errorProvider1.SetError(Password, string.Empty);
            }
            
            Person? person = personRepo.Login(Username.Text, Password.Text);
            
            if (person != null)
            { 
                if (person.ObjectName == UserType.Client)
                {
                    this.Hide();
                    MyProfile secondForm = new MyProfile((Client)person);
                    secondForm.ShowDialog();
                    this.Show();
                }
                else if (person.ObjectName == UserType.Employee)
                {
                  if(person.Id == Employee.ManagerId) 
                    {
                        this.Hide();
                        main secondForm = new main((Employee)person);
                        secondForm.ShowDialog();
                        this.Show();

                    }
                    else
                    {
                        this.Hide();
                        EmployeeForm secondForm = new((Employee)person);
                        secondForm.ShowDialog();
                        this.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Incorrect username or password") ;
            }
        }

    }
}

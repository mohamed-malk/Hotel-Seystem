namespace Hotel_System_Back.Models
{
    public partial class Employee
    {
        public Employee()
        {

        }
        public Employee(Employee targetEmployee)
        {
            Email = targetEmployee.Email;
            UserName = targetEmployee.UserName;
            Password = targetEmployee.Password;
            
            NId = targetEmployee.NId;
            Name = targetEmployee.Name;
            Gender = targetEmployee.Gender;
            Address = targetEmployee.Address;
            Age = targetEmployee.Age;

            Salary = targetEmployee.Salary;
            Attend = targetEmployee.Attend;
        }
        
        public void Update(string userName, string email, string password,
            string nId, string name, int age, bool gender, string address,
            int attend, float salary)
        {
            Update(userName, email, password, nId,  name,  age,  gender,  address);
            Salary = salary;
            Attend = attend;
        }
    }
}
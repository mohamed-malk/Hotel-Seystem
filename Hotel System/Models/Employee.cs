namespace Hotel_System.Models
{
    public partial class Employee : Person
    {
        public static int ManagerId => 1;
        public int Attend { get; set; }
        public float Salary { get; set; }

        public override string ObjectName { get; } = "Employee";
    }
}

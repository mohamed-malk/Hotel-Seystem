namespace Hotel_System_Back.Models
{
    public partial class Employee : Person
    {
        public static int ManagerId => Unity.MangerId;
        public int Attend { get; set; }
        public float Salary { get; set; }

        public override UserType ObjectName { get; } = UserType.Employee;
    }
}

using Hotel_System.Models;

namespace Hotel_System
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new DashBoard());

            HotelDbContext dbContext = new();

            //dbContext.Employees.ChangeManager(dbContext.Employees.Find(6)!);
            //dbContext.SaveChanges();

            MessageBox.Show(
                dbContext.People.Login("mohMalk", "Mohamed23Malk26").ToString()
            );
            //MessageBox.Show(dbContext.Employees.Find(5)!.Name);
            //dbContext.Clients.Filter(e => e.Age == 50);

            //dbContext.Employees.Add(new Employee
            //{
            //    Address = "Cairo"
            //})
        }
    }
}
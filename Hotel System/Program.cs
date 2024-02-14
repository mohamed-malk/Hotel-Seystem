using Hotel_System.Services;

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
            EmployeeRepo employeeRepo = new EmployeeRepo();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new DashBoard());

            ReservationRepo repo = new ReservationRepo();

            repo.ReserveRoom(7, 3, 500,
                DateTime.Today.Add(
                    new TimeSpan(1, 0, 0, 0)), 
                DateTime.Today.Add(
                new TimeSpan(10, 0, 0, 0)
                ));
        }
    }
}
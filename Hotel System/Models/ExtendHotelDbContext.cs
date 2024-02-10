namespace Hotel_System.Models
{
    public partial class HotelDbContext
    {
        public static string GetValue(string key) =>
            CommonTable.Single(c => c.Key == key).Value;
    }
}

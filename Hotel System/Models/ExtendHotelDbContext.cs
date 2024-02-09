namespace Hotel_System.Models
{
    public partial class HotelDbContext
    {
        public string this[string key] =>
            CommonTable.Single(c => c.Key == key).Value;
    }
}

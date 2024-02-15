namespace Hotel_System_Back.Models
{
    public class TransactionTable
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int RoomNumber { get; set; }
        public bool IsCompleted { get; set; }
        public float Paid { get; set; }
        public float Rest { get; set; }
    }
}

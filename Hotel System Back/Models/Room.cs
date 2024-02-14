using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel_System_Back.Models
{
    public enum RoomType : byte
    {
        Single = 1, Double, Triple
    }
    
    public partial class Room
    {
        #region Proprities

        public int Id { get; set; }
        public int Number { get; set; }
        public int Rate { get; set; }
        public RoomType Type { get; set; }
        public bool IsAvailable { get; set; }

        [NotMapped] // Not Convert to SQL Table
        public float Price =>
            float.Parse(
                new HotelDbContext().CommonTable.Find(Unity.RoomPrice)!.Value
                ) * (int)Type;

        #endregion

        // Reduce Join
        public virtual ICollection<Reservation>? Reservations { get; set; }
            = new HashSet<Reservation>();
    }
}

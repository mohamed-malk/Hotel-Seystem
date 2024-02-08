namespace Hotel_System.Models
{
    public class Reservation
    {

        #region Relation Proprities

        public DateTime ReservationDate { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
       
        #endregion

        #region Relation Mapping

        public int ClientId { get; set; }
        public virtual Client Client { get; set; } = null!;

        public int RoomId { get; set; }
        public virtual Room Room { get; set; } = null!;

        public int PaymentId { get; set; }
        public virtual Payment Payment { get; set; } = null!;

        #endregion
    }
}

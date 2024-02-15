namespace Hotel_System_Back.ModelViews
{
    public readonly struct ReservationView(
        DateTime reservationDate, DateTime checkInDate,
        DateTime checkOutDate, int durationDays,
        int clientId, string clientName, int roomId,
        int roomNumber, int paymentId, DateTime paymentDate, 
        float coast, float rest)
    {
        public DateTime ReservationDate => reservationDate;
        public DateTime CheckInDate => checkInDate;
        public DateTime CheckOutDate => checkOutDate;
        public int DurationDays => durationDays;

        public int ClientId => clientId;
        public string ClientName => clientName;

        public int RoomId => roomId;
        public int RoomNumber => roomNumber;

        public int PaymentId => paymentId;
        public DateTime PaymentDate => paymentDate;
        public float Coast => coast;
        public float Rest => rest;
    }
}

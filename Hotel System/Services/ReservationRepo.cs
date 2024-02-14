using Microsoft.EntityFrameworkCore;

namespace Hotel_System.Services;
public class ReservationRepo
{
    private readonly HotelDbContext _dbContext = new();
    
    public bool ReserveRoom(int clientId, int roomId,
       float amount, DateTime startDate, DateTime endDate)
    {
        #region Check

        Room? room = _dbContext.Rooms.Find(roomId);
        if (room == null || !room.IsAvailable) // Room not found or already occupied
            throw Exceptions.NotFoundException("Room");

        Client? client = _dbContext.Clients.Find(clientId);
        if (client == null)
            throw Exceptions.NotFoundException("Client");

        if (amount > room.Price)
            throw new Exception("Amount higher than Room Price");

        #endregion

        #region Reservation

        Reservation reservation = new()
        {
            ClientId = clientId,
            RoomId = roomId,
            CheckInDate = startDate,
            CheckOutDate = endDate
        };

        // Add payment to the Reservation
        Payment payment = new()
        {
            ClientId = clientId,
            Date = DateTime.Now,
            Amount = amount,
            TargetAmount = room.Price * reservation.DurationDays
        };
        _dbContext.Payments.Add(payment);
        _dbContext.SaveChanges(); // Save Payment First

        Payment? paymentDb = _dbContext.Payments
            .SingleOrDefault(p => p.ClientId == clientId
                                  && p.Date == payment.Date);

        if (paymentDb != null)
            reservation.PaymentId = paymentDb.Id;
        else throw new("Something Wrong !");

        #endregion

        #region Update Necessery Data

        // Reserve the room
        room.IsAvailable = false;
        client.UpdatePoints(client.Points + 1); // Add point for user  

        // Update in Db sets and DB 
        _dbContext.Reservations.Add(reservation);
        _dbContext.Clients.Update(client);
        _dbContext.Rooms.Update(room);

        _dbContext.SaveChanges();

        #endregion

        return true;
    }
    public void CancelReservation(int clintId, int roomId, DateTime date)
    {
        Reservation? reservation = _dbContext.Reservations
            .Include(r => r.Payment)
            .FirstOrDefault(r =>
                r.ClientId == clintId && r.RoomId == roomId
                                      && r.ReservationDate == date);

        if (reservation == null)
            throw Exceptions.NotFoundException("Reservation");

        if (reservation.Payment.Rest != 0)
            throw new Exception("Cant Remove this Reservation, " +
                                "because there are Rest Money");

        Room? room = _dbContext.Rooms.Find(reservation.RoomId);
        if (room != null)
            room.IsAvailable = true; // Mark the room as not occupied
        else throw new Exception("Room Doesn't Exist, Something Wrong");

        _dbContext.Rooms.Update(room);
        _dbContext.Reservations.Remove(reservation);
        _dbContext.SaveChanges();
    }
    public List<Reservation> GetReservationList() =>
        _dbContext.Reservations.ToList();

    public List<Payment> GetPaymentList() =>
        _dbContext.Payments.ToList();
}
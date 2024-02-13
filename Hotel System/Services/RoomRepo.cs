using Hotel_System.Models;
using Microsoft.EntityFrameworkCore;

namespace Hotel_System.Services
{
    public class RoomRepo
    {
        private readonly HotelDbContext _dbContext = new();
        
        public void Add(Room room)
        {
            // Check if room number already exists
            if (_dbContext.Rooms.Any(r => r.Number == room.Number))
                throw Exceptions.AlreadyExistException("Room");

            _dbContext.Rooms.Add(room);
            _dbContext.SaveChangesAsync();
        }

        public bool ReserveRoom(int clientId, int roomId,
            float amount, DateTime startDate, DateTime endDate)
        {
            Room? room = _dbContext.Rooms.Find(roomId);
            if (room == null || !room.IsAvailable)
            {
                // Room not found or already occupied
                return false;
            }

            if (amount > room.Price)
                throw new Exception("Amount higher than Room Price");

            Reservation reservation = new()
            {
                ClientId = clientId,
                RoomId = roomId,
                CheckInDate = startDate,
                CheckOutDate = endDate
            };
            Payment payment = new()
            {
                ClientId = clientId,
                Date = DateTime.Now,
                Amount = amount,
                TargetAmount = room.Price * reservation.DurationDays
            };
            _dbContext.Payments.Add(payment);
            _dbContext.SaveChanges();

            Payment? paymentDb = _dbContext.Payments
                .SingleOrDefault(p => p.ClientId == clientId && p.Date == payment.Date);

            if (paymentDb != null)
                reservation.PaymentId = paymentDb.Id;
            else throw new("Something Wrong !");

            // Reserve the room
            room.IsAvailable = false;


            _dbContext.Reservations.Add(reservation);
            _dbContext.Rooms.Update(room);
            
            _dbContext.SaveChanges();
            return true;
        }

        public void CancelReservation(int clintId, int roomId,  DateTime date)
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
    }

}


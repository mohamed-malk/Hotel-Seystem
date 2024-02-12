using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_System.Models
{
    public class RoomRepository
    {
        private readonly HotelDbContext _context ;

        public RoomRepository(HotelDbContext context)
        {
            _context = context;
        }
        public bool AddRoom(Room room)
        {
            // Check if room number already exists
            if ( _context.Rooms.Any(r => r.Number == room.Number))
            {
                return false; // Room number already exists
            }

            _context.Rooms.Add(room);
            _context.SaveChangesAsync();
            return true;
        }

        public bool ReserveRoom(float amount, float targetAmount,int clientId, int roomId, DateTime startDate, DateTime endDate ,DateTime ReservationDate)
        {
            var room =  _context.Rooms.Find(roomId);
            if (room == null || ! room.IsAvailable)
            {
                // Room not found or already occupied
                return false;
            }

            // Reserve the room
            room.IsAvailable = false;

            var roomRes = new Reservation
            {
                ClientId = clientId,
                RoomId = roomId,
                CheckInDate = startDate,
                CheckOutDate = endDate,
                Payment = new Payment
                {
                    Amount = amount,
                    TargetAmount = targetAmount
                }
            };
            _context.Reservations.Add(roomRes);
            _context.Payments.Add(roomRes.Payment);
            _context.SaveChanges();
            return true;
        }
        

        public bool CancelReservation(int reservationId)
            {
                var reservation =  _context.Reservations.Find(reservationId);
                if (reservation == null)
                {
                    return false; // Reservation not found
                }

                var room = _context.Rooms.Find(reservation.RoomId);
                if (room != null)
                {
                    room.IsAvailable = true; // Mark the room as not occupied
                }

                _context.Reservations.Remove(reservation);
                _context.SaveChanges();
                return true;
            }
       

    }

    }


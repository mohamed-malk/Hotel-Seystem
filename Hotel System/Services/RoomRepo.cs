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
            _dbContext.SaveChanges();
        }

        public List<string> GetRoomList() =>
            _dbContext.Rooms.Select(room =>
                $"{room.Id} " +
                $"{room.Number} " +
                $"{room.Rate} " +
                $"{room.Type} " +
                $"{room.IsAvailable}").ToList();
    }

}


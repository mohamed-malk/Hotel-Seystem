namespace Hotel_System_Back.Services;
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

    public List<Room> GetRoomList() => _dbContext.Rooms.ToList();
    public List<Room> GetAvailableRooms() => _dbContext.Rooms
        .Filter(r => r.IsAvailable == true).ToList();
}

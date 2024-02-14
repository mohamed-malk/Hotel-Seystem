using System.Collections.Generic;

namespace Hotel_System_Back.Services
{
    public readonly struct MemberShipClients
        (string memberShipName, int clientsNumber)
    {
        public string MemberShipName { get; } = memberShipName;
        public int ClientsNumber { get; } = clientsNumber;
    }

    public class InformationRepo
    {
        private readonly HotelDbContext _dbContext = new();

        public List<TransactionTable> Report(DateTime? dataTime = null) =>
            _dbContext.TransactionTable
                .Filter(t => t.Date == dataTime).ToList();
        public List<MemberShipClients> ClientsCategory() =>
            (from memberShip in _dbContext.Memberships
                join client in _dbContext.Clients
                    on memberShip.Id equals client.MemberShipId into result
                select new MemberShipClients(memberShip.Name, result.Count())).ToList();
        public Dictionary<string, float> Insights(DateTime? dataTime = null)
        {
            var data = Report(dataTime);
            Dictionary<string, float> res = new()
            {
                { "Total Income", data.Sum(t => t.Paid + t.Rest) },
                { "Actual Income", data.Sum(t => t.Paid) },
                { "Out Income", data.Sum(t => t.Rest) }
            };
            return res;
        }

        public List<int> TopRooms(int top) =>
            _dbContext.Rooms.Take(top)
                .Select(tR => tR.Number).ToList();
        public List<int> LastRooms(int tail) =>
            _dbContext.Rooms.Take(tail)
                .Select(tR => tR.Number).ToList();
    }
}

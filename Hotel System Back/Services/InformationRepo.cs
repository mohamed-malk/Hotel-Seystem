using Hotel_System_Back.Models;

namespace Hotel_System_Back.Services
{
    public class InformationRepo
    {
        private readonly HotelDbContext _dbContext = new();

        public List<TransactionTable> Report() => 
            _dbContext.TransactionTable.ToList();
        public List<TransactionTable> Report(DateTime dataTime) =>
            _dbContext.TransactionTable
                .Filter(t => t.Date == dataTime).ToList();

        public List<object> ClientsCategory()
        {

            var groupedClients =
                (from memberShip in _dbContext.Memberships
                join client in _dbContext.Clients 
                    on memberShip.Id equals client.MemberShipId into result
                select new
                {
                    MemberShipName = memberShip.Name,
                    ClientsNumber = result.Count()
                }).ToList();



            return new();
        }
    }
}

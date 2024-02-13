using Hotel_System.Models;

namespace Hotel_System.Services
{
    internal class ClientRepo : PersonRepo
    {

        private readonly HotelDbContext _dbContext = new();

        public void Add(Client client)
        {
            _dbContext.Clients.Add(client);
            _dbContext.SaveChanges();
        }

        public override void Delete(int id)
        {
            Client? client = GetById(id);
            
            if (client != null) Delete(client);
            else throw Exceptions.NotFoundException("Client");
        }
        public override void Delete(string nId)
        {
            Client? client = _dbContext.Clients
                .SingleOrDefault(c => c.NId == nId);
            
            if (client != null) Delete(client);
            else throw Exceptions.NotFoundException("Client");
        }
        public void Delete(Client client)
        {
            _dbContext.Clients.Remove(client);
            _dbContext.SaveChanges();
        }

        public List<Client> GetAll() => _dbContext.Clients.ToList();
        public override Client? GetById(int id) => _dbContext.Clients.Find(id);
        public List<Client> GetByName(string name)
            => _dbContext.Clients.Filter(c =>
                c.Name.ToLower() == name.ToLower()).ToList();
        public List<Client> GetByNamePattern(string pattern)
            => _dbContext.Clients.Filter(c =>
                c.Name.ToLower().Contains(pattern.ToLower())).ToList();
        public List<Client> GetByAddress(string address)
            => _dbContext.Clients.Filter(c =>
                c.Address.ToLower() == address.ToLower()).ToList();

        public void Update(Client client)
        {
            _dbContext.Clients.Update(client);
            _dbContext.SaveChanges();
        }
        public override Client Update(int id,
            Dictionary<Properties, object> newValues)
        {

            Dictionary<Properties, object> perValues = newValues;
            perValues.Remove(Properties.MemberShipId);
            perValues.Remove(Properties.Nationality);
            perValues.Remove(Properties.Points);
            Client client = (Client)base.Update(id, perValues);

            foreach (var item in newValues)
            {
                switch (item.Key)
                {
                    case Properties.MemberShipId:
                        client.MemberShipId = (int)item.Value;
                        break;
                    case Properties.Nationality:
                        client.Nationality = (string)item.Value;
                        break;
                    case Properties.Points:
                        client.Points = (int)item.Value;
                        break;
                    default:
                        throw Exceptions.NotFoundProperty(item.Key.ToString());
                }
            }
            
            _dbContext.Clients.Update(client);
            _dbContext.SaveChanges();
            return client;
        }
    }
}

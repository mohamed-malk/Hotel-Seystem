using Hotel_System.Models;

namespace Hotel_System.Services;

public class ClientRepo : PersonRepo
{
    private readonly HotelDbContext _dbContext = new();

    /// <summary>
    /// Add new Client 
    /// </summary>
    /// <param name="client">client object</param>
    public void Add(Client client)
    {
        _dbContext.Clients.Add(client);
        _dbContext.SaveChanges();
    }

    /// <summary>
    /// For Registration
    /// </summary>
    public Client Add(string userName, string email, 
        string password, string nId)
    {
        Client client = new()
        {
            UserName = userName,
            Email = email,
            Password = password,
            Address = "",
            Name = "",
            NId = nId,
            Nationality = ""
        };

        _dbContext.Clients.Add(client);
        _dbContext.SaveChanges();

        return client;
    }

    /// <summary>
    /// Delete Client By Id
    /// </summary>
    /// <param name="id">Client Id</param>
    public override void Delete(int id)
    {
        Client? client = GetById(id);

        if (client != null) Delete(client);
        else throw Exceptions.NotFoundException("Client");
    }

    /// <summary>
    /// Delete Client By National ID
    /// </summary>
    /// <param name="nId">Client National ID</param>
    public override void Delete(string nId)
    {
        Client? client = _dbContext.Clients
            .SingleOrDefault(c => c.NId == nId);

        if (client != null) Delete(client);
        else throw Exceptions.NotFoundException("Client");
    }

    /// <summary>
    /// Delete Client Object
    /// </summary>
    /// <param name="client">object</param>
    public void Delete(Client client)
    {
        _dbContext.Clients.Remove(client);
        _dbContext.SaveChanges();
    }

    /// <summary>
    /// Get All Clients From DataBase
    /// </summary>
    /// <returns><see cref="List{T}"/> of Client of their Data </returns>
    public List<Client> GetAll() => _dbContext.Clients.ToList();

    /// <summary>
    /// Get Client From DataBase By ID
    /// </summary>
    /// <returns>Client</returns>
    public override Client? GetById(int id) => _dbContext.Clients.Find(id);

    /// <summary>
    /// Get All Clients From DataBase that their <paramref name="name"/>
    /// </summary>
    /// <param name="name">name to search</param>
    /// <returns><see cref="List{T}"/> of Clients</returns>
    public List<Client> GetByName(string name)
        => _dbContext.Clients.Filter(c =>
            c.Name.ToLower() == name.ToLower()).ToList();

    /// <summary>
    /// Get All Clients From DataBase that their match the <paramref name="pattern"/>
    /// </summary>
    /// <param name="pattern">pattern to search</param>
    /// <returns><see cref="List{T}"/> of Clients</returns>
    public List<Client> GetByNamePattern(string pattern)
        => _dbContext.Clients.Filter(c =>
            c.Name.ToLower().Contains(pattern.ToLower())).ToList();

    /// <summary>
    /// Get All Clients From DataBase that have <paramref name="address"/>
    /// </summary>
    /// <param name="address">address to search</param>
    /// <returns><see cref="List{T}"/> of Clients</returns>
    public List<Client> GetByAddress(string address)
        => _dbContext.Clients.Filter(c =>
            c.Address.ToLower() == address.ToLower()).ToList();

    /// <summary>
    /// Update the client object
    /// </summary>
    /// <param name="client">object that will be updated</param>
    public void Update(Client client)
    {
        _dbContext.Clients.Update(client);
        _dbContext.SaveChanges();
    }

    /// <summary>
    /// Update the particular Proprieties of Client 
    /// </summary>
    /// <param name="id">The Client that will be updated</param>
    /// <param name="newValues">Dictionary of Desired Properties and their new Values</param>
    /// <returns>The Updated Client</returns>
    /// <exception cref="Exceptions.NotFoundProperty"></exception>
    public override Client Update(int id,
        Dictionary<Properties, object> newValues)
    {
        // pass the basic Properties as Person
        Dictionary<Properties, object> perValues = newValues;
        perValues.Remove(Properties.MemberShipId);
        perValues.Remove(Properties.Nationality);
        perValues.Remove(Properties.Points);
        Client client = (Client)base.Update(id, perValues);

        // update other
        foreach (var item in newValues)
            switch (item.Key)
            {
                case Properties.Nationality:
                    client.Nationality = (string)item.Value;
                    break;
                case Properties.Points:
                    client.UpdatePoints((int)item.Value);
                    break;
                default:
                    throw Exceptions.NotFoundProperty(item.Key.ToString());
            }

        _dbContext.Clients.Update(client);
        _dbContext.SaveChanges();
        return client;
    }
}
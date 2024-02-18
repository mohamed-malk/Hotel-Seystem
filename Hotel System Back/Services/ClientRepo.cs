namespace Hotel_System_Back.Services;

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
    public List<ClientView> GetAll() => _dbContext.Clients
        .Select(client => new ClientView(client.Id, client.Name,
            client.UserName, client.Email, client.Password,
            client.NId, client.Age, client.Gender,
            client.Address, client.Nationality,
            client.Points, client.MemberShipId,
            client.MemberShip!.Name))
        .ToList();

    /// <summary>
    /// Get Client From DataBase By ID
    /// </summary>
    /// <returns>Client</returns>
    public override Client? GetById(int id) => _dbContext.Clients.Find(id);

    public new ClientView? GetByIdShow(int id)
    {
        Client? client = GetById(id);
        return new ClientView(client!.Id, client.Name,
            client.UserName, client.Email, client.Password,
            client.NId, client.Age, client.Gender,
            client.Address, client.Nationality,
            client.Points, client.MemberShipId,
            client.MemberShip!.Name);
    }

    /// <summary>
    /// Get All Clients From DataBase that their <paramref name="name"/>
    /// </summary>
    /// <param name="name">name to search</param>
    /// <returns><see cref="List{T}"/> of Clients</returns>
    public List<ClientView> GetByName(string name)
    {
        var tempSet = _dbContext.Set<Client>();
        tempSet.AddRange(_dbContext.Clients.Filter(c =>
            c.Name.ToLower() == name.ToLower()));

        return tempSet.Include(m => m.MemberShip)
            .Select(client => new ClientView(client.Id, client.Name,
                client.UserName, client.Email, client.Password,
                client.NId, client.Age, client.Gender,
                client.Address, client.Nationality,
                client.Points, client.MemberShipId,
                client.MemberShip!.Name))
            .ToList();
    }

/// <summary>
    /// Get All Clients From DataBase that their match the <paramref name="pattern"/>
    /// </summary>
    /// <param name="pattern">pattern to search</param>
    /// <returns><see cref="List{T}"/> of Clients</returns>
    public List<ClientView> GetByNamePattern(string pattern)
    { 
        var tempSet = _dbContext.Set<Client>();
        tempSet.AddRange(
            _dbContext.Clients.Filter(c =>
                c.Name.ToLower().Contains(pattern.ToLower())));

        return tempSet.Include(m => m.MemberShip)
            .Select(
                client => new ClientView(client.Id, client.Name,
                    client.UserName, client.Email, client.Password,
                    client.NId, client.Age, client.Gender,
                    client.Address, client.Nationality,
                    client.Points, client.MemberShipId,
                    client.MemberShip!.Name))
            .ToList();
    }

/// <summary>
/// Get All Clients From DataBase that have <paramref name="address"/>
/// </summary>
/// <param name="address">address to search</param>
/// <returns><see cref="List{T}"/> of Clients</returns>
public List<ClientView> GetByAddress(string address)
    {
        var tempSet = _dbContext.Set<Client>(); 
        tempSet.AddRange(
        _dbContext.Clients.Filter(c =>
                c.Address.ToLower() == address.ToLower()));

        return tempSet.Include(m => m.MemberShip)
            .Select(
                client => new ClientView(client.Id, client.Name,
                    client.UserName, client.Email, client.Password,
                    client.NId, client.Age, client.Gender,
                    client.Address, client.Nationality,
                    client.Points, client.MemberShipId,
                    client.MemberShip!.Name))
            .ToList();
    }

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
        Client client = (Client)base.Update(id, newValues);


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
                //default:
                //    throw Exceptions.NotFoundProperty(item.Key.ToString());
            }

        _dbContext.Clients.Update(client);
        _dbContext.SaveChanges();
        return client;
    }
}
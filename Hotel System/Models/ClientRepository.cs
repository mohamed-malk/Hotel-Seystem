using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_System.Models
{
    public class ClientRepository
    {
        private readonly HotelDbContext _context;

        public ClientRepository(HotelDbContext context)
        {
            _context = context;
        }

        public bool AddClient(Client client)
        {
            // Check if client with the same national ID already exists
            if (_context.Clients.Any(c => c.NId == client.NId))
            {
                return false; // Client with the same national ID already exists
            }

            _context.Clients.Add(client);
            _context.SaveChangesAsync();
            return true;
        }
        public bool UpdateClient(int clientId, Client updatedClient)
        {
            var client =  _context.Clients.Find(clientId);
            if (client == null)
            {
                return false; // Client not found
            }

            client.Name = updatedClient.Name;
            client.Email = updatedClient.Email;
            client.UserName = updatedClient.UserName;
            client.Password = updatedClient.Password;
            client.Age = updatedClient.Age;
            client.Gender = updatedClient.Gender;
            client.Address = updatedClient.Address;
            client.NId = updatedClient.NId;
            client.Nationality = updatedClient.Nationality;
            client.MemberShipId = updatedClient.MemberShipId;
            client.MemberShipId = updatedClient.MemberShipId;




            // Update other properties as needed

            _context.SaveChanges();
            return true;
        }
        public bool RemoveClient(int clientId)
        {
            var client =  _context.Clients.Find(clientId);
            if (client == null)
            {
                return false; // Client not found
            }

            _context.Clients.Remove(client);
            _context.SaveChanges();
            return true;
        }
    }

}

namespace Hotel_System.Models
{
    public partial class Client
    {
        private Client()
        {

        }
        public void Update(string userName, string email, string password,
            string nId, string name, int age, bool gender, string address,
            string nationality, int points, int memberShipId)
        {
            Update(userName, email, password, nId, name, age, gender, address);
            
            Nationality = nationality;
            Points = points;
            MemberShipId = memberShipId;
        }

        public static Client CreateClient()
        {
           return new();
        }

    }
}

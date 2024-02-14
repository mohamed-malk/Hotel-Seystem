namespace Hotel_System_Back.Models
{
    public partial class Client
    {

        /// <summary>
        /// Update Points with new Value and Update the MemberShip
        /// </summary>
        /// <param name="value"> value that will be added</param>
        internal void UpdatePoints(int value)
        {
            HotelDbContext db = new();
            Points = value;
            
            int mappedPoints = Points / int.Parse(
                db.CommonTable.Find(Unity.UpgradePercentage)!.Value);
            var lis = db.Memberships
                .Select(m => new { m.Advantages, m.Id }).ToList();
            
            // Update the memberShip  
            for(int i = 0; i < lis.Count - 1; i++)
                if (mappedPoints >= (int)lis[i].Advantages 
                    && mappedPoints < (int)lis[i + 1].Advantages)
                {
                        MemberShipId = lis[i].Id;
                        break;
                }
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

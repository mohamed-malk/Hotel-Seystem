using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel_System.Models
{
    public class Client : Person
    {
        // Proprieties
        public string Nationality { get; set; } = null!;
        public int Points { get; set; }
        
        // Mapping RelationShip
        public int? MemberShipId { get; set; }
        public virtual MemberShip? MemberShip { get; set; }

        // Reduce Join Query
        public virtual ICollection<FeedBack>? FeedBacks { get; set; }
    }
}

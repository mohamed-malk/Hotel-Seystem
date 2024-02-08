using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel_System.Models
{
    public class Client : Person
    {
        [MaxLength(20)]
        public string Nationality { get; set; } = null!;

        public int MemberShipId { get; set; }
        public virtual MemberShip MemberShip { get; set; } = null!;
    }
}

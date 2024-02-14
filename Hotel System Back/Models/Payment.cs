using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel_System_Back.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public float Amount { get; set; }
        public float TargetAmount { get; set; }
        
        [NotMapped]
        public float Rest => TargetAmount - Amount;

        public int? ClientId { get; set; }
        public virtual Client? Client { get; set; }
    }
}

using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices.JavaScript;

namespace Hotel_System.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public float Amount { get; set; }

        public float TargetAmount { get; set; }
        
        [NotMapped]
        public float Rest => TargetAmount - Amount;
    }
}

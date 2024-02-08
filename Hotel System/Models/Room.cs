using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel_System.Models
{
    public enum RoomType : byte
    {
        Single, Double, Triple
    }
    
    public partial class Room
    {
        public int Id { get; set; }

        public int Number { get; set; }

        [Range(1, 5)]
        public int Rate { get; set; }

        [Range(0, 2)]
        public RoomType Type { get; set; }

        [NotMapped]
        public float Price =>
            float.Parse(new CommonTable().Value) * (int)Type;

        public bool IsAvailable { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace Hotel_System.Models
{
    public class FeedBack
    {
        public int Id { get; set; }

        [Range(1, 5)]
        public int Rate { get; set; }

        [Range(1, 10)]
        public int FoodQuality { get; set; }
        public string Description { get; set; } = null!;

        public DateTime Date { get; set; }

        public int ClientId { get; set; }
        public virtual Client Client { get; set; } = null!;
    }
}

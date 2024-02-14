namespace Hotel_System_Back.Models
{
    public class FeedBack
    {
        #region Proprities

        public int Id { get; set; }
        public int Rate { get; set; }
        public int FoodQuality { get; set; }
        public string? Description { get; set; } = null!;
        public DateTime Date { get; set; }

        #endregion

        // Mapping RelationShip
        public int ClientId { get; set; }
        public virtual Client Client { get; set; } = null!;
    }
}

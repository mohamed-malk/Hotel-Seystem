namespace Hotel_System.Models
{
    public partial class Client : Person
    {
        public new int Id { get; private set; }
        // Proprieties
        public string Nationality { get; set; } = null!;
        public int Points { get; set; }
        
        // Mapping RelationShip
        public int? MemberShipId { get; set; }
        public virtual MemberShip? MemberShip { get; set; }

        // Reduce Join Query
        public virtual ICollection<FeedBack>? FeedBacks { get; set; }
            = new HashSet<FeedBack>();
        public virtual ICollection<Reservation>? Reservation { get; set; }
            = new HashSet<Reservation>();


        public override string ObjectName { get; } = "Client";
    }
}

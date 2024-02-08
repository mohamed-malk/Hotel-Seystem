namespace Hotel_System.Models
{
    [Flags]
    public enum Advantages : byte
    {
        FreeStay = 0001,
        FreeUpgrade = 0010,
        Additional = 0100
    }
    public class MemberShip
    {
        int Id { get; set; }
        private string Name { get; set; } = null!;
        string Description { get; set; } = null!;
        public Advantages Advantages { get; set; }
    }
}

namespace Hotel_System.Models
{
    [Flags]
    public enum Advantages : byte
    {
        FreeStay = 0b0001,
        FreeUpgrade = 0b0010,
        Additional = 0b0100
    }
    public class MemberShip
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public Advantages Advantages { get; set; }
    }

    public class Vip : MemberShip
    {
    }
    public class Advanced : MemberShip
    {
    }
    public class Normal : MemberShip
    {
    }
}

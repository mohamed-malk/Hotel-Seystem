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

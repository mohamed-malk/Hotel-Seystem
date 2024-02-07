using System.ComponentModel.DataAnnotations;

namespace Hotel_Seystem.Models
{
    public class Person
    {
        public int Id { get; set; }

        public string UserName { get; set; } = null!;
        [EmailAddress]
        public string Email { get; set; } = null!;
        [MaxLength(14)] [MinLength(14)] public string NId { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
    }
}

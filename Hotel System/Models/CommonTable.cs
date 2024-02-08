using System.ComponentModel.DataAnnotations;

namespace Hotel_System.Models
{
    public class CommonTable
    {
        [Key] public string Key { get; set; } = null!;
        public string Value { get; set; } = null!;
    }
}

using System.ComponentModel.DataAnnotations;

namespace Hotel_System.Models
{
    /// <summary>
    /// Represent the Shared/General Configuration Values 
    /// </summary>
    public class CommonTable
    {
        // Proprieties
        public string Key { get; private set; } = null!;
        public string Value { get; private set; } = null!;

    }
}

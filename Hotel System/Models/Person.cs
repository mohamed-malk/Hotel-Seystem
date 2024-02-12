using System.ComponentModel.DataAnnotations;

namespace Hotel_System.Models
{
    /// <summary>
    /// Represent the Common Data for Person
    /// </summary>

    public abstract partial class Person
    {
        #region Proprieties

        public int Id { get; set; }
        public string UserName { get; set; } = null!;

        [EmailAddress]
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string NId { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int Age { get; set; }
        public bool Gender { get; set; }
        public string Address { get; set; } = null!;

        #endregion

        public abstract string ObjectName { get; }
    }
}

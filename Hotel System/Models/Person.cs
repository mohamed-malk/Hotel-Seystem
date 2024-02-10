using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hotel_System.Models
{
    /// <summary>
    /// Represent the Common Data for Person
    /// </summary>

    public abstract class Person
    {
        #region Proprieties

        public int Id { get; set; }
        public string UserName { get; set; } = null!;

        [EmailAddress]
        public string Email { get; set; } = null!;
        public string NId { get; set; } = null!;
        public string Name { get; set; } = null!;
        public int Age { get; set; }
        public bool Gender { get; set; }
        public string Address { get; set; } = null!;
        public string Password { get; set; } = null!;

        #endregion


        public abstract string ObjectName { get; }
    }
}

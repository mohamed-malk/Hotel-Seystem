using Hotel_System.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Hotel_System.Config
{
    /// <summary>
    /// Configuration on Common Proprieties/Attributes for Client/Employee Entity 
    /// </summary>
    public class PersonConfig : IEntityTypeConfiguration<Person>
    {
        /// <summary>
        /// Configuration Statements
        /// </summary>
        /// <param name="builder"> <see cref="Person"/> EntityBuilder </param>
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            // Primary Key
            builder.HasKey(e => e.Id);

            #region Constraints on Columns 

            builder.Property(p => p.UserName)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false);
            builder.Property(p => p.Email)
                .HasMaxLength(50)
                .IsRequired()
                .IsUnicode(false);
            builder.Property(p => p.NId)
                .HasMaxLength(14)
                .IsRequired()
                .IsUnicode(false);
            builder.Property(p => p.Name)
                .HasMaxLength(25)
                .IsRequired();
            builder.Property(p => p.Address)
                .HasMaxLength(100);
            builder.Property(p => p.Password)
                .HasDefaultValue("m@S*n!S#")
                .HasMaxLength(20);

            #endregion

            // Apply Unique Constraint
            builder.HasIndex(p => p.UserName).IsUnique();
            builder.HasIndex(p => p.Email).IsUnique();
            builder.HasIndex(p => p.NId).IsUnique();

            // Constraints
            builder.ToTable(b => b
                .HasCheckConstraint("EmailValidation",
                    "[Email] like '[A-Za-z0-9+_.-]+@ (.+)$'"));
            builder.ToTable(b => b
                .HasCheckConstraint("NidValidation", "len([NId]) = 14"));

            // Use Table per Concert Class Strategy
            // to map the Inheritance Classes  
            builder.UseTpcMappingStrategy();
        }
    }
}

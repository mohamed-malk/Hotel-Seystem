using Hotel_System_Back.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace Hotel_System_Back.Config
{
    /// <summary>
    /// Configuration on Common Proprieties/Attributes for Client/Employee Entity 
    /// </summary>
    public class PersonConfig : 
        IEntityTypeConfiguration<Person>
    {
        /// <summary>
        /// Configuration Statements
        /// </summary>
        /// <param name="builder"> <see cref="Person"/> EntityBuilder </param>
        public virtual void Configure(EntityTypeBuilder<Person> builder)
        {
            // Use Table per Concert Class Strategy
             // to map the Inheritance Classes  
            builder.UseTpcMappingStrategy();

            #region Shared Columns
            
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

            // Apply Unique Constraints
            builder.HasIndex(p => p.UserName).IsUnique();
            builder.HasIndex(p => p.Email).IsUnique();
            builder.HasIndex(p => p.NId).IsUnique();

            #endregion
        }
    }
}

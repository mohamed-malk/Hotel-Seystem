using Hotel_System_Back.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hotel_System_Back.Config
{
    internal class MemberShipConfig : IEntityTypeConfiguration<MemberShip>
    {
        public void Configure(EntityTypeBuilder<MemberShip> builder)
        {
            // Primary Key
            builder.HasKey(e => e.Id);


            #region Constraints on Columns

            builder.Property(m => m.Name)
                .IsRequired()
                .HasMaxLength(8);
            builder.Property(m => m.Description)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(m => m.Advantages)
                .IsRequired();

            #endregion

            // Apply Unique Constraint
            builder.HasIndex(b => b.Advantages).IsUnique();

            // Use Table per Hierarchy Strategy
            // to map the Inheritance Classes  
            builder.UseTphMappingStrategy();

            // Set Discriminator as Name
            builder.HasDiscriminator(b => b.Name);


        }
    }
}

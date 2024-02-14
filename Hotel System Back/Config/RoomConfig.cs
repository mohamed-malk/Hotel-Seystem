using Hotel_System_Back.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hotel_System_Back.Config
{
    /// <summary>
    /// Configuration on Common Proprieties/Attributes for Room Entity 
    /// </summary>
    internal class RoomConfig : IEntityTypeConfiguration<Room>
    {
        /// <summary>
        /// Configuration Statements
        /// </summary>
        /// <param name="builder"> <see cref="Room"/> EntityBuilder </param>
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            // Primary Key
            builder.HasKey(e => e.Id);

            // Constraints on Columns 
            builder.Property(r => r.Number)
                .IsRequired();
            builder.Property(r => r.Rate)
                .IsRequired();
            builder.Property(r => r.Type)
                .IsRequired();

            // Other Constraints
            builder.ToTable(b =>
                b.HasCheckConstraint("RateRange", "[Rate] > 0 and [Rate] < 6"));
            builder.ToTable(b =>
                b.HasCheckConstraint("TypeRange", "[Type] > 0 and [Type] < 3"));
        }
    }
}

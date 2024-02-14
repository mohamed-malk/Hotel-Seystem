using Hotel_System_Back.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hotel_System_Back.Config
{
    /// <summary>
    /// Configuration on Common Proprieties/Attributes for <see cref="CommonTable"/> Entity 
    /// </summary>
    internal class CommonTableConfig : IEntityTypeConfiguration<CommonTable>
    {
        /// <summary>
        /// Configuration Statements
        /// </summary>
        /// <param name="builder"> <see cref="CommonTable"/> EntityBuilder </param>
        public void Configure(EntityTypeBuilder<CommonTable> builder)
        { 
            // Primary Kay
            builder.HasKey(e => e.Key);

            // Constraints on Columns
            builder.Property(c => c.Key)
                .IsRequired()
                .ValueGeneratedNever()
                .HasMaxLength(200);
            builder.Property(c => c.Value)
                .IsRequired()
                .ValueGeneratedNever()
                .HasMaxLength(200);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel_System.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hotel_System.Config
{
    /// <summary>
    /// Configuration on Common Proprieties/Attributes for FeedBack Entity 
    /// </summary>
    public class FeedBackConfig : IEntityTypeConfiguration<FeedBack> 
    {
        /// <summary>
        /// Configuration Statements
        /// </summary>
        /// <param name="builder"> <see cref="FeedBack"/> EntityBuilder </param>
        public void Configure(EntityTypeBuilder<FeedBack> builder)
        {
            // Primary Key
            builder.HasKey(e => e.Id);

            #region Constraint On Columns

            builder.Property(f => f.Rate)
                .IsRequired();
            builder.Property(f => f.Description)
                .IsRequired(false)
                .HasMaxLength(100);
            builder.Property(f => f.Date)
                .HasDefaultValue(DateTime.Today);

            #endregion

            // Mapping RelationShip
            builder.HasOne(f => f.Client)
                .WithMany(c => c.FeedBacks)
                .HasForeignKey(f => f.ClientId);

            // Other Constraints
            builder.ToTable(b => b
                .HasCheckConstraint("RateRange", "[Rate] > 0 and [Rate] < 6"));
            builder.ToTable(b => b
                .HasCheckConstraint("FoodRange", "[FoodQuality] > 0 and [FoodQuality] < 11"));
        }
    }
}

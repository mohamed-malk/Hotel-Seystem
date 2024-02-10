using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel_System.Models;

namespace Hotel_System.Config
{
    public class ReservationConfig : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            // Primary Key
            builder.HasKey(e => 
                new { e.ClientId, e.RoomId, e.ReservationDate });

            // Constraint on Column
            builder.Property(r => r.ReservationDate)
                .HasDefaultValueSql("GetDate()");
            
            // Other Constraints
            builder.ToTable(b =>
                b.HasCheckConstraint("CheckInValidation", "[CheckInDate] > GetDate()"));
            builder.ToTable(b =>
                b.HasCheckConstraint("CheckOutValidation", "[CheckOutDate] > [CheckInDate]"));
        }
    }
}
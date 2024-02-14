using Hotel_System_Back.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hotel_System_Back.Config ;
internal class TransactionTableConfig : IEntityTypeConfiguration<TransactionTable>
{
    public void Configure(EntityTypeBuilder<TransactionTable> builder)
    {
        builder.HasNoKey();
        
        builder.Property(t => t.Date)
            .HasDefaultValueSql("GetDate()");
    }
}

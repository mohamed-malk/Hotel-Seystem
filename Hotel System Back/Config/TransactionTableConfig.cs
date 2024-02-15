using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hotel_System_Back.Config ;
internal class TransactionTableConfig : IEntityTypeConfiguration<TransactionTable>
{
    public void Configure(EntityTypeBuilder<TransactionTable> builder)
    {
        builder.HasKey(e => e.Id);

        builder.Property(t => t.Id)
            .HasAnnotation("SqlServer:Identity", "1, 1");
        builder.Property(t => t.Date)
            .HasDefaultValueSql("GetDate()");
    }
}

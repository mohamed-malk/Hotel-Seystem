using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace Hotel_System.Models
{
    public static class ExtendClass
    {
        public static IEnumerable<TEntity> Filter<TEntity>
            (this DbSet<TEntity> source, Func<TEntity, bool> filterFunc)
            where TEntity : class =>
            source.Where(filterFunc).Select(s => s);

        
        public static void ApplyConstraints<TEntity>(EntityTypeBuilder<TEntity> builder) 
        where TEntity : Person
        {
            // Constraints
            builder.ToTable(b => b
                .HasCheckConstraint("EmailValidation",
                    "[Email] like '[A-Za-z0-9+_.-]+@ (.+)$'"));
            builder.ToTable(b => b
                .HasCheckConstraint("NidValidation", "len([NId]) = 14"));
        }

    }
}

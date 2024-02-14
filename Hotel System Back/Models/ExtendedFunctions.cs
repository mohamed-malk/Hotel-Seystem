using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hotel_System_Back.Models
{
    public static class ExtendClass
    {
        /// <summary>
        /// Check that an Entity in <see cref="HotelDbContext"/>
        /// </summary>
        /// <typeparam name="TEntity">Class</typeparam>
        /// <param name="entity">Entity</param>
        /// <returns>The Entity is belonged to DbContext or not </returns>
        private static bool CheckType<TEntity>(DbSet<TEntity> entity) where TEntity : class
        {
            return entity is DbSet<Person>
                   || entity is DbSet<Employee>
                   || entity is DbSet<Client>
                   || entity is DbSet<Room>
                   || entity is DbSet<Reservation>
                   || entity is DbSet<Payment>
                   || entity is DbSet<FeedBack>
                   || entity is DbSet<MemberShip>
                   || entity is DbSet<CommonTable>
                   || entity is DbSet<TransactionTable>;
        }

        /// <summary>
        /// Extend Function Filter the <see cref="DbSet{TEntity}"/>
        /// of Entities based on particular criteria
        /// </summary>
        /// <typeparam name="TEntity">
        /// <see cref="Person"/> | <see cref="Client"/> | <see cref="Employee"/>
        /// <see cref="Room"/> | <see cref="Reservation"/> | <see cref="Payment"/>
        /// <see cref="FeedBack"/> | <see cref="MemberShip"/>
        /// </typeparam>
        /// <param name="source">Type that function is extended on it</param>
        /// <param name="filterFunc">function that define the criteria will be used in filtering</param>
        /// <returns><see cref="IEnumerable{TEntity}"/> of Entities that pass a criteria</returns>
        public static IEnumerable<TEntity> Filter<TEntity>
            (this DbSet<TEntity> source, Func<TEntity, bool> filterFunc)
            where TEntity : class
        {
            if (CheckType(source))
                return source.Where(filterFunc).Select(s => s);
            throw new TargetException("The Entity Must be one of the Entities in DbContext");
        }

        /// <summary>
        /// Constraints on <see cref="Client"/> | <see cref="Employee"/> only 
        /// </summary>
        /// <typeparam name="TEntity"><see cref="Client"/> | <see cref="Employee"/></typeparam>
        /// <param name="builder">Entity</param>
        public static void ApplyConstraints<TEntity>(EntityTypeBuilder<TEntity> builder)
            where TEntity : Person
        {
            // Constraints
            builder.ToTable(b => b
                .HasCheckConstraint("EmailValidation",
                    "[Email] like '%[a-zA-Z0-9.]@__%.__%' and [Email] not like '%[-+/*]%'"));
            builder.ToTable(b => b
                .HasCheckConstraint("NidValidation", "len([NId]) = 14 and [NId] not like '%[a-zA-Z.+/*_]%'"));
        }
    }
}

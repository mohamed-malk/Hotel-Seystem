using Microsoft.EntityFrameworkCore;
namespace Hotel_System.Models
{
    public static class ExtendClass
    {
        public static IEnumerable<TEntity> Filter<TEntity>
            (this DbSet<TEntity> source, Func<TEntity, bool> fun)
            where TEntity : class =>
            source.Where(fun).Select(s => s);
    }
}

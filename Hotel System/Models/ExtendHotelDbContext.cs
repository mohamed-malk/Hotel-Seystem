using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Hotel_System.Models
{
    public partial class HotelDbContext
    {
        public IEnumerable<TEntity> Filter<TEntity>
            (Func<TEntity, bool> fun)
            where TEntity : class =>
            Clients.Where(fun).Select(s => s);
        //public IEnumerable<T>? Filter<T>(Func<T, bool> fun)
        //{
        //    if (typeof(T) == typeof(Client))
        //    {
        //        Func<Client, bool>? filter = fun as Func<Client, bool>;
        //        return Clients.Where(filter!).Select(s => s) as IEnumerable<T>;
        //    }
        //    if (typeof(T) == typeof(Employee))
        //    {
        //        Func<Employee, bool>? filter = fun as Func<Employee, bool>;
        //        return Employees.Where(filter!).Select(s => s) as IEnumerable<T>;
        //    }

        //    return null;
        //}
    }
}

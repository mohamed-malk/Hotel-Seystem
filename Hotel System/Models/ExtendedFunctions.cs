using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hotel_System.Models
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
            return entity.GetType() == typeof(DbSet<Person>)
                   || entity.GetType() == typeof(DbSet<Employee>)
                   || entity.GetType() == typeof(DbSet<Client>)
                   || entity.GetType() == typeof(DbSet<Room>)
                   || entity.GetType() == typeof(DbSet<Reservation>)
                   || entity.GetType() == typeof(DbSet<Payment>)
                   || entity.GetType() == typeof(DbSet<FeedBack>)
                   || entity.GetType() == typeof(DbSet<MemberShip>);
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

        #region Person Region

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
                    "[Email] like '%[a-zA-z0-9.]@__%.__%' and [Email] not like '%[-+/*]%'"));
            builder.ToTable(b => b
                .HasCheckConstraint("NidValidation", "len([NId]) = 14"));
        }

        /// <summary>
        /// Login to System
        /// </summary>
        /// <returns>Login Successfully or Not </returns>
        public static bool Login(this DbSet<Person> source,
            string userName, string password) => source.SingleOrDefault(p =>
            p.UserName == userName && p.Password == password) != null;

        #endregion

        #region Employee Region

        /// <summary>
        /// Add Manager
        /// </summary>
        /// <returns><see cref="Employee"/> Manger</returns>
        /// <exception cref="Exceptions.AlreadyExistException"></exception>
        public static Employee CreateManager(this DbSet<Employee> source,
            string userName, string email, string password,
            string nId, string name, int age, bool gender, string address,
            int attend, float salary)
            => source.Find(Employee.ManagerId) == null
                ? new Employee
                {
                    Id = Employee.ManagerId,
                    UserName = userName,
                    Password = password,
                    Address = address,
                    Age = age,
                    Attend = attend,
                    Email = email,
                    Gender = gender,
                    Name = name,
                    NId = nId,
                    Salary = salary
                }
                : throw Exceptions.AlreadyExistException("Manager");

        /// <summary>
        /// Make the Employee is a Manager, in case No Manger is existed
        /// </summary>
        /// <param name="source"></param>
        /// <param name="manger">The Employee that will be a Manger</param>
        /// <returns><see cref="Employee"/>Manger</returns>
        /// <exception cref="Exceptions.AlreadyExistException"></exception>
        public static Employee CreateManager(this DbSet<Employee> source, Employee manger)
        {
            if (source.Find(Employee.ManagerId) == null)
            {  
                //----------- Repeated -----------//
                // First Remove Person as Employee
                source.Remove(manger);
                // Second Add Person as Manger
                source.Add(new(manger)
                {
                    Id = Employee.ManagerId
                });

                return manger;
            }
            throw Exceptions.AlreadyExistException("Manager");
        }

        /// <summary>
        /// Change Manger with other Employee
        /// </summary>
        /// <param name="source"><see cref="DbSet{Employee}"/></param>
        /// <param name="employee">Employee that will be a Manager</param>
        /// <param name="removeMan">Remove a Manger from System or Make it as Employee</param>
        public static void ChangeManager(this DbSet<Employee> source,
            Employee employee, bool removeMan = false)
        {
            // Get the Manger 
            Employee? oldManger = source.Find(Employee.ManagerId);

            if (oldManger != null) // The Manger is existed
            {
                // Remove Manager From System
                source.Remove(oldManger);

                if (!removeMan)
                {
                    // Add Manager as new Employee with new ID
                    Employee newEmployee = new(oldManger);
                    source.Add(newEmployee); // Add him as Employee
                }

                //----------- Repeated -----------//
                // First Remove Person as Employee
                source.Remove(employee);
                // Second Add Person as Manger
                source.Add(new(employee)
                {
                    Id = Employee.ManagerId
                });
            }
            else throw Exceptions.NotFoundException("Manger");
        }

        #endregion
    }
}

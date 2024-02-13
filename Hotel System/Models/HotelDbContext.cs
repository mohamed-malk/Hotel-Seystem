using Hotel_System.Config;
using Microsoft.EntityFrameworkCore;

namespace Hotel_System.Models
{
    public partial class HotelDbContext : DbContext
    {
        public virtual DbSet<Person> People { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<Client> Clients { get; set; } = null!;
        public virtual DbSet<Room> Rooms { get; set; } = null!;
        public virtual DbSet<Reservation> Reservations { get; set; } = null!;

        public virtual DbSet<MemberShip> Memberships { get; set; } = null!;
        public virtual DbSet<FeedBack> FeedBacks { get; set; } = null!;
        public virtual DbSet<Payment> Payments { get; set; } = null!;
        
        public virtual DbSet<CommonTable> CommonTable { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(Unity.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ReservationConfig).Assembly);
        }

    }
}

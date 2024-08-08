using Microsoft.EntityFrameworkCore;
using TaxiAppWebApi.Models;

namespace TaxiAppWebApi.Data
{
    public class TaxiAppDbContext : DbContext
    {
        public TaxiAppDbContext(DbContextOptions<TaxiAppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Analytics> Analytics { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Ride> Rides { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Opcionalna konfiguracija za entitete
        }
    }
}

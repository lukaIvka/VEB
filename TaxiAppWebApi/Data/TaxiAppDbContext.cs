using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TaxiAppWebApi.Models;

namespace TaxiAppWebApi.Data
{
    public class TaxiAppDbContext : IdentityDbContext<User>
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
            modelBuilder.Entity<Payment>()
                .Property(p => p.Amount)
                .HasColumnType("decimal(18, 2)");

            // Takođe, dodajte za 'TotalRevenue' ako postoji isti problem:
            modelBuilder.Entity<Analytics>()
                .Property(a => a.TotalRevenue)
                .HasColumnType("decimal(18, 2)");


            modelBuilder.Entity<Ride>()
                    .HasOne(r => r.StartLocation)
                    .WithMany()
                    .HasForeignKey(r => r.StartLocationId)
                    .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Ride>()
                .HasOne(r => r.EndLocation)
                .WithMany()
                .HasForeignKey(r => r.EndLocationId)
                .OnDelete(DeleteBehavior.Cascade);

            // Define the relationships for Ride and User
            modelBuilder.Entity<Ride>()
                .HasOne(r => r.Driver)
                .WithMany()
                .HasForeignKey(r => r.DriverId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Ride>()
                .HasOne(r => r.Passenger)
                .WithMany()
                .HasForeignKey(r => r.PassengerId)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Location>()
                .Property(l => l.Address)
                .HasMaxLength(255);

            modelBuilder.Entity<User>()
                .Property(u => u.UserName)
                .HasMaxLength(100);

            modelBuilder.Entity<Location>()
                .HasIndex(l => l.Address);

            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();



            base.OnModelCreating(modelBuilder);
        }

    }
}

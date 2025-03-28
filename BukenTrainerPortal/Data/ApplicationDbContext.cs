using BukenTrainerPortal.Models;
using Microsoft.EntityFrameworkCore;

namespace BukenTrainerPortal.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        // Db set properties go here
        public DbSet<Athlete> Athletes { get; set; }
        public DbSet<Coach> Coaches { get; set; }
        public DbSet<CheckIn> CheckIns { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Athlete>()
                .HasData(
                    new Athlete
                    {
                        ID = 1,
                        FirstName = "Luken",
                        LastName = "Buken",
                    },
                    new Athlete
                    {
                        ID = 2,
                        FirstName = "John",
                        LastName = "Smith",
                    },
                    new Athlete
                    {
                        ID = 3,
                        FirstName = "John",
                        LastName = "Doe",
                    }
                );
        }
    }
}

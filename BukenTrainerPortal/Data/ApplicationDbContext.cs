using Microsoft.EntityFrameworkCore;

namespace BukenTrainerPortal.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        // Db set properties go here
        public DbSet<Models.Athlete> Athletes { get; set; }
        public DbSet<Models.Coach> Coaches { get; set; }
        public DbSet<Models.CheckIn> CheckIns { get; set; }
    }
}

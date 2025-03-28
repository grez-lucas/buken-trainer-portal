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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder
                .UseNpgsql(
                    "Host=localhost;Port=5432;Database=trainer_portal_db;Username=postgres;Password=postgres;"
                )
                .UseSeeding(
                    (context, _) =>
                    {
                        var coach1 = new Coach
                        {
                            ID = 1,
                            FirstName = "Luken",
                            LastName = "Buken",
                        };
                        var coach2 = new Coach
                        {
                            ID = 2,
                            FirstName = "Anna",
                            LastName = "Smith",
                        };
                        var coach3 = new Coach
                        {
                            ID = 3,
                            FirstName = "Carlos",
                            LastName = "Garcia",
                        };

                        context.Set<Coach>().AddRange(coach1, coach2, coach3);
                        context.SaveChanges();

                        context
                            .Set<Athlete>()
                            .AddRange(
                                new Athlete
                                {
                                    FirstName = "Alice",
                                    LastName = "Johnson",
                                    CoachId = 1,
                                }, // Assigned to Luken Buken
                                new Athlete
                                {
                                    FirstName = "Bob",
                                    LastName = "Williams",
                                    CoachId = 1,
                                }, // Assigned to Luken Buken
                                new Athlete
                                {
                                    FirstName = "Charlie",
                                    LastName = "Brown",
                                    CoachId = 2,
                                }, // Assigned to Anna Smith
                                new Athlete
                                {
                                    FirstName = "David",
                                    LastName = "Davis",
                                    CoachId = 2,
                                }, // Assigned to Anna Smith
                                new Athlete
                                {
                                    FirstName = "Eve",
                                    LastName = "Miller",
                                    CoachId = 3,
                                } // Assigned to Carlos Garcia
                            );
                        context.SaveChanges();
                    }
                )
                .UseAsyncSeeding(
                    async (context, _, cancellationToken) =>
                    {
                        if (!await context.Set<Coach>().AnyAsync(c => c.ID == 1, cancellationToken))
                        {
                            var coach1 = new Coach
                            {
                                ID = 1,
                                FirstName = "Luken",
                                LastName = "Buken",
                            };
                            var coach2 = new Coach
                            {
                                ID = 2,
                                FirstName = "Anna",
                                LastName = "Smith",
                            };
                            var coach3 = new Coach
                            {
                                ID = 3,
                                FirstName = "Carlos",
                                LastName = "Garcia",
                            };
                            context.Set<Coach>().AddRange(coach1, coach2, coach3);
                            await context.SaveChangesAsync(cancellationToken);
                        }

                        if (
                            !await context
                                .Set<Athlete>()
                                .AnyAsync(a => a.ID == 1, cancellationToken)
                        )
                        {
                            context
                                .Set<Athlete>()
                                .AddRange(
                                    new Athlete
                                    {
                                        FirstName = "Alice",
                                        LastName = "Johnson",
                                        CoachId = 1,
                                    }, // Assigned to Luken Buken
                                    new Athlete
                                    {
                                        FirstName = "Bob",
                                        LastName = "Williams",
                                        CoachId = 1,
                                    }, // Assigned to Luken Buken
                                    new Athlete
                                    {
                                        FirstName = "Charlie",
                                        LastName = "Brown",
                                        CoachId = 2,
                                    }, // Assigned to Anna Smith
                                    new Athlete
                                    {
                                        FirstName = "David",
                                        LastName = "Davis",
                                        CoachId = 2,
                                    }, // Assigned to Anna Smith
                                    new Athlete
                                    {
                                        FirstName = "Eve",
                                        LastName = "Miller",
                                        CoachId = 3,
                                    } // Assigned to Carlos Garcia
                                );
                            await context.SaveChangesAsync(cancellationToken);
                        }
                    }
                );
    }
}



using Relex.BrandReputation.Data.GroupingConfigurations;

namespace Relex.BrandReputation.Data.DbContexts
{
    public class BrandReputationDbContext : DbContext
    {
        public BrandReputationDbContext(DbContextOptions<BrandReputationDbContext> options) : base(options)
        {
        }

        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ReviewEntityTypeConfiguration).Assembly);
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Review>().HasData(ReviewSeeder.Seed());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer((opt) => opt.MigrationsHistoryTable("EFMigrationsHistory", "Deployment"));
        }
    }
}


namespace Relex.BrandReputation.Data.Extensions
{
    public static class DbContextExtension
    {

        public static bool AreAllMigrationsApplied(this DbContext context)
        {
            var applied = context.GetService<IHistoryRepository>()
                .GetAppliedMigrations()
                .Select(m => m.MigrationId);

            var total = context.GetService<IMigrationsAssembly>()
                .Migrations
                .Select(m => m.Key);

            return !total.Except(applied).Any();
        }

        public static void EnsureSeeded(this BrandReputationDbContext context)
        {
            if (!context.Set<Review>().Any())
            {
                context.Set<Review>().AddRange(ReviewSeeder.Seed());
                context.SaveChanges();
            }
        }

        public static void ApplyMissedMigrations(this BrandReputationDbContext context)
        {
            if (!context.AreAllMigrationsApplied())
            {
                context.Database.Migrate();
                context.EnsureSeeded();
            }

        }
    }
}
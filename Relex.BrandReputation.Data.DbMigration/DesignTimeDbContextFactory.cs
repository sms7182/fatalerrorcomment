using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace Relex.BrandReputation.Data.DbMigration
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<BrandReputationDbContext>
    {
        public BrandReputationDbContext CreateDbContext(string[] args)
        {

            var builder = new DbContextOptionsBuilder<BrandReputationDbContext>();
            builder.UseSqlServer(GetConnectionString(), b => b.MigrationsAssembly(GetCurrentAssembllyName()));
            return new BrandReputationDbContext(builder.Options);

        }

        private string GetConnectionString()
        {
            return new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build()
               .GetConnectionString("DefaultConnection");
        }

        private string GetCurrentAssembllyName()
       => this.GetType().Assembly.GetName().Name;
    }
}
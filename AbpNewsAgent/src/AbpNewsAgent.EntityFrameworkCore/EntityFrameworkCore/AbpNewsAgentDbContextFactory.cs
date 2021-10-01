using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AbpNewsAgent.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class AbpNewsAgentDbContextFactory : IDesignTimeDbContextFactory<AbpNewsAgentDbContext>
    {
        public AbpNewsAgentDbContext CreateDbContext(string[] args)
        {
            AbpNewsAgentEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<AbpNewsAgentDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new AbpNewsAgentDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../AbpNewsAgent.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}

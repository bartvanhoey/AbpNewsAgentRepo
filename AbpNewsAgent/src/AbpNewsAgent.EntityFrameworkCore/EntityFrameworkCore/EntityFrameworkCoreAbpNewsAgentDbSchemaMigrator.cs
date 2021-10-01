using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AbpNewsAgent.Data;
using Volo.Abp.DependencyInjection;

namespace AbpNewsAgent.EntityFrameworkCore
{
    public class EntityFrameworkCoreAbpNewsAgentDbSchemaMigrator
        : IAbpNewsAgentDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreAbpNewsAgentDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the AbpNewsAgentDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<AbpNewsAgentDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}

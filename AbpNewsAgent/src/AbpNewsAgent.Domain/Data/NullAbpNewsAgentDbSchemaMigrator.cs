using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpNewsAgent.Data
{
    /* This is used if database provider does't define
     * IAbpNewsAgentDbSchemaMigrator implementation.
     */
    public class NullAbpNewsAgentDbSchemaMigrator : IAbpNewsAgentDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}
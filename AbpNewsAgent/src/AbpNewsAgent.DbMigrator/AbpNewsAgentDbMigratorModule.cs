using AbpNewsAgent.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace AbpNewsAgent.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AbpNewsAgentEntityFrameworkCoreModule),
        typeof(AbpNewsAgentApplicationContractsModule)
        )]
    public class AbpNewsAgentDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}

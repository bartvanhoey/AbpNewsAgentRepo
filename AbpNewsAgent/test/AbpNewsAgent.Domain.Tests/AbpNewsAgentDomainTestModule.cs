using AbpNewsAgent.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AbpNewsAgent
{
    [DependsOn(
        typeof(AbpNewsAgentEntityFrameworkCoreTestModule)
        )]
    public class AbpNewsAgentDomainTestModule : AbpModule
    {

    }
}
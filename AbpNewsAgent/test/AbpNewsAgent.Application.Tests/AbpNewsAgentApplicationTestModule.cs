using Volo.Abp.Modularity;

namespace AbpNewsAgent
{
    [DependsOn(
        typeof(AbpNewsAgentApplicationModule),
        typeof(AbpNewsAgentDomainTestModule)
        )]
    public class AbpNewsAgentApplicationTestModule : AbpModule
    {

    }
}
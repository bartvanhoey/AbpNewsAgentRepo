using AbpNewsAgent.Localization;
using Volo.Abp.AspNetCore.Components;

namespace AbpNewsAgent.Blazor
{
    public abstract class AbpNewsAgentComponentBase : AbpComponentBase
    {
        protected AbpNewsAgentComponentBase()
        {
            LocalizationResource = typeof(AbpNewsAgentResource);
        }
    }
}

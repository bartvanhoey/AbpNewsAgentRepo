using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AbpNewsAgent.Blazor
{
    [Dependency(ReplaceServices = true)]
    public class AbpNewsAgentBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "AbpNewsAgent";
    }
}

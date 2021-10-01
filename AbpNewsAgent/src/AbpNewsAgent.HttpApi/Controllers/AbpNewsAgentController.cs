using AbpNewsAgent.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpNewsAgent.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class AbpNewsAgentController : AbpController
    {
        protected AbpNewsAgentController()
        {
            LocalizationResource = typeof(AbpNewsAgentResource);
        }
    }
}
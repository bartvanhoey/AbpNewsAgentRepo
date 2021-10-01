using System;
using System.Collections.Generic;
using System.Text;
using AbpNewsAgent.Localization;
using Volo.Abp.Application.Services;

namespace AbpNewsAgent
{
    /* Inherit your application services from this class.
     */
    public abstract class AbpNewsAgentAppService : ApplicationService
    {
        protected AbpNewsAgentAppService()
        {
            LocalizationResource = typeof(AbpNewsAgentResource);
        }
    }
}

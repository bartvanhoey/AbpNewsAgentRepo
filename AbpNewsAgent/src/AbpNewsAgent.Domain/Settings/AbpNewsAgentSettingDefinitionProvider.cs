using Volo.Abp.Settings;

namespace AbpNewsAgent.Settings
{
    public class AbpNewsAgentSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(AbpNewsAgentSettings.MySetting1));
        }
    }
}

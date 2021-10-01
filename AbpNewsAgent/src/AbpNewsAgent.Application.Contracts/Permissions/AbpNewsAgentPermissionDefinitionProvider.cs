using AbpNewsAgent.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AbpNewsAgent.Permissions
{
    public class AbpNewsAgentPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(AbpNewsAgentPermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(AbpNewsAgentPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AbpNewsAgentResource>(name);
        }
    }
}

using App.Human.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace App.Human.Permissions;

public class HumanPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(HumanPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(HumanPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<HumanResource>(name);
    }
}

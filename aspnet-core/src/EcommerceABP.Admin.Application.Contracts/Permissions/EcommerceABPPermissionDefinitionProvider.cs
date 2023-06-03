using EcommerceABP.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace EcommerceABP.Admin.Permissions;

public class EcommerceABPPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(EcommerceABPPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(EcommerceABPPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<EcommerceABPResource>(name);
    }
}

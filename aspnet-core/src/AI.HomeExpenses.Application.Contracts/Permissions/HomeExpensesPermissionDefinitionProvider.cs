using AI.HomeExpenses.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AI.HomeExpenses.Permissions;

public class HomeExpensesPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(HomeExpensesPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(HomeExpensesPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<HomeExpensesResource>(name);
    }
}

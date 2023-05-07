using AI.HomeExpenses.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AI.HomeExpenses.Permissions;

public class HomeExpensesPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        // var myGroup = context.AddGroup(HomeExpensesPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(HomeExpensesPermissions.MyPermission1, L("Permission:MyPermission1"));
        var homeExpensesGroup = context.AddGroup(HomeExpensesPermissions.GroupName, L("Permission:HomeExpenses"));

        var booksPermission = homeExpensesGroup.AddPermission(HomeExpensesPermissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(HomeExpensesPermissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(HomeExpensesPermissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(HomeExpensesPermissions.Books.Delete, L("Permission:Books.Delete"));

        var authorsPermission = homeExpensesGroup.AddPermission(
        HomeExpensesPermissions.Authors.Default, L("Permission:Authors"));
        authorsPermission.AddChild(HomeExpensesPermissions.Authors.Create, L("Permission:Authors.Create"));
        authorsPermission.AddChild(HomeExpensesPermissions.Authors.Edit, L("Permission:Authors.Edit"));
        authorsPermission.AddChild(HomeExpensesPermissions.Authors.Delete, L("Permission:Authors.Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<HomeExpensesResource>(name);
    }
}

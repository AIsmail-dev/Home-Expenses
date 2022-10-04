using Abp.Authorization;
using HomeExpenses.Authorization.Roles;
using HomeExpenses.Authorization.Users;

namespace HomeExpenses.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}

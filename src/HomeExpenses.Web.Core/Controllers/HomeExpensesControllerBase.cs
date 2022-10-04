using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace HomeExpenses.Controllers
{
    public abstract class HomeExpensesControllerBase: AbpController
    {
        protected HomeExpensesControllerBase()
        {
            LocalizationSourceName = HomeExpensesConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}

using AI.HomeExpenses.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AI.HomeExpenses.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class HomeExpensesController : AbpControllerBase
{
    protected HomeExpensesController()
    {
        LocalizationResource = typeof(HomeExpensesResource);
    }
}

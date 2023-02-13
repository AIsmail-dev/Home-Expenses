using System;
using System.Collections.Generic;
using System.Text;
using AI.HomeExpenses.Localization;
using Volo.Abp.Application.Services;

namespace AI.HomeExpenses;

/* Inherit your application services from this class.
 */
public abstract class HomeExpensesAppService : ApplicationService
{
    protected HomeExpensesAppService()
    {
        LocalizationResource = typeof(HomeExpensesResource);
    }
}

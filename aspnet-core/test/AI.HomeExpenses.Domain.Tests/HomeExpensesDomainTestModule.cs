using AI.HomeExpenses.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AI.HomeExpenses;

[DependsOn(
    typeof(HomeExpensesEntityFrameworkCoreTestModule)
    )]
public class HomeExpensesDomainTestModule : AbpModule
{

}

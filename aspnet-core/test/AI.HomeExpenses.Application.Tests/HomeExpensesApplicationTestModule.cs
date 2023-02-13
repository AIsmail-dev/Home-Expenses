using Volo.Abp.Modularity;

namespace AI.HomeExpenses;

[DependsOn(
    typeof(HomeExpensesApplicationModule),
    typeof(HomeExpensesDomainTestModule)
    )]
public class HomeExpensesApplicationTestModule : AbpModule
{

}

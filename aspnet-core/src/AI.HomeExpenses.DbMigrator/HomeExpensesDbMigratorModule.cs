using AI.HomeExpenses.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace AI.HomeExpenses.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(HomeExpensesEntityFrameworkCoreModule),
    typeof(HomeExpensesApplicationContractsModule)
    )]
public class HomeExpensesDbMigratorModule : AbpModule
{

}

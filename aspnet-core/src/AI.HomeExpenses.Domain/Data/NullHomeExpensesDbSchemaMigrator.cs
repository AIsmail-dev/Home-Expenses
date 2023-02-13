using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AI.HomeExpenses.Data;

/* This is used if database provider does't define
 * IHomeExpensesDbSchemaMigrator implementation.
 */
public class NullHomeExpensesDbSchemaMigrator : IHomeExpensesDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}

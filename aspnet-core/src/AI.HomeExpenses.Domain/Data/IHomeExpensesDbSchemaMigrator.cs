using System.Threading.Tasks;

namespace AI.HomeExpenses.Data;

public interface IHomeExpensesDbSchemaMigrator
{
    Task MigrateAsync();
}

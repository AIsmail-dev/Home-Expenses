using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace HomeExpenses.EntityFrameworkCore
{
    public static class HomeExpensesDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<HomeExpensesDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<HomeExpensesDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}

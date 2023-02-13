using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AI.HomeExpenses.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class HomeExpensesDbContextFactory : IDesignTimeDbContextFactory<HomeExpensesDbContext>
{
    public HomeExpensesDbContext CreateDbContext(string[] args)
    {
        HomeExpensesEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<HomeExpensesDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new HomeExpensesDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../AI.HomeExpenses.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}

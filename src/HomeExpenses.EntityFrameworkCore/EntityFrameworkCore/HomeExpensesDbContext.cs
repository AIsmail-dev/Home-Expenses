using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using HomeExpenses.Authorization.Roles;
using HomeExpenses.Authorization.Users;
using HomeExpenses.MultiTenancy;

namespace HomeExpenses.EntityFrameworkCore
{
    public class HomeExpensesDbContext : AbpZeroDbContext<Tenant, Role, User, HomeExpensesDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public HomeExpensesDbContext(DbContextOptions<HomeExpensesDbContext> options)
            : base(options)
        {
        }
    }
}

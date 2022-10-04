using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HomeExpenses.EntityFrameworkCore;
using HomeExpenses.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace HomeExpenses.Web.Tests
{
    [DependsOn(
        typeof(HomeExpensesWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class HomeExpensesWebTestModule : AbpModule
    {
        public HomeExpensesWebTestModule(HomeExpensesEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(HomeExpensesWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(HomeExpensesWebMvcModule).Assembly);
        }
    }
}
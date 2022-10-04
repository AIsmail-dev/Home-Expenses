using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HomeExpenses.Authorization;

namespace HomeExpenses
{
    [DependsOn(
        typeof(HomeExpensesCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class HomeExpensesApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<HomeExpensesAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(HomeExpensesApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}

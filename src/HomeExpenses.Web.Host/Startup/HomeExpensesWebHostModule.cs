using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HomeExpenses.Configuration;

namespace HomeExpenses.Web.Host.Startup
{
    [DependsOn(
       typeof(HomeExpensesWebCoreModule))]
    public class HomeExpensesWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public HomeExpensesWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(HomeExpensesWebHostModule).GetAssembly());
        }
    }
}

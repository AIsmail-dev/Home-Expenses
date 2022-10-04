using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using HomeExpenses.Configuration.Dto;

namespace HomeExpenses.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : HomeExpensesAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

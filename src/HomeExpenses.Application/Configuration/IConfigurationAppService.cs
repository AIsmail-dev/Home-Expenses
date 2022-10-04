using System.Threading.Tasks;
using HomeExpenses.Configuration.Dto;

namespace HomeExpenses.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

using Volo.Abp.Settings;

namespace AI.HomeExpenses.Settings;

public class HomeExpensesSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(HomeExpensesSettings.MySetting1));
    }
}

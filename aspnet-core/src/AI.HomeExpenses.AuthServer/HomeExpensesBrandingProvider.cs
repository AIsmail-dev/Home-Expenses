using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace AI.HomeExpenses;

[Dependency(ReplaceServices = true)]
public class HomeExpensesBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "HomeExpenses";
}

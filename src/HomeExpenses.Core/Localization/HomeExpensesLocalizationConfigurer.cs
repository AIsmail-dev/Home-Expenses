using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace HomeExpenses.Localization
{
    public static class HomeExpensesLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(HomeExpensesConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(HomeExpensesLocalizationConfigurer).GetAssembly(),
                        "HomeExpenses.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}

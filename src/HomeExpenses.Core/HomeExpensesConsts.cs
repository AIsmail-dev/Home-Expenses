using HomeExpenses.Debugging;

namespace HomeExpenses
{
    public class HomeExpensesConsts
    {
        public const string LocalizationSourceName = "HomeExpenses";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "427defcc33b045738536e59960b255ff";
    }
}

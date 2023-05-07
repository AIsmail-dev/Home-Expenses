using Volo.Abp;

namespace AI.HomeExpenses.Incomings;

public class IncomingAlreadyExistsException : BusinessException
{
    public IncomingAlreadyExistsException(string name)
        : base(HomeExpensesDomainErrorCodes.RecordAlreadyExists)
    {
        WithData("name", name);
    }
}

using Volo.Abp;

namespace AI.HomeExpenses.Authors;

public class AuthorAlreadyExistsException : BusinessException
{
    public AuthorAlreadyExistsException(string name)
        : base(HomeExpensesDomainErrorCodes.AuthorAlreadyExists)
    {
        WithData("name", name);
    }
}

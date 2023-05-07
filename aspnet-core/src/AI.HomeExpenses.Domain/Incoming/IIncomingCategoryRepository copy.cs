using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace AI.HomeExpenses.Incomings;

public interface IIncomingCategoryRepository : IRepository<IncomingCategory, Guid>
{
    Task<IncomingCategory> FindByNameAsync(string name);

    Task<List<IncomingCategory>> GetListAsync(
        int skipCount,
        int maxResultCount,
        string sorting,
        string filter = null
    );
}

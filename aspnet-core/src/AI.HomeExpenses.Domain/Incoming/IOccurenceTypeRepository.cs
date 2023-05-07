using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace AI.HomeExpenses.Incomings;

public interface IOccurenceTypeRepository : IRepository<OccurenceType, Guid>
{
    Task<OccurenceType> FindByNameAsync(string name);

    Task<List<OccurenceType>> GetListAsync(
        int skipCount,
        int maxResultCount,
        string sorting,
        string filter = null
    );
}

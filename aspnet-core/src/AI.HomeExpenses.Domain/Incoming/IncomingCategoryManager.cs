using System;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Volo.Abp;
using Volo.Abp.Domain.Services;

namespace AI.HomeExpenses.Incomings;

public class IncomingCategoryManager : DomainService
{
    private readonly IIncomingCategoryRepository _incomingCategoryRepository;

    public IncomingCategoryManager(IIncomingCategoryRepository incomingCategoryRepository)
    {
        _incomingCategoryRepository = incomingCategoryRepository;
    }

    public async Task<IncomingCategory> CreateAsync(
        [NotNull] string name)
    {
        Check.NotNullOrWhiteSpace(name, nameof(name));

        var existingIncomingCategory = await _incomingCategoryRepository.FindByNameAsync(name);
        if (existingIncomingCategory != null)
        {
            throw new IncomingAlreadyExistsException(name);
        }

        return new IncomingCategory(
            GuidGenerator.Create(),
            name
        );
    }
}

using System;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Volo.Abp;
using Volo.Abp.Domain.Services;

namespace AI.HomeExpenses.Incomings;

public class OccurenceTypeManager : DomainService
{
    private readonly IOccurenceTypeRepository _occurenceTypeRepository;

    public OccurenceTypeManager(IOccurenceTypeRepository occurenceTypeRepository)
    {
        _occurenceTypeRepository = occurenceTypeRepository;
    }

    public async Task<OccurenceType> CreateAsync(
        [NotNull] string name)
    {
        Check.NotNullOrWhiteSpace(name, nameof(name));

        var existingOccurenceType = await _occurenceTypeRepository.FindByNameAsync(name);
        if (existingOccurenceType != null)
        {
            throw new IncomingAlreadyExistsException(name);
        }

        return new OccurenceType(
            GuidGenerator.Create(),
            name
        );
    }
}

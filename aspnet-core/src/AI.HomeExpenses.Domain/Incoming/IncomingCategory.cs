using System;
using System.Diagnostics.CodeAnalysis;
using Volo.Abp;
using Volo.Abp.Domain.Entities.Auditing;

namespace AI.HomeExpenses.Incomings;

public class IncomingCategory : AuditedAggregateRoot<Guid>
{
    public string Name { get; set; }

    internal IncomingCategory(
        Guid id,
        [NotNull] string name)
        : base(id)
    {
        SetName(name);
    }

    private void SetName([NotNull] string name)
    {
        Name = Check.NotNullOrWhiteSpace(
            name, 
            nameof(name)
        );
    }
}
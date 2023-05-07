using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace AI.HomeExpenses.Outcomings;

public class OutcomingCategory : AuditedAggregateRoot<Guid>
{
    public string Name { get; set; }

}
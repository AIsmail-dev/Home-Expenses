using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace AI.HomeExpenses.Incomings;

public class IncomingBill : AuditedAggregateRoot<Guid>
{
    public int IncomingItemId { get; set; }
    public IncomingItem IncomingItem { get; set; }
    public DateTime OccurenceDate { get; set; }
    public decimal OccurenceValue { get; set; }
    public bool IsCancelled { get; set; }

}
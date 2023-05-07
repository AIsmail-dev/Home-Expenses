using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace AI.HomeExpenses.Outcomings;

public class OutcomingBill : AuditedAggregateRoot<Guid>
{
    public int OutcomingItemId { get; set; }
    public OutcomingItem OutcomingItem { get; set; }
    public DateTime OccurenceDate { get; set; }
    public decimal OccurenceValue { get; set; }
    public bool IsCancelled { get; set; }

}
using System;
using AI.HomeExpenses.Incomings;
using Volo.Abp.Domain.Entities.Auditing;

namespace AI.HomeExpenses.Outcomings;

public class OutcomingItem : AuditedAggregateRoot<Guid>
{
    public string Name { get; set; }
    public int OutcomingCategoryId { get; set; }
    public OutcomingCategory OutcomingCategory { get; set; }
    public decimal ItemValue { get; set; }
    public int OccuranceTypeId { get; set; }
    public OccurenceType OccurenceType { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int WeekDay { get; set; }
    public DateTime OccurenceDay { get; set; }
}
using System;
using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace AI.HomeExpenses.Incomings;

public class IncomingItem : AuditedAggregateRoot<Guid>
{
    public string Name { get; set; }
    public Guid IncomingCategoryId { get; set; }
    public IncomingCategory IncomingCategory { get; set; }
    public decimal ItemValue { get; set; }
    public Guid OccuranceTypeId { get; set; }
    public OccurenceType OccurenceType { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int WeekDay { get; set; }
    public DateTime OccurenceDay { get; set; }
    public List<IncomingBill> IncomingBills { get; set; }
}
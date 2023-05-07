using System;
using Volo.Abp.Application.Dtos;
using AI.HomeExpenses.Localization;

namespace AI.HomeExpenses.Incomings;

public class IncomingItemDto : AuditedEntityDto<Guid>
{
    public string Name { get; set; }

    public OccurenceTypeEnum OccurenceType { get; set; }

    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public DateTime OccurenceDay { get; set; }
    public int WeekDay { get; set; }

    public decimal ItemValue { get; set; }
    public Guid OccurenceId { get; set; }
    public string OccurenceTypeName { get; set; }
    public Guid IncomingCategoryId { get; set; }
    public string IncomingCategoryName { get; set; }

}

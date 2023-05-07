using System;
using Volo.Abp.Application.Dtos;

namespace AI.HomeExpenses.Incomings;

public class LookupDto : EntityDto<Guid>
{
    public string Name { get; set; }
}

using System;
using Volo.Abp.Application.Dtos;

namespace AI.HomeExpenses.Books;

public class AuthorLookupDto : EntityDto<Guid>
{
    public string Name { get; set; }
}

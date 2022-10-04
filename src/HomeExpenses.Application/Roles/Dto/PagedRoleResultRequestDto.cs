using Abp.Application.Services.Dto;

namespace HomeExpenses.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}


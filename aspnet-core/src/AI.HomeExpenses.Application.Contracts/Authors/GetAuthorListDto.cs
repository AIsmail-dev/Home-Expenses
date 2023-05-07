using Volo.Abp.Application.Dtos;

namespace AI.HomeExpenses.Authors;

public class GetAuthorListDto : PagedAndSortedResultRequestDto
{
    public string Filter { get; set; }
}

using Abp.Application.Services;
using HomeExpenses.MultiTenancy.Dto;

namespace HomeExpenses.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}


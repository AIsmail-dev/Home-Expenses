using System.Threading.Tasks;
using Abp.Application.Services;
using HomeExpenses.Sessions.Dto;

namespace HomeExpenses.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

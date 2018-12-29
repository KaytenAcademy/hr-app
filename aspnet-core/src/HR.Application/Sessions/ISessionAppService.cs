using System.Threading.Tasks;
using Abp.Application.Services;
using HR.Sessions.Dto;

namespace HR.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

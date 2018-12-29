using System.Threading.Tasks;
using Abp.Application.Services;
using HR.Authorization.Accounts.Dto;

namespace HR.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}

using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HR.MultiTenancy.Dto;

namespace HR.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}


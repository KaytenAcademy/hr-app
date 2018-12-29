using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HR.Roles.Dto;
using HR.Users.Dto;

namespace HR.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}

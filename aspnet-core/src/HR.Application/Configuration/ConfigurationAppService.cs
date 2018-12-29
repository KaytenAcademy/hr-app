using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using HR.Configuration.Dto;

namespace HR.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : HRAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

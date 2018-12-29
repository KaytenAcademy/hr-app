using System.Threading.Tasks;
using HR.Configuration.Dto;

namespace HR.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

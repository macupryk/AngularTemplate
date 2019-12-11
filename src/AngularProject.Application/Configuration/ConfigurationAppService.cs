using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using AngularProject.Configuration.Dto;

namespace AngularProject.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AngularProjectAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

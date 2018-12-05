using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MAPPhoneBook.Configuration.Dto;

namespace MAPPhoneBook.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MAPPhoneBookAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

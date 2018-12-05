using System.Threading.Tasks;
using MAPPhoneBook.Configuration.Dto;

namespace MAPPhoneBook.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

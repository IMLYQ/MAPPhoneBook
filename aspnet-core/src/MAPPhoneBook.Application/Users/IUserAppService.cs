using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MAPPhoneBook.Roles.Dto;
using MAPPhoneBook.Users.Dto;

namespace MAPPhoneBook.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}

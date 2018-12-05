using System.Threading.Tasks;
using Abp.Application.Services;
using MAPPhoneBook.Authorization.Accounts.Dto;

namespace MAPPhoneBook.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}

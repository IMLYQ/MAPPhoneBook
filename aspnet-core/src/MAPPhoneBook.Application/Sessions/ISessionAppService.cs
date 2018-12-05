using System.Threading.Tasks;
using Abp.Application.Services;
using MAPPhoneBook.Sessions.Dto;

namespace MAPPhoneBook.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

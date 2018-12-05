using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MAPPhoneBook.MultiTenancy.Dto;

namespace MAPPhoneBook.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

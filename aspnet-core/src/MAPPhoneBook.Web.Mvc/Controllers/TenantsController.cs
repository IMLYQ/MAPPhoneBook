using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abp.Application.Services.Dto;
using Abp.AspNetCore.Mvc.Authorization;
using MAPPhoneBook.Authorization;
using MAPPhoneBook.Controllers;
using MAPPhoneBook.MultiTenancy;

namespace MAPPhoneBook.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Tenants)]
    public class TenantsController : MAPPhoneBookControllerBase
    {
        private readonly ITenantAppService _tenantAppService;

        public TenantsController(ITenantAppService tenantAppService)
        {
            _tenantAppService = tenantAppService;
        }

        public async Task<ActionResult> Index()
        {
            var output = await _tenantAppService.GetAll(new PagedResultRequestDto { MaxResultCount = int.MaxValue }); // Paging not implemented yet
            return View(output);
        }

        public async Task<ActionResult> EditTenantModal(int tenantId)
        {
            var tenantDto = await _tenantAppService.Get(new EntityDto(tenantId));
            return View("_EditTenantModal", tenantDto);
        }
    }
}

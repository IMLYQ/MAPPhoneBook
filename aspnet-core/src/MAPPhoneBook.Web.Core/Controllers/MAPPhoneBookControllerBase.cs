using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace MAPPhoneBook.Controllers
{
    public abstract class MAPPhoneBookControllerBase: AbpController
    {
        protected MAPPhoneBookControllerBase()
        {
            LocalizationSourceName = MAPPhoneBookConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}

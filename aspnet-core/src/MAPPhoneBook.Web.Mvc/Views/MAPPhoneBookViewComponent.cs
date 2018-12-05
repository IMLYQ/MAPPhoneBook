using Abp.AspNetCore.Mvc.ViewComponents;

namespace MAPPhoneBook.Web.Views
{
    public abstract class MAPPhoneBookViewComponent : AbpViewComponent
    {
        protected MAPPhoneBookViewComponent()
        {
            LocalizationSourceName = MAPPhoneBookConsts.LocalizationSourceName;
        }
    }
}

using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace MAPPhoneBook.Web.Views
{
    public abstract class MAPPhoneBookRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected MAPPhoneBookRazorPage()
        {
            LocalizationSourceName = MAPPhoneBookConsts.LocalizationSourceName;
        }
    }
}

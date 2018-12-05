using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using MAPPhoneBook.Controllers;

namespace MAPPhoneBook.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : MAPPhoneBookControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}

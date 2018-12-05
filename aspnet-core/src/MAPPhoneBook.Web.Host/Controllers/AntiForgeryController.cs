using Microsoft.AspNetCore.Antiforgery;
using MAPPhoneBook.Controllers;

namespace MAPPhoneBook.Web.Host.Controllers
{
    public class AntiForgeryController : MAPPhoneBookControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}

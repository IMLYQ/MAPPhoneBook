using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MAPPhoneBook.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace MAPPhoneBook.Web.Mvc.Controllers
{
    public class PersonsController : MAPPhoneBookControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
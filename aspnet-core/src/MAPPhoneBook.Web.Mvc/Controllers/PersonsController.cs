using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MAPPhoneBook.Controllers;
using MAPPhoneBook.Dtos;
using MAPPhoneBook.PhoneBooks;
using Microsoft.AspNetCore.Mvc;

namespace MAPPhoneBook.Web.Mvc.Controllers
{
    public class PersonsController : MAPPhoneBookControllerBase
    {

        private readonly IPersonAppService _personAppService;

        public PersonsController(IPersonAppService personAppService)
        {
            _personAppService = personAppService;
        }

        public async Task<IActionResult> Index(GetPersonInput input)
        {
            //Persons?skipCount=0&maxResultCount=10   访问Person报错时是由于没有传入分页参数
            var dtos = await _personAppService.GetPagedPersonAsync(input);
            return View(dtos);
        }
    }
}
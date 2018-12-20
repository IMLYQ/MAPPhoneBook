using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Abp.UI;
using MAPPhoneBook.Dtos;
using MAPPhoneBook.PhoneBooks.Dtos;
//using MAPPhoneBook.PhoneBooks.Persons;
using Microsoft.EntityFrameworkCore;

namespace MAPPhoneBook.PhoneBooks
{
    public class PersonAppService : MAPPhoneBookAppServiceBase, IPersonAppService
    {

        private readonly IRepository<Persons.Person> _personrepository;

        public PersonAppService(IRepository<Persons.Person> personrepository)
        {
            _personrepository = personrepository;
        }

        public async Task CreateOrUpdatePersonAsync(CreateOrUpdatePersonInput input)
        {
            //判断ID是否有值
            //更新操作
            if (input.PersonEditDto.Id.HasValue)
            {
                await UpdatePersonAsync(input.PersonEditDto);
            }
            //新增操作
            else
            {
                await CreatePersonAsync(input.PersonEditDto);
            }

        }

        public async Task DeletePersonAsync(EntityDto input)
        {
            var entity = await _personrepository.GetAsync(input.Id);

            if (entity == null)
            {
                throw new UserFriendlyException("该用户已经不存在，无法二次删除");
            }

            await _personrepository.DeleteAsync(input.Id);
        }

        public async Task<PagedResultDto<PersonListDto>> GetPagedPersonAsync(GetPersonInput input)
        {
            var query = _personrepository.GetAllIncluding(a => a.PhoneNumbers);

            var personCount = await query.CountAsync();

            var persons = await query.OrderBy(input.Sorting).PageBy(input).ToListAsync();

            var dtos = persons.MapTo<List<PersonListDto>>();

            return new PagedResultDto<PersonListDto>(personCount, dtos);

        }

        public Task<PersonListDto> GetPersonByIdAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<PersonListDto> GetPersonByIdAsync(NullableIdDto input)
        {
            var person = await _personrepository.GetAsync(input.Id.Value);
            return person.MapTo<PersonListDto>();

        }

        protected async Task UpdatePersonAsync(PersonEditDto input)
        {
            //查询更新的实体
            var entity = await _personrepository.GetAsync(input.Id.Value);
            //更新数据库
            await _personrepository.UpdateAsync(input.MapTo(entity));

        }

        protected async Task CreatePersonAsync(PersonEditDto input)
        { 
            await _personrepository.InsertAsync(input.MapTo<Persons.Person>());

        }  
    }
}

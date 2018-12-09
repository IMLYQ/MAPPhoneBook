using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MAPPhoneBook.Dtos;
using MAPPhoneBook.PhoneBooks.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MAPPhoneBook.PhoneBooks
{
    public interface IPersonAppService:IApplicationService
    {
        /// <summary>
        /// 获取人的相关信息,支持分页
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<PagedResultDto<PersonListDto>> GetPagedPersonAsync(GetPersonInput input);

        /// <summary>
        /// 根据ID获取相关用户信息
        /// </summary>
        /// <returns></returns>
        Task<PersonListDto> GetPersonByIdAsync(NullableIdDto input);

        /// <summary>
        /// 新增或者更改联系人信息
        /// </summary>
        /// <returns></returns>
        Task CreateOrUpdatePersonAsync(CreateOrUpdatePersonInput input);

        /// <summary>
        /// 删除联系人
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task DeletePersonAsync(EntityDto input);
    }
}

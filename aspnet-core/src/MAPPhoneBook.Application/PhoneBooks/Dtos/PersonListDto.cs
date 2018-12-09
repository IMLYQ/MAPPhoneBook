using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using MAPPhoneBook.PhoneBooks.Persons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MAPPhoneBook.PhoneBooks.Dtos
{ 
    //代表从person映射出来到PersonListDto
    [AutoMapFrom(typeof(Person))]
   public class PersonListDto:FullAuditedEntityDto
    {
        /// <summary>
        /// 姓名
        /// </summary>
 
        public string Name { get; set; }

        /// <summary>
        /// 邮箱地址
        /// </summary> 
        public string EmailAddress { get; set; }

        /// <summary>
        /// 地址信息
        /// </summary> 
        public string Address { get; set; }
    }
}

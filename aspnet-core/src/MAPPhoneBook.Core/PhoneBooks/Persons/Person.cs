using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using MAPPhoneBook.PhoneBooks.PhoneNumbers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MAPPhoneBook.PhoneBooks.Persons
{
    /// <summary>
    /// 人员
    /// </summary>
   [Table("ABP.Person")]
   public class Person:FullAuditedEntity
    {
        /// <summary>
        /// 姓名
        /// </summary>
     
        [Required]
        [MaxLength(MAPPhoneBookConsts.MaxNameLength)]
        public string Name { get; set; }

        /// <summary>
        /// 邮箱地址
        /// </summary>
        [EmailAddress]
        [MaxLength(MAPPhoneBookConsts.MaxEmailLength)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// 地址信息
        /// </summary>
        /// 
        [MaxLength(MAPPhoneBookConsts.MaxAddressLength)]
        public string Address { get; set; }

        /// <summary>
        /// 电话号码的导航属性
        /// </summary>
        [MaxLength(MAPPhoneBookConsts.MaxPhoneNumberLength)]
        public ICollection<PhoneNumber> PhoneNumbers { get; set; }
    }
}

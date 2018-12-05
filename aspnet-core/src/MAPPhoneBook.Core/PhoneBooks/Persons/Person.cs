using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
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
        [MaxLength(50)]
        public string Name { get; set; }

        /// <summary>
        /// 邮箱地址
        /// </summary>
        [EmailAddress]
        [MaxLength(80)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// 地址信息
        /// </summary>
        /// 
        [MaxLength(200)]
        public string Address { get; set; }
    }
}

using Abp;
using Abp.Runtime.Validation;
using MAPPhoneBook.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace MAPPhoneBook.Dtos
{
    public class GetPersonInput : PagedAndSortedInputDto, IShouldNormalize
    {


        public string FilterText { get; set; }
        /// <summary>
        /// 默认排序用到
        /// </summary>
        public void Normalize()
        {
            if (string.IsNullOrEmpty(Sorting))
            {
                Sorting = "Id";
            }
        }
    }
}

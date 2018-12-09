using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MAPPhoneBook.Dto
{
    public class PagedAndSortedInputDto : IPagedResultRequest, ISortedResultRequest
    {
        public string Sorting { get; set; }
        [Range(0, int.MaxValue)]
        public int SkipCount { get; set; }
        /// <summary>
        /// 每页显示最大条数
        /// </summary>
        [Range(1,500)]
        public int MaxResultCount { get; set; }
    }
}

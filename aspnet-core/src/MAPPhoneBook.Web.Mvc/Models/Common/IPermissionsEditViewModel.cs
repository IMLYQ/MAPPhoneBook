using System.Collections.Generic;
using MAPPhoneBook.Roles.Dto;

namespace MAPPhoneBook.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}
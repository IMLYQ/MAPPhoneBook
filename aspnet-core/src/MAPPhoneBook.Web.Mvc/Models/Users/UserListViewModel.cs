using System.Collections.Generic;
using MAPPhoneBook.Roles.Dto;
using MAPPhoneBook.Users.Dto;

namespace MAPPhoneBook.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}

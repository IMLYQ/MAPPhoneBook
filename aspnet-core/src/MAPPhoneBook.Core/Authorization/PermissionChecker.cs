using Abp.Authorization;
using MAPPhoneBook.Authorization.Roles;
using MAPPhoneBook.Authorization.Users;

namespace MAPPhoneBook.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}

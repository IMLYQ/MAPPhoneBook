using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MAPPhoneBook.Authorization.Roles;
using MAPPhoneBook.Authorization.Users;
using MAPPhoneBook.MultiTenancy;

namespace MAPPhoneBook.EntityFrameworkCore
{
    public class MAPPhoneBookDbContext : AbpZeroDbContext<Tenant, Role, User, MAPPhoneBookDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MAPPhoneBookDbContext(DbContextOptions<MAPPhoneBookDbContext> options)
            : base(options)
        {
        }
    }
}

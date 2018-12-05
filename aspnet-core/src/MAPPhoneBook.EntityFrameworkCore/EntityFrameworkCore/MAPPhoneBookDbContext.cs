using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MAPPhoneBook.Authorization.Roles;
using MAPPhoneBook.Authorization.Users;
using MAPPhoneBook.MultiTenancy;
using MAPPhoneBook.PhoneBooks.Persons;
using MAPPhoneBook.PhoneBooks.PhoneNumbers;

namespace MAPPhoneBook.EntityFrameworkCore
{
    public class MAPPhoneBookDbContext : AbpZeroDbContext<Tenant, Role, User, MAPPhoneBookDbContext>
    {
        /* Define a DbSet for each entity of the application */

            
        public MAPPhoneBookDbContext(DbContextOptions<MAPPhoneBookDbContext> options)
            : base(options)
        {
        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<PhoneNumber> PhoneNumbers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().ToTable("Person", "PB");
            modelBuilder.Entity<PhoneNumber>().ToTable("PhoneNumber", "PB");
            base.OnModelCreating(modelBuilder);
        }
    }
}

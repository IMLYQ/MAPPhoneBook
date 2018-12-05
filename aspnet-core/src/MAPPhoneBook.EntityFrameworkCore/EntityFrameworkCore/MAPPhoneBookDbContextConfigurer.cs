using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MAPPhoneBook.EntityFrameworkCore
{
    public static class MAPPhoneBookDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MAPPhoneBookDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MAPPhoneBookDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}

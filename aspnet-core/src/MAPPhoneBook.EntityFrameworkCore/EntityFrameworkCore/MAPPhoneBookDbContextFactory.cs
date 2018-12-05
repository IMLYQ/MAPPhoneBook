using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MAPPhoneBook.Configuration;
using MAPPhoneBook.Web;

namespace MAPPhoneBook.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class MAPPhoneBookDbContextFactory : IDesignTimeDbContextFactory<MAPPhoneBookDbContext>
    {
        public MAPPhoneBookDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MAPPhoneBookDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            MAPPhoneBookDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MAPPhoneBookConsts.ConnectionStringName));

            return new MAPPhoneBookDbContext(builder.Options);
        }
    }
}

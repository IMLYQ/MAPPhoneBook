using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MAPPhoneBook.Configuration;

namespace MAPPhoneBook.Web.Host.Startup
{
    [DependsOn(
       typeof(MAPPhoneBookWebCoreModule))]
    public class MAPPhoneBookWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MAPPhoneBookWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MAPPhoneBookWebHostModule).GetAssembly());
        }
    }
}

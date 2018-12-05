using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MAPPhoneBook.Configuration;

namespace MAPPhoneBook.Web.Startup
{
    [DependsOn(typeof(MAPPhoneBookWebCoreModule))]
    public class MAPPhoneBookWebMvcModule : AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MAPPhoneBookWebMvcModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<MAPPhoneBookNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MAPPhoneBookWebMvcModule).GetAssembly());
        }
    }
}

using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MAPPhoneBook.Authorization;

namespace MAPPhoneBook
{
    [DependsOn(
        typeof(MAPPhoneBookCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MAPPhoneBookApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MAPPhoneBookAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MAPPhoneBookApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}

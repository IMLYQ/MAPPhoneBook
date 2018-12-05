using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Timing;
using Abp.Zero;
using Abp.Zero.Configuration;
using MAPPhoneBook.Authorization.Roles;
using MAPPhoneBook.Authorization.Users;
using MAPPhoneBook.Configuration;
using MAPPhoneBook.Localization;
using MAPPhoneBook.MultiTenancy;
using MAPPhoneBook.Timing;

namespace MAPPhoneBook
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class MAPPhoneBookCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            // Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            MAPPhoneBookLocalizationConfigurer.Configure(Configuration.Localization);

            // 是否启用多租户
            Configuration.MultiTenancy.IsEnabled = MAPPhoneBookConsts.MultiTenancyEnabled;

            // Configure roles
            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

            Configuration.Settings.Providers.Add<AppSettingProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MAPPhoneBookCoreModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<AppTimes>().StartupTime = Clock.Now;
        }
    }
}

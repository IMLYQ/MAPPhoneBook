using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MAPPhoneBook.Configuration;
using MAPPhoneBook.EntityFrameworkCore;
using MAPPhoneBook.Migrator.DependencyInjection;

namespace MAPPhoneBook.Migrator
{
    [DependsOn(typeof(MAPPhoneBookEntityFrameworkModule))]
    public class MAPPhoneBookMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public MAPPhoneBookMigratorModule(MAPPhoneBookEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(MAPPhoneBookMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                MAPPhoneBookConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MAPPhoneBookMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}

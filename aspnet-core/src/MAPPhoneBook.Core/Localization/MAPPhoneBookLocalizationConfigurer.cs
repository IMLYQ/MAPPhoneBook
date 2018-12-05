using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace MAPPhoneBook.Localization
{
    public static class MAPPhoneBookLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(MAPPhoneBookConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(MAPPhoneBookLocalizationConfigurer).GetAssembly(),
                        "MAPPhoneBook.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}

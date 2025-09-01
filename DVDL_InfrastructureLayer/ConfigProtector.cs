using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVDL_InfrastructureLayer
{
    public class ConfigProtector
    {
        public static void ProtectSections(params string[] sectionNames)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            bool changed = false;

            foreach (var name in sectionNames)
            {
                var section = config.GetSection(name);
                if (section == null) continue;

                if (!section.SectionInformation.IsProtected)
                {
                    // استخدم DPAPI (أسهل اختيار لسطح المكتب على ويندوز)
                    section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                    section.SectionInformation.ForceSave = true;
                    changed = true;
                }
            }

            if (changed)
                config.Save(ConfigurationSaveMode.Full);
        }

        public static void UnprotectSections(params string[] sectionNames)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            bool changed = false;

            foreach (var name in sectionNames)
            {
                var section = config.GetSection(name);
                if (section == null) continue;

                if (section.SectionInformation.IsProtected)
                {
                    section.SectionInformation.UnprotectSection();
                    section.SectionInformation.ForceSave = true;
                    changed = true;
                }
            }

            if (changed)
                config.Save(ConfigurationSaveMode.Full);
        }
    }

}


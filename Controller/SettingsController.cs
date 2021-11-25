using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookShopManagementSystem.Helper;

namespace BookShopManagementSystem.Controller
{
    public class SettingsController
    {
        private string settingsPath = "settings.ini";

        public SettingsController()
        {
            if (!File.Exists(settingsPath))
            {
                var file = File.Create(settingsPath);
                file.Close();
            }
        }

        public void SetLang(string lang)
        {
            IniFile ini = new IniFile(settingsPath);
            ini.Write("Language", lang);
        }

        public string GetLang()
        {
            IniFile ini = new IniFile(settingsPath);
            return ini.Read("Language") ?? "ENG";
        }
    }
}

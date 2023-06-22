using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using static Skylark.WallpaperEngine.CS.Variable;

namespace Skylark.WallpaperEngine.CS
{
    public class Setting
    {
        public static string ConfigFileName => "Config.json";
        public static int MinimumPasswordLength => 6;
        public static int MaximumPasswordLength => 50;

        public Setting(string ConfigFileName)
        {
            if (File.Exists(ConfigFileName))
            {
                Load(ConfigFileName);
            }
            else
            {
                Save(ConfigFileName);
            }
        }

        private static void Load(string ConfigFileName)
        {
            string SS = File.ReadAllText(ConfigFileName);
            if (!string.IsNullOrEmpty(SS) && !string.IsNullOrWhiteSpace(SS))
            {
                Dictionary<string, string> Settings = JsonConvert.DeserializeObject<Dictionary<string, string>>(SS);
                if (Settings.ContainsKey("PageMode") && Settings.ContainsKey("WindowMode") && Settings.ContainsKey("SpecialMode") && Settings.ContainsKey("TopMostMode") && Settings.ContainsKey("HistoryMode") && Settings.ContainsKey("AlphabeticMode") && Settings.ContainsKey("EXExpandMode") && Settings.ContainsKey("PasswordLength"))
                {
                    TopMostMode = GetBoolean(Settings["TopMostMode"], TopMostMode);
                    HistoryMode = GetBoolean(Settings["HistoryMode"], HistoryMode);
                    EXExpandMode = GetBoolean(Settings["EXExpandMode"], EXExpandMode);
                    PasswordLength = GetInt(Settings["PasswordLength"], PasswordLength, MinimumPasswordLength, MaximumPasswordLength);
                }
            }
            Save(ConfigFileName);
        }

        public static void Save(string ConfigFileName)
        {
            Dictionary<string, string> Settings = new()
            {
                { "TopMostMode", GetString(TopMostMode, TopMostMode) },
                { "HistoryMode", GetString(HistoryMode, HistoryMode) },
                { "EXExpandMode", GetString(EXExpandMode, EXExpandMode) },
                { "PasswordLength", GetString(PasswordLength, PasswordLength) }
            };

            File.WriteAllText(ConfigFileName, JsonConvert.SerializeObject(Settings, Formatting.Indented));
        }

        public static bool HistoryMode { get; set; } = true;
        public static int PasswordLength { get; set; } = 15;
        public static bool TopMostMode { get; set; }
        public static bool EXExpandMode { get; set; }
    }
}
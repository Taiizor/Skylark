#region Imports

using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using SELFOT = Skylark.Enum.LockScreenFolderOrderType;
using SELFT = Skylark.Enum.LockScreenFitType;

#endregion

namespace Skylark.Wing.Model
{
    /// <summary>
    /// Configuration data model for Windows lock screen live wallpaper.
    /// </summary>
    public class LockScreenConfigModel
    {
        #region Properties

        // General
        public bool Enabled { get; set; } = true;
        public bool MatchDesktopWallpaper { get; set; } = true;
        public string MediaPath { get; set; } = string.Empty;
        public SELFT FitMode { get; set; } = SELFT.Cover;
        public int Speed { get; set; } = 100;
        public int AudioVolume { get; set; } = 0;
        public bool Muted
        {
            get => AudioVolume == 0;
            set
            {
                if (value)
                {
                    AudioVolume = 0;
                }
                else if (AudioVolume == 0)
                {
                    AudioVolume = 100;
                }
            }
        }
        public SELFOT FolderOrder { get; set; } = SELFOT.Random;

        // Performance & Power
        public int RenderWidth { get; set; } = 960;
        public bool HwDecode { get; set; } = true;
        public bool HardwareAcceleration
        {
            get => HwDecode;
            set => HwDecode = value;
        }
        public bool PlayOnPasswordScreen { get; set; } = true;
        public int IdlePauseSeconds { get; set; } = 300;
        public int LowBatteryThreshold { get; set; } = 20;
        public int LowBatteryLevel { get; set; } = 2; // 0: off, 1: light, 2: balanced, 3: maximum
        public bool LowBatteryOnAC { get; set; } = false;

        // Screens & Boot
        public bool ShowOnShutdown { get; set; } = false;
        public bool BootStillFrame { get; set; } = true;
        public int BootStillSeconds { get; set; } = 180;

        // Color Adjustments
        public int Hue { get; set; } = 0;
        public int Saturation { get; set; } = 100;
        public int Brightness { get; set; } = 0;
        public int Contrast { get; set; } = 100;
        public int Gamma { get; set; } = 100;
        public int Dim { get; set; } = 0;

        #endregion

        #region Serialization

        /// <summary>
        /// Serializes the model into JSON string formatted for native lock screen core.
        /// </summary>
        /// <returns>JSON string</returns>
        public string ToJson()
        {
            StringBuilder sb = new();
            sb.AppendLine("{");

            // General
            sb.AppendLine("  \"General\": {");
            sb.AppendLine($"    \"Enabled\": {Enabled.ToString().ToLowerInvariant()},");
            sb.AppendLine($"    \"MatchDesktopWallpaper\": {MatchDesktopWallpaper.ToString().ToLowerInvariant()},");
            sb.AppendLine($"    \"MediaPath\": \"{EscapeJson(MediaPath)}\",");
            sb.AppendLine($"    \"FitMode\": \"{FitMode}\",");
            sb.AppendLine($"    \"Speed\": {Speed},");
            sb.AppendLine($"    \"AudioVolume\": {AudioVolume},");
            sb.AppendLine($"    \"FolderOrder\": {(int)FolderOrder}");
            sb.AppendLine("  },");

            // Performance
            sb.AppendLine("  \"Performance\": {");
            sb.AppendLine($"    \"RenderWidth\": {RenderWidth},");
            sb.AppendLine($"    \"HwDecode\": {HwDecode.ToString().ToLowerInvariant()},");
            sb.AppendLine($"    \"PlayOnPasswordScreen\": {PlayOnPasswordScreen.ToString().ToLowerInvariant()},");
            sb.AppendLine($"    \"IdlePauseSeconds\": {IdlePauseSeconds},");
            sb.AppendLine($"    \"LowBatteryThreshold\": {LowBatteryThreshold},");
            sb.AppendLine($"    \"LowBatteryLevel\": {LowBatteryLevel},");
            sb.AppendLine($"    \"LowBatteryOnAC\": {LowBatteryOnAC.ToString().ToLowerInvariant()}");
            sb.AppendLine("  },");

            // Screens
            sb.AppendLine("  \"Screens\": {");
            sb.AppendLine($"    \"ShowOnShutdown\": {ShowOnShutdown.ToString().ToLowerInvariant()},");
            sb.AppendLine($"    \"BootStillFrame\": {BootStillFrame.ToString().ToLowerInvariant()},");
            sb.AppendLine($"    \"BootStillSeconds\": {BootStillSeconds}");
            sb.AppendLine("  },");

            // ColorAdjustments
            sb.AppendLine("  \"ColorAdjustments\": {");
            sb.AppendLine($"    \"Hue\": {Hue},");
            sb.AppendLine($"    \"Saturation\": {Saturation},");
            sb.AppendLine($"    \"Brightness\": {Brightness},");
            sb.AppendLine($"    \"Contrast\": {Contrast},");
            sb.AppendLine($"    \"Gamma\": {Gamma},");
            sb.AppendLine($"    \"Dim\": {Dim}");
            sb.AppendLine("  }");

            sb.AppendLine("}");
            return sb.ToString();
        }

        /// <summary>
        /// Deserializes a JSON string into a LockScreenConfigModel.
        /// </summary>
        /// <param name="Json"></param>
        /// <returns></returns>
        public static LockScreenConfigModel FromJson(string Json)
        {
            LockScreenConfigModel Model = new();
            if (string.IsNullOrWhiteSpace(Json))
            {
                return Model;
            }

            try
            {
                // General
                Model.Enabled = ExtractBoolean(Json, "Enabled", Model.Enabled);
                Model.MatchDesktopWallpaper = ExtractBoolean(Json, "MatchDesktopWallpaper", Model.MatchDesktopWallpaper);
                Model.MediaPath = ExtractString(Json, "MediaPath", Model.MediaPath);
                Model.Speed = ExtractInt(Json, "Speed", Model.Speed);
                Model.AudioVolume = ExtractInt(Json, "AudioVolume", Model.AudioVolume);
                Model.FolderOrder = (SELFOT)ExtractInt(Json, "FolderOrder", (int)Model.FolderOrder);

                string FitModeStr = ExtractString(Json, "FitMode", "Cover");
                if (System.Enum.TryParse(FitModeStr, true, out SELFT ParsedFit))
                {
                    Model.FitMode = ParsedFit;
                }

                // Performance
                Model.RenderWidth = ExtractInt(Json, "RenderWidth", Model.RenderWidth);
                Model.HwDecode = ExtractBoolean(Json, "HwDecode", Model.HwDecode);
                Model.PlayOnPasswordScreen = ExtractBoolean(Json, "PlayOnPasswordScreen", Model.PlayOnPasswordScreen);
                Model.IdlePauseSeconds = ExtractInt(Json, "IdlePauseSeconds", Model.IdlePauseSeconds);
                Model.LowBatteryThreshold = ExtractInt(Json, "LowBatteryThreshold", Model.LowBatteryThreshold);
                Model.LowBatteryLevel = ExtractInt(Json, "LowBatteryLevel", Model.LowBatteryLevel);
                Model.LowBatteryOnAC = ExtractBoolean(Json, "LowBatteryOnAC", Model.LowBatteryOnAC);

                // Screens
                Model.ShowOnShutdown = ExtractBoolean(Json, "ShowOnShutdown", Model.ShowOnShutdown);
                Model.BootStillFrame = ExtractBoolean(Json, "BootStillFrame", Model.BootStillFrame);
                Model.BootStillSeconds = ExtractInt(Json, "BootStillSeconds", Model.BootStillSeconds);

                // ColorAdjustments
                Model.Hue = ExtractInt(Json, "Hue", Model.Hue);
                Model.Saturation = ExtractInt(Json, "Saturation", Model.Saturation);
                Model.Brightness = ExtractInt(Json, "Brightness", Model.Brightness);
                Model.Contrast = ExtractInt(Json, "Contrast", Model.Contrast);
                Model.Gamma = ExtractInt(Json, "Gamma", Model.Gamma);
                Model.Dim = ExtractInt(Json, "Dim", Model.Dim);
            }
            catch
            {
                // Return default model on parsing failure
            }

            return Model;
        }

        private static string EscapeJson(string Str)
        {
            if (string.IsNullOrEmpty(Str))
            {
                return string.Empty;
            }

            return Str.Replace("\\", "\\\\").Replace("\"", "\\\"");
        }

        private static string ExtractString(string Json, string Key, string DefaultValue)
        {
            Match M = Regex.Match(Json, $"\"{Key}\"\\s*:\\s*\"([^\"]*)\"", RegexOptions.IgnoreCase);
            return M.Success ? M.Groups[1].Value.Replace("\\\\", "\\") : DefaultValue;
        }

        private static int ExtractInt(string Json, string Key, int DefaultValue)
        {
            Match M = Regex.Match(Json, $"\"{Key}\"\\s*:\\s*(-?\\d+)", RegexOptions.IgnoreCase);
            return M.Success && int.TryParse(M.Groups[1].Value, NumberStyles.Integer, CultureInfo.InvariantCulture, out int Result)
                ? Result
                : DefaultValue;
        }

        private static bool ExtractBoolean(string Json, string Key, bool DefaultValue)
        {
            Match M = Regex.Match(Json, $"\"{Key}\"\\s*:\\s*(true|false)", RegexOptions.IgnoreCase);
            return M.Success ? bool.Parse(M.Groups[1].Value) : DefaultValue;
        }

        #endregion
    }
}
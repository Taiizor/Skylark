#if NET6_0_OR_GREATER

using IWshRuntimeLibrary;
using System.IO;
using SWNM = Skylark.Wing.Native.Methods;

namespace Skylark.Wing.Helper
{
    /// <summary>
    /// 
    /// </summary>
    public static class ShortcutRuntime
    {
        /// <summary>
        /// Creates a shortcut at a specified location with specified parameters.
        /// </summary>
        /// <param name="shortcutLocation">The location where the shortcut will be created (e.g., "C:\\SomeFolder").</param>
        /// <param name="shortcutName">The name of the shortcut (e.g., "Notepad.lnk").</param>
        /// <param name="description">The description for the shortcut.</param>
        /// <param name="hotkey">The hotkey for the shortcut (e.g., "Ctrl+Shift+N").</param>
        /// <param name="targetPath">The path to the executable file that the shortcut points to.</param>
        /// <param name="iconLocation">The location of the icon to be used for the shortcut.</param>
        /// <param name="workingDirectory">The working directory for the shortcut.</param>
        /// <param name="arguments">Arguments to be passed to the target application.</param>
        /// <param name="windowStyle">The window style for the shortcut.</param>
        public static void Create(string shortcutLocation, string shortcutName, string description, string hotkey, string targetPath, string iconLocation = null, string workingDirectory = null, string arguments = null, SWNM.WindowStyle windowStyle = SWNM.WindowStyle.Normal)
        {
            WshShell shell = new();

            string shortcutAddress = Path.Combine(shortcutLocation, shortcutName);
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);

            shortcut.Description = description;
            shortcut.TargetPath = targetPath;

            if (workingDirectory != null)
            {
                shortcut.WorkingDirectory = workingDirectory;
            }

            if (iconLocation != null)
            {
                shortcut.IconLocation = iconLocation;
            }

            if (arguments != null)
            {
                shortcut.Arguments = arguments;
            }

            if (hotkey != null)
            {
                shortcut.Hotkey = hotkey;
            }

            shortcut.WindowStyle = (int)windowStyle;

            shortcut.Save();
        }
    }
}

#endif
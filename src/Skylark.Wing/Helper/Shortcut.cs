using System.Reflection;
using SWIIWS = Skylark.Wing.Interface.IWshShortcut;
using SWMI = Skylark.Wing.Manage.Internal;

namespace Skylark.Wing.Helper
{
    public static class Shortcut
    {
        public static void Create(string FileName, string TargetPath)
        {
            Create(FileName, TargetPath, null);
        }

        public static void Create(string FileName, string TargetPath, string Arguments = null)
        {
            Create(FileName, TargetPath, Arguments, null);
        }

        public static void Create(string FileName, string TargetPath, string Arguments = null, string WorkingDirectory = null)
        {
            Create(FileName, TargetPath, Arguments, WorkingDirectory, null);
        }

        public static void Create(string FileName, string TargetPath, string Arguments = null, string WorkingDirectory = null, string IconLocation = null)
        {
            Create(FileName, TargetPath, Arguments, WorkingDirectory, IconLocation, null);
        }

        public static void Create(string FileName, string TargetPath, string Arguments = null, string WorkingDirectory = null, string IconLocation = null, string Description = null)
        {
            Create(FileName, TargetPath, Arguments, WorkingDirectory, IconLocation, Description, null);
        }

        public static void Create(string FileName, string TargetPath, string Arguments = null, string WorkingDirectory = null, string IconLocation = null, string Description = null, string Hotkey = null)
        {
            SWIIWS Shortcut = (SWIIWS)SWMI.M_TYPE.InvokeMember("CreateShortcut", BindingFlags.InvokeMethod, null, SWMI.M_SHELL, new object[] { FileName });

            if (!string.IsNullOrEmpty(WorkingDirectory))
            {
                Shortcut.WorkingDirectory = WorkingDirectory;
            }

            if (!string.IsNullOrEmpty(IconLocation))
            {
                Shortcut.IconLocation = IconLocation;
            }

            if (!string.IsNullOrEmpty(Description))
            {
                Shortcut.Description = Description;
            }

            if (!string.IsNullOrEmpty(Arguments))
            {
                Shortcut.Arguments = Arguments;
            }

            if (!string.IsNullOrEmpty(Hotkey))
            {
                Shortcut.Hotkey = Hotkey;
            }

            Shortcut.TargetPath = TargetPath;

            Shortcut.Save();
        }
    }
}

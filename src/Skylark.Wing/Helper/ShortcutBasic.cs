using System;
using System.IO;
using System.Reflection;
using SWMI = Skylark.Wing.Manage.Internal;
using SWNM = Skylark.Wing.Native.Methods;

namespace Skylark.Wing.Helper
{
    /// <summary>
    /// 
    /// </summary>
    public static class ShortcutBasic
    {
        /// <summary>
        /// Create shortcut in current path.
        /// </summary>
        /// <param name="linkFileName">shortcut name(include .lnk extension.)</param>
        /// <param name="targetPath">target path</param>
        /// <param name="workingDirectory">working path</param>
        /// <param name="arguments">arguments</param>
        /// <param name="hotkey">hot key(ex: Ctrl+Shift+Alt+A)</param>
        /// <param name="shortcutWindowStyle">window style</param>
        /// <param name="description">shortcut description</param>
        /// <param name="iconNumber">icon index(start of 0)</param>
        /// <returns></returns>
        /// <exception cref="FileNotFoundException"></exception>
        public static void Create(string linkFileName, string targetPath, string workingDirectory = "", string arguments = "", string hotkey = "", SWNM.ShortcutWindowStyles shortcutWindowStyle = SWNM.ShortcutWindowStyles.WshNormalFocus, string description = "", int iconNumber = 0)
        {
            if (linkFileName.EndsWith(SWMI.DEFAULT_SHORTCUT_EXTENSION) == false)
            {
                linkFileName = string.Format("{0}{1}", linkFileName, SWMI.DEFAULT_SHORTCUT_EXTENSION);
            }

            if (File.Exists(targetPath) == false)
            {
                throw new FileNotFoundException(targetPath);
            }

            if (workingDirectory == string.Empty)
            {
                workingDirectory = Path.GetDirectoryName(targetPath);
            }

            string iconLocation = string.Format("{0},{1}", targetPath, iconNumber);

#if NET6_0_OR_GREATER
            dynamic shell = SWMI.M_SHELL;
            dynamic shortcut = shell.CreateShortcut(linkFileName);

            shortcut.Hotkey = hotkey;
            shortcut.Arguments = arguments;
            shortcut.TargetPath = targetPath;
            shortcut.Description = description;
            shortcut.IconLocation = iconLocation;
            shortcut.WindowStyle = shortcutWindowStyle;
            shortcut.WorkingDirectory = workingDirectory;

            shortcut.Save();
#else
            Type shellType = SWMI.M_TYPE;

            object shell = SWMI.M_SHELL;
            object shortcut = shellType.InvokeMethod("CreateShortcut", shell, linkFileName);

            Type shortcutType = shortcut.GetType();

            shortcutType.InvokeSetMember("Hotkey", shortcut, hotkey);
            shortcutType.InvokeSetMember("Arguments", shortcut, arguments);
            shortcutType.InvokeSetMember("TargetPath", shortcut, targetPath);
            shortcutType.InvokeSetMember("Description", shortcut, description);
            shortcutType.InvokeSetMember("IconLocation", shortcut, iconLocation);
            shortcutType.InvokeSetMember("WindowStyle", shortcut, shortcutWindowStyle);
            shortcutType.InvokeSetMember("WorkingDirectory", shortcut, workingDirectory);

            shortcutType.InvokeMethod("Save", shortcut);
#endif
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="methodName"></param>
        /// <param name="targetInstance"></param>
        /// <param name="arguments"></param>
        /// <returns></returns>
        private static object InvokeSetMember(this Type type, string methodName, object targetInstance, params object[] arguments)
        {
            return type.InvokeMember(methodName, BindingFlags.Public | BindingFlags.Instance | BindingFlags.SetProperty, null, targetInstance, arguments);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="methodName"></param>
        /// <param name="targetInstance"></param>
        /// <param name="arguments"></param>
        /// <returns></returns>
        private static object InvokeMethod(this Type type, string methodName, object targetInstance, params object[] arguments)
        {
            return type.InvokeMember(methodName, BindingFlags.Public | BindingFlags.Instance | BindingFlags.InvokeMethod, null, targetInstance, arguments);
        }
    }
}
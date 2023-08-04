using System.Text.RegularExpressions;
using EAT = Skylark.Enum.AssemblyType;
using EVT = Skylark.Enum.VersionType;
using HA = Skylark.Helper.Assemblies;

namespace Skylark.Helper
{
    /// <summary>
    /// 
    /// </summary>
    public static class Versionly
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Type"></param>
        /// <returns></returns>
        public static Version Auto(EAT Type)
        {
            return HA.Assemble(Type).GetName().Version;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Type"></param>
        /// <returns></returns>
        public static async Task<Version> AutoAsync(EAT Type)
        {
            return await Task.Run(() => Auto(Type));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        public static Version Clear(string Value)
        {
            return new Version(Regex.Replace(Value, "[^0-9.]", ""));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        public static async Task<Version> ClearAsync(string Value)
        {
            return await Task.Run(() => Clear(Value));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Version Entry()
        {
            return HA.Assemble(EAT.Entry).GetName().Version;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static async Task<Version> EntryAsync()
        {
            return await Task.Run(Entry);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Version Calling()
        {
            return HA.Assemble(EAT.Calling).GetName().Version;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static async Task<Version> CallingAsync()
        {
            return await Task.Run(Calling);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Current"></param>
        /// <param name="Latest"></param>
        /// <returns></returns>
        public static EVT Compare(Version Current, Version Latest)
        {
            return Latest.CompareTo(Current) switch
            {
                < 0 => EVT.Current,
                > 0 => EVT.Latest,
                _ => EVT.Equal
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Current"></param>
        /// <param name="Latest"></param>
        /// <returns></returns>
        public static async Task<EVT> CompareAsync(Version Current, Version Latest)
        {
            return await Task.Run(() => Compare(Current, Latest));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Version Executing()
        {
            return HA.Assemble(EAT.Executing).GetName().Version;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static async Task<Version> ExecutingAsync()
        {
            return await Task.Run(Executing);
        }
    }
}
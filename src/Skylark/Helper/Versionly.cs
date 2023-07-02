using EAT = Skylark.Enum.AssemblyType;
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
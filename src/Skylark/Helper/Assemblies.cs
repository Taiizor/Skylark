using System.Reflection;
using EAT = Skylark.Enum.AssemblyType;

namespace Skylark.Helper
{
    /// <summary>
    /// 
    /// </summary>
    public static class Assemblies
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Type"></param>
        /// <returns></returns>
        public static Assembly Assemble(EAT Type)
        {
            return Type switch
            {
                EAT.Entry => Assembly.GetEntryAssembly(),
                EAT.Calling => Assembly.GetCallingAssembly(),
                _ => Assembly.GetExecutingAssembly(),
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Type"></param>
        /// <returns></returns>
        public static async Task<Assembly> AssembleAsync(EAT Type)
        {
            return await Task.Run(() => Assemble(Type));
        }
    }
}
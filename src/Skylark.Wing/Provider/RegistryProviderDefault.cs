using Microsoft.Win32;
using SWIIR = Skylark.Wing.Interface.IRegistry;

namespace Skylark.Wing.Provider
{
    /// <summary>
    /// 
    /// </summary>
    public class RegistryProviderDefault : SWIIR
    {
        /// <summary>
        /// 
        /// </summary>
        public RegistryProviderDefault()
        {
            // NOPE
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="keyName"></param>
        /// <param name="valueName"></param>
        /// <param name="defaultValue"></param>
        /// <returns></returns>
        public object GetValue(string keyName, string valueName, object defaultValue)
        {
            return Registry.GetValue(keyName, valueName, defaultValue);
        }
    }
}
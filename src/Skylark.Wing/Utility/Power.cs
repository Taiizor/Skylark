using Microsoft.Win32;
using System.Runtime.InteropServices;
using SEEST = Skylark.Enum.EnergySaverType;

namespace Skylark.Wing.Utility
{
    /// <summary>
    /// 
    /// </summary>
    public static class Power
    {
        /// <summary>
        /// 
        /// </summary>
        private static readonly SystemPowerStatus sps = new();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sps"></param>
        /// <returns></returns>
        public static bool GetSystemPowerStatus(ref SystemPowerStatus sps)
        {
            return GetSystemPowerStatus(sps);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static SystemStatusFlag GetBatterySaverStatus()
        {
            return GetSystemPowerStatus(sps) ? sps._SystemStatusFlag : SystemStatusFlag.Off;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static byte GetBatteryLifePercent()
        {
            return GetSystemPowerStatus(sps) ? sps._BatteryLifePercent : byte.MaxValue;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static int GetBatteryLifeTime()
        {
            return GetSystemPowerStatus(sps) ? sps._BatteryLifeTime : -1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static int GetBatteryFullLifeTime()
        {
            return GetSystemPowerStatus(sps) ? sps._BatteryFullLifeTime : -1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static ACLineStatus GetACPowerStatus()
        {
            return GetSystemPowerStatus(sps) ? sps._ACLineStatus : ACLineStatus.Online;
        }

        /// <summary>
        /// Retrieves the current battery status flag, indicating the battery's state.
        /// </summary>
        /// <remarks>The returned value provides information about the battery's state, such as whether it
        /// is charging,  critically low, or fully charged. Use this method to monitor the battery status in
        /// applications  that require power state awareness.</remarks>
        /// <returns>A <see cref="BatteryFlag"/> value representing the current battery status.  Returns <see
        /// cref="BatteryFlag.Unknown"/> if the battery status cannot be determined.</returns>
        public static BatteryFlag GetBatteryFlag()
        {
            return GetSystemPowerStatus(sps) ? sps._BatteryFlag : BatteryFlag.Unknown;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool IsBatterySavingMode => GetBatterySaverStatus() == SystemStatusFlag.On;

        /// <summary>
        /// Retrieves the current energy saver state from the system registry.
        /// </summary>
        /// <remarks>This method reads the energy saver state from the Windows registry. If the specified
        /// registry value  does not exist, is empty, or contains an invalid value, the method returns <see
        /// cref="SEEST.Disabled"/>.</remarks>
        /// <param name="SubKey">The registry subkey path where the energy saver state is stored. The default value is 
        /// SYSTEM\CurrentControlSet\Control\Power.</param>
        /// <param name="SubValue">The name of the registry value that contains the energy saver state. The default value is  EnergySaverState.</param>
        /// <returns>A <see cref="SEEST"/> value representing the energy saver state. Possible values are: <list type="bullet">
        /// <item><description><see cref="SEEST.On"/> if the energy saver is enabled.</description></item>
        /// <item><description><see cref="SEEST.Off"/> if the energy saver is disabled.</description></item>
        /// <item><description><see cref="SEEST.Disabled"/> if the state is unavailable or invalid.</description></item>
        /// </list></returns>
        public static SEEST GetEnergySaverState(string SubKey = @"SYSTEM\CurrentControlSet\Control\Power", string SubValue = "EnergySaverState")
        {
            RegistryKey Key = GetRegistryKey(SubKey);

            try
            {
                string Value = Key.GetValue(SubValue).ToString();

                if (string.IsNullOrWhiteSpace(Value))
                {
                    return SEEST.Disabled;
                }
                else
                {
                    if (int.TryParse(Value.ToString(), out int State))
                    {
                        return State switch
                        {
                            1 => SEEST.On,
                            2 => SEEST.Off,
                            _ => SEEST.Disabled
                        };
                    }

                    return SEEST.Disabled;
                }
            }
            finally
            {
                Key.Close();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Key"></param>
        /// <param name="Writable"></param>
        /// <returns></returns>
        private static RegistryKey GetRegistryKey(string Key, bool Writable = false)
        {
            return Registry.LocalMachine.OpenSubKey(Key, Writable);
        }

        #region pinvoke

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sps"></param>
        /// <returns></returns>
        [DllImport("Kernel32")]
        private static extern bool GetSystemPowerStatus(SystemPowerStatus sps);

        /// <summary>
        /// 
        /// </summary>
        public enum ACLineStatus : byte
        {
            Offline = 0,
            Online = 1,
            Unknown = 255
        }

        /// <summary>
        /// 
        /// </summary>
        public enum BatteryFlag : byte
        {
            High = 1,
            Low = 2,
            Critical = 4,
            Charging = 8,
            NoSystemBattery = 128,
            Unknown = 255
        }

        /// <summary>
        /// 
        /// </summary>
        public enum SystemStatusFlag : byte
        {
            Off = 0, // Battery saver is off.
            On = 1 // Battery saver on. Save energy where possible.
        }

        /// <summary>
        /// Fields must mirror their unmanaged counterparts, in order
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        public class SystemPowerStatus
        {
            public ACLineStatus _ACLineStatus;
            public BatteryFlag _BatteryFlag;
            public byte _BatteryLifePercent;
            public SystemStatusFlag _SystemStatusFlag;
            public int _BatteryLifeTime;
            public int _BatteryFullLifeTime;
        }

        #endregion
    }
}
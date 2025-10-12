using System.Runtime.InteropServices;

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
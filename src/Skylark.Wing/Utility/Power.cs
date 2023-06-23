using System.Runtime.InteropServices;

namespace Skylark.Wing.Utility
{
    public static class Power
    {
        private static readonly SystemPowerStatus sps = new();

        public static bool GetSystemPowerStatus(ref SystemPowerStatus sps)
        {
            return GetSystemPowerStatus(sps);
        }

        public static SystemStatusFlag GetBatterySaverStatus()
        {
            return GetSystemPowerStatus(sps) ? sps._SystemStatusFlag : SystemStatusFlag.Off;
        }

        public static ACLineStatus GetACPowerStatus()
        {
            return GetSystemPowerStatus(sps) ? sps._ACLineStatus : ACLineStatus.Online;
        }

        public static bool IsBatterySavingMode => GetBatterySaverStatus() == SystemStatusFlag.On;

        #region pinvoke

        [DllImport("Kernel32")]
        private static extern bool GetSystemPowerStatus(SystemPowerStatus sps);

        public enum ACLineStatus : byte
        {
            Offline = 0,
            Online = 1,
            Unknown = 255
        }

        public enum BatteryFlag : byte
        {
            High = 1,
            Low = 2,
            Critical = 4,
            Charging = 8,
            NoSystemBattery = 128,
            Unknown = 255
        }

        public enum SystemStatusFlag : byte
        {
            Off = 0, // Battery saver is off.
            On = 1 // Battery saver on. Save energy where possible.
        }

        // Fields must mirror their unmanaged counterparts, in order
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

        #endregion //pinvoke
    }
}

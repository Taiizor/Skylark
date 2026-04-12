using SWNM = Skylark.Wing.Native.Methods;

namespace Skylark.Wing.Helper
{
    /// <summary>
    ///
    /// </summary>
    public static class ScreenSaver
    {
        /// <summary>
        /// Determines whether a screen saver is currently running on the calling process's interactive window station.
        /// </summary>
        /// <returns></returns>
        public static bool IsRunning()
        {
            int Running = 0;

            SWNM.SystemParametersInfo((int)SWNM.SPI.SPI_GETSCREENSAVERRUNNING, 0, ref Running, 0);

            return Running != 0;
        }
    }
}
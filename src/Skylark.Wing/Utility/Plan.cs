using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using SEPPT = Skylark.Enum.PowerPlanType;
using SWMI = Skylark.Wing.Manage.Internal;

namespace Skylark.Wing.Utility
{
    /// <summary>
    /// 
    /// </summary>
    public static class Plan
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="hMem"></param>
        /// <returns></returns>
        [DllImport("kernel32.dll")]
        private static extern IntPtr LocalFree(IntPtr hMem);

        /// <summary>
        /// Retrieves the GUID of the currently active power scheme.
        /// </summary>
        /// <remarks>This method is a P/Invoke wrapper for the native PowerGetActiveScheme function in
        /// powrprof.dll. It retrieves the power scheme currently in use by the system.</remarks>
        /// <param name="UserRootPowerKey">Reserved for future use. Must be <see langword="IntPtr.Zero"/>.</param>
        /// <param name="ActivePolicyGuid">When this method returns, contains a pointer to the GUID of the active power scheme. The caller is
        /// responsible for freeing the memory allocated for the GUID using <c>LocalFree</c>.</param>
        /// <returns>A <see cref="uint"/> value indicating the result of the operation.  Returns <c>0</c> if the operation
        /// succeeds; otherwise, returns a system error code.</returns>
        [DllImport("powrprof.dll", SetLastError = true)]
        private static extern uint PowerGetActiveScheme(IntPtr UserRootPowerKey, out IntPtr ActivePolicyGuid);

        /// <summary>
        /// Retrieves the friendly name of a specified power setting.
        /// </summary>
        /// <remarks>This method is a P/Invoke wrapper for the native PowerReadFriendlyName function in
        /// powrprof.dll. Ensure that the buffer is properly allocated and that the buffer size is sufficient to hold
        /// the friendly name.</remarks>
        /// <param name="RootPowerKey">Reserved for future use. Must be <see langword="IntPtr.Zero"/>.</param>
        /// <param name="SchemeGuid">The identifier of the power scheme containing the power setting.</param>
        /// <param name="SubGroupOfPowerSettingsGuid">The identifier of the subgroup of power settings. Use <see langword="IntPtr.Zero"/> to specify no subgroup.</param>
        /// <param name="PowerSettingGuid">The identifier of the specific power setting. Use <see langword="IntPtr.Zero"/> to specify no setting.</param>
        /// <param name="Buffer">A pointer to a buffer that receives the friendly name as a null-terminated string.</param>
        /// <param name="BufferSize">On input, specifies the size of the buffer in bytes. On output, receives the size of the data written to the
        /// buffer.</param>
        /// <returns>Returns a system error code. A value of 0 indicates success.</returns>
        [DllImport("powrprof.dll", SetLastError = true)]
        private static extern uint PowerReadFriendlyName(IntPtr RootPowerKey, ref Guid SchemeGuid, IntPtr SubGroupOfPowerSettingsGuid, IntPtr PowerSettingGuid, IntPtr Buffer, ref uint BufferSize);

        /// <summary>
        /// Retrieves the GUID of the currently active power scheme on the system.
        /// </summary>
        /// <remarks>This method queries the system for the active power scheme and returns its unique
        /// identifier as a <see cref="Guid"/>. If the operation fails, a <see cref="Win32Exception"/> is thrown with
        /// the corresponding error code.</remarks>
        /// <returns>The <see cref="Guid"/> representing the currently active power scheme.</returns>
        /// <exception cref="Win32Exception">Thrown if the underlying system call fails. The exception's error code provides details about the failure.</exception>
        public static Guid GetActivePowerSchemeGuid()
        {
            uint result = PowerGetActiveScheme(IntPtr.Zero, out nint pGuid);

            if (result != 0) // 0 = ERROR_SUCCESS
            {
                throw new Win32Exception((int)result);
            }

            Guid activeScheme = Marshal.PtrToStructure<Guid>(pGuid);
            LocalFree(pGuid); // Free the memory allocated by PowerGetActiveScheme

            return activeScheme;
        }

        /// <summary>
        /// Retrieves the system energy performance plan (SEPPT) corresponding to the specified GUID.
        /// </summary>
        /// <remarks>This method maps well-known GUIDs to predefined energy performance plans, such as
        /// Balanced, Power Saver, High Performance, and Ultimate Performance. If the GUID does not correspond to any of
        /// these predefined plans, the method returns <see cref="SEPPT.Custom"/>.</remarks>
        /// <param name="guid">The unique identifier of the energy plan to retrieve.</param>
        /// <returns>A <see cref="SEPPT"/> value representing the energy performance plan associated with the specified GUID.
        /// Returns <see cref="SEPPT.Custom"/> if the GUID does not match any predefined plans.</returns>
        public static SEPPT GetPlanFromGuid(Guid guid)
        {
            if (guid == SWMI.PlanBalanced)
            {
                return SEPPT.Balanced;
            }

            if (guid == SWMI.PlanPowerSaver)
            {
                return SEPPT.PowerSaver;
            }

            if (guid == SWMI.PlanHighPerformance)
            {
                return SEPPT.HighPerformance;
            }

            if (guid == SWMI.PlanUltimatePerformance)
            {
                return SEPPT.UltimatePerformance;
            }

            return SEPPT.Custom;
        }

        /// <summary>
        /// Retrieves the friendly name of the specified power scheme.
        /// </summary>
        /// <remarks>This method allocates unmanaged memory to retrieve the power scheme name.  The caller
        /// does not need to manage this memory, as it is freed internally.</remarks>
        /// <param name="scheme">The <see cref="Guid"/> representing the unique identifier of the power scheme.</param>
        /// <returns>The friendly name of the power scheme as a <see cref="string"/>.</returns>
        public static string GetPowerSchemeName(Guid scheme)
        {
            uint size = 0;

            _ = PowerReadFriendlyName(IntPtr.Zero, ref scheme, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, ref size);

            IntPtr buffer = Marshal.AllocHGlobal((int)size);

            _ = PowerReadFriendlyName(IntPtr.Zero, ref scheme, IntPtr.Zero, IntPtr.Zero, buffer, ref size);

            string name = Marshal.PtrToStringUni(buffer);

            Marshal.FreeHGlobal(buffer);

            return name;
        }
    }
}
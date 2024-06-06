using SWNM = Skylark.Wing.Native.Methods;

namespace Skylark.Wing.Interface
{
    public interface IWin32API
    {
        SWNM.NTSTATUS RtlGetVersion(ref SWNM.OSVERSIONINFOEX versionInfo);

        int GetSystemMetrics(SWNM.SystemMetric smIndex);
    }
}
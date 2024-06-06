using System;

namespace Skylark.Wing.Helper
{
    public class VersionInfo
    {
        public Version Version { get; private set; }

        public VersionInfo(int major, int minor)
        {
            Version = new Version(major, minor);
        }

        public VersionInfo(int major, int minor, int build)
        {
            Version = new Version(major, minor, build);
        }

        public VersionInfo(int major, int minor, int build, int revision)
        {
            Version = new Version(major, minor, build, revision);
        }
    }
}
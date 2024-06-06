using System;
using SWIIR = Skylark.Wing.Interface.IRegistry;
using SWNM = Skylark.Wing.Native.Methods;

namespace Skylark.Wing.Provider
{
    /// <summary>
    /// Get the release id and UBR (Update Build Revision) on Windows system having major version 10.
    /// </summary>
    public class MajorVersion10Provider
    {
        private static readonly string FullPathToCurrentVersion = @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion";
        private readonly SWNM.RegistryEntry _displayVersionRegistry = new(FullPathToCurrentVersion, "DisplayVersion", null);
        private readonly SWNM.RegistryEntry _releaseIdRegistry = new(FullPathToCurrentVersion, "ReleaseId", null);
        private readonly SWNM.RegistryEntry _ubrRegistry = new(FullPathToCurrentVersion, "UBR", null);

        private SWIIR _registryProvider;

        /// <summary>
        /// Returns the Windows numeric release ID (e.g. 1909, 2004, 2009). For versions like 20H2 use DisplayVersion.
        /// </summary>
        /// <remarks>returns the release id or null, if detection has failed.</remarks>
        [Obsolete("Works until Windows 10 version 2009/20H2 (build 19042) only. Use DisplayVersion instead.")]
        public string ReleaseId { get; private set; } = null;

        /// <summary>
        /// Gets the Update Build Revision of a Windows 10 system
        /// </summary>
        /// <remarks>returns null, if detection has failed.</remarks>
        public string UBR { get; private set; } = null;

        /// <summary>
        /// Gets the Display Version such as 1909, 2004, 20H2.
        /// </summary>
        public string DisplayVersion { get; private set; } = null;

        /// <summary>
        /// Create instance with custom registry provider.
        /// </summary>
        /// <param name="registryProvider"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public MajorVersion10Provider(SWIIR registryProvider)
        {
            _ = registryProvider ?? throw new ArgumentNullException();

            _registryProvider = registryProvider;
            GetAllProperties();
        }

        /// <summary>
        /// 
        /// </summary>
        public MajorVersion10Provider()
        {
            _registryProvider = new RegistryProviderDefault();
            GetAllProperties();
        }

        /// <summary>
        /// 
        /// </summary>
        private void GetAllProperties()
        {
            ReleaseId = GetReleaseId();
            UBR = GetUBR();
            DisplayVersion = GetDisplayVersion();
        }

        /// <summary>        
        /// The version number representing feature updates, is referred as the release id, such as 1903, 1909. 
        /// Works until Windows 10 version 2009/20H2 (build 19042) only.
        /// </summary>
        /// <returns>Returns the release id or null, if value is not available.</returns>
        /// <remarks>Feature updates for Windows 10 are released twice a year, around March and September, via the Semi-Annual Channel.</remarks>        
        private string GetReleaseId()
        {
            return _registryProvider.GetValue(_releaseIdRegistry.FullPathToKey, _releaseIdRegistry.ValueName, _releaseIdRegistry.DefaultValueNotFound)?.ToString();
        }

        /// <summary>
        /// Gets the  UBR (Update Build Revision).
        /// </summary>
        /// <returns></returns>
        /// <remarks>E.g, it returns 778 for Microsoft Windows [Version 10.0.18363.778] </remarks>
        private string GetUBR()
        {
            return _registryProvider.GetValue(_ubrRegistry.FullPathToKey, _ubrRegistry.ValueName, _ubrRegistry.DefaultValueNotFound)?.ToString();
        }


        /// <summary>
        /// Returns the DisplayVersion such as 20H2 (for ReleaseId 2009). If value is not found, it will return the ReleaseId.
        /// </summary>
        /// <returns></returns>
        private string GetDisplayVersion()
        {
            string displayVersion = _registryProvider.GetValue(_displayVersionRegistry.FullPathToKey, _displayVersionRegistry.ValueName, _displayVersionRegistry.DefaultValueNotFound)?.ToString();

            return displayVersion ?? GetReleaseId();
        }
    }
}
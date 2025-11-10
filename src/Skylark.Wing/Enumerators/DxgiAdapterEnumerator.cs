using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using SDE = Skylark.DxgiException;

namespace Skylark.Wing.Enumerators
{
    /// <summary>
    /// Provides native DXGI (DirectX Graphics Infrastructure) adapter enumeration functionality
    /// using P/Invoke without external dependencies.
    /// </summary>
    /// <remarks>
    /// This class interacts with the Windows DXGI API to enumerate graphics adapters and retrieve
    /// detailed information such as GPU names, LUID (Locally Unique Identifier), memory, and vendor details.
    /// 
    /// <para>
    /// <b>Use Cases:</b>
    /// - Mapping Performance Counter LUID values to real GPU names
    /// - Enumerating all graphics adapters in the system
    /// - Retrieving GPU hardware information without external libraries
    /// </para>
    /// 
    /// <para>
    /// <b>Platform Requirements:</b>
    /// - Windows Vista or later
    /// - DirectX 10.0 or later
    /// </para>
    /// 
    /// <para>
    /// <b>Thread Safety:</b>
    /// This class is thread-safe for read operations. However, COM objects should be accessed
    /// from the thread that created them.
    /// </para>
    /// </remarks>
    /// <example>
    /// <code>
    /// // Get all GPU adapters
    /// var adapters = DxgiAdapterEnumerator.EnumerateAdapters();
    /// foreach (var adapter in adapters)
    /// {
    ///     Console.WriteLine($"GPU: {adapter.Description}");
    ///     Console.WriteLine($"LUID: {adapter.LuidString}");
    ///     Console.WriteLine($"VRAM: {adapter.DedicatedVideoMemoryMB} MB");
    /// }
    /// 
    /// // Get LUID to GPU name mapping
    /// var mapping = DxgiAdapterEnumerator.GetLuidToNameMapping();
    /// if (mapping.TryGetValue("0x00000000_0x0001223B", out string gpuName))
    /// {
    ///     Console.WriteLine($"GPU Name: {gpuName}");
    /// }
    /// </code>
    /// </example>
    public static class DxgiAdapterEnumerator
    {
        #region Constants

        /// <summary>
        /// HRESULT success code.
        /// </summary>
        private const int S_OK = 0;

        /// <summary>
        /// DXGI error code indicating that no more adapters are available.
        /// </summary>
        private const int DXGI_ERROR_NOT_FOUND = unchecked((int)0x887A0002);

        /// <summary>
        /// IID for IDXGIFactory interface.
        /// </summary>
        private static readonly Guid IID_IDXGIFactory = new("7b7166ec-21c7-44ae-b21a-c9ae321ae369");

        #endregion

        #region Structures

        /// <summary>
        /// Describes an adapter (or video card) using DXGI 1.0.
        /// </summary>
        /// <remarks>
        /// This structure contains information about the video adapter, including description,
        /// vendor ID, device ID, and memory information.
        /// </remarks>
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
        internal struct DXGI_ADAPTER_DESC
        {
            /// <summary>
            /// A string that contains the adapter description.
            /// </summary>
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
            public string Description;

            /// <summary>
            /// The PCI ID or ACPI ID of the adapter's hardware vendor.
            /// </summary>
            public uint VendorId;

            /// <summary>
            /// The PCI ID or ACPI ID of the adapter's hardware device.
            /// </summary>
            public uint DeviceId;

            /// <summary>
            /// The PCI ID or ACPI ID of the adapter's hardware subsystem.
            /// </summary>
            public uint SubSysId;

            /// <summary>
            /// The adapter's PCI or ACPI revision number.
            /// </summary>
            public uint Revision;

            /// <summary>
            /// The number of bytes of dedicated video memory.
            /// </summary>
            public UIntPtr DedicatedVideoMemory;

            /// <summary>
            /// The number of bytes of dedicated system memory.
            /// </summary>
            public UIntPtr DedicatedSystemMemory;

            /// <summary>
            /// The number of bytes of shared system memory.
            /// </summary>
            public UIntPtr SharedSystemMemory;

            /// <summary>
            /// A unique value that identifies the adapter.
            /// </summary>
            public LUID AdapterLuid;
        }

        /// <summary>
        /// Describes a locally unique identifier (LUID).
        /// </summary>
        [StructLayout(LayoutKind.Sequential)]
        internal struct LUID
        {
            /// <summary>
            /// Low-order bits of the LUID.
            /// </summary>
            public uint LowPart;

            /// <summary>
            /// High-order bits of the LUID.
            /// </summary>
            public int HighPart;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Enumerates all graphics adapters in the system.
        /// </summary>
        /// <returns>
        /// A list of <see cref="AdapterInfo"/> objects containing information about each adapter.
        /// Returns an empty list if enumeration fails.
        /// </returns>
        /// <exception cref="SDE">
        /// Thrown when DXGI factory creation fails or adapter enumeration encounters an error.
        /// </exception>
        /// <example>
        /// <code>
        /// try
        /// {
        ///     var adapters = DxgiAdapterEnumerator.EnumerateAdapters();
        ///     foreach (var adapter in adapters)
        ///     {
        ///         Console.WriteLine($"{adapter.Description} - {adapter.DedicatedVideoMemoryMB} MB");
        ///     }
        /// }
        /// catch (SDE ex)
        /// {
        ///     Console.WriteLine($"Failed to enumerate adapters: {ex.Message}");
        /// }
        /// </code>
        /// </example>
        public static List<AdapterInfo> EnumerateAdapters()
        {
            List<AdapterInfo> adapters = [];

            IntPtr factoryPtr = IntPtr.Zero;
            try
            {
                // Create DXGI factory
                Guid factoryGuid = IID_IDXGIFactory;
                int hr = CreateDXGIFactory(ref factoryGuid, out factoryPtr);

                if (hr != S_OK || factoryPtr == IntPtr.Zero)
                {
                    throw new SDE($"Failed to create DXGI factory. HRESULT: 0x{hr:X8}", hr);
                }

                // Enumerate adapters
                for (uint index = 0; ; index++)
                {
                    IntPtr adapterPtr = IntPtr.Zero;

                    try
                    {
                        hr = EnumAdapters(factoryPtr, index, out adapterPtr);

                        // No more adapters available
                        if (hr == DXGI_ERROR_NOT_FOUND)
                        {
                            break;
                        }

                        // Skip failed enumerations
                        if (hr != S_OK || adapterPtr == IntPtr.Zero)
                        {
                            continue;
                        }

                        // Get adapter description
                        DXGI_ADAPTER_DESC desc = new();
                        hr = GetAdapterDesc(adapterPtr, ref desc);

                        if (hr == S_OK)
                        {
                            adapters.Add(new AdapterInfo(desc, index));
                        }
                    }
                    finally
                    {
                        // Release adapter COM object
                        if (adapterPtr != IntPtr.Zero)
                        {
                            Marshal.Release(adapterPtr);
                        }
                    }
                }
            }
            finally
            {
                // Release factory COM object
                if (factoryPtr != IntPtr.Zero)
                {
                    Marshal.Release(factoryPtr);
                }
            }

            return adapters;
        }

        /// <summary>
        /// Creates a mapping between LUID strings and GPU names.
        /// </summary>
        /// <returns>
        /// A dictionary where keys are LUID strings (format: "0xXXXXXXXX_0xXXXXXXXX") 
        /// and values are GPU description strings.
        /// </returns>
        /// <remarks>
        /// This method is particularly useful for correlating Performance Counter LUID values
        /// with actual GPU names. The LUID format matches the format used in Windows Performance Counters.
        /// </remarks>
        /// <example>
        /// <code>
        /// var luidMapping = DxgiAdapterEnumerator.GetLuidToNameMapping();
        /// 
        /// // Use with Performance Counter LUID
        /// string perfCounterLuid = "0x00000000_0x0001223B";
        /// if (luidMapping.TryGetValue(perfCounterLuid, out string gpuName))
        /// {
        ///     Console.WriteLine($"Performance Counter belongs to: {gpuName}");
        /// }
        /// </code>
        /// </example>
        public static Dictionary<string, string> GetLuidToNameMapping()
        {
            Dictionary<string, string> mapping = [];

            try
            {
                List<AdapterInfo> adapters = EnumerateAdapters();

                foreach (AdapterInfo adapter in adapters)
                {
                    mapping[adapter.LuidString] = adapter.Description;
                }
            }
            catch (SDE)
            {
                // Return empty mapping on error
                // Caller can check if dictionary is empty
            }

            return mapping;
        }

        /// <summary>
        /// Tries to get the GPU name for a specific LUID.
        /// </summary>
        /// <param name="luidString">
        /// The LUID string in format "0xXXXXXXXX_0xXXXXXXXX".
        /// </param>
        /// <param name="gpuName">
        /// When this method returns, contains the GPU name if found; otherwise, null.
        /// </param>
        /// <returns>
        /// <c>true</c> if the GPU was found; otherwise, <c>false</c>.
        /// </returns>
        /// <example>
        /// <code>
        /// if (DxgiAdapterEnumerator.TryGetGpuNameByLuid("0x00000000_0x0001223B", out string name))
        /// {
        ///     Console.WriteLine($"Found GPU: {name}");
        /// }
        /// else
        /// {
        ///     Console.WriteLine("GPU not found for this LUID");
        /// }
        /// </code>
        /// </example>
        public static bool TryGetGpuNameByLuid(string luidString, out string gpuName)
        {
            gpuName = null;

            try
            {
                Dictionary<string, string> mapping = GetLuidToNameMapping();

                return mapping.TryGetValue(luidString, out gpuName);
            }
            catch (SDE)
            {
                return false;
            }
        }

        #endregion

        #region P/Invoke Declarations

        /// <summary>
        /// Creates a DXGI factory which is used to enumerate adapters.
        /// </summary>
        /// <param name="riid">The globally unique identifier (GUID) of the IDXGIFactory interface.</param>
        /// <param name="ppFactory">Address of a pointer to the DXGI factory.</param>
        /// <returns>HRESULT indicating success or failure.</returns>
        [DllImport("dxgi.dll", EntryPoint = "CreateDXGIFactory", PreserveSig = true)]
        private static extern int CreateDXGIFactory([In] ref Guid riid, [Out] out IntPtr ppFactory);

        /// <summary>
        /// Enumerates adapters using the IDXGIFactory virtual function table.
        /// </summary>
        /// <param name="factory">Pointer to the DXGI factory.</param>
        /// <param name="adapter">The index of the adapter to enumerate.</param>
        /// <param name="ppAdapter">Address of a pointer to the adapter.</param>
        /// <returns>HRESULT indicating success or failure.</returns>
        private static int EnumAdapters(IntPtr factory, uint adapter, out IntPtr ppAdapter)
        {
            // IDXGIFactory vtable layout:
            // 0: QueryInterface (IUnknown)
            // 1: AddRef (IUnknown)
            // 2: Release (IUnknown)
            // 3: SetPrivateData (IDXGIObject)
            // 4: SetPrivateDataInterface (IDXGIObject)
            // 5: GetPrivateData (IDXGIObject)
            // 6: GetParent (IDXGIObject)
            // 7: EnumAdapters (IDXGIFactory) <- Target method

            IntPtr vTable = Marshal.ReadIntPtr(factory);
            IntPtr enumAdaptersPtr = Marshal.ReadIntPtr(vTable, 7 * IntPtr.Size);

            EnumAdaptersDelegate enumAdapters = Marshal.GetDelegateForFunctionPointer<EnumAdaptersDelegate>(enumAdaptersPtr);
            return enumAdapters(factory, adapter, out ppAdapter);
        }

        /// <summary>
        /// Gets the adapter description using the IDXGIAdapter virtual function table.
        /// </summary>
        /// <param name="adapter">Pointer to the adapter.</param>
        /// <param name="desc">Reference to the adapter description structure.</param>
        /// <returns>HRESULT indicating success or failure.</returns>
        private static int GetAdapterDesc(IntPtr adapter, ref DXGI_ADAPTER_DESC desc)
        {
            // IDXGIAdapter vtable layout:
            // 0: QueryInterface (IUnknown)
            // 1: AddRef (IUnknown)
            // 2: Release (IUnknown)
            // 3: SetPrivateData (IDXGIObject)
            // 4: SetPrivateDataInterface (IDXGIObject)
            // 5: GetPrivateData (IDXGIObject)
            // 6: GetParent (IDXGIObject)
            // 7: EnumOutputs (IDXGIAdapter)
            // 8: GetDesc (IDXGIAdapter) <- Target method

            IntPtr vTable = Marshal.ReadIntPtr(adapter);
            IntPtr getDescPtr = Marshal.ReadIntPtr(vTable, 8 * IntPtr.Size);

            GetDescDelegate getDesc = Marshal.GetDelegateForFunctionPointer<GetDescDelegate>(getDescPtr);
            return getDesc(adapter, ref desc);
        }

        /// <summary>
        /// Delegate for IDXGIFactory::EnumAdapters method.
        /// </summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int EnumAdaptersDelegate(IntPtr pFactory, uint Adapter, out IntPtr ppAdapter);

        /// <summary>
        /// Delegate for IDXGIAdapter::GetDesc method.
        /// </summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate int GetDescDelegate(IntPtr pAdapter, ref DXGI_ADAPTER_DESC pDesc);

        #endregion
    }

    #region Public Data Classes

    /// <summary>
    /// Contains information about a graphics adapter.
    /// </summary>
    /// <remarks>
    /// This class provides a managed representation of graphics adapter information
    /// retrieved from the DXGI API.
    /// </remarks>
    public class AdapterInfo
    {
        /// <summary>
        /// Gets the adapter description string (GPU name).
        /// </summary>
        /// <example>
        /// "NVIDIA GeForce RTX 3080", "Intel(R) UHD Graphics 630"
        /// </example>
        public string Description { get; }

        /// <summary>
        /// Gets the adapter's vendor ID.
        /// </summary>
        /// <remarks>
        /// Common vendor IDs:
        /// - 0x10DE: NVIDIA
        /// - 0x1002: AMD
        /// - 0x8086: Intel
        /// - 0x1414: Microsoft (Software Renderer)
        /// </remarks>
        public uint VendorId { get; }

        /// <summary>
        /// Gets the vendor name based on the vendor ID.
        /// </summary>
        public string VendorName => VendorId switch
        {
            0x10DE => "NVIDIA",
            0x1002 => "AMD",
            0x8086 => "Intel",
            0x1414 => "Microsoft",
            _ => "Unknown"
        };

        /// <summary>
        /// Gets the adapter's device ID.
        /// </summary>
        public uint DeviceId { get; }

        /// <summary>
        /// Gets the adapter's subsystem ID.
        /// </summary>
        public uint SubSysId { get; }

        /// <summary>
        /// Gets the adapter's revision number.
        /// </summary>
        public uint Revision { get; }

        /// <summary>
        /// Gets the dedicated video memory in bytes.
        /// </summary>
        public ulong DedicatedVideoMemory { get; }

        /// <summary>
        /// Gets the dedicated video memory in megabytes.
        /// </summary>
        public ulong DedicatedVideoMemoryMB => DedicatedVideoMemory / 1024 / 1024;

        /// <summary>
        /// Gets the dedicated system memory in bytes.
        /// </summary>
        public ulong DedicatedSystemMemory { get; }

        /// <summary>
        /// Gets the shared system memory in bytes.
        /// </summary>
        public ulong SharedSystemMemory { get; }

        /// <summary>
        /// Gets the adapter's LUID (Locally Unique Identifier).
        /// </summary>
        /// <remarks>
        /// The LUID uniquely identifies the adapter in the system and is used by
        /// Windows Performance Counters to track GPU-specific metrics.
        /// </remarks>
        public (int HighPart, uint LowPart) Luid { get; }

        /// <summary>
        /// Gets the LUID as a formatted string.
        /// </summary>
        /// <remarks>
        /// Format: "0xXXXXXXXX_0xXXXXXXXX" (HighPart_LowPart)
        /// This format matches the LUID format used in Windows Performance Counters.
        /// </remarks>
        /// <example>
        /// "0x00000000_0x0001223B"
        /// </example>
        public string LuidString => $"0x{Luid.HighPart:X8}_0x{Luid.LowPart:X8}";

        /// <summary>
        /// Gets the zero-based index of the adapter in the enumeration.
        /// </summary>
        public uint Index { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdapterInfo"/> class.
        /// </summary>
        /// <param name="desc">The DXGI adapter description.</param>
        /// <param name="index">The adapter index.</param>
        internal AdapterInfo(DxgiAdapterEnumerator.DXGI_ADAPTER_DESC desc, uint index)
        {
            Index = index;
            DeviceId = desc.DeviceId;
            Revision = desc.Revision;
            SubSysId = desc.SubSysId;
            VendorId = desc.VendorId;
            Description = desc.Description;
            SharedSystemMemory = (ulong)desc.SharedSystemMemory;
            DedicatedVideoMemory = (ulong)desc.DedicatedVideoMemory;
            DedicatedSystemMemory = (ulong)desc.DedicatedSystemMemory;
            Luid = (desc.AdapterLuid.HighPart, desc.AdapterLuid.LowPart);
        }

        /// <summary>
        /// Returns a string representation of the adapter information.
        /// </summary>
        public override string ToString()
        {
            return $"{Description} ({VendorName}) - {DedicatedVideoMemoryMB} MB VRAM - LUID: {LuidString}";
        }

        /// <summary>
        /// Returns a detailed string representation of the adapter's properties and memory configuration.
        /// </summary>
        /// <remarks>The returned string includes information such as the adapter's index, description,
        /// vendor details, device identifiers, memory allocation, and the locally unique identifier (LUID). This method
        /// is primarily intended for diagnostic or logging purposes.</remarks>
        /// <returns>A string containing detailed information about the adapter, including its index, description, vendor and
        /// device IDs, memory configuration, and LUID.</returns>
        public string ToDetailedString()
        {
            return $"Adapter #{Index}: {Description}\n" +
                   $"  Vendor ID: 0x{VendorId:X4} ({VendorName})\n" +
                   $"  Device ID: 0x{DeviceId:X4}\n" +
                   $"  SubSys ID: 0x{SubSysId:X4}\n" +
                   $"  Revision: 0x{Revision:X4}\n" +
                   $"  Dedicated Video Memory: {DedicatedVideoMemoryMB} MB\n" +
                   $"  Dedicated System Memory: {DedicatedSystemMemory / 1024 / 1024} MB\n" +
                   $"  Shared System Memory: {SharedSystemMemory / 1024 / 1024} MB\n" +
                   $"  LUID: {LuidString}";
        }
    }

    #endregion
}
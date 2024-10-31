using System;
using System.Runtime.InteropServices;
using DISPPARAMS = System.Runtime.InteropServices.ComTypes.DISPPARAMS;
using EXCEPINFO = System.Runtime.InteropServices.ComTypes.EXCEPINFO;
using HRESULT = Skylark.Wing.Native.Methods.HRESULT;

namespace Skylark.Wing.Interface
{
    /// <summary>
    /// 
    /// </summary>
    [ComImport]
    [Guid("d597bab3-5b9f-11d1-8dd2-00aa004abd5e")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ISensLogon
    {
        #region <IDispatch>

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        int GetTypeInfoCount();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="iTInfo"></param>
        /// <param name="lcid"></param>
        /// <returns></returns>
        [return: MarshalAs(UnmanagedType.Interface)]
        IntPtr GetTypeInfo([In, MarshalAs(UnmanagedType.U4)] int iTInfo, [In, MarshalAs(UnmanagedType.U4)] int lcid);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="riid"></param>
        /// <param name="rgszNames"></param>
        /// <param name="cNames"></param>
        /// <param name="lcid"></param>
        /// <param name="rgDispId"></param>
        /// <returns></returns>
        [PreserveSig]
        HRESULT GetIDsOfNames([In] ref Guid riid, [In, MarshalAs(UnmanagedType.LPArray)] string[] rgszNames, [In, MarshalAs(UnmanagedType.U4)] int cNames, [In, MarshalAs(UnmanagedType.U4)] int lcid, [Out, MarshalAs(UnmanagedType.LPArray)] int[] rgDispId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dispIdMember"></param>
        /// <param name="riid"></param>
        /// <param name="lcid"></param>
        /// <param name="dwFlags"></param>
        /// <param name="pDispParams"></param>
        /// <param name="pVarResult"></param>
        /// <param name="pExcepInfo"></param>
        /// <param name="pArgErr"></param>
        /// <returns></returns>
        [PreserveSig]
        HRESULT Invoke(int dispIdMember, [In] ref Guid riid, [In, MarshalAs(UnmanagedType.U4)] int lcid, [In, MarshalAs(UnmanagedType.U4)] int dwFlags, [Out, In] DISPPARAMS pDispParams, [Out] out object pVarResult, [Out, In] EXCEPINFO pExcepInfo, [Out, MarshalAs(UnmanagedType.LPArray)] IntPtr[] pArgErr);

        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stringUserName"></param>
        /// <returns></returns>
        [PreserveSig]
        HRESULT Logon(string stringUserName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stringUserName"></param>
        /// <returns></returns>
        [PreserveSig]
        HRESULT Logoff(string stringUserName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stringUserName"></param>
        /// <returns></returns>
        [PreserveSig]
        HRESULT StartShell(string stringUserName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stringUserName"></param>
        /// <returns></returns>
        [PreserveSig]
        HRESULT DisplayLock(string stringUserName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stringUserName"></param>
        /// <returns></returns>
        [PreserveSig]
        HRESULT DisplayUnlock(string stringUserName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stringUserName"></param>
        /// <returns></returns>
        [PreserveSig]
        HRESULT StartScreenSaver(string stringUserName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stringUserName"></param>
        /// <returns></returns>
        [PreserveSig]
        HRESULT StopScreenSaver(string stringUserName);
    }
}
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
    [Guid("4E14FB9F-2E22-11D1-9964-00C04FBBB345")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IEventSystem
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
        /// <param name="progID"></param>
        /// <param name="queryCriteria"></param>
        /// <param name="errorIndex"></param>
        /// <param name="ppInterface"></param>
        /// <returns></returns>
        [PreserveSig]
        HRESULT Query(string progID, string queryCriteria, out int errorIndex, out IntPtr ppInterface);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ProgID"></param>
        /// <param name="pInterface"></param>
        /// <returns></returns>
        [PreserveSig]
        HRESULT Store(string ProgID, IntPtr pInterface);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="progID"></param>
        /// <param name="queryCriteria"></param>
        /// <param name="errorIndex"></param>
        /// <returns></returns>
        [PreserveSig]
        HRESULT Remove(string progID, string queryCriteria, out int errorIndex);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pbstrEventClassID"></param>
        /// <returns></returns>
        [PreserveSig]
        HRESULT get_EventObjectChangeEventClassID(out string pbstrEventClassID);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="progID"></param>
        /// <param name="queryCriteria"></param>
        /// <param name="ppInterface"></param>
        /// <returns></returns>
        [PreserveSig]
        HRESULT QueryS(string progID, string queryCriteria, out IntPtr ppInterface);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="progID"></param>
        /// <param name="queryCriteria"></param>
        /// <returns></returns>
        [PreserveSig]
        HRESULT RemoveS(string progID, string queryCriteria);
    }
}
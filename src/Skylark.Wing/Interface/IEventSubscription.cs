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
    [Guid("4A6B0E15-2E38-11D1-9965-00C04FBBB345")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IEventSubscription
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
        /// <param name="pstringSubscriptionID"></param>
        /// <returns></returns>
        HRESULT get_SubscriptionID(out string pstringSubscriptionID);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stringSubscriptionID"></param>
        /// <returns></returns>
        HRESULT put_SubscriptionID(string stringSubscriptionID);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pstringSubscriptionName"></param>
        /// <returns></returns>
        HRESULT get_SubscriptionName(out string pstringSubscriptionName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stringSubscriptionName"></param>
        /// <returns></returns>
        HRESULT put_SubscriptionName(string stringSubscriptionName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pstringPublisherID"></param>
        /// <returns></returns>
        HRESULT get_PublisherID(out string pstringPublisherID);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stringPublisherID"></param>
        /// <returns></returns>
        HRESULT put_PublisherID(string stringPublisherID);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pstringEventClassID"></param>
        /// <returns></returns>
        HRESULT get_EventClassID(out string pstringEventClassID);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stringEventClassID"></param>
        /// <returns></returns>
        HRESULT put_EventClassID(string stringEventClassID);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pstringMethodName"></param>
        /// <returns></returns>
        HRESULT get_MethodName(out string pstringMethodName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stringMethodName"></param>
        /// <returns></returns>
        HRESULT put_MethodName(string stringMethodName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pstringSubscriberCLSID"></param>
        /// <returns></returns>
        HRESULT get_SubscriberCLSID(out string pstringSubscriberCLSID);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stringSubscriberCLSID"></param>
        /// <returns></returns>
        HRESULT put_SubscriberCLSID(string stringSubscriberCLSID);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ppSubscriberInterface"></param>
        /// <returns></returns>
        HRESULT get_SubscriberInterface(out IntPtr ppSubscriberInterface);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pSubscriberInterface"></param>
        /// <returns></returns>
        HRESULT put_SubscriberInterface(IntPtr pSubscriberInterface);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pfPerUser"></param>
        /// <returns></returns>
        HRESULT get_PerUser(out bool pfPerUser);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fPerUser"></param>
        /// <returns></returns>
        HRESULT put_PerUser(bool fPerUser);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pstringOwnerSID"></param>
        /// <returns></returns>
        HRESULT get_OwnerSID(out string pstringOwnerSID);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stringOwnerSID"></param>
        /// <returns></returns>
        HRESULT put_OwnerSID(string stringOwnerSID);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pfEnabled"></param>
        /// <returns></returns>
        HRESULT get_Enabled(out bool pfEnabled);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fEnabled"></param>
        /// <returns></returns>
        HRESULT put_Enabled(bool fEnabled);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pstringDescription"></param>
        /// <returns></returns>
        HRESULT get_Description(out string pstringDescription);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stringDescription"></param>
        /// <returns></returns>
        HRESULT put_Description(string stringDescription);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pstringMachineName"></param>
        /// <returns></returns>
        HRESULT get_MachineName(out string pstringMachineName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stringMachineName"></param>
        /// <returns></returns>
        HRESULT put_MachineName(string stringMachineName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stringPropertyName"></param>
        /// <param name="propertyValue"></param>
        /// <returns></returns>
        //HRESULT GetPublisherProperty(string stringPropertyName, out VARIANT propertyValue);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stringPropertyName"></param>
        /// <param name="propertyValue"></param>
        /// <returns></returns>
        HRESULT GetPublisherProperty(string stringPropertyName, out object propertyValue);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stringPropertyName"></param>
        /// <param name="propertyValue"></param>
        /// <returns></returns>
        //HRESULT PutPublisherProperty(string stringPropertyName, VARIANT propertyValue);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stringPropertyName"></param>
        /// <param name="propertyValue"></param>
        /// <returns></returns>
        HRESULT PutPublisherProperty(string stringPropertyName, object propertyValue);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stringPropertyName"></param>
        /// <returns></returns>
        HRESULT RemovePublisherProperty(string stringPropertyName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        //HRESULT GetPublisherPropertyCollection(out IEventObjectCollection collection);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        HRESULT GetPublisherPropertyCollection(out IntPtr collection);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stringPropertyName"></param>
        /// <param name="propertyValue"></param>
        /// <returns></returns>
        //HRESULT GetSubscriberProperty(string stringPropertyName, out VARIANT propertyValue);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stringPropertyName"></param>
        /// <param name="propertyValue"></param>
        /// <returns></returns>
        HRESULT GetSubscriberProperty(string stringPropertyName, out object propertyValue);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stringPropertyName"></param>
        /// <param name="propertyValue"></param>
        /// <returns></returns>
        //HRESULT PutSubscriberProperty(string stringPropertyName, VARIANT propertyValue);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stringPropertyName"></param>
        /// <param name="propertyValue"></param>
        /// <returns></returns>
        HRESULT PutSubscriberProperty(string stringPropertyName, object propertyValue);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stringPropertyName"></param>
        /// <returns></returns>
        HRESULT RemoveSubscriberProperty(string stringPropertyName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        //HRESULT GetSubscriberPropertyCollection(out IEventObjectCollection collection);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="collection"></param>
        /// <returns></returns>
        HRESULT GetSubscriberPropertyCollection(out IntPtr collection);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pstringInterfaceID"></param>
        /// <returns></returns>
        HRESULT get_InterfaceID(out string pstringInterfaceID);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stringInterfaceID"></param>
        /// <returns></returns>
        HRESULT put_InterfaceID(string stringInterfaceID);
    }
}
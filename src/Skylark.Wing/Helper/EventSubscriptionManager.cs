using System;
using System.Runtime.InteropServices;
using DISPPARAMS = System.Runtime.InteropServices.ComTypes.DISPPARAMS;
using EXCEPINFO = System.Runtime.InteropServices.ComTypes.EXCEPINFO;
using HRESULT = Skylark.Wing.Native.Methods.HRESULT;
using SWIIEL = Skylark.Wing.Interface.IEventListener;
using SWIIESM = Skylark.Wing.Interface.IEventSystem;
using SWIIESN = Skylark.Wing.Interface.IEventSubscription;

namespace Skylark.Wing.Helper
{
    /// <summary>
    /// EventSubscriptionManager Class - Handles event subscription logic
    /// </summary>
    public class EventSubscriptionManager(SWIIEL eventListener)
    {
        private SWIIESM _eventSystem;

        public HRESULT Initialize()
        {
            HRESULT hr = HRESULT.E_FAIL;

            Guid CLSID_CEventSubscription = new("7542e960-79c7-11d1-88f9-0080c7d771bf");

            Type eventSubscriptionType = Type.GetTypeFromCLSID(CLSID_CEventSubscription, true);

            object eventSubscription = Activator.CreateInstance(eventSubscriptionType);

            SWIIESN pEventSubscription = (SWIIESN)eventSubscription;

            if (pEventSubscription != null)
            {
                hr = pEventSubscription.put_EventClassID("{D5978630-5B9F-11D1-8DD2-00AA004ABD5E}");

                if (hr == HRESULT.S_OK)
                {
                    hr = pEventSubscription.put_SubscriptionName("SkylarkEventSubscriptionManager");

                    if (hr == HRESULT.S_OK)
                    {
                        hr = pEventSubscription.put_PerUser(true);

                        if (hr == HRESULT.S_OK)
                        {
                            IntPtr pSubscriberInterface = Marshal.GetIUnknownForObject(this);

                            hr = pEventSubscription.put_SubscriberInterface(pSubscriberInterface);

                            Guid CLSID_CEventSystem = new("4E14FBA2-2E22-11D1-9964-00C04FBBB345");

                            Type eventSystemType = Type.GetTypeFromCLSID(CLSID_CEventSystem, true);

                            object eventSystem = Activator.CreateInstance(eventSystemType);

                            _eventSystem = (SWIIESM)eventSystem;

                            IntPtr pInterface = Marshal.GetIUnknownForObject(pEventSubscription);

                            hr = _eventSystem.Store("EventSystem.EventSubscription", pInterface);
                        }
                    }
                }

                Marshal.ReleaseComObject(pEventSubscription);
            }

            return hr;
        }

        public HRESULT Uninitialize()
        {
            HRESULT hr = HRESULT.E_FAIL;

            if (_eventSystem != null)
            {
                // System.UnauthorizedAccessException
                // HResult = 0x80070005
                // Message = Accès refusé. (Exception de HRESULT: 0x80070005(E_ACCESSDENIED))

                hr = _eventSystem.Remove("EventSystem.EventSubscription", "EventClassID={D5978630-5B9F-11D1-8DD2-00AA004ABD5E}", out _);

                Marshal.ReleaseComObject(_eventSystem);
            }

            return hr;
        }

        public int GetTypeInfoCount()
        {
            throw new NotImplementedException();
        }

        public IntPtr GetTypeInfo(int iTInfo, int lcid)
        {
            throw new NotImplementedException();
        }

        public HRESULT GetIDsOfNames(ref Guid riid, string[] rgszNames, int cNames, int lcid, int[] rgDispId)
        {
            throw new NotImplementedException();
        }

        public HRESULT Invoke(int dispIdMember, ref Guid riid, int lcid, int dwFlags, DISPPARAMS pDispParams, out object pVarResult, EXCEPINFO pExcepInfo, IntPtr[] pArgErr)
        {
            throw new NotImplementedException();
        }

        public HRESULT Logon(string userName)
        {
            return eventListener.OnLogon(userName);
        }

        public HRESULT Logoff(string userName)
        {
            return eventListener.OnLogoff(userName);
        }

        public HRESULT StartShell(string userName)
        {
            return eventListener.OnStartShell(userName);
        }

        public HRESULT DisplayLock(string userName)
        {
            return eventListener.OnDisplayLock(userName);
        }

        public HRESULT DisplayUnlock(string userName)
        {
            return eventListener.OnDisplayUnlock(userName);
        }

        public HRESULT StartScreenSaver(string userName)
        {
            return eventListener.OnStartScreenSaver(userName);
        }

        public HRESULT StopScreenSaver(string userName)
        {
            return eventListener.OnStopScreenSaver(userName);
        }
    }
}
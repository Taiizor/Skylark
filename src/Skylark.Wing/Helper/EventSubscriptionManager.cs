using System;
using System.Runtime.InteropServices;
using DISPPARAMS = System.Runtime.InteropServices.ComTypes.DISPPARAMS;
using EXCEPINFO = System.Runtime.InteropServices.ComTypes.EXCEPINFO;
using SWIIEL = Skylark.Wing.Interface.IEventListener;
using SWIIESM = Skylark.Wing.Interface.IEventSystem;
using SWIIESN = Skylark.Wing.Interface.IEventSubscription;
using SWNM = Skylark.Wing.Native.Methods;

namespace Skylark.Wing.Helper
{
    /// <summary>
    /// EventSubscriptionManager Class - Handles event subscription logic
    /// </summary>
    public class EventSubscriptionManager
    {
        private readonly SWIIEL _eventListener;
        private SWIIESM _eventSystem;

        public EventSubscriptionManager(SWIIEL eventListener)
        {
            _eventListener = eventListener;
        }

        public SWNM.HRESULT Initialize()
        {
            SWNM.HRESULT hr = SWNM.HRESULT.E_FAIL;

            Guid CLSID_CEventSubscription = new("7542e960-79c7-11d1-88f9-0080c7d771bf");

            Type eventSubscriptionType = Type.GetTypeFromCLSID(CLSID_CEventSubscription, true);

            object eventSubscription = Activator.CreateInstance(eventSubscriptionType);

            SWIIESN pEventSubscription = (SWIIESN)eventSubscription;

            if (pEventSubscription != null)
            {
                hr = pEventSubscription.put_EventClassID("{D5978630-5B9F-11D1-8DD2-00AA004ABD5E}");

                if (hr == SWNM.HRESULT.S_OK)
                {
                    hr = pEventSubscription.put_SubscriptionName("SkylarkEventSubscriptionManager");

                    if (hr == SWNM.HRESULT.S_OK)
                    {
                        hr = pEventSubscription.put_PerUser(true);

                        if (hr == SWNM.HRESULT.S_OK)
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

        public SWNM.HRESULT Uninitialize()
        {
            SWNM.HRESULT hr = SWNM.HRESULT.E_FAIL;

            if (_eventSystem != null)
            {
                // System.UnauthorizedAccessException
                // HResult = 0x80070005
                // Message = Accès refusé. (Exception de HRESULT: 0x80070005(E_ACCESSDENIED))

                hr = _eventSystem.Remove("EventSystem.EventSubscription", "EventClassID={D5978630-5B9F-11D1-8DD2-00AA004ABD5E}", out int errorIndex);

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

        public SWNM.HRESULT GetIDsOfNames(ref Guid riid, string[] rgszNames, int cNames, int lcid, int[] rgDispId)
        {
            throw new NotImplementedException();
        }

        public SWNM.HRESULT Invoke(int dispIdMember, ref Guid riid, int lcid, int dwFlags, DISPPARAMS pDispParams, out object pVarResult, EXCEPINFO pExcepInfo, IntPtr[] pArgErr)
        {
            throw new NotImplementedException();
        }

        public SWNM.HRESULT Logon(string userName)
        {
            return _eventListener.OnLogon(userName);
        }

        public SWNM.HRESULT Logoff(string userName)
        {
            return _eventListener.OnLogoff(userName);
        }

        public SWNM.HRESULT StartShell(string userName)
        {
            return _eventListener.OnStartShell(userName);
        }

        public SWNM.HRESULT DisplayLock(string userName)
        {
            return _eventListener.OnDisplayLock(userName);
        }

        public SWNM.HRESULT DisplayUnlock(string userName)
        {
            return _eventListener.OnDisplayUnlock(userName);
        }

        public SWNM.HRESULT StartScreenSaver(string userName)
        {
            return _eventListener.OnStartScreenSaver(userName);
        }

        public SWNM.HRESULT StopScreenSaver(string userName)
        {
            return _eventListener.OnStopScreenSaver(userName);
        }
    }
}
using SWNM = Skylark.Wing.Native.Methods;

namespace Skylark.Wing.Interface
{
    /// <summary>
    /// 
    /// </summary>
    public interface IEventListener
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        SWNM.HRESULT OnLogon(string userName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        SWNM.HRESULT OnLogoff(string userName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        SWNM.HRESULT OnStartShell(string userName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        SWNM.HRESULT OnDisplayLock(string userName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        SWNM.HRESULT OnDisplayUnlock(string userName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        SWNM.HRESULT OnStartScreenSaver(string userName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        SWNM.HRESULT OnStopScreenSaver(string userName);
    }
}
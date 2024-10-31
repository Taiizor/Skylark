using HRESULT = Skylark.Wing.Native.Methods.HRESULT;

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
        HRESULT OnLogon(string userName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        HRESULT OnLogoff(string userName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        HRESULT OnStartShell(string userName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        HRESULT OnDisplayLock(string userName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        HRESULT OnDisplayUnlock(string userName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        HRESULT OnStartScreenSaver(string userName);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        HRESULT OnStopScreenSaver(string userName);
    }
}
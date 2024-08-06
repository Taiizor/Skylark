#region Imports

using SEPT = Skylark.Enum.PortType;
using SEST = Skylark.Enum.ServiceType;
using SSCCS = Skylark.Struct.Certificate.CertificateStruct;
using SSECCE = Skylark.Standard.Extension.Certificate.CertificateExtension;
using SSEPPGE = Skylark.Standard.Extension.Ping.PingExtension;
using SSEPPTE = Skylark.Standard.Extension.Port.PortExtension;
using SSPPSS = Skylark.Struct.Ping.PingSendStruct;

#endregion

// |---------DO-NOT-REMOVE---------|
//
//     Creator: Taiizor
//     Website: www.Vegalya.com
//     Created: 27.Feb.2023
//     Changed: 06.Aug.2024
//     Version: 3.1.5.1
//
// |---------DO-NOT-REMOVE---------|

namespace Skylark.Uptime
{
    #region Core

    #region Uptimer

    /// <summary>
    /// Skylark uptimer class. 
    /// </summary>
    public class Uptimer(string Address)
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Timeout"></param>
        /// <returns></returns>
        public SSPPSS Ping(int Timeout = 3000)
        {
            return SSEPPGE.Send(Address, Timeout);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Timeout"></param>
        /// <returns></returns>
        public async Task<SSCCS> Certificate(int Timeout = 3000)
        {
            return await SSECCE.GetCertificateAsync(Address, Timeout);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Port"></param>
        /// <param name="Timeout"></param>
        /// <returns></returns>
        public SEPT Service(int Port, int Timeout = 3000)
        {
            return SSEPPTE.Scan(Address, Port, Timeout);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Type"></param>
        /// <param name="Timeout"></param>
        /// <returns></returns>
        public SEPT Service(SEST Type, int Timeout = 3000)
        {
            return Service((int)Type, Timeout);
        }
    }

    #endregion

    #endregion
}
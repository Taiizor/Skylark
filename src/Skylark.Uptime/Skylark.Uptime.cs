#region Imports

using Skylark.Enum;
using Skylark.Standard.Extension.Port;
using Skylark.Struct.Ping;
using System.Net.Sockets;
using SSEPPE = Skylark.Standard.Extension.Ping.PingExtension;

#endregion

// |---------DO-NOT-REMOVE---------|
//
//     Creator: Taiizor
//     Website: www.Vegalya.com
//     Created: 27.Feb.2023
//     Changed: 02.Feb.2023
//     Version: 3.0.0.3
//
// |---------DO-NOT-REMOVE---------|

namespace Skylark.Uptime
{
    #region Core

    #region Uptimer

    /// <summary>
    /// Skylark uptimer class. 
    /// </summary>
    public class Uptimer
    {
        private readonly string domainName;

        public Uptimer(string domainName)
        {
            this.domainName = domainName;
        }

        public PingSendStruct Ping()
        {
            return SSEPPE.Send(domainName);
        }

        public PortType Service(ServiceUptimeType Type)
        {
            return PortExtension.Scan(domainName, (int)Type);
        }
    }

    #endregion

    #endregion
}
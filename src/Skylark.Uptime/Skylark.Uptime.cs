#region Imports

using Skylark.Struct.Ping;
using System.Net.Sockets;
using SAE = Skylark.ArgumentException;
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

        public bool Service(string serviceName)
        {
            int port = serviceName.ToLower() switch
            {
                "http" => 80,
                "https" => 443,
                "smtp" => 25,
                "pop3" => 110,
                "imap" => 143,
                "ftp" => 21,
                "ssh" => 22,
                _ => throw new SAE("Geçersiz servis adı"),
            };
            try
            {
                using TcpClient client = new();
                client.Connect(domainName, port);

                return true;
            }
            catch (SocketException)
            {
                return false;
            }
        }
    }

    #endregion

    #endregion
}
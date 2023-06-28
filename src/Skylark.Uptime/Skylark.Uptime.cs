#region Imports

using System.Net.Security;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using SEPT = Skylark.Enum.PortType;
using SEST = Skylark.Enum.ServiceType;
using SSCCS = Skylark.Struct.Certificate.CertificateStruct;
using SSEPPGE = Skylark.Standard.Extension.Ping.PingExtension;
using SSEPPTE = Skylark.Standard.Extension.Port.PortExtension;
using SSPPSS = Skylark.Struct.Ping.PingSendStruct;
using SUMI = Skylark.Uptime.Manage.Internal;

#endregion

// |---------DO-NOT-REMOVE---------|
//
//     Creator: Taiizor
//     Website: www.Vegalya.com
//     Created: 27.Feb.2023
//     Changed: 28.Jun.2023
//     Version: 3.0.1.4
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
        private readonly string Address = Address;

        public SSPPSS Ping()
        {
            return SSEPPGE.Send(Address);
        }

        public async Task<SSCCS> Certificate()
        {
            try
            {
                using TcpClient Client = new();
                await Client.ConnectAsync(Address, 443);

                using NetworkStream Stream = Client.GetStream();
                using SslStream sslStream = new(Stream);
                await sslStream.AuthenticateAsClientAsync(Address);

                X509Certificate certificate = sslStream.RemoteCertificate;
                if (certificate != null)
                {
                    string expirationDateString = certificate.GetExpirationDateString();
                    if (DateTime.TryParse(expirationDateString, out DateTime expirationDateTime))
                    {
                        int remainingDays = (int)(expirationDateTime - DateTime.Now).TotalDays;
                        return new()
                        {
                            State = true,
                            RemainingDays = remainingDays,
                            ExpirationDateTime = expirationDateTime
                        };
                    }
                    else
                    {
                        return SUMI.CertificateStruct;
                    }
                }
                else
                {
                    return SUMI.CertificateStruct;
                }
            }
            catch
            {
                return SUMI.CertificateStruct;
            }
        }

        public SEPT Service(SEST Type)
        {
            return SSEPPTE.Scan(Address, (int)Type);
        }
    }

    #endregion

    #endregion
}
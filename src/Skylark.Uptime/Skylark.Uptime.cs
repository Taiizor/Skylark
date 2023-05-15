#region Imports

using Skylark.Enum;
using Skylark.Standard.Extension.Port;
using Skylark.Struct.Certificate;
using Skylark.Struct.Ping;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using SSEPPE = Skylark.Standard.Extension.Ping.PingExtension;
using SUMI = Skylark.Uptime.Manage.Internal;

#endregion

// |---------DO-NOT-REMOVE---------|
//
//     Creator: Taiizor
//     Website: www.Vegalya.com
//     Created: 27.Feb.2023
//     Changed: 23.Mar.2023
//     Version: 3.0.0.6
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
        /// <summary>
        /// 
        /// </summary>
        private readonly string Address;

        public Uptimer(string Address)
        {
            this.Address = Address;
        }

        public PingSendStruct Ping()
        {
            return SSEPPE.Send(Address);
        }

        public async Task<CertificateStruct> Certificate()
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

        public PortType Service(ServiceType Type)
        {
            return PortExtension.Scan(Address, (int)Type);
        }
    }

    #endregion

    #endregion
}
﻿#region Imports

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
//     Changed: 10.Jun.2024
//     Version: 3.1.4.6
//
// |---------DO-NOT-REMOVE---------|

namespace Skylark.Uptime
{
    #region Core

    #region Uptimer

    /// <summary>
    /// Skylark uptimer class. 
    /// </summary>
    public class Uptimer(string Address, int Timeout = 3000)
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public SSPPSS Ping()
        {
            return SSEPPGE.Send(Address, Timeout);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<SSCCS> Certificate()
        {
            try
            {
                using TcpClient Client = new()
                {
                    SendTimeout = Timeout,
                    ReceiveTimeout = Timeout,
                };

                if (Address.Contains("https://"))
                {
                    Address = Address.Replace("https://", "");
                }

                if (Address.Contains("http://"))
                {
                    Address = Address.Replace("http://", "");
                }

                await Client.ConnectAsync(Address, 443);

                using NetworkStream Network = Client.GetStream();

                using SslStream Ssl = new(Network);

                await Ssl.AuthenticateAsClientAsync(Address);

                X509Certificate Certificate = Ssl.RemoteCertificate;

                if (Certificate != null)
                {
                    string ExpirationDateString = Certificate.GetExpirationDateString();

                    if (DateTime.TryParse(ExpirationDateString, out DateTime ExpirationDateTime))
                    {
                        int RemainingDays = (int)(ExpirationDateTime - DateTime.UtcNow).TotalDays; //DateTime.Now

                        return new()
                        {
                            State = true,
                            RemainingDays = RemainingDays,
                            ExpirationDateTime = ExpirationDateTime
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Port"></param>
        /// <returns></returns>
        public SEPT Service(int Port)
        {
            return SSEPPTE.Scan(Address, Port, Timeout);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Type"></param>
        /// <returns></returns>
        public SEPT Service(SEST Type)
        {
            return SSEPPTE.Scan(Address, (int)Type, Timeout);
        }
    }

    #endregion

    #endregion
}
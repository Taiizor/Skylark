using System.Net.Security;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using SE = Skylark.Exception;
using SHL = Skylark.Helper.Length;
using SSCCS = Skylark.Struct.Certificate.CertificateStruct;
using SSHCCH = Skylark.Standard.Helper.Certificate.CertificateHelper;
using SSMCCM = Skylark.Standard.Manage.Certificate.CertificateManage;

namespace Skylark.Standard.Extension.Certificate
{
    /// <summary>
    /// 
    /// </summary>
    public static class CertificateExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Address"></param>
        /// <param name="Timeout"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static SSCCS GetCertificate(string Address = SSMCCM.Address, int Timeout = SSMCCM.Timeout)
        {
            try
            {
                Address = SSHCCH.GetAddress(Address);
                Address = SHL.Parameter(Address, SSMCCM.Address);
                Timeout = SHL.Clamp(Timeout, SSMCCM.MinTimeout, SSMCCM.MaxTimeout);

                SSCCS Result = SSMCCM.Result;

                using TcpClient Client = new()
                {
                    SendTimeout = Timeout,
                    ReceiveTimeout = Timeout,
                };

                Client.Connect(Address, 443);

                using NetworkStream Network = Client.GetStream();

                using SslStream Ssl = new(Network);

                Ssl.AuthenticateAsClient(Address);

                X509Certificate Certificate = Ssl.RemoteCertificate;

                if (Certificate != null)
                {
                    string ExpirationDateString = Certificate.GetExpirationDateString();

                    if (DateTime.TryParse(ExpirationDateString, out DateTime ExpirationDateTime))
                    {
                        Result.State = true;
                        Result.ExpirationDateTime = ExpirationDateTime;
                        Result.RemainingDays = (int)(ExpirationDateTime - DateTime.UtcNow).TotalDays; //DateTime.Now;
                    }
                }

                return Result;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Address"></param>
        /// <param name="Timeout"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static async Task<SSCCS> GetCertificateAsync(string Address = SSMCCM.Address, int Timeout = SSMCCM.Timeout)
        {
            try
            {
                Address = SSHCCH.GetAddress(Address);
                Address = SHL.Parameter(Address, SSMCCM.Address);
                Timeout = SHL.Clamp(Timeout, SSMCCM.MinTimeout, SSMCCM.MaxTimeout);

                SSCCS Result = SSMCCM.Result;

                using TcpClient Client = new()
                {
                    SendTimeout = Timeout,
                    ReceiveTimeout = Timeout,
                };

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
                        Result.State = true;
                        Result.ExpirationDateTime = ExpirationDateTime;
                        Result.RemainingDays = (int)(ExpirationDateTime - DateTime.UtcNow).TotalDays; //DateTime.Now;
                    }
                }

                return Result;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }
    }
}
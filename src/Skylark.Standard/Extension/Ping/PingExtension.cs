using System.Net.NetworkInformation;
using SE = Skylark.Exception;
using SHL = Skylark.Helper.Length;
using SSMPPM = Skylark.Standard.Manage.Ping.PingManage;
using SSPPSS = Skylark.Struct.Ping.PingSendStruct;
using SNNIP = System.Net.NetworkInformation.Ping;
using SNNIPO = System.Net.NetworkInformation.PingOptions;
using SSHPPH = Skylark.Standard.Helper.Ping.PingHelper;

namespace Skylark.Standard.Extension.Ping
{
    /// <summary>
    /// 
    /// </summary>
    public static class PingExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Address"></param>
        /// <param name="Timeout"></param>
        /// <param name="Ttl"></param>
        /// <param name="Fragment"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static SSPPSS Send(string Address = SSMPPM.Address, int Timeout = SSMPPM.Timeout, int Ttl = SSMPPM.Ttl, bool Fragment = SSMPPM.Fragment)
        {
            try
            {
                Address = SSHPPH.GetAddress(Address);
                Address = SHL.Parameter(Address, SSMPPM.Address);

                SNNIP Ping = new();
                SSPPSS Result = SSMPPM.Result;

                SNNIPO PingOptions = new(SHL.Clamp(Ttl, SSMPPM.MinTtl, SSMPPM.MaxTtl), Fragment);

                PingReply Reply = Ping.Send(Address, SHL.Clamp(Timeout, SSMPPM.MinTimeout, SSMPPM.MaxTimeout), SSMPPM.Buffer, PingOptions);

                if (Reply.Status == IPStatus.Success)
                {
                    Result.Result = Reply.Status;
                    Result.Ttl = Reply.Options.Ttl;
                    Result.Buffer = Reply.Buffer.Length;
                    Result.RoundTrip = Reply.RoundtripTime;
                    Result.Address = Reply.Address.ToString();
                    Result.Fragment = Reply.Options.DontFragment;
                }
                else
                {
                    Result.Address = Address;
                    Result.Result = Reply.Status;
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
        /// <param name="Ttl"></param>
        /// <param name="Fragment"></param>
        /// <returns></returns>
        public static async Task<SSPPSS> SendAsync(string Address = SSMPPM.Address, int Timeout = SSMPPM.Timeout, int Ttl = SSMPPM.Ttl, bool Fragment = SSMPPM.Fragment)
        {
            return await Task.Run(() => Send(Address, Timeout, Ttl, Fragment));
        }
    }
}
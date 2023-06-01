using System.Net.NetworkInformation;
using E = Skylark.Exception;
using HL = Skylark.Helper.Length;
using ME = Skylark.Standard.Manage.External;
using MPM = Skylark.Standard.Manage.Ping.PingManage;
using SPPSS = Skylark.Struct.Ping.PingSendStruct;

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
        public static SPPSS Send(string Address = MPM.Address, int Timeout = MPM.Timeout, int Ttl = MPM.Ttl, bool Fragment = MPM.Fragment)
        {
            try
            {
                Address = HL.Parameter(Address, MPM.Address);

                SPPSS Result = MPM.Result;

                ME.PingOptions = new(HL.Clamp(Ttl, MPM.MinTtl, MPM.MaxTtl), Fragment);

                PingReply Reply = ME.Ping.Send(Address, HL.Clamp(Timeout, MPM.MinTimeout, MPM.MaxTimeout), MPM.Buffer, ME.PingOptions);

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
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
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
        public static async Task<SPPSS> SendAsync(string Address = MPM.Address, int Timeout = MPM.Timeout, int Ttl = MPM.Ttl, bool Fragment = MPM.Fragment)
        {
            return await Task.Run(() => Send(Address, Timeout, Ttl, Fragment));
        }
    }
}
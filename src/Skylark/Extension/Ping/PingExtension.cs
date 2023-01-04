using System.Net.NetworkInformation;
using E = Skylark.Exception;
using HL = Skylark.Helper.Length;
using ME = Skylark.Manage.External;
using MPM = Skylark.Manage.PingManage;
using SPSS = Skylark.Struct.PingSendStruct;

namespace Skylark.Extension
{
    /// <summary>
    /// 
    /// </summary>
    public class PingExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Address"></param>
        /// <param name="Timeout"></param>
        /// <param name="Ttl"></param>
        /// <param name="Fragment"></param>
        /// <returns></returns>
        public static SPSS Send(string Address = MPM.Address, int Timeout = MPM.Timeout, int Ttl = MPM.Ttl, bool Fragment = MPM.Fragment)
        {
            try
            {
                Address = HL.Parameter(Address, MPM.Address);

                SPSS Result = MPM.Result;

                ME.PingOptions = new(HL.Number(Ttl, MPM.MinTtl, MPM.MaxTtl), Fragment);

                PingReply Reply = ME.Ping.Send(Address, HL.Number(Timeout, MPM.MinTimeout, MPM.MaxTimeout), MPM.Buffer, ME.PingOptions);

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
    }
}
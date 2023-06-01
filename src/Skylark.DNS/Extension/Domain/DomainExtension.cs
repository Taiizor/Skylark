using DCIDQR = DnsClient.IDnsQueryResponse;
using DCLC = DnsClient.LookupClient;
using DCPDRR = DnsClient.Protocol.DnsResourceRecord;
using SE = Skylark.Exception;
using SEQDT = Skylark.Enum.QueryDomainType;
using SDNSHC = Skylark.DNS.Helper.Converter;
using SHL = Skylark.Helper.Length;
using SDNSMDDM = Skylark.DNS.Manage.Domain.DomainManage;
using SDNSME = Skylark.DNS.Manage.External;
using SNIPA = System.Net.IPAddress;
using SNIPEP = System.Net.IPEndPoint;

namespace Skylark.DNS.Extension.Domain
{
    /// <summary>
    /// 
    /// </summary>
    public static class DomainExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Domain"></param>
        /// <param name="Type"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static DCIDQR QueryResponse(string Domain = SDNSMDDM.Domain, SEQDT Type = SDNSMDDM.QueryType)
        {
            try
            {
                Domain = SHL.Parameter(Domain, SDNSMDDM.Domain);

                SNIPEP Endpoint = new(SNIPA.Parse(SDNSME.Server), SDNSME.Port);
                DCLC Client = new(Endpoint);

                return Client.Query(Domain, SDNSHC.Convert(Type, SDNSMDDM.DefaultType));
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Domain"></param>
        /// <param name="Type"></param>
        /// <returns></returns>
        public static async Task<DCIDQR> QueryResponseAsync(string Domain = SDNSMDDM.Domain, SEQDT Type = SDNSMDDM.QueryType)
        {
            return await Task.Run(() => QueryResponse(Domain, Type));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Domain"></param>
        /// <param name="Type"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static IReadOnlyList<DCPDRR> QueryAnswers(string Domain = SDNSMDDM.Domain, SEQDT Type = SDNSMDDM.QueryType)
        {
            try
            {
                DCIDQR Result = QueryResponse(Domain, Type);

                return Result.Answers;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Domain"></param>
        /// <param name="Type"></param>
        /// <returns></returns>
        public static async Task<IReadOnlyList<DCPDRR>> QueryAnswersAsync(string Domain = SDNSMDDM.Domain, SEQDT Type = SDNSMDDM.QueryType)
        {
            return await Task.Run(() => QueryAnswers(Domain, Type));
        }
    }
}
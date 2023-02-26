using DCIDQR = DnsClient.IDnsQueryResponse;
using DCLC = DnsClient.LookupClient;
using DCPDRR = DnsClient.Protocol.DnsResourceRecord;
using E = Skylark.Exception;
using EQDT = Skylark.DNS.Enum.QueryDomainType;
using HC = Skylark.DNS.Helper.Converter;
using HL = Skylark.Helper.Length;
using MDDM = Skylark.DNS.Manage.Domain.DomainManage;
using ME = Skylark.DNS.Manage.External;
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
        /// <exception cref="E"></exception>
        public static DCIDQR QueryResponse(string Domain = MDDM.Domain, EQDT Type = MDDM.QueryType)
        {
            try
            {
                Domain = HL.Parameter(Domain, MDDM.Domain);

                SNIPEP Endpoint = new(SNIPA.Parse(ME.Server), ME.Port);
                DCLC Client = new(Endpoint);

                return Client.Query(Domain, HC.Convert(Type, MDDM.DefaultType));
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Domain"></param>
        /// <param name="Type"></param>
        /// <returns></returns>
        public static Task<DCIDQR> QueryResponseAsync(string Domain = MDDM.Domain, EQDT Type = MDDM.QueryType)
        {
            return Task.Run(() => QueryResponse(Domain, Type));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Domain"></param>
        /// <param name="Type"></param>
        public static IReadOnlyList<DCPDRR> QueryAnswers(string Domain = MDDM.Domain, EQDT Type = MDDM.QueryType)
        {
            try
            {
                DCIDQR Result = QueryResponse(Domain, Type);

                return Result.Answers;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Domain"></param>
        /// <param name="Type"></param>
        /// <returns></returns>
        public static Task<IReadOnlyList<DCPDRR>> QueryAnswersAsync(string Domain = MDDM.Domain, EQDT Type = MDDM.QueryType)
        {
            return Task.Run(() => QueryAnswers(Domain, Type));
        }
    }
}
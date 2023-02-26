using DnsClient;
using DnsClient.Protocol;
using E = Skylark.Exception;
using EQDT = Skylark.DNS.Enum.QueryDomainType;
using HC = Skylark.DNS.Helper.Converter;
using MDDM = Skylark.DNS.Manage.Domain.DomainManage;
using ME = Skylark.DNS.Manage.External;
using MI = Skylark.DNS.Manage.Internal;

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
        public static IDnsQueryResponse QueryResponse(string Domain = MDDM.Domain, EQDT Type = MDDM.QueryType)
        {
            try
            {
                Domain = Domain.Length > MI.ParameterLength ? MDDM.Domain : Domain;

                return ME.Client.Query(Domain, HC.Convert(Type, MDDM.DefaultType));
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
        public static Task<IDnsQueryResponse> QueryResponseAsync(string Domain = MDDM.Domain, EQDT Type = MDDM.QueryType)
        {
            return Task.Run(() => QueryResponse(Domain, Type));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Domain"></param>
        /// <param name="Type"></param>
        public static IReadOnlyList<DnsResourceRecord> QueryAnswers(string Domain = MDDM.Domain, EQDT Type = MDDM.QueryType)
        {
            try
            {
                IDnsQueryResponse Result = QueryResponse(Domain, Type);

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
        public static Task<IReadOnlyList<DnsResourceRecord>> QueryAnswersAsync(string Domain = MDDM.Domain, EQDT Type = MDDM.QueryType)
        {
            return Task.Run(() => QueryAnswers(Domain, Type));
        }
    }
}
namespace Skylark.Enum
{
    /// <summary>
    /// 
    /// </summary>
    public enum QueryDomainType
    {
        /// <summary>
        /// 
        /// </summary>
        A = 1,
        /// <summary>
        /// 
        /// </summary>
        NS = 2,
        /// <summary>
        /// 
        /// </summary>
        [Obsolete("Use MX")]
        /// <summary>
        /// 
        /// </summary>
        MD = 3,
        /// <summary>
        /// 
        /// </summary>
        [Obsolete("Use MX")]
        /// <summary>
        /// 
        /// </summary>
        MF = 4,
        /// <summary>
        /// 
        /// </summary>
        CNAME = 5,
        /// <summary>
        /// 
        /// </summary>
        SOA = 6,
        /// <summary>
        /// 
        /// </summary>
        MB = 7,
        /// <summary>
        /// 
        /// </summary>
        MG = 8,
        /// <summary>
        /// 
        /// </summary>
        MR = 9,
        /// <summary>
        /// 
        /// </summary>
        NULL = 10,
        /// <summary>
        /// 
        /// </summary>
        WKS = 11,
        /// <summary>
        /// 
        /// </summary>
        PTR = 12,
        /// <summary>
        /// 
        /// </summary>
        HINFO = 13,
        /// <summary>
        /// 
        /// </summary>
        MINFO = 14,
        /// <summary>
        /// 
        /// </summary>
        MX = 0xF,
        /// <summary>
        /// 
        /// </summary>
        TXT = 0x10,
        /// <summary>
        /// 
        /// </summary>
        RP = 17,
        /// <summary>
        /// 
        /// </summary>
        AFSDB = 18,
        /// <summary>
        /// 
        /// </summary>
        AAAA = 28,
        /// <summary>
        /// 
        /// </summary>
        SRV = 33,
        /// <summary>
        /// 
        /// </summary>
        NAPTR = 35,
        /// <summary>
        /// 
        /// </summary>
        DS = 43,
        /// <summary>
        /// 
        /// </summary>
        RRSIG = 46,
        /// <summary>
        /// 
        /// </summary>
        NSEC = 47,
        /// <summary>
        /// 
        /// </summary>
        DNSKEY = 48,
        /// <summary>
        /// 
        /// </summary>
        NSEC3 = 50,
        /// <summary>
        /// 
        /// </summary>
        NSEC3PARAM = 51,
        /// <summary>
        /// 
        /// </summary>
        TLSA = 52,
        /// <summary>
        /// 
        /// </summary>
        SPF = 99,
        /// <summary>
        /// 
        /// </summary>
        AXFR = 252,
        /// <summary>
        /// 
        /// </summary>
        ANY = 0xFF,
        /// <summary>
        /// 
        /// </summary>
        URI = 0x100,
        /// <summary>
        /// 
        /// </summary>
        CAA = 257,
        /// <summary>
        /// 
        /// </summary>
        SSHFP = 44
    }
}

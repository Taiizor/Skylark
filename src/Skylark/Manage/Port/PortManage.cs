namespace Skylark.Manage
{
    /// <summary>
    /// 
    /// </summary>
    internal class PortManage
    {
        /// <summary>
        /// 
        /// </summary>
        public const int Count = 10;

        /// <summary>
        /// 
        /// </summary>
        public const int Port = 443;
        /// <summary>
        /// 
        /// </summary>
        public const int MinPort = 0;
        /// <summary>
        /// 
        /// </summary>
        public const int MaxPort = 65535;

        /// <summary>
        /// 
        /// </summary>
        public const int Timeout = 500;
        /// <summary>
        /// 
        /// </summary>
        public const int MinTimeout = 100;
        /// <summary>
        /// 
        /// </summary>
        public const int MaxTimeout = 3000;

        /// <summary>
        /// 
        /// </summary>
        public const string Unknown = "Unknown";

        /// <summary>
        /// 
        /// </summary>
        public const string Address = "www.google.com";

        /// <summary>
        /// 
        /// </summary>
        public static readonly int[] Ports = new[] { 21, 22, 53, 80, 110, 143, 587, 3306 };

        /// <summary>
        /// 
        /// </summary>
        public static readonly Dictionary<int, string> List = new()
        {
            { 21, "FTP" },
            { 22, "SSH & SFTP" },
            { 23, "TELNET" },
            { 25, "SMTP" },
            { 43, "WHOIS" },
            { 50, "IPSec NAT-T" },
            { 53, "DNS" },
            { 67, "DHCP Server" },
            { 68, "DHCP Client" },
            { 69, "TFTP" },
            { 79, "FINGER" },
            { 80, "HTTP" },
            { 88, "Kerberos" },
            { 110, "POP3" },
            { 119, "NNTP" },
            { 135, "Microsoft RPC" },
            { 137, "NetBIOS Server" },
            { 139, "NetBIOS Client" },
            { 143, "IMAP" },
            { 161, "SNMP" },
            { 162, "SNMP" },
            { 179, "BGP" },
            { 389, "LDAP" },
            { 443, "HTTPS" },
            { 444, "SNPP" },
            { 458, "Apple QuickTime" },
            { 465, "SMTPS" },
            { 569, "MSN" },
            { 587, "SMTP" },
            { 993, "IMAPS" },
            { 995, "POP3S" },
            { 1194, "OpenVPN" },
            { 1433, "SQL Server" },
            { 1521, "ORACLE" },
            { 1723, "PPTP" },
            { 1900, "UPnP" },
            { 2049, "NFS" },
            { 2222, "Direct Admin" },
            { 2375, "Docker REST API" },
            { 3000, "Rails" },
            { 3306, "MySQL" },
            { 3389, "Microsoft RDP" },
            { 5000, "UPnP" },
            { 5432, "PostgreSQL" },
            { 6379, "Redis" },
            { 6646, "IRC" },
            { 8008, "HTTP Alternate" },
            { 8080, "HTTP Alternate" },
            { 8443, "HTTPS Alternate" },
            { 27017, "MongoDB" }
        };
    }
}
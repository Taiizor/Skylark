namespace Skylark.Standard.Manage.Port
{
    /// <summary>
    /// 
    /// </summary>
    internal static class PortManage
    {
        /// <summary>
        /// 
        /// </summary>
        public const int Count = 16;

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
        public const int MaxTimeout = 9000;

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
        public static readonly string Error = $"There can be up to {Count} ports.";

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
            { 123, "NTP" },
            { 135, "Microsoft RPC" },
            { 137, "NetBIOS Name Service" },
            { 138, "NetBIOS Datagram Service" },
            { 139, "NetBIOS Session Service" },
            { 143, "IMAP" },
            { 161, "SNMP" },
            { 162, "SNMP" },
            { 179, "BGP" },
            { 389, "LDAP" },
            { 443, "HTTPS" },
            { 444, "SNPP" },
            { 458, "Apple QuickTime" },
            { 465, "SMTPS" },
            { 500, "IPSec" },
            { 514, "Syslog" },
            { 515, "LPD" },
            { 569, "MSN" },
            { 587, "SMTP" },
            { 636, "LDAPS" },
            { 873, "RSYNC" },
            { 990, "FTPS" },
            { 993, "IMAPS" },
            { 995, "POP3S" },
            { 1194, "OpenVPN" },
            { 1433, "SQL Server" },
            { 1434, "SQL Server Browser Service" },
            { 1521, "ORACLE" },
            { 1527, "Apache Derby" },
            { 1723, "PPTP" },
            { 1812, "RADIUS Authentication" },
            { 1813, "RADIUS Accounting" },
            { 1900, "UPnP" },
            { 2049, "NFS" },
            { 2082, "cPanel" },
            { 2083, "cPanel SSL" },
            { 2222, "Direct Admin" },
            { 2375, "Docker REST API" },
            { 3000, "Rails" },
            { 3306, "MySQL" },
            { 3389, "Microsoft RDP" },
            { 3690, "Subversion" },
            { 4369, "Erlang Port Mapper" },
            { 5000, "UPnP" },
            { 5001, "IBM DB2" },
            { 5432, "PostgreSQL" },
            { 5672, "AMQP" },
            { 5985, "WinRM HTTP" },
            { 5986, "WinRM HTTPS" },
            { 6379, "Redis" },
            { 6443, "Kubernetes API" },
            { 6667, "IRC" },
            { 6646, "IRC" },
            { 7000, "Cassandra" },
            { 7001, "Cassandra SSL" },
            { 7199, "Cassandra JMX" },
            { 8000, "HTTP Alternate" },
            { 8008, "HTTP Alternate" },
            { 8080, "HTTP Alternate" },
            { 8086, "InfluxDB" },
            { 8443, "HTTPS Alternate" },
            { 9000, "SonarQube" },
            { 9042, "Cassandra Native Transport" },
            { 9092, "Kafka" },
            { 9160, "Cassandra Thrift" },
            { 9200, "Elasticsearch" },
            { 9418, "Git" },
            { 11211, "Memcached" },
            { 15672, "RabbitMQ Management" },
            { 27017, "MongoDB" },
            { 27018, "MongoDB Sharding" },
            { 27019, "MongoDB Config Server" },
            { 33060, "MySQL (X Protocol)" },
            { 33848, "CalDAV" },
            { 33849, "CardDAV" },
            { 50000, "SAP" }
        };
    }
}
using SSBBS = Skylark.Struct.Browser.BrowserStruct;

namespace Skylark.Standard.Manage.Browser
{
    /// <summary>
    /// 
    /// </summary>
    internal static class BrowserManage
    {
        /// <summary>
        /// 
        /// </summary>
        public const string RobotNone = "Human";

        /// <summary>
        /// 
        /// </summary>
        public const string MobileNone = "Desktop";

        /// <summary>
        /// 
        /// </summary>
        public const string VersionNone = "Unknown Version";

        /// <summary>
        /// 
        /// </summary>
        public const string BrowserNone = "Unknown Browser";

        /// <summary>
        /// 
        /// </summary>
        public const string PlatformNone = "Unknown Platform";

        /// <summary>
        /// 
        /// </summary>
        public const string UserAgent = "Mozilla/5.0 (Windows NT 11.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/120.0.0.0 Safari/537.36 Edg/120.0.0.0";

        /// <summary>
        /// 
        /// </summary>
        public static readonly SSBBS Result = new()
        {
            RobotIs = false,
            MobileIs = false,
            BrowserIs = false,
            Robot = RobotNone,
            Mobile = MobileNone,
            Browser = BrowserNone,
            Platform = PlatformNone,
            BrowserVersion = VersionNone
        };

        /// <summary>
        /// 
        /// </summary>
        public static readonly Dictionary<string, string> Robots = new()
        {
            { "Google", "Google" },
            //{"Googlebot", "Google"},
            //{"Googlebot-Image", "Google"},
            //{"AdsBot-Google", "Google"},
            //{"Google-Site-Verification", "Google"},
            { "Feedfetcher-Google", "Google" },
            { "Mediapartners-Google", "Google" },
            { "Yandex", "Yandex" },
            //{"YandexBot", "Yandex"},
            { "Discordbot", "Discord" },
            { "WhatsApp", "WhatsApp" },
            { "FaceBook", "FaceBook" },
            //{"facebookexternalhit", "FaceBook"},
            { "Applebot", "Apple" },
            { "Twitter", "Twitter" },
            //{"Twitterbot", "Twitter"},
            { "Bingbot", "Bing" },
            { "DuckDuckBot", "DuckDuckGo" },
            { "keycdn-tools", "SpeedTest" },
            { "libwww-perl", "LibPerl" },
            { "Python-urllib", "LibPython" },
            { "NetcraftSurveyAgent", "NetCraft" },
            { "Nimbostratus-Bot", "CloudSystemNetworks" },
            { "NinjaBot", "InternetMarketingNinjas" },
            { "AhrefsBot", "Ahrefs" },
            { "SemrushBot", "Semrush" },
            { "MJ12bot", "Majestic" },
            { "XML-Sitemaps", "XMLGen" },
            { "Microsoft", "Microsoft" },
            { "msnbot", "MSNBot" },
            //{"baiduspider", "BaiduSpider"},
            { "Baiduspider", "BaiduSpider" },
            { "Yahoo", "Yahoo" },
            //{"Yahoo! Slurp", "Yahoo"},
            { "Y!J-ASR", "Yahoo" },
            { "Y!J-BSC", "Yahoo" },
            { "infoseek", "InfoSeek" },
            //{"marvin", "InfoSeek"},
            { "Lycos", "Lycos" },
            { "CrazyWebCrawler", "CrazyWebcrawler" },
            { "curious george", "CuriousGeorge" },
            { "Alexabot", "Alexa" },
            { "ia_archiver", "Alexa" },
            { "Uptimebot", "UptimeBot" },
            { "Sogou", "SogouSpider" },
            { "Exabot", "ExaBot" },
            { "ZoomSpider", "ZSEBOT" },
            { "ChangeDetection", "ChangeDetection" },
            { "Slackbot", "SlackBot" },
            { "Slack-ImgProxy", "SlackBot" },
            { "YisouSpider", "YisouSpider" },
            //{"dotbot", "DotBot"},
            { "DotBot", "DotBot" },
            { "FeedDemon", "FeedDemon" },
            { "Qwantify", "Qwantify" },
            //{"ssearch_bot", "SSearch_Bot"},
            { "ICC-Crawler", "ICC-Crawler" },
            { "magpie-crawler", "Magpie-Crawler" },
            //{"seznambot", "SeznamBot"},
            { "SeznamBot", "SeznamBot" },
            { "WeSEE", "WeSEE" },
            //{"WeSEE_Bot", "WeSEE"},
            //{"WeSEE:Search", "WeSEE"},
            //{"WeSEE:Ads", "WeSEE"},
            { "CCBot", "CCBot" },
            //{"commoncrawl.org/research//Nutch", "CCBot"},
            { "CCResearchBot", "CCBot" },
            { "coccoc", "CocCoc" },
            { "EtaoSpider", "EtaoSpider" },
            { "HTTrack", "HTTrack" },
            //{"IntuitGSACrawler", ""},
            { "gsa-crawler", "GSA-Crawler" },
            { "Mail.RU_Bot", "MailRU" },
            //{"rogerbot", "RogerBot"},
            { "rogerBot", "RogerBot" },
            { "Roverbot", "RoverBot" },
            { "TeleportPro", "TeleportPro" },
            { "Teleport Pro", "TeleportPro" },
            { "ZyBorg", "ZyBorg" },
            { "Nutch", "Nutch" },
            { "ask jeeves", "AskJeeves" },
            { "Teoma", "AskJeeves" },
            { "Daumoa", "Daumoa" },
            { "Daum", "Daum" },
            { "NaverBot", "Yeti" },
            { "Naver", "Yeti" },
            { "Yeti", "Yeti" }
        };

        /// <summary>
        /// 
        /// </summary>
        public static readonly Dictionary<string, string> Mobiles = new()
        {
			// Legacy array, old values commented out
            { "MobileExplorer", "Mobile Explorer" },
            //{ "OpenWave", "Open Wave" },
            //{ "Opera Mini", "Opera Mini" },
            //{ "OperaMini", "Opera Mini" },
            //{ "Elaine", "Palm" },
            { "PalmSource", "Palm" },
            //{ "Digital Paths", "Palm" },
            //{ "Avantgo", "Avantgo" },
            //{ "Xiino", "Xiino" },
            { "Palmscape", "Palmscape" },
            //{ "Nokia", "Nokia" },
            //{ "Ericsson", "Ericsson" },
            //{ "BlackBerry", "BlackBerry" },
            //{ "Motorola", "Motorola" },

            // Phones and Manufacturers
            { "Motorola", "Motorola" },
            { "Nokia", "Nokia" },
            { "Nexus", "Nexus" },
            { "Palm", "Palm" },
            { "iPhone", "iPhone" },
            { "iPad", "iPad" },
            { "iPod", "iPod" },
            { "Sony", "Sony Ericsson" },
            { "Ericsson", "Sony Ericsson" },
            { "BlackBerry", "BlackBerry" },
            { "PlayBook", "BlackBerry" },
            { "BB10", "BlackBerry" },
            { "Cocoon", "O2 Cocoon" },
            { "Blazer", "Treo" },
            { "LG", "LG" },
            { "Amoi", "Amoi" },
            { "XDA", "XDA" },
            { "MDA", "MDA" },
            { "Vario", "Vario" },
            { "HTC", "HTC" },
            { "Samsung", "Samsung" },
            { "Sharp", "Sharp" },
            { "Sie-", "Siemens" },
            { "Alcatel", "Alcatel" },
            { "BenQ", "BenQ" },
            { "iPaq", "HP iPaq" },
            { "Mot-", "Motorola" },
            { "PlayStation Portable", "PlayStation Portable" },
            { "PlayStation 3", "PlayStation 3" },
            { "PlayStation Vita", "PlayStation Vita" },
            { "PlayStation", "PlayStation" },
            { "Hiptop", "Danger Hiptop" },
            { "NEC-", "NEC" },
            { "Panasonic", "Panasonic" },
            { "Philips", "Philips" },
            { "Sagem", "Sagem" },
            { "Sanyo", "Sanyo" },
            { "SPV", "SPV" },
            { "ZTE", "ZTE" },
            { "Sendo", "Sendo" },
            { "Nintendo DSi", "Nintendo DSi" },
            { "Nintendo DS", "Nintendo DS" },
            { "Nintendo 3DS", "Nintendo 3DS" },
            { "Wii", "Nintendo Wii" },
            { "Open Web", "Open Web" },
            { "OpenWeb", "OpenWeb" },

            // Operating Systems
            { "Android", "Android" },
            { "Symbian", "Symbian" },
            { "SymbianOS", "Symbian OS" },
            { "Elaine", "Palm" },
            { "Series60", "Symbian S60" },
            { "Windows CE", "Windows CE" },
            { "Windows Phone", "Windows Phone" },
            { "WPDesktop", "Windows Phone" },

            // Browsers
            { "Obigo", "Obigo" },
            { "Netfront", "Netfront Browser" },
            { "Openwave", "Openwave Browser" },
            { "MobilExplorer", "Mobile Explorer" },
            { "OperaMini", "Opera Mini" },
            { "Opera Mini", "Opera Mini" },
            { "Opera Mobi", "Opera Mobile" },
            { "Fennec", "Firefox Mobile" },

            // Other
            { "Digital Paths", "Digital Paths" },
            { "AvantGo", "AvantGo" },
            { "Xiino", "Xiino" },
            { "Novarra", "Novarra Transcoder" },
            { "Vodafone", "Vodafone" },
            { "Docomo", "NTT DoCoMo" },
            { "O2", "O2" },
            { "KFAPWI", "Kindle Fire" },
            { "KFAP", "Kindle Fire" },

            // FallBack
            { "Mobile", "Generic Mobile" },
            { "Wireless", "Generic Mobile" },
            { "J2ME", "Generic Mobile" },
            { "MIDP", "Generic Mobile" },
            { "CLDC", "Generic Mobile" },
            { "UP.Link", "Generic Mobile" },
            { "UP.Browser", "Generic Mobile" },
            { "SmartPhone", "Generic Mobile" },
            { "CellPhone", "Generic Mobile" }
        };

        /// <summary>
        /// 
        /// </summary>
        public static readonly Dictionary<string, string> Browsers = new()
        {
            { "Trident/7.0", "Internet Explorer" },
            { "Beamrise", "Beamrise" },
            { "Opera", "Opera" },
            { "OPR", "Opera" },
            { "Edg", "Edge" },
            { "Edge", "Edge" },
            { "Flock", "Flock" },
            { "Shiira", "Shiira" },
            { "Chimera", "Chimera" },
            { "Phoenix", "Phoenix" },
            { "Firebird", "FireBird" },
            { "Camino", "Camino" },
            { "Dolphin", "Dolphin" },
            { "Netscape", "Netscape" },
            { "OmniWeb", "OmniWeb" },
            { "Konqueror", "Konqueror" },
            { "iCab", "iCab" },
            { "Lynx", "Lynx" },
            { "Links", "Links" },
            { "HotJava", "HotJava" },
            { "Amaya", "Amaya" },
            { "IBrowse", "IBrowse" },
            { "iTunes", "iTunes" },
            { "Silk", "Silk" },
            { "Dillo", "Dillo" },
            { "Maxthon", "Maxthon" },
            { "Arora", "Arora" },
            { "Galeon", "Galeon" },
            { "Iceape", "Iceape" },
            { "Iceweasel", "Iceweasel" },
            { "Midori", "Midori" },
            { "QupZilla", "QupZilla" },
            { "Namoroka", "Namoroka" },
            { "NetSurf", "NetSurf" },
            { "BOLT", "BOLT" },
            { "EudoraWeb", "EudoraWeb" },
            { "ShadowFox", "ShadowFox" },
            { "Swiftfox", "SwiftFox" },
            { "Uzbl", "Uzbl" },
            { "uBrowser", "u Browser" },
            { "UCBrowser", "UC Browser" },
            { "Kindle", "Kindle" },
            { "wOSBrowser", "wOS Browser" },
            { "Epiphany", "Epiphany" },
            { "SeaMonkey", "SeaMonkey" },
            { "Avant Browser", "Avant Browser" },
            { "Mobile Safari", "Mobile Safari" },
            { "Chrome", "Chrome" },
            { "MSIE", "Internet Explorer" },
            { "Internet Explorer", "Internet Explorer" },
            { "Safari", "Safari" },
            { "Vivaldi", "Vivaldi" },
            { "Yandex", "Yandex" },
            { "DMBrowser", "DM Browser" },
            { "Firefox", "Firefox" },
            { "Mozilla", "Mozilla" }
            //{ "Ubuntu", "UbuntuWebBrowser" }
        };

        /// <summary>
        /// 
        /// </summary>
        public static readonly Dictionary<string, string> Platforms = new()
        {
            { "Windows NT 15.0", "Windows 15" },
            { "Windows NT 14.0", "Windows 14" },
            { "Windows NT 13.0", "Windows 13" },
            { "Windows NT 12.0", "Windows 12" },
            { "Windows NT 11.0", "Windows 11" },
            { "Windows NT 10.0", "Windows 10" },
            { "Windows NT 6.3", "Windows 8.1" },
            { "Windows NT 6.2", "Windows 8" },
            { "Windows NT 6.1", "Windows 7" },
            { "Windows NT 6.0", "Windows Vista" },
            { "Windows NT 5.2", "Windows 2003" },
            { "Windows NT 5.1", "Windows XP" },
            { "Windows NT 5.0", "Windows 2000" },
            { "Windows NT 4.0", "Windows NT_4.0" },
            { "WinNT4.0", "Windows NT_4.0" },
            { "WinNT 4.0", "Windows NT" },
            { "WinNT", "Windows NT" },
            { "Windows 98", "Windows 98" },
            { "Win98", "Windows 98" },
            { "Windows 95", "Windows 95" },
            { "Win95", "Windows 95" },
            { "Windows Phone", "Windows Phone" },
            { "Windows", "Windows OS" },
            { "iPhone", "iOS" },
            { "iPad", "iOS" },
            { "iPod", "iOS" },
            { "Android", "Android" },
            { "Linux", "Linux" },
            { "Nokia", "Nokia" },
            { "BlackBerry", "BlackBerry" },
            { "PlayBook", "BlackBerry" },
            { "BB10", "BlackBerry" },
            { "FreeBSD", "Free BSD" },
            { "OpenBSD", "Open BSD" },
            { "NetBSD", "Net BSD" },
            { "Unix", "Unix OS" },
            { "DragonFly", "DragonFlyBSD" },
            { "OpenSolaris", "OpenSolaris" },
            { "SunOS", "Sun OS" },
            { "OS/2", "OS/2" },
            { "BeOS", "Be OS" },
            { "Dillo", "Linux" },
            { "PalmOS", "Palm OS" },
            { "Symbian", "Symbian OS" },
            { "Pardus", "Pardus" },
            { "RebelMouse", "RebelMouse" },
            { "Macintosh", "Macintosh" },
            { "OS X", "Mac OS X" },
            { "PPC Mac", "Power PC Mac" },
            { "PPC", "Macintosh" },
            { "Debian", "Debian" },
            { "ApacheBench", "ApacheBench" },
            { "AIX", "AIX" },
            { "Irix", "Irix" },
            { "BSDi", "BSDi" },
            { "GNU", "GNU/Linux" },
            { "OSF", "DEC OSF" },
            { "HP-UX", "HP-UX" },
            { "Mac", "Macintosh" },
            { "Win", "Windows OS" }
        };
    }
}
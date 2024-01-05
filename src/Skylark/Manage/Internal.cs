using ETZT = Skylark.Enum.TimeZoneType;
using SRRS = Skylark.Struct.Rectangles.RectanglesStruct;

namespace Skylark.Manage
{
    /// <summary>
    /// 
    /// </summary>
    public static class Internal
    {
        /// <summary>
        /// 
        /// </summary>
        public const int PathLength = 4096;

        /// <summary>
        /// 
        /// </summary>
        public const int TextLength = 5000000;

        /// <summary>
        /// 
        /// </summary>
        public static SRRS CombinedRectangles;

        /// <summary>
        /// 
        /// </summary>
        public const int ParameterLength = 128;

        /// <summary>
        /// 1 GB = 1073741824 Byte
        /// 2 GB = 2147483648 Byte
        /// 3 GB = 3221225472 Byte
        /// 4 GB = 4294967296 Byte
        /// 5 GB = 5368709120 Byte
        /// </summary>
        public const long FileLength = 5368709120;

        /// <summary>
        /// 
        /// </summary>
        public const int MONITOR_DEFAULTTONULL = 0;
        /// <summary>
        /// 
        /// </summary>
        public const int MONITOR_DEFAULTTOPRIMARY = 1;
        /// <summary>
        /// 
        /// </summary>
        public const int MONITOR_DEFAULTTONEAREST = 2;

        /// <summary>
        /// 
        /// </summary>
        public static readonly Random Randomise = new();

        /// <summary>
        /// 
        /// </summary>
        public static readonly string[] SplitSpace = new string[] { " " };

        /// <summary>
        /// 
        /// </summary>
        public static readonly string[] SplitNewLine = new string[] { "\r\n", "\r", "\n" };

        /// <summary>
        /// 
        /// </summary>
        public static readonly string[] SplitSpaceNewLine = new string[] { "\r\n", "\r", "\n", " " };

        /// <summary>
        /// 
        /// </summary>
        public static readonly Dictionary<ETZT, string> TimeZoneNames = new()
        {
            { ETZT.GMT_Minus_12_00_International_Date_Line_West, "(GMT-12:00) International Date Line West" },
            { ETZT.GMT_Minus_11_00_American_Samoa, "(GMT-11:00) American Samoa" },
            { ETZT.GMT_Minus_11_00_Midway_Island, "(GMT-11:00) Midway Island" },
            { ETZT.GMT_Minus_10_00_Hawaii, "(GMT-10:00) Hawaii" },
            { ETZT.GMT_Minus_09_00_Alaska, "(GMT-09:00) Alaska" },
            { ETZT.GMT_Minus_08_00_Pacific_Time_US_and_Canada, "(GMT-08:00) Pacific Time (US & Canada)" },
            { ETZT.GMT_Minus_08_00_Tijuana, "(GMT-08:00) Tijuana" },
            { ETZT.GMT_Minus_07_00_Arizona, "(GMT-07:00) Arizona" },
            { ETZT.GMT_Minus_07_00_Mazatlan, "(GMT-07:00) Mazatlan" },
            { ETZT.GMT_Minus_07_00_Mountain_Time_US_and_Canada, "(GMT-07:00) Mountain Time (US & Canada)" },
            { ETZT.GMT_Minus_06_00_Central_America, "(GMT-06:00) Central America" },
            { ETZT.GMT_Minus_06_00_Central_Time_US_and_Canada, "(GMT-06:00) Central Time (US & Canada)" },
            { ETZT.GMT_Minus_06_00_Chihuahua, "(GMT-06:00) Chihuahua" },
            { ETZT.GMT_Minus_06_00_Guadalajara, "(GMT-06:00) Guadalajara" },
            { ETZT.GMT_Minus_06_00_Mexico_City, "(GMT-06:00) Mexico City" },
            { ETZT.GMT_Minus_06_00_Monterrey, "(GMT-06:00) Monterrey" },
            { ETZT.GMT_Minus_06_00_Saskatchewan, "(GMT-06:00) Saskatchewan" },
            { ETZT.GMT_Minus_05_00_Bogota, "(GMT-05:00) Bogota" },
            { ETZT.GMT_Minus_05_00_Eastern_Time_US_and_Canada, "(GMT-05:00) Eastern Time (US & Canada)" },
            { ETZT.GMT_Minus_05_00_Indiana_East, "(GMT-05:00) Indiana (East)" },
            { ETZT.GMT_Minus_05_00_Lima, "(GMT-05:00) Lima" },
            { ETZT.GMT_Minus_05_00_Quito, "(GMT-05:00) Quito" },
            { ETZT.GMT_Minus_04_00_Atlantic_Time_Canada, "(GMT-04:00) Atlantic Time (Canada)" },
            { ETZT.GMT_Minus_04_00_Caracas, "(GMT-04:00) Caracas" },
            { ETZT.GMT_Minus_04_00_Georgetown, "(GMT-04:00) Georgetown" },
            { ETZT.GMT_Minus_04_00_La_Paz, "(GMT-04:00) La Paz" },
            { ETZT.GMT_Minus_04_00_Puerto_Rico, "(GMT-04:00) Puerto Rico" },
            { ETZT.GMT_Minus_04_00_Santiago, "(GMT-04:00) Santiago" },
            { ETZT.GMT_Minus_03_30_Newfoundland, "(GMT-03:30) Newfoundland" },
            { ETZT.GMT_Minus_03_00_Brasilia, "(GMT-03:00) Brasilia" },
            { ETZT.GMT_Minus_03_00_Buenos_Aires, "(GMT-03:00) Buenos Aires" },
            { ETZT.GMT_Minus_03_00_Montevideo, "(GMT-03:00) Montevideo" },
            { ETZT.GMT_Minus_02_00_Greenland, "(GMT-02:00) Greenland" },
            { ETZT.GMT_Minus_02_00_Mid_Atlantic, "(GMT-02:00) Mid-Atlantic" },
            { ETZT.GMT_Minus_01_00_Azores, "(GMT-01:00) Azores" },
            { ETZT.GMT_Minus_01_00_Cape_Verde_Island, "(GMT-01:00) Cape Verde Island" },
            { ETZT.GMT_Plus_00_00_Edinburgh, "(GMT+00:00) Edinburgh" },
            { ETZT.GMT_Plus_00_00_Lisbon, "(GMT+00:00) Lisbon" },
            { ETZT.GMT_Plus_00_00_London, "(GMT+00:00) London" },
            { ETZT.GMT_Plus_00_00_Monrovia, "(GMT+00:00) Monrovia" },
            { ETZT.GMT_Plus_00_00_UTC, "(GMT+00:00) UTC" },
            { ETZT.GMT_Plus_01_00_Amsterdam, "(GMT+01:00) Amsterdam" },
            { ETZT.GMT_Plus_01_00_Belgrade, "(GMT+01:00) Belgrade" },
            { ETZT.GMT_Plus_01_00_Berlin, "(GMT+01:00) Berlin" },
            { ETZT.GMT_Plus_01_00_Bern, "(GMT+01:00) Bern" },
            { ETZT.GMT_Plus_01_00_Bratislava, "(GMT+01:00) Bratislava" },
            { ETZT.GMT_Plus_01_00_Brussels, "(GMT+01:00) Brussels" },
            { ETZT.GMT_Plus_01_00_Budapest, "(GMT+01:00) Budapest" },
            { ETZT.GMT_Plus_01_00_Casablanca, "(GMT+01:00) Casablanca" },
            { ETZT.GMT_Plus_01_00_Copenhagen, "(GMT+01:00) Copenhagen" },
            { ETZT.GMT_Plus_01_00_Dublin, "(GMT+01:00) Dublin" },
            { ETZT.GMT_Plus_01_00_Ljubljana, "(GMT+01:00) Ljubljana" },
            { ETZT.GMT_Plus_01_00_Madrid, "(GMT+01:00) Madrid" },
            { ETZT.GMT_Plus_01_00_Paris, "(GMT+01:00) Paris" },
            { ETZT.GMT_Plus_01_00_Prague, "(GMT+01:00) Prague" },
            { ETZT.GMT_Plus_01_00_Rome, "(GMT+01:00) Rome" },
            { ETZT.GMT_Plus_01_00_Sarajevo, "(GMT+01:00) Sarajevo" },
            { ETZT.GMT_Plus_01_00_Skopje, "(GMT+01:00) Skopje" },
            { ETZT.GMT_Plus_01_00_Stockholm, "(GMT+01:00) Stockholm" },
            { ETZT.GMT_Plus_01_00_Vienna, "(GMT+01:00) Vienna" },
            { ETZT.GMT_Plus_01_00_Warsaw, "(GMT+01:00) Warsaw" },
            { ETZT.GMT_Plus_01_00_West_Central_Africa, "(GMT+01:00) West Central Africa" },
            { ETZT.GMT_Plus_01_00_Zagreb, "(GMT+01:00) Zagreb" },
            { ETZT.GMT_Plus_01_00_Zurich, "(GMT+01:00) Zurich" },
            { ETZT.GMT_Plus_02_00_Athens, "(GMT+02:00) Athens" },
            { ETZT.GMT_Plus_02_00_Bucharest, "(GMT+02:00) Bucharest" },
            { ETZT.GMT_Plus_02_00_Cairo, "(GMT+02:00) Cairo" },
            { ETZT.GMT_Plus_02_00_Harare, "(GMT+02:00) Harare" },
            { ETZT.GMT_Plus_02_00_Helsinki, "(GMT+02:00) Helsinki" },
            { ETZT.GMT_Plus_02_00_Jerusalem, "(GMT+02:00) Jerusalem" },
            { ETZT.GMT_Plus_02_00_Kaliningrad, "(GMT+02:00) Kaliningrad" },
            { ETZT.GMT_Plus_02_00_Kyiv, "(GMT+02:00) Kyiv" },
            { ETZT.GMT_Plus_02_00_Pretoria, "(GMT+02:00) Pretoria" },
            { ETZT.GMT_Plus_02_00_Riga, "(GMT+02:00) Riga" },
            { ETZT.GMT_Plus_02_00_Sofia, "(GMT+02:00) Sofia" },
            { ETZT.GMT_Plus_02_00_Tallinn, "(GMT+02:00) Tallinn" },
            { ETZT.GMT_Plus_02_00_Vilnius, "(GMT+02:00) Vilnius" },
            { ETZT.GMT_Plus_03_00_Baghdad, "(GMT+03:00) Baghdad" },
            { ETZT.GMT_Plus_03_00_Istanbul, "(GMT+03:00) Istanbul" },
            { ETZT.GMT_Plus_03_00_Kuwait, "(GMT+03:00) Kuwait" },
            { ETZT.GMT_Plus_03_00_Minsk, "(GMT+03:00) Minsk" },
            { ETZT.GMT_Plus_03_00_Moscow, "(GMT+03:00) Moscow" },
            { ETZT.GMT_Plus_03_00_Nairobi, "(GMT+03:00) Nairobi" },
            { ETZT.GMT_Plus_03_00_Riyadh, "(GMT+03:00) Riyadh" },
            { ETZT.GMT_Plus_03_00_St_Petersburg, "(GMT+03:00) St. Petersburg" },
            { ETZT.GMT_Plus_03_00_Volgograd, "(GMT+03:00) Volgograd" },
            { ETZT.GMT_Plus_03_30_Tehran, "(GMT+03:30) Tehran" },
            { ETZT.GMT_Plus_04_00_Abu_Dhabi, "(GMT+04:00) Abu Dhabi" },
            { ETZT.GMT_Plus_04_00_Baku, "(GMT+04:00) Baku" },
            { ETZT.GMT_Plus_04_00_Muscat, "(GMT+04:00) Muscat" },
            { ETZT.GMT_Plus_04_00_Samara, "(GMT+04:00) Samara" },
            { ETZT.GMT_Plus_04_00_Tbilisi, "(GMT+04:00) Tbilisi" },
            { ETZT.GMT_Plus_04_00_Yerevan, "(GMT+04:00) Yerevan" },
            { ETZT.GMT_Plus_04_30_Kabul, "(GMT+04:30) Kabul" },
            { ETZT.GMT_Plus_05_00_Ekaterinburg, "(GMT+05:00) Ekaterinburg" },
            { ETZT.GMT_Plus_05_00_Islamabad, "(GMT+05:00) Islamabad" },
            { ETZT.GMT_Plus_05_00_Karachi, "(GMT+05:00) Karachi" },
            { ETZT.GMT_Plus_05_00_Tashkent, "(GMT+05:00) Tashkent" },
            { ETZT.GMT_Plus_05_30_Chennai, "(GMT+05:30) Chennai" },
            { ETZT.GMT_Plus_05_30_Kolkata, "(GMT+05:30) Kolkata" },
            { ETZT.GMT_Plus_05_30_Mumbai, "(GMT+05:30) Mumbai" },
            { ETZT.GMT_Plus_05_30_New_Delhi, "(GMT+05:30) New Delhi" },
            { ETZT.GMT_Plus_05_30_Sri_Jayawardenepura, "(GMT+05:30) Sri Jayawardenepura" },
            { ETZT.GMT_Plus_05_45_Kathmandu, "(GMT+05:45) Kathmandu" },
            { ETZT.GMT_Plus_06_00_Almaty, "(GMT+06:00) Almaty" },
            { ETZT.GMT_Plus_06_00_Astana, "(GMT+06:00) Astana" },
            { ETZT.GMT_Plus_06_00_Dhaka, "(GMT+06:00) Dhaka" },
            { ETZT.GMT_Plus_06_00_Urumqi, "(GMT+06:00) Urumqi" },
            { ETZT.GMT_Plus_06_30_Rangoon, "(GMT+06:30) Rangoon" },
            { ETZT.GMT_Plus_07_00_Bangkok, "(GMT+07:00) Bangkok" },
            { ETZT.GMT_Plus_07_00_Hanoi, "(GMT+07:00) Hanoi" },
            { ETZT.GMT_Plus_07_00_Jakarta, "(GMT+07:00) Jakarta" },
            { ETZT.GMT_Plus_07_00_Krasnoyarsk, "(GMT+07:00) Krasnoyarsk" },
            { ETZT.GMT_Plus_07_00_Novosibirsk, "(GMT+07:00) Novosibirsk" },
            { ETZT.GMT_Plus_08_00_Beijing, "(GMT+08:00) Beijing" },
            { ETZT.GMT_Plus_08_00_Chongqing, "(GMT+08:00) Chongqing" },
            { ETZT.GMT_Plus_08_00_Hong_Kong, "(GMT+08:00) Hong Kong" },
            { ETZT.GMT_Plus_08_00_Irkutsk, "(GMT+08:00) Irkutsk" },
            { ETZT.GMT_Plus_08_00_Kuala_Lumpur, "(GMT+08:00) Kuala Lumpur" },
            { ETZT.GMT_Plus_08_00_Perth, "(GMT+08:00) Perth" },
            { ETZT.GMT_Plus_08_00_Singapore, "(GMT+08:00) Singapore" },
            { ETZT.GMT_Plus_08_00_Taipei, "(GMT+08:00) Taipei" },
            { ETZT.GMT_Plus_08_00_Ulaanbaatar, "(GMT+08:00) Ulaanbaatar" },
            { ETZT.GMT_Plus_09_00_Osaka, "(GMT+09:00) Osaka" },
            { ETZT.GMT_Plus_09_00_Sapporo, "(GMT+09:00) Sapporo" },
            { ETZT.GMT_Plus_09_00_Seoul, "(GMT+09:00) Seoul" },
            { ETZT.GMT_Plus_09_00_Tokyo, "(GMT+09:00) Tokyo" },
            { ETZT.GMT_Plus_09_00_Yakutsk, "(GMT+09:00) Yakutsk" },
            { ETZT.GMT_Plus_09_30_Adelaide, "(GMT+09:30) Adelaide" },
            { ETZT.GMT_Plus_09_30_Darwin, "(GMT+09:30) Darwin" },
            { ETZT.GMT_Plus_10_00_Brisbane, "(GMT+10:00) Brisbane" },
            { ETZT.GMT_Plus_10_00_Canberra, "(GMT+10:00) Canberra" },
            { ETZT.GMT_Plus_10_00_Guam, "(GMT+10:00) Guam" },
            { ETZT.GMT_Plus_10_00_Hobart, "(GMT+10:00) Hobart" },
            { ETZT.GMT_Plus_10_00_Melbourne, "(GMT+10:00) Melbourne" },
            { ETZT.GMT_Plus_10_00_Port_Moresby, "(GMT+10:00) Port Moresby" },
            { ETZT.GMT_Plus_10_00_Sydney, "(GMT+10:00) Sydney" },
            { ETZT.GMT_Plus_10_00_Vladivostok, "(GMT+10:00) Vladivostok" },
            { ETZT.GMT_Plus_11_00_Magadan, "(GMT+11:00) Magadan" },
            { ETZT.GMT_Plus_11_00_New_Caledonia, "(GMT+11:00) New Caledonia" },
            { ETZT.GMT_Plus_11_00_Solomon_Island, "(GMT+11:00) Solomon Island" },
            { ETZT.GMT_Plus_11_00_Srednekolymsk, "(GMT+11:00) Srednekolymsk" },
            { ETZT.GMT_Plus_12_00_Auckland, "(GMT+12:00) Auckland" },
            { ETZT.GMT_Plus_12_00_Fiji, "(GMT+12:00) Fiji" },
            { ETZT.GMT_Plus_12_00_Kamchatka, "(GMT+12:00) Kamchatka" },
            { ETZT.GMT_Plus_12_00_Marshall_Island, "(GMT+12:00) Marshall Island" },
            { ETZT.GMT_Plus_12_00_Wellington, "(GMT+12:00) Wellington" },
            { ETZT.GMT_Plus_12_45_Chatham_Island, "(GMT+12:45) Chatham Island" },
            { ETZT.GMT_Plus_13_00_Nuku_alofa, "(GMT+13:00) Nuku'alofa" },
            { ETZT.GMT_Plus_13_00_Samoa, "(GMT+13:00) Samoa" },
            { ETZT.GMT_Plus_13_00_Tokelau_Island, "(GMT+13:00) Tokelau Island" }
        };

        /// <summary>
        /// 
        /// </summary>
        public static readonly Dictionary<ETZT, string> TimeZoneShortNames = new()
        {
            { ETZT.GMT_Minus_12_00_International_Date_Line_West, "(GMT-12:00)" },
            { ETZT.GMT_Minus_11_00_American_Samoa, "(GMT-11:00)" },
            { ETZT.GMT_Minus_11_00_Midway_Island, "(GMT-11:00)" },
            { ETZT.GMT_Minus_10_00_Hawaii, "(GMT-10:00)" },
            { ETZT.GMT_Minus_09_00_Alaska, "(GMT-09:00)" },
            { ETZT.GMT_Minus_08_00_Pacific_Time_US_and_Canada, "(GMT-08:00)" },
            { ETZT.GMT_Minus_08_00_Tijuana, "(GMT-08:00)" },
            { ETZT.GMT_Minus_07_00_Arizona, "(GMT-07:00)" },
            { ETZT.GMT_Minus_07_00_Mazatlan, "(GMT-07:00)" },
            { ETZT.GMT_Minus_07_00_Mountain_Time_US_and_Canada, "(GMT-07:00)" },
            { ETZT.GMT_Minus_06_00_Central_America, "(GMT-06:00)" },
            { ETZT.GMT_Minus_06_00_Central_Time_US_and_Canada, "(GMT-06:00)" },
            { ETZT.GMT_Minus_06_00_Chihuahua, "(GMT-06:00)" },
            { ETZT.GMT_Minus_06_00_Guadalajara, "(GMT-06:00)" },
            { ETZT.GMT_Minus_06_00_Mexico_City, "(GMT-06:00)" },
            { ETZT.GMT_Minus_06_00_Monterrey, "(GMT-06:00)" },
            { ETZT.GMT_Minus_06_00_Saskatchewan, "(GMT-06:00)" },
            { ETZT.GMT_Minus_05_00_Bogota, "(GMT-05:00)" },
            { ETZT.GMT_Minus_05_00_Eastern_Time_US_and_Canada, "(GMT-05:00)" },
            { ETZT.GMT_Minus_05_00_Indiana_East, "(GMT-05:00)" },
            { ETZT.GMT_Minus_05_00_Lima, "(GMT-05:00)" },
            { ETZT.GMT_Minus_05_00_Quito, "(GMT-05:00)" },
            { ETZT.GMT_Minus_04_00_Atlantic_Time_Canada, "(GMT-04:00)" },
            { ETZT.GMT_Minus_04_00_Caracas, "(GMT-04:00)" },
            { ETZT.GMT_Minus_04_00_Georgetown, "(GMT-04:00)" },
            { ETZT.GMT_Minus_04_00_La_Paz, "(GMT-04:00)" },
            { ETZT.GMT_Minus_04_00_Puerto_Rico, "(GMT-04:00)" },
            { ETZT.GMT_Minus_04_00_Santiago, "(GMT-04:00)" },
            { ETZT.GMT_Minus_03_30_Newfoundland, "(GMT-03:30)" },
            { ETZT.GMT_Minus_03_00_Brasilia, "(GMT-03:00)" },
            { ETZT.GMT_Minus_03_00_Buenos_Aires, "(GMT-03:00)" },
            { ETZT.GMT_Minus_03_00_Montevideo, "(GMT-03:00)" },
            { ETZT.GMT_Minus_02_00_Greenland, "(GMT-02:00)" },
            { ETZT.GMT_Minus_02_00_Mid_Atlantic, "(GMT-02:00)" },
            { ETZT.GMT_Minus_01_00_Azores, "(GMT-01:00)" },
            { ETZT.GMT_Minus_01_00_Cape_Verde_Island, "(GMT-01:00)" },
            { ETZT.GMT_Plus_00_00_Edinburgh, "(GMT+00:00)" },
            { ETZT.GMT_Plus_00_00_Lisbon, "(GMT+00:00)" },
            { ETZT.GMT_Plus_00_00_London, "(GMT+00:00)" },
            { ETZT.GMT_Plus_00_00_Monrovia, "(GMT+00:00)" },
            { ETZT.GMT_Plus_00_00_UTC, "(GMT+00:00)" },
            { ETZT.GMT_Plus_01_00_Amsterdam, "(GMT+01:00)" },
            { ETZT.GMT_Plus_01_00_Belgrade, "(GMT+01:00)" },
            { ETZT.GMT_Plus_01_00_Berlin, "(GMT+01:00)" },
            { ETZT.GMT_Plus_01_00_Bern, "(GMT+01:00)" },
            { ETZT.GMT_Plus_01_00_Bratislava, "(GMT+01:00)" },
            { ETZT.GMT_Plus_01_00_Brussels, "(GMT+01:00)" },
            { ETZT.GMT_Plus_01_00_Budapest, "(GMT+01:00)" },
            { ETZT.GMT_Plus_01_00_Casablanca, "(GMT+01:00)" },
            { ETZT.GMT_Plus_01_00_Copenhagen, "(GMT+01:00)" },
            { ETZT.GMT_Plus_01_00_Dublin, "(GMT+01:00)" },
            { ETZT.GMT_Plus_01_00_Ljubljana, "(GMT+01:00)" },
            { ETZT.GMT_Plus_01_00_Madrid, "(GMT+01:00)" },
            { ETZT.GMT_Plus_01_00_Paris, "(GMT+01:00)" },
            { ETZT.GMT_Plus_01_00_Prague, "(GMT+01:00)" },
            { ETZT.GMT_Plus_01_00_Rome, "(GMT+01:00)" },
            { ETZT.GMT_Plus_01_00_Sarajevo, "(GMT+01:00)" },
            { ETZT.GMT_Plus_01_00_Skopje, "(GMT+01:00)" },
            { ETZT.GMT_Plus_01_00_Stockholm, "(GMT+01:00)" },
            { ETZT.GMT_Plus_01_00_Vienna, "(GMT+01:00)" },
            { ETZT.GMT_Plus_01_00_Warsaw, "(GMT+01:00)" },
            { ETZT.GMT_Plus_01_00_West_Central_Africa, "(GMT+01:00)" },
            { ETZT.GMT_Plus_01_00_Zagreb, "(GMT+01:00)" },
            { ETZT.GMT_Plus_01_00_Zurich, "(GMT+01:00)" },
            { ETZT.GMT_Plus_02_00_Athens, "(GMT+02:00)" },
            { ETZT.GMT_Plus_02_00_Bucharest, "(GMT+02:00)" },
            { ETZT.GMT_Plus_02_00_Cairo, "(GMT+02:00)" },
            { ETZT.GMT_Plus_02_00_Harare, "(GMT+02:00)" },
            { ETZT.GMT_Plus_02_00_Helsinki, "(GMT+02:00)" },
            { ETZT.GMT_Plus_02_00_Jerusalem, "(GMT+02:00)" },
            { ETZT.GMT_Plus_02_00_Kaliningrad, "(GMT+02:00)" },
            { ETZT.GMT_Plus_02_00_Kyiv, "(GMT+02:00)" },
            { ETZT.GMT_Plus_02_00_Pretoria, "(GMT+02:00)" },
            { ETZT.GMT_Plus_02_00_Riga, "(GMT+02:00)" },
            { ETZT.GMT_Plus_02_00_Sofia, "(GMT+02:00)" },
            { ETZT.GMT_Plus_02_00_Tallinn, "(GMT+02:00)" },
            { ETZT.GMT_Plus_02_00_Vilnius, "(GMT+02:00)" },
            { ETZT.GMT_Plus_03_00_Baghdad, "(GMT+03:00)" },
            { ETZT.GMT_Plus_03_00_Istanbul, "(GMT+03:00)" },
            { ETZT.GMT_Plus_03_00_Kuwait, "(GMT+03:00)" },
            { ETZT.GMT_Plus_03_00_Minsk, "(GMT+03:00)" },
            { ETZT.GMT_Plus_03_00_Moscow, "(GMT+03:00)" },
            { ETZT.GMT_Plus_03_00_Nairobi, "(GMT+03:00)" },
            { ETZT.GMT_Plus_03_00_Riyadh, "(GMT+03:00)" },
            { ETZT.GMT_Plus_03_00_St_Petersburg, "(GMT+03:00)" },
            { ETZT.GMT_Plus_03_00_Volgograd, "(GMT+03:00)" },
            { ETZT.GMT_Plus_03_30_Tehran, "(GMT+03:30)" },
            { ETZT.GMT_Plus_04_00_Abu_Dhabi, "(GMT+04:00)" },
            { ETZT.GMT_Plus_04_00_Baku, "(GMT+04:00)" },
            { ETZT.GMT_Plus_04_00_Muscat, "(GMT+04:00)" },
            { ETZT.GMT_Plus_04_00_Samara, "(GMT+04:00)" },
            { ETZT.GMT_Plus_04_00_Tbilisi, "(GMT+04:00)" },
            { ETZT.GMT_Plus_04_00_Yerevan, "(GMT+04:00)" },
            { ETZT.GMT_Plus_04_30_Kabul, "(GMT+04:30)" },
            { ETZT.GMT_Plus_05_00_Ekaterinburg, "(GMT+05:00)" },
            { ETZT.GMT_Plus_05_00_Islamabad, "(GMT+05:00)" },
            { ETZT.GMT_Plus_05_00_Karachi, "(GMT+05:00)" },
            { ETZT.GMT_Plus_05_00_Tashkent, "(GMT+05:00)" },
            { ETZT.GMT_Plus_05_30_Chennai, "(GMT+05:30)" },
            { ETZT.GMT_Plus_05_30_Kolkata, "(GMT+05:30)" },
            { ETZT.GMT_Plus_05_30_Mumbai, "(GMT+05:30)" },
            { ETZT.GMT_Plus_05_30_New_Delhi, "(GMT+05:30)" },
            { ETZT.GMT_Plus_05_30_Sri_Jayawardenepura, "(GMT+05:30)" },
            { ETZT.GMT_Plus_05_45_Kathmandu, "(GMT+05:45)" },
            { ETZT.GMT_Plus_06_00_Almaty, "(GMT+06:00)" },
            { ETZT.GMT_Plus_06_00_Astana, "(GMT+06:00)" },
            { ETZT.GMT_Plus_06_00_Dhaka, "(GMT+06:00)" },
            { ETZT.GMT_Plus_06_00_Urumqi, "(GMT+06:00)" },
            { ETZT.GMT_Plus_06_30_Rangoon, "(GMT+06:30)" },
            { ETZT.GMT_Plus_07_00_Bangkok, "(GMT+07:00)" },
            { ETZT.GMT_Plus_07_00_Hanoi, "(GMT+07:00)" },
            { ETZT.GMT_Plus_07_00_Jakarta, "(GMT+07:00)" },
            { ETZT.GMT_Plus_07_00_Krasnoyarsk, "(GMT+07:00)" },
            { ETZT.GMT_Plus_07_00_Novosibirsk, "(GMT+07:00)" },
            { ETZT.GMT_Plus_08_00_Beijing, "(GMT+08:00)" },
            { ETZT.GMT_Plus_08_00_Chongqing, "(GMT+08:00)" },
            { ETZT.GMT_Plus_08_00_Hong_Kong, "(GMT+08:00)" },
            { ETZT.GMT_Plus_08_00_Irkutsk, "(GMT+08:00)" },
            { ETZT.GMT_Plus_08_00_Kuala_Lumpur, "(GMT+08:00)" },
            { ETZT.GMT_Plus_08_00_Perth, "(GMT+08:00)" },
            { ETZT.GMT_Plus_08_00_Singapore, "(GMT+08:00)" },
            { ETZT.GMT_Plus_08_00_Taipei, "(GMT+08:00)" },
            { ETZT.GMT_Plus_08_00_Ulaanbaatar, "(GMT+08:00)" },
            { ETZT.GMT_Plus_09_00_Osaka, "(GMT+09:00)" },
            { ETZT.GMT_Plus_09_00_Sapporo, "(GMT+09:00)" },
            { ETZT.GMT_Plus_09_00_Seoul, "(GMT+09:00)" },
            { ETZT.GMT_Plus_09_00_Tokyo, "(GMT+09:00)" },
            { ETZT.GMT_Plus_09_00_Yakutsk, "(GMT+09:00)" },
            { ETZT.GMT_Plus_09_30_Adelaide, "(GMT+09:30)" },
            { ETZT.GMT_Plus_09_30_Darwin, "(GMT+09:30)" },
            { ETZT.GMT_Plus_10_00_Brisbane, "(GMT+10:00)" },
            { ETZT.GMT_Plus_10_00_Canberra, "(GMT+10:00)" },
            { ETZT.GMT_Plus_10_00_Guam, "(GMT+10:00)" },
            { ETZT.GMT_Plus_10_00_Hobart, "(GMT+10:00)" },
            { ETZT.GMT_Plus_10_00_Melbourne, "(GMT+10:00)" },
            { ETZT.GMT_Plus_10_00_Port_Moresby, "(GMT+10:00)" },
            { ETZT.GMT_Plus_10_00_Sydney, "(GMT+10:00)" },
            { ETZT.GMT_Plus_10_00_Vladivostok, "(GMT+10:00)" },
            { ETZT.GMT_Plus_11_00_Magadan, "(GMT+11:00)" },
            { ETZT.GMT_Plus_11_00_New_Caledonia, "(GMT+11:00)" },
            { ETZT.GMT_Plus_11_00_Solomon_Island, "(GMT+11:00)" },
            { ETZT.GMT_Plus_11_00_Srednekolymsk, "(GMT+11:00)" },
            { ETZT.GMT_Plus_12_00_Auckland, "(GMT+12:00)" },
            { ETZT.GMT_Plus_12_00_Fiji, "(GMT+12:00)" },
            { ETZT.GMT_Plus_12_00_Kamchatka, "(GMT+12:00)" },
            { ETZT.GMT_Plus_12_00_Marshall_Island, "(GMT+12:00)" },
            { ETZT.GMT_Plus_12_00_Wellington, "(GMT+12:00)" },
            { ETZT.GMT_Plus_12_45_Chatham_Island, "(GMT+12:45)" },
            { ETZT.GMT_Plus_13_00_Nuku_alofa, "(GMT+13:00)" },
            { ETZT.GMT_Plus_13_00_Samoa, "(GMT+13:00)" },
            { ETZT.GMT_Plus_13_00_Tokelau_Island, "(GMT+13:00)" }
        };
    }
}
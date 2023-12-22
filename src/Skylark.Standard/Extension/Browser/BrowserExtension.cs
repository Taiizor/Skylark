using System.Text.RegularExpressions;
using SE = Skylark.Exception;
using SHL = Skylark.Helper.Length;
using SSBBS = Skylark.Struct.Browser.BrowserStruct;
using SSMBBM = Skylark.Standard.Manage.Browser.BrowserManage;

namespace Skylark.Standard.Extension.Browser
{
    /// <summary>
    /// 
    /// </summary>
    public static class BrowserExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="UserAgent"></param>
        /// <returns></returns>
        public static SSBBS Parse(string UserAgent = SSMBBM.UserAgent)
        {
            try
            {
                UserAgent = SHL.Text(UserAgent, SSMBBM.UserAgent);

                SSBBS Result = SSMBBM.Result;

                Result.Robot = Robot(UserAgent);
                Result.Mobile = Mobile(UserAgent);
                Result.Browser = Browser(UserAgent);
                Result.RobotIs = RobotIs(UserAgent);
                Result.MobileIs = MobileIs(UserAgent);
                Result.Platform = Platform(UserAgent);
                Result.BrowserIs = BrowserIs(UserAgent);
                Result.BrowserVersion = BrowserVersion(UserAgent);

                return Result;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="UserAgent"></param>
        /// <returns></returns>
        public static async Task<SSBBS> ParseAsync(string UserAgent = SSMBBM.UserAgent)
        {
            return await Task.Run(() => Parse(UserAgent));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="UserAgent"></param>
        /// <returns></returns>
        public static string Robot(string UserAgent = SSMBBM.UserAgent)
        {
            try
            {
                UserAgent = SHL.Text(UserAgent, SSMBBM.UserAgent);

                foreach (KeyValuePair<string, string> Pair in SSMBBM.Robots)
                {
                    string Pattern = $"{Regex.Escape(Pair.Key)}";

                    Match Matches = Regex.Match(UserAgent, Pattern, RegexOptions.IgnoreCase);

                    if (Matches.Success)
                    {
                        return Pair.Value;
                    }
                }

                return SSMBBM.RobotNone;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="UserAgent"></param>
        /// <returns></returns>
        public static async Task<string> RobotAsync(string UserAgent = SSMBBM.UserAgent)
        {
            return await Task.Run(() => Robot(UserAgent));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="UserAgent"></param>
        /// <returns></returns>
        public static bool RobotIs(string UserAgent = SSMBBM.UserAgent)
        {
            try
            {
                UserAgent = SHL.Text(UserAgent, SSMBBM.UserAgent);

                foreach (KeyValuePair<string, string> Pair in SSMBBM.Robots)
                {
                    string Pattern = $"{Regex.Escape(Pair.Key)}";

                    Match Matches = Regex.Match(UserAgent, Pattern, RegexOptions.IgnoreCase);

                    if (Matches.Success)
                    {
                        return true;
                    }
                }

                return false;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="UserAgent"></param>
        /// <returns></returns>
        public static async Task<bool> RobotIsAsync(string UserAgent = SSMBBM.UserAgent)
        {
            return await Task.Run(() => RobotIs(UserAgent));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="UserAgent"></param>
        /// <returns></returns>
        public static string Mobile(string UserAgent = SSMBBM.UserAgent)
        {
            try
            {
                UserAgent = SHL.Text(UserAgent, SSMBBM.UserAgent);

                foreach (KeyValuePair<string, string> Pair in SSMBBM.Mobiles)
                {
                    if (UserAgent.IndexOf(Pair.Key, StringComparison.OrdinalIgnoreCase) != -1)
                    {
                        return Pair.Value;
                    }
                }

                return SSMBBM.MobileNone;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="UserAgent"></param>
        /// <returns></returns>
        public static async Task<string> MobileAsync(string UserAgent = SSMBBM.UserAgent)
        {
            return await Task.Run(() => Mobile(UserAgent));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="UserAgent"></param>
        /// <returns></returns>
        public static bool MobileIs(string UserAgent = SSMBBM.UserAgent)
        {
            try
            {
                UserAgent = SHL.Text(UserAgent, SSMBBM.UserAgent);

                foreach (KeyValuePair<string, string> Pair in SSMBBM.Mobiles)
                {
                    if (UserAgent.IndexOf(Pair.Key, StringComparison.OrdinalIgnoreCase) != -1)
                    {
                        return true;
                    }
                }

                return false;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="UserAgent"></param>
        /// <returns></returns>
        public static async Task<bool> MobileIsAsync(string UserAgent = SSMBBM.UserAgent)
        {
            return await Task.Run(() => MobileIs(UserAgent));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="UserAgent"></param>
        /// <returns></returns>
        public static string Browser(string UserAgent = SSMBBM.UserAgent)
        {
            try
            {
                UserAgent = SHL.Text(UserAgent, SSMBBM.UserAgent);

                foreach (KeyValuePair<string, string> Pair in SSMBBM.Browsers)
                {
                    string Pattern = $"{Pair.Key}.*?([0-9\\.]+)";

                    Match Matches = Regex.Match(UserAgent, Pattern, RegexOptions.IgnoreCase);

                    if (Matches.Success)
                    {
                        return Pair.Value;
                    }
                }

                return SSMBBM.BrowserNone;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="UserAgent"></param>
        /// <returns></returns>
        public static async Task<string> BrowserAsync(string UserAgent = SSMBBM.UserAgent)
        {
            return await Task.Run(() => Browser(UserAgent));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="UserAgent"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static bool BrowserIs(string UserAgent = SSMBBM.UserAgent)
        {
            try
            {
                UserAgent = SHL.Text(UserAgent, SSMBBM.UserAgent);

                foreach (KeyValuePair<string, string> Pair in SSMBBM.Browsers)
                {
                    string Pattern = $"{Pair.Key}.*?([0-9\\.]+)";

                    Match Matches = Regex.Match(UserAgent, Pattern, RegexOptions.IgnoreCase);

                    if (Matches.Success)
                    {
                        return true;
                    }
                }

                return false;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="UserAgent"></param>
        /// <returns></returns>
        public static async Task<bool> BrowserIsAsync(string UserAgent = SSMBBM.UserAgent)
        {
            return await Task.Run(() => BrowserIs(UserAgent));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="UserAgent"></param>
        /// <returns></returns>
        public static string BrowserVersion(string UserAgent = SSMBBM.UserAgent)
        {
            try
            {
                UserAgent = SHL.Text(UserAgent, SSMBBM.UserAgent);

                foreach (KeyValuePair<string, string> Pair in SSMBBM.Browsers)
                {
                    string Pattern = $"{Pair.Key}.*?([0-9\\.]+)";

                    Match Matches = Regex.Match(UserAgent, Pattern, RegexOptions.IgnoreCase);

                    if (Matches.Success)
                    {
                        return Matches.Groups[1].Value;
                    }
                }

                return SSMBBM.VersionNone;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="UserAgent"></param>
        /// <returns></returns>
        public static async Task<string> BrowserVersionAsync(string UserAgent = SSMBBM.UserAgent)
        {
            return await Task.Run(() => BrowserVersion(UserAgent));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="UserAgent"></param>
        /// <returns></returns>
        public static string Platform(string UserAgent = SSMBBM.UserAgent)
        {
            try
            {
                UserAgent = SHL.Text(UserAgent, SSMBBM.UserAgent);

                foreach (KeyValuePair<string, string> Pair in SSMBBM.Platforms)
                {
                    if (Regex.IsMatch(UserAgent, Regex.Escape(Pair.Key), RegexOptions.IgnoreCase))
                    {
                        return Pair.Value;
                    }
                }

                return SSMBBM.PlatformNone;
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="UserAgent"></param>
        /// <returns></returns>
        public static async Task<string> PlatformAsync(string UserAgent = SSMBBM.UserAgent)
        {
            return await Task.Run(() => Platform(UserAgent));
        }
    }
}
﻿using System.Text.RegularExpressions;
using HD = Skylark.Helper.Detect;

namespace Skylark.Helper
{
    internal class WebHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        public static string[] GetTags(string Value)
        {
            string Pattern = @"\s*[^>]+\s*=\s*""([^""]*)""";
            MatchCollection Matches = Regex.Matches(Value, Pattern);

            return Matches.Cast<Match>().Select(Tag => Tag.Value).ToArray();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <returns></returns>
        public static string GetConvert(string Value)
        {
            return Value.Replace(',', HD.Symbol()).Replace('.', HD.Symbol());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Separator"></param>
        /// <returns></returns>
        public static string GetPlaces(string Value, bool Separator)
        {
            if (Separator)
            {
                return string.Format("{0:N0}", Convert.ToInt32(Value));
            }
            else
            {
                return string.Format("{0:0}", Convert.ToInt32(Value));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Separator"></param>
        /// <returns></returns>
        public static string GetPlaces(decimal Value, bool Separator)
        {
            if (Separator)
            {
                return string.Format("{0:N2}", Value);
            }
            else
            {
                return string.Format("{0:0.00}", Value);
            }
        }
    }
}
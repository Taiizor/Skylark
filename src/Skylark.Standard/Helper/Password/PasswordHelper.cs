﻿using System.Diagnostics;
using System.Text.RegularExpressions;
using SEAPT = Skylark.Enum.AlphabeticPasswordType;
using SEMPT = Skylark.Enum.MeterPasswordType;
using SESLPT = Skylark.Enum.SpecialPasswordType;
using SESRPT = Skylark.Enum.SimilarPasswordType;
using SHF = Skylark.Helper.Format;
using SHS = Skylark.Helper.Skymath;
using SSMPPM = Skylark.Standard.Manage.Password.PasswordManage;

namespace Skylark.Standard.Helper.Password
{
    /// <summary>
    /// 
    /// </summary>
    internal static class PasswordHelper
    {
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
                return SHF.Formatter("{0:N2}", Value);
            }
            else
            {
                return SHF.Formatter("{0:0.00}", Value);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Password"></param>
        /// <returns></returns>
        public static SEMPT GetMeter(string Password)
        {
            SEMPT Point = 0;

            if (Password.Length >= (int)SSMPPM.MeterOptions["MinLength"])
            {
                Point = Point.UpgradeMeterLevel();
            }

            if (Regex.IsMatch(Password, SSMPPM.MeterOptions["RegexDigit"] as string))
            {
                Point = Point.UpgradeMeterLevel();
            }

            if (Regex.IsMatch(Password, SSMPPM.MeterOptions["RegexSymbol"] as string))
            {
                Point = Point.UpgradeMeterLevel();
            }

            if (Regex.IsMatch(Password, SSMPPM.MeterOptions["RegexLowercase"] as string))
            {
                Point = Point.UpgradeMeterLevel();
            }

            if (Regex.IsMatch(Password, SSMPPM.MeterOptions["RegexUppercase"] as string))
            {
                Point = Point.UpgradeMeterLevel();
            }

            return Point;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Password1"></param>
        /// <param name="Password2"></param>
        /// <param name="Similar"></param>
        /// <returns></returns>
        public static double GetSimilarity(string Password1, string Password2, SESRPT Similar)
        {
            switch (Similar)
            {
                case SESRPT.Flat:
                    int ShortLength = Math.Min(Password1.Length, Password2.Length);

                    int SimilarCharLength = 0;

                    for (int C = 0; C < ShortLength; C++)
                    {
                        if (Password1[C] == Password2[C])
                        {
                            SimilarCharLength++;
                        }
                    }

                    return (double)SimilarCharLength / ShortLength;
                case SESRPT.NGram:
                    Password1 = Password1.ToLower();
                    Password2 = Password2.ToLower();

                    List<string> nGrams1 = CreateNGram(Password1, SSMPPM.NGramLength);
                    List<string> nGrams2 = CreateNGram(Password2, SSMPPM.NGramLength);

                    int ortakNGramSayisi = nGrams1.Intersect(nGrams2).Count();

                    return (double)ortakNGramSayisi / Math.Max(nGrams1.Count, nGrams2.Count);
                case SESRPT.Cosine:
                    Dictionary<string, int> Dict1 = new();
                    Dictionary<string, int> Dict2 = new();

                    foreach (string Word in Password1.Split())
                    {
                        if (Dict1.TryGetValue(Word, out int Value))
                        {
                            Dict1[Word] = ++Value;
                        }
                        else
                        {
                            Dict1[Word] = 1;
                        }
                    }

                    foreach (string Word in Password2.Split())
                    {
                        if (Dict2.TryGetValue(Word, out int Value))
                        {
                            Dict2[Word] = ++Value;
                        }
                        else
                        {
                            Dict2[Word] = 1;
                        }
                    }

                    HashSet<string> Keys = new(Dict1.Keys.Concat(Dict2.Keys));

                    double DotProduct = 0;
                    double Magnitude1 = 0;
                    double Magnitude2 = 0;

                    foreach (string Key in Keys)
                    {
                        int Count1 = Dict1.TryGetValue(Key, out int Value1) ? Value1 : 0;
                        int Count2 = Dict2.TryGetValue(Key, out int Value2) ? Value2 : 0;

                        DotProduct += Count1 * Count2;
                        Magnitude1 += Count1 * Count1;
                        Magnitude2 += Count2 * Count2;
                    }

                    double Magnitude = Math.Sqrt(Magnitude1) * Math.Sqrt(Magnitude2);

                    return DotProduct / Magnitude;
                case SESRPT.Jaccard:
                    HashSet<char> Set1 = new(Password1);
                    HashSet<char> Set2 = new(Password2);

                    int Intersection = 0;

                    foreach (char C in Set1)
                    {
                        if (Set2.Contains(C))
                        {
                            Intersection++;
                        }
                    }

                    int Union = Set1.Count + Set2.Count - Intersection;

                    return (double)Intersection / Union;
                case SESRPT.Jaccardy:
                    HashSet<string> Set3 = new(Password1.Split());
                    HashSet<string> Set4 = new(Password2.Split());

                    int IntersectionCount = Set3.Intersect(Set4).Count();
                    int UnionCount = Set3.Union(Set4).Count();

                    return (double)IntersectionCount / UnionCount;
                case SESRPT.Levenshtein:
                    int P1 = Password1.Length;
                    int P2 = Password2.Length;

                    int[,] D = new int[P1 + 1, P2 + 1];

                    double Similarity;

                    if (P1 == 0)
                    {
                        Similarity = 1 - ((double)P2 / Math.Max(Password1.Length, Password2.Length));

                        return Similarity;
                    }

                    if (P2 == 0)
                    {
                        Similarity = 1 - ((double)P1 / Math.Max(Password1.Length, Password2.Length));

                        return Similarity;
                    }

                    for (int i = 1; i <= P1; i++)
                    {
                        for (int j = 1; j <= P2; j++)
                        {
                            int Cost = (Password2[j - 1] == Password1[i - 1]) ? 0 : 1;

                            D[i, j] = Math.Min(Math.Min(D[i - 1, j] + 1, D[i, j - 1] + 1), D[i - 1, j - 1] + Cost);
                        }
                    }

                    int Distance = D[P1, P2];

                    Similarity = 1 - ((double)Distance / Math.Max(Password1.Length, Password2.Length));

                    return Similarity;
                default:
                    Password1 = Password1.ToLower();
                    Password2 = Password2.ToLower();

                    return JaroWinkler(Password1, Password2);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mode"></param>
        /// <returns></returns>
        public static string GetSpecial(SESLPT Mode)
        {
            return Mode switch
            {
                SESLPT.None => string.Empty,
                SESLPT.Number => SSMPPM.Number,
                SESLPT.Symbol => SSMPPM.Symbol,
                _ => SSMPPM.Number + SSMPPM.Symbol,
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Mode"></param>
        /// <returns></returns>
        public static string GetAlphabetic(SEAPT Mode)
        {
            return Mode switch
            {
                SEAPT.Big => SSMPPM.Big,
                SEAPT.None => string.Empty,
                SEAPT.Small => SSMPPM.Small,
                _ => SSMPPM.Big + SSMPPM.Small,
            };
        }

        /// <summary>
        /// If more password strengths are removed, this will compute it automatically
        /// </summary>
        private static readonly int LowestPasswordStrength = typeof(SEMPT)
            .GetEnumValues()
            .Cast<int>()
            .Min();

        /// <summary>
        /// If more password strengths are added, this will compute it automatically
        /// </summary>
        private static readonly int HighestPasswordStrength = typeof(SEMPT)
            .GetEnumValues()
            .Cast<int>()
            .Max();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Password1"></param>
        /// <param name="Password2"></param>
        /// <returns></returns>
        private static int TranspositionsNumber(string Password1, string Password2)
        {
            int Length = 0;
            int ShortLength = Math.Min(Password1.Length, Password2.Length);

            for (int C = 0; C < ShortLength; C++)
            {
                if (Password1[C] != Password2[C])
                {
                    Length++;
                }
            }

            return Length / 2;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Password"></param>
        /// <param name="Length"></param>
        /// <returns></returns>
        private static List<string> CreateNGram(string Password, int Length)
        {
            List<string> nGrams = new();

            for (int C = 0; C <= Password.Length - Length; C++)
            {
                string nGram = Password.Substring(C, Length);
                nGrams.Add(nGram);
            }

            return nGrams;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="MeterPasswordType"></param>
        /// <returns></returns>
        private static SEMPT UpgradeMeterLevel(this SEMPT MeterPasswordType)
        {
            int Result = (int)MeterPasswordType + 20;

            SHS.Clamp(Result, LowestPasswordStrength, HighestPasswordStrength);
            Debug.Assert(Result % 20 == 0);
            return (SEMPT)Result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Password1"></param>
        /// <param name="Password2"></param>
        /// <returns></returns>
        private static double JaroWinkler(string Password1, string Password2)
        {
            int MaxLength = (Math.Max(Password1.Length, Password2.Length) / 2) - 1;

            int CommonLength = CommonCharacter(Password1, Password2, MaxLength);

            if (CommonLength == 0)
            {
                return 0.0;
            }

            int TranspositionsLength = TranspositionsNumber(Password1, Password2);

            double Jaro = (((double)CommonLength / Password1.Length) + ((double)CommonLength / Password2.Length) + ((double)(CommonLength - TranspositionsLength) / CommonLength)) / 3.0;

            double JaroWinkler = Jaro + Math.Min(0.1, 1.0 / Math.Max(Password1.Length, Password2.Length) * TranspositionsLength);

            return JaroWinkler;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="MeterPasswordType"></param>
        /// <returns></returns>
        private static SEMPT DowngradeMeterLevel(this SEMPT MeterPasswordType)
        {
            int Result = (int)MeterPasswordType - 20;

            SHS.Clamp(Result, LowestPasswordStrength, HighestPasswordStrength);
            Debug.Assert(Result % 20 == 0);
            return (SEMPT)Result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Password1"></param>
        /// <param name="Password2"></param>
        /// <param name="MaxLength"></param>
        /// <returns></returns>
        private static int CommonCharacter(string Password1, string Password2, int MaxLength)
        {
            int CommonLength = 0;

            int ShortLength = Math.Min(Password1.Length, Password2.Length);

            for (int C = 0; C < ShortLength; C++)
            {
                if (Math.Abs(Password1.IndexOf(Password2[C]) - C) <= MaxLength)
                {
                    CommonLength++;
                }
            }

            return CommonLength;
        }
    }
}
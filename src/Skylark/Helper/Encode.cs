﻿using System.Text;
using E = Skylark.Exception;
using EET = Skylark.Enum.EncodeType;

namespace Skylark.Helper
{
    /// <summary>
    /// 
    /// </summary>
    public static class Encode
    {
        /// <summary>
        /// 
        /// </summary>
        private const string ErrorMessage = "Encode variable not selected.";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Encode"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static byte[] GetBytes(string Text, EET Encode)
        {
            return Encode
                .GetEncoding(false, ErrorMessage)
                .GetBytes(Text);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Encode"></param>
        /// <returns></returns>
        public static async Task<byte[]> GetBytesAsync(string Text, EET Encode)
        {
            return await Task.Run(() => GetBytes(Text, Encode));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Bytes"></param>
        /// <param name="Encode"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string GetString(byte[] Bytes, EET Encode)
        {
            return Encode
                .GetEncoding(false, ErrorMessage)
                .GetString(Bytes);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Bytes"></param>
        /// <param name="Encode"></param>
        /// <returns></returns>
        public static async Task<string> GetStringAsync(byte[] Bytes, EET Encode)
        {
            return await Task.Run(() => GetString(Bytes, Encode));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="EncodeType"></param>
        /// <param name="UseUtf8IfNotValid"></param>
        /// <param name="ErrorMessage"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        private static Encoding GetEncoding(this EET EncodeType, bool UseUtf8IfNotValid = false, string ErrorMessage = ErrorMessage)
        {
            if (!System.Enum.IsDefined(typeof(EET), EncodeType))
            {
                if (UseUtf8IfNotValid)
                {
                    return Encoding.UTF8;
                }

                throw new E(ErrorMessage);
            }

            return EncodeType switch
            {
                EET.UTF7 => Encoding.UTF7,
                EET.UTF8 => Encoding.UTF8,
                EET.UTF32 => Encoding.UTF32,
                EET.ASCII => Encoding.ASCII,
                EET.Unicode => Encoding.Unicode,
                EET.BigEndianUnicode => Encoding.BigEndianUnicode,
                _ => Encoding.Default
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="EncodeType"></param>
        /// <param name="UseUtf8IfNotValid"></param>
        /// <param name="ErrorMessage"></param>
        /// <returns></returns>
        private static async Task<Encoding> GetEncodingAsync(this EET EncodeType, bool UseUtf8IfNotValid = false, string ErrorMessage = ErrorMessage)
        {
            return await Task.Run(() => GetEncoding(EncodeType, UseUtf8IfNotValid, ErrorMessage));
        }
    }
}
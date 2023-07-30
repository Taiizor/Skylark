using System.Security.Cryptography;
using SE = Skylark.Exception;
using SHF = Skylark.Helper.Format;
using SHHHH = Skylark.Standard.Helper.Hash.HashHelper;
using SHL = Skylark.Helper.Length;
using MHHM = Skylark.Standard.Manage.Hash.HashManage;

namespace Skylark.Standard.Extension.Hash
{
    /// <summary>
    /// 
    /// </summary>
    public static class HashExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="Split"></param>
        /// <param name="Upper"></param>
        /// <param name="Invariant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static string FileToMD5(string Path = MHHM.Path, string Split = MHHM.Split, bool Upper = MHHM.Upper, bool Invariant = MHHM.Invariant)
        {
            try
            {
                Path = HL.Path(Path, MHHM.Path);
                Split = HL.Parameter(Split, MHHM.Split);

                HHHH.FileControl(Path);

                using MD5 MD5 = new MD5CryptoServiceProvider();

                return HF.Formatter(HHHH.ToString(MD5.ComputeHash(HHHH.OpenRead(Path)), Split), Upper, Invariant);
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="Split"></param>
        /// <param name="Upper"></param>
        /// <param name="Invariant"></param>
        /// <returns></returns>
        public static async Task<string> FileToMD5Async(string Path = MHHM.Path, string Split = MHHM.Split, bool Upper = MHHM.Upper, bool Invariant = MHHM.Invariant)
        {
            return await Task.Run(() => FileToMD5(Path, Split, Upper, Invariant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="Split"></param>
        /// <param name="Upper"></param>
        /// <param name="Invariant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static string FileToSHA1(string Path = MHHM.Path, string Split = MHHM.Split, bool Upper = MHHM.Upper, bool Invariant = MHHM.Invariant)
        {
            try
            {
                Path = HL.Path(Path, MHHM.Path);
                Split = HL.Parameter(Split, MHHM.Split);

                HHHH.FileControl(Path);

                using SHA1 SHA1 = new SHA1CryptoServiceProvider();

                return HF.Formatter(HHHH.ToString(SHA1.ComputeHash(HHHH.OpenRead(Path)), Split), Upper, Invariant);
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="Split"></param>
        /// <param name="Upper"></param>
        /// <param name="Invariant"></param>
        /// <returns></returns>
        public static async Task<string> FileToSHA1Async(string Path = MHHM.Path, string Split = MHHM.Split, bool Upper = MHHM.Upper, bool Invariant = MHHM.Invariant)
        {
            return await Task.Run(() => FileToSHA1(Path, Split, Upper, Invariant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="Split"></param>
        /// <param name="Upper"></param>
        /// <param name="Invariant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static string FileToSHA256(string Path = MHHM.Path, string Split = MHHM.Split, bool Upper = MHHM.Upper, bool Invariant = MHHM.Invariant)
        {
            try
            {
                Path = HL.Path(Path, MHHM.Path);
                Split = HL.Parameter(Split, MHHM.Split);

                HHHH.FileControl(Path);

                using SHA256 SHA256 = new SHA256CryptoServiceProvider();

                return HF.Formatter(HHHH.ToString(SHA256.ComputeHash(HHHH.OpenRead(Path)), Split), Upper, Invariant);
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="Split"></param>
        /// <param name="Upper"></param>
        /// <param name="Invariant"></param>
        /// <returns></returns>
        public static async Task<string> FileToSHA256Async(string Path = MHHM.Path, string Split = MHHM.Split, bool Upper = MHHM.Upper, bool Invariant = MHHM.Invariant)
        {
            return await Task.Run(() => FileToSHA256(Path, Split, Upper, Invariant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="Split"></param>
        /// <param name="Upper"></param>
        /// <param name="Invariant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static string FileToSHA384(string Path = MHHM.Path, string Split = MHHM.Split, bool Upper = MHHM.Upper, bool Invariant = MHHM.Invariant)
        {
            try
            {
                Path = HL.Path(Path, MHHM.Path);
                Split = HL.Parameter(Split, MHHM.Split);

                HHHH.FileControl(Path);

                using SHA384 SHA384 = new SHA384CryptoServiceProvider();

                return HF.Formatter(HHHH.ToString(SHA384.ComputeHash(HHHH.OpenRead(Path)), Split), Upper, Invariant);
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="Split"></param>
        /// <param name="Upper"></param>
        /// <param name="Invariant"></param>
        /// <returns></returns>
        public static async Task<string> FileToSHA384Async(string Path = MHHM.Path, string Split = MHHM.Split, bool Upper = MHHM.Upper, bool Invariant = MHHM.Invariant)
        {
            return await Task.Run(() => FileToSHA384(Path, Split, Upper, Invariant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="Split"></param>
        /// <param name="Upper"></param>
        /// <param name="Invariant"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static string FileToSHA512(string Path = MHHM.Path, string Split = MHHM.Split, bool Upper = MHHM.Upper, bool Invariant = MHHM.Invariant)
        {
            try
            {
                Path = HL.Path(Path, MHHM.Path);
                Split = HL.Parameter(Split, MHHM.Split);

                HHHH.FileControl(Path);

                using SHA512 SHA512 = new SHA512CryptoServiceProvider();

                return HF.Formatter(HHHH.ToString(SHA512.ComputeHash(HHHH.OpenRead(Path)), Split), Upper, Invariant);
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="Split"></param>
        /// <param name="Upper"></param>
        /// <param name="Invariant"></param>
        /// <returns></returns>
        public static async Task<string> FileToSHA512Async(string Path = MHHM.Path, string Split = MHHM.Split, bool Upper = MHHM.Upper, bool Invariant = MHHM.Invariant)
        {
            return await Task.Run(() => FileToSHA512(Path, Split, Upper, Invariant));
        }
    }
}
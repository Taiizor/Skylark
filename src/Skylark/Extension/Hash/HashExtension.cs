using System.Security.Cryptography;
using E = Skylark.Exception;
using HF = Skylark.Helper.Format;
using HHH = Skylark.Helper.HashHelper;
using HL = Skylark.Helper.Length;
using MHM = Skylark.Manage.HashManage;

namespace Skylark.Extension
{
    /// <summary>
    /// 
    /// </summary>
    public class HashExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="Split"></param>
        /// <param name="Upper"></param>
        /// <param name="Invariant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string FileToMD5(string Path = MHM.Path, string Split = MHM.Split, bool Upper = MHM.Upper, bool Invariant = MHM.Invariant)
        {
            try
            {
                Path = HL.Parameter(Path, MHM.Path);
                Split = HL.Parameter(Split, MHM.Split);

                HHH.FileControl(Path);

                using MD5 MD5 = new MD5CryptoServiceProvider();

                return HF.Formatter(HHH.ToString(MD5.ComputeHash(HHH.OpenRead(Path)), Split), Upper, Invariant);
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
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
        public static Task<string> FileToMD5Async(string Path = MHM.Path, string Split = MHM.Split, bool Upper = MHM.Upper, bool Invariant = MHM.Invariant)
        {
            return Task.Run(() => FileToMD5(Path, Split, Upper, Invariant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="Split"></param>
        /// <param name="Upper"></param>
        /// <param name="Invariant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string FileToSHA1(string Path = MHM.Path, string Split = MHM.Split, bool Upper = MHM.Upper, bool Invariant = MHM.Invariant)
        {
            try
            {
                Path = HL.Parameter(Path, MHM.Path);
                Split = HL.Parameter(Split, MHM.Split);

                HHH.FileControl(Path);

                using SHA1 SHA1 = new SHA1CryptoServiceProvider();

                return HF.Formatter(HHH.ToString(SHA1.ComputeHash(HHH.OpenRead(Path)), Split), Upper, Invariant);
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
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
        public static Task<string> FileToSHA1Async(string Path = MHM.Path, string Split = MHM.Split, bool Upper = MHM.Upper, bool Invariant = MHM.Invariant)
        {
            return Task.Run(() => FileToSHA1(Path, Split, Upper, Invariant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="Split"></param>
        /// <param name="Upper"></param>
        /// <param name="Invariant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string FileToSHA256(string Path = MHM.Path, string Split = MHM.Split, bool Upper = MHM.Upper, bool Invariant = MHM.Invariant)
        {
            try
            {
                Path = HL.Parameter(Path, MHM.Path);
                Split = HL.Parameter(Split, MHM.Split);

                HHH.FileControl(Path);

                using SHA256 SHA256 = new SHA256CryptoServiceProvider();

                return HF.Formatter(HHH.ToString(SHA256.ComputeHash(HHH.OpenRead(Path)), Split), Upper, Invariant);
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
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
        public static Task<string> FileToSHA256Async(string Path = MHM.Path, string Split = MHM.Split, bool Upper = MHM.Upper, bool Invariant = MHM.Invariant)
        {
            return Task.Run(() => FileToSHA256(Path, Split, Upper, Invariant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="Split"></param>
        /// <param name="Upper"></param>
        /// <param name="Invariant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string FileToSHA384(string Path = MHM.Path, string Split = MHM.Split, bool Upper = MHM.Upper, bool Invariant = MHM.Invariant)
        {
            try
            {
                Path = HL.Parameter(Path, MHM.Path);
                Split = HL.Parameter(Split, MHM.Split);

                HHH.FileControl(Path);

                using SHA384 SHA384 = new SHA384CryptoServiceProvider();

                return HF.Formatter(HHH.ToString(SHA384.ComputeHash(HHH.OpenRead(Path)), Split), Upper, Invariant);
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
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
        public static Task<string> FileToSHA384Async(string Path = MHM.Path, string Split = MHM.Split, bool Upper = MHM.Upper, bool Invariant = MHM.Invariant)
        {
            return Task.Run(() => FileToSHA384(Path, Split, Upper, Invariant));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Path"></param>
        /// <param name="Split"></param>
        /// <param name="Upper"></param>
        /// <param name="Invariant"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string FileToSHA512(string Path = MHM.Path, string Split = MHM.Split, bool Upper = MHM.Upper, bool Invariant = MHM.Invariant)
        {
            try
            {
                Path = HL.Parameter(Path, MHM.Path);
                Split = HL.Parameter(Split, MHM.Split);

                HHH.FileControl(Path);

                using SHA512 SHA512 = new SHA512CryptoServiceProvider();

                return HF.Formatter(HHH.ToString(SHA512.ComputeHash(HHH.OpenRead(Path)), Split), Upper, Invariant);
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
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
        public static Task<string> FileToSHA512Async(string Path = MHM.Path, string Split = MHM.Split, bool Upper = MHM.Upper, bool Invariant = MHM.Invariant)
        {
            return Task.Run(() => FileToSHA512(Path, Split, Upper, Invariant));
        }
    }
}
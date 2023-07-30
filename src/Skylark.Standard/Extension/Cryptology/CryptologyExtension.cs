﻿using System.Security.Cryptography;
using SE = Skylark.Exception;
using SEET = Skylark.Enum.EncodeType;
using SHA = Skylark.Helper.Adaptation;
using SHCCH = Skylark.Standard.Helper.Cryptology.CryptologyHelper;
using SHE = Skylark.Helper.Encode;
using SHF = Skylark.Helper.Format;
using SHL = Skylark.Helper.Length;
using SMCCM = Skylark.Standard.Manage.Cryptology.CryptologyManage;

namespace Skylark.Standard.Extension.Cryptology
{
    /// <summary>
    /// 
    /// </summary>
    public static class CryptologyExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Encode"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static string TextToBase(string Text = MCCM.Text, EET Encode = MCCM.Encode)
        {
            try
            {
                Text = SHL.Text(Text, MCCM.Text);

                return HCCH.ToBase64String(HE.GetBytes(Text, Encode));
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Encode"></param>
        /// <returns></returns>
        public static async Task<string> TextToBaseAsync(string Text = MCCM.Text, EET Encode = MCCM.Encode)
        {
            return await Task.Run(() => TextToBase(Text, Encode));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="IV"></param>
        /// <param name="Key"></param>
        /// <param name="Mode"></param>
        /// <param name="Encode"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static string TextToAes(string Text = MCCM.Text, string IV = MCCM.IV, string Key = MCCM.Key, CipherMode Mode = MCCM.Cipher, EET Encode = MCCM.Encode)
        {
            try
            {
                IV = HA.Pin(IV, MCCM.IV, 16);
                Key = HA.Pin(Key, MCCM.Key, 32);
                Text = SHL.Text(Text, MCCM.Text);

                Aes Encryptor = Aes.Create();

                Encryptor.Mode = Mode;
                Encryptor.IV = HE.GetBytes(IV, Encode);
                Encryptor.Key = HE.GetBytes(Key, Encode);

                ICryptoTransform CEncryptor = Encryptor.CreateEncryptor();

                MemoryStream MStream = new();
                CryptoStream CStream = new(MStream, CEncryptor, CryptoStreamMode.Write);

                string Result = string.Empty;

                try
                {
                    byte[] Bytes = HE.GetBytes(Text, Encode);

                    CStream.Write(Bytes, 0, Bytes.Length);
                    CStream.FlushFinalBlock();

                    Result = HCCH.ToBase64String(MStream.ToArray());
                }
                finally
                {
                    MStream.Close();
                    CStream.Close();
                }

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
        /// <param name="Text"></param>
        /// <param name="IV"></param>
        /// <param name="Key"></param>
        /// <param name="Mode"></param>
        /// <param name="Encode"></param>
        /// <returns></returns>
        public static async Task<string> TextToAesAsync(string Text = MCCM.Text, string IV = MCCM.IV, string Key = MCCM.Key, CipherMode Mode = MCCM.Cipher, EET Encode = MCCM.Encode)
        {
            return await Task.Run(() => TextToAes(Text, IV, Key, Mode, Encode));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Upper"></param>
        /// <param name="Invariant"></param>
        /// <param name="Encode"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static string TextToMD5(string Text = MCCM.Text, bool Upper = MCCM.Upper, bool Invariant = MCCM.Invariant, EET Encode = MCCM.Mode)
        {
            try
            {
                Text = SHL.Text(Text, MCCM.Text);

                using MD5 MD5 = MD5.Create();

                return HF.Formatter(HCCH.GetBuild(MD5.ComputeHash(HE.GetBytes(Text, Encode))), Upper, Invariant);
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Upper"></param>
        /// <param name="Invariant"></param>
        /// <param name="Encode"></param>
        /// <returns></returns>
        public static async Task<string> TextToMD5Async(string Text = MCCM.Text, bool Upper = MCCM.Upper, bool Invariant = MCCM.Invariant, EET Encode = MCCM.Mode)
        {
            return await Task.Run(() => TextToMD5(Text, Upper, Invariant, Encode));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Upper"></param>
        /// <param name="Invariant"></param>
        /// <param name="Encode"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static string TextToSHA1(string Text = MCCM.Text, bool Upper = MCCM.Upper, bool Invariant = MCCM.Invariant, EET Encode = MCCM.Mode)
        {
            try
            {
                Text = SHL.Text(Text, MCCM.Text);

                using SHA1 SHA1 = SHA1.Create();

                return HF.Formatter(HCCH.GetBuild(SHA1.ComputeHash(HE.GetBytes(Text, Encode))), Upper, Invariant);
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Upper"></param>
        /// <param name="Invariant"></param>
        /// <param name="Encode"></param>
        /// <returns></returns>
        public static async Task<string> TextToSHA1Async(string Text = MCCM.Text, bool Upper = MCCM.Upper, bool Invariant = MCCM.Invariant, EET Encode = MCCM.Mode)
        {
            return await Task.Run(() => TextToSHA1(Text, Upper, Invariant, Encode));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Upper"></param>
        /// <param name="Invariant"></param>
        /// <param name="Encode"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static string TextToSHA256(string Text = MCCM.Text, bool Upper = MCCM.Upper, bool Invariant = MCCM.Invariant, EET Encode = MCCM.Mode)
        {
            try
            {
                Text = SHL.Text(Text, MCCM.Text);

                using SHA256 SHA256 = SHA256.Create();

                return HF.Formatter(HCCH.GetBuild(SHA256.ComputeHash(HE.GetBytes(Text, Encode))), Upper, Invariant);
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Upper"></param>
        /// <param name="Invariant"></param>
        /// <param name="Encode"></param>
        /// <returns></returns>
        public static async Task<string> TextToSHA256Async(string Text = MCCM.Text, bool Upper = MCCM.Upper, bool Invariant = MCCM.Invariant, EET Encode = MCCM.Mode)
        {
            return await Task.Run(() => TextToSHA256(Text, Upper, Invariant, Encode));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Upper"></param>
        /// <param name="Invariant"></param>
        /// <param name="Encode"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static string TextToSHA384(string Text = MCCM.Text, bool Upper = MCCM.Upper, bool Invariant = MCCM.Invariant, EET Encode = MCCM.Mode)
        {
            try
            {
                Text = SHL.Text(Text, MCCM.Text);

                using SHA384 SHA384 = SHA384.Create();

                return HF.Formatter(HCCH.GetBuild(SHA384.ComputeHash(HE.GetBytes(Text, Encode))), Upper, Invariant);
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Upper"></param>
        /// <param name="Invariant"></param>
        /// <param name="Encode"></param>
        /// <returns></returns>
        public static async Task<string> TextToSHA384Async(string Text = MCCM.Text, bool Upper = MCCM.Upper, bool Invariant = MCCM.Invariant, EET Encode = MCCM.Mode)
        {
            return await Task.Run(() => TextToSHA384(Text, Upper, Invariant, Encode));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Upper"></param>
        /// <param name="Invariant"></param>
        /// <param name="Encode"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static string TextToSHA512(string Text = MCCM.Text, bool Upper = MCCM.Upper, bool Invariant = MCCM.Invariant, EET Encode = MCCM.Mode)
        {
            try
            {
                Text = SHL.Text(Text, MCCM.Text);

                using SHA512 SHA512 = SHA512.Create();

                return HF.Formatter(HCCH.GetBuild(SHA512.ComputeHash(HE.GetBytes(Text, Encode))), Upper, Invariant);
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Upper"></param>
        /// <param name="Invariant"></param>
        /// <param name="Encode"></param>
        /// <returns></returns>
        public static async Task<string> TextToSHA512Async(string Text = MCCM.Text, bool Upper = MCCM.Upper, bool Invariant = MCCM.Invariant, EET Encode = MCCM.Mode)
        {
            return await Task.Run(() => TextToSHA512(Text, Upper, Invariant, Encode));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Base"></param>
        /// <param name="Encode"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static string BaseToText(string Base = MCCM.Base, EET Encode = MCCM.Encode)
        {
            try
            {
                Base = SHL.Text(Base, MCCM.Base);

                return HE.GetString(HCCH.FromBase64String(Base), Encode);
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Base"></param>
        /// <param name="Encode"></param>
        /// <returns></returns>
        public static async Task<string> BaseToTextAsync(string Base = MCCM.Base, EET Encode = MCCM.Encode)
        {
            return await Task.Run(() => BaseToText(Base, Encode));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Aes"></param>
        /// <param name="IV"></param>
        /// <param name="Key"></param>
        /// <param name="Mode"></param>
        /// <param name="Encode"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static string AesToText(string Aes = MCCM.Aes, string IV = MCCM.IV, string Key = MCCM.Key, CipherMode Mode = MCCM.Cipher, EET Encode = MCCM.Encode)
        {
            try
            {
                IV = HA.Pin(IV, MCCM.IV, 16);
                Aes = SHL.Text(Aes, MCCM.Aes);
                Key = HA.Pin(Key, MCCM.Key, 32);

                Aes Decryptor = System.Security.Cryptography.Aes.Create();

                Decryptor.Mode = Mode;
                Decryptor.IV = HE.GetBytes(IV, Encode);
                Decryptor.Key = HE.GetBytes(Key, Encode);

                MemoryStream MStream = new();

                ICryptoTransform CDecryptor = Decryptor.CreateDecryptor();

                CryptoStream CStream = new(MStream, CDecryptor, CryptoStreamMode.Write);

                string Result = string.Empty;

                try
                {
                    byte[] Bytes = HCCH.FromBase64String(Aes);

                    CStream.Write(Bytes, 0, Bytes.Length);
                    CStream.FlushFinalBlock();

                    Result = HE.GetString(MStream.ToArray(), Encode);
                }
                finally
                {
                    MStream.Close();
                    CStream.Close();
                }

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
        /// <param name="Aes"></param>
        /// <param name="IV"></param>
        /// <param name="Key"></param>
        /// <param name="Mode"></param>
        /// <param name="Encode"></param>
        /// <returns></returns>
        public static async Task<string> AesToTextAsync(string Aes = MCCM.Aes, string IV = MCCM.IV, string Key = MCCM.Key, CipherMode Mode = MCCM.Cipher, EET Encode = MCCM.Encode)
        {
            return await Task.Run(() => AesToText(Aes, IV, Key, Mode, Encode));
        }
    }
}
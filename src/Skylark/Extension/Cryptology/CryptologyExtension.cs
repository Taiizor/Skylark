using System.Security.Cryptography;
using E = Skylark.Exception;
using EET = Skylark.Enum.EncodeType;
using HA = Skylark.Helper.Adaptation;
using HCH = Skylark.Helper.CryptologyHelper;
using HE = Skylark.Helper.Encode;
using HF = Skylark.Helper.Format;
using HL = Skylark.Helper.Length;
using MCM = Skylark.Manage.CryptologyManage;

namespace Skylark.Extension
{
    /// <summary>
    /// 
    /// </summary>
    public class CryptologyExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Encode"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string TextToBase(string Text = MCM.Text, EET Encode = MCM.Encode)
        {
            try
            {
                Text = HL.Text(Text, MCM.Text);

                return HCH.ToBase64String(HE.GetBytes(Text, Encode));
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Encode"></param>
        /// <returns></returns>
        public static Task<string> TextToBaseAsync(string Text = MCM.Text, EET Encode = MCM.Encode)
        {
            return Task.FromResult(TextToBase(Text, Encode));
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
        /// <exception cref="E"></exception>
        public static string TextToAes(string Text = MCM.Text, string IV = MCM.IV, string Key = MCM.Key, CipherMode Mode = MCM.Cipher, EET Encode = MCM.Encode)
        {
            try
            {
                IV = HA.Pin(IV, MCM.IV, 16);
                Key = HA.Pin(Key, MCM.Key, 32);
                Text = HL.Text(Text, MCM.Text);

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

                    Result = HCH.ToBase64String(MStream.ToArray());
                }
                finally
                {
                    MStream.Close();
                    CStream.Close();
                }

                return Result;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
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
        public static Task<string> TextToAesAsync(string Text = MCM.Text, string IV = MCM.IV, string Key = MCM.Key, CipherMode Mode = MCM.Cipher, EET Encode = MCM.Encode)
        {
            return Task.FromResult(TextToAes(Text, IV, Key, Mode, Encode));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Upper"></param>
        /// <param name="Invariant"></param>
        /// <param name="Encode"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string TextToMD5(string Text = MCM.Text, bool Upper = MCM.Upper, bool Invariant = MCM.Invariant, EET Encode = MCM.Mode)
        {
            try
            {
                Text = HL.Text(Text, MCM.Text);

                using MD5 MD5 = MD5.Create();

                return HF.Formatter(HCH.GetBuild(MD5.ComputeHash(HE.GetBytes(Text, Encode))), Upper, Invariant);
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
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
        public static Task<string> TextToMD5Async(string Text = MCM.Text, bool Upper = MCM.Upper, bool Invariant = MCM.Invariant, EET Encode = MCM.Mode)
        {
            return Task.FromResult(TextToMD5(Text, Upper, Invariant, Encode));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Upper"></param>
        /// <param name="Invariant"></param>
        /// <param name="Encode"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string TextToSHA1(string Text = MCM.Text, bool Upper = MCM.Upper, bool Invariant = MCM.Invariant, EET Encode = MCM.Mode)
        {
            try
            {
                Text = HL.Text(Text, MCM.Text);

                using SHA1 SHA1 = SHA1.Create();

                return HF.Formatter(HCH.GetBuild(SHA1.ComputeHash(HE.GetBytes(Text, Encode))), Upper, Invariant);
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
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
        public static Task<string> TextToSHA1Async(string Text = MCM.Text, bool Upper = MCM.Upper, bool Invariant = MCM.Invariant, EET Encode = MCM.Mode)
        {
            return Task.FromResult(TextToSHA1(Text, Upper, Invariant, Encode));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Upper"></param>
        /// <param name="Invariant"></param>
        /// <param name="Encode"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string TextToSHA256(string Text = MCM.Text, bool Upper = MCM.Upper, bool Invariant = MCM.Invariant, EET Encode = MCM.Mode)
        {
            try
            {
                Text = HL.Text(Text, MCM.Text);

                using SHA256 SHA256 = SHA256.Create();

                return HF.Formatter(HCH.GetBuild(SHA256.ComputeHash(HE.GetBytes(Text, Encode))), Upper, Invariant);
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
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
        public static Task<string> TextToSHA256Async(string Text = MCM.Text, bool Upper = MCM.Upper, bool Invariant = MCM.Invariant, EET Encode = MCM.Mode)
        {
            return Task.FromResult(TextToSHA256(Text, Upper, Invariant, Encode));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Upper"></param>
        /// <param name="Invariant"></param>
        /// <param name="Encode"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string TextToSHA384(string Text = MCM.Text, bool Upper = MCM.Upper, bool Invariant = MCM.Invariant, EET Encode = MCM.Mode)
        {
            try
            {
                Text = HL.Text(Text, MCM.Text);

                using SHA384 SHA384 = SHA384.Create();

                return HF.Formatter(HCH.GetBuild(SHA384.ComputeHash(HE.GetBytes(Text, Encode))), Upper, Invariant);
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
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
        public static Task<string> TextToSHA384Async(string Text = MCM.Text, bool Upper = MCM.Upper, bool Invariant = MCM.Invariant, EET Encode = MCM.Mode)
        {
            return Task.FromResult(TextToSHA384(Text, Upper, Invariant, Encode));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Upper"></param>
        /// <param name="Invariant"></param>
        /// <param name="Encode"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string TextToSHA512(string Text = MCM.Text, bool Upper = MCM.Upper, bool Invariant = MCM.Invariant, EET Encode = MCM.Mode)
        {
            try
            {
                Text = HL.Text(Text, MCM.Text);

                using SHA512 SHA512 = SHA512.Create();

                return HF.Formatter(HCH.GetBuild(SHA512.ComputeHash(HE.GetBytes(Text, Encode))), Upper, Invariant);
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
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
        public static Task<string> TextToSHA512Async(string Text = MCM.Text, bool Upper = MCM.Upper, bool Invariant = MCM.Invariant, EET Encode = MCM.Mode)
        {
            return Task.FromResult(TextToSHA512(Text, Upper, Invariant, Encode));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Base"></param>
        /// <param name="Encode"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string BaseToText(string Base = MCM.Base, EET Encode = MCM.Encode)
        {
            try
            {
                Base = HL.Text(Base, MCM.Base);

                return HE.GetString(HCH.FromBase64String(Base), Encode);
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Base"></param>
        /// <param name="Encode"></param>
        /// <returns></returns>
        public static Task<string> BaseToTextAsync(string Base = MCM.Base, EET Encode = MCM.Encode)
        {
            return Task.FromResult(BaseToText(Base, Encode));
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
        /// <exception cref="E"></exception>
        public static string AesToText(string Aes = MCM.Aes, string IV = MCM.IV, string Key = MCM.Key, CipherMode Mode = MCM.Cipher, EET Encode = MCM.Encode)
        {
            try
            {
                IV = HA.Pin(IV, MCM.IV, 16);
                Aes = HL.Text(Aes, MCM.Aes);
                Key = HA.Pin(Key, MCM.Key, 32);

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
                    byte[] Bytes = HCH.FromBase64String(Aes);

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
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
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
        public static Task<string> AesToTextAsync(string Aes = MCM.Aes, string IV = MCM.IV, string Key = MCM.Key, CipherMode Mode = MCM.Cipher, EET Encode = MCM.Encode)
        {
            return Task.FromResult(AesToText(Aes, IV, Key, Mode, Encode));
        }
    }
}
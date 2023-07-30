using System.Security.Cryptography;
using SE = Skylark.Exception;
using SEET = Skylark.Enum.EncodeType;
using SHA = Skylark.Helper.Adaptation;
using SHE = Skylark.Helper.Encode;
using SHF = Skylark.Helper.Format;
using SHL = Skylark.Helper.Length;
using SSHCCH = Skylark.Standard.Helper.Cryptology.CryptologyHelper;
using SSMCCM = Skylark.Standard.Manage.Cryptology.CryptologyManage;

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
        public static string TextToBase(string Text = SSMCCM.Text, SEET Encode = SSMCCM.Encode)
        {
            try
            {
                Text = SHL.Text(Text, SSMCCM.Text);

                return SSHCCH.ToBase64String(SHE.GetBytes(Text, Encode));
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
        public static async Task<string> TextToBaseAsync(string Text = SSMCCM.Text, SEET Encode = SSMCCM.Encode)
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
        public static string TextToAes(string Text = SSMCCM.Text, string IV = SSMCCM.IV, string Key = SSMCCM.Key, CipherMode Mode = SSMCCM.Cipher, SEET Encode = SSMCCM.Encode)
        {
            try
            {
                IV = SHA.Pin(IV, SSMCCM.IV, 16);
                Key = SHA.Pin(Key, SSMCCM.Key, 32);
                Text = SHL.Text(Text, SSMCCM.Text);

                Aes Encryptor = Aes.Create();

                Encryptor.Mode = Mode;
                Encryptor.IV = SHE.GetBytes(IV, Encode);
                Encryptor.Key = SHE.GetBytes(Key, Encode);

                ICryptoTransform CEncryptor = Encryptor.CreateEncryptor();

                MemoryStream MStream = new();
                CryptoStream CStream = new(MStream, CEncryptor, CryptoStreamMode.Write);

                string Result = string.Empty;

                try
                {
                    byte[] Bytes = SHE.GetBytes(Text, Encode);

                    CStream.Write(Bytes, 0, Bytes.Length);
                    CStream.FlushFinalBlock();

                    Result = SSHCCH.ToBase64String(MStream.ToArray());
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
        public static async Task<string> TextToAesAsync(string Text = SSMCCM.Text, string IV = SSMCCM.IV, string Key = SSMCCM.Key, CipherMode Mode = SSMCCM.Cipher, SEET Encode = SSMCCM.Encode)
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
        public static string TextToMD5(string Text = SSMCCM.Text, bool Upper = SSMCCM.Upper, bool Invariant = SSMCCM.Invariant, SEET Encode = SSMCCM.Mode)
        {
            try
            {
                Text = SHL.Text(Text, SSMCCM.Text);

                using MD5 MD5 = MD5.Create();

                return SHF.Formatter(SSHCCH.GetBuild(MD5.ComputeHash(SHE.GetBytes(Text, Encode))), Upper, Invariant);
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
        public static async Task<string> TextToMD5Async(string Text = SSMCCM.Text, bool Upper = SSMCCM.Upper, bool Invariant = SSMCCM.Invariant, SEET Encode = SSMCCM.Mode)
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
        public static string TextToSHA1(string Text = SSMCCM.Text, bool Upper = SSMCCM.Upper, bool Invariant = SSMCCM.Invariant, SEET Encode = SSMCCM.Mode)
        {
            try
            {
                Text = SHL.Text(Text, SSMCCM.Text);

                using SHA1 SHA1 = SHA1.Create();

                return SHF.Formatter(SSHCCH.GetBuild(SHA1.ComputeHash(SHE.GetBytes(Text, Encode))), Upper, Invariant);
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
        public static async Task<string> TextToSHA1Async(string Text = SSMCCM.Text, bool Upper = SSMCCM.Upper, bool Invariant = SSMCCM.Invariant, SEET Encode = SSMCCM.Mode)
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
        public static string TextToSHA256(string Text = SSMCCM.Text, bool Upper = SSMCCM.Upper, bool Invariant = SSMCCM.Invariant, SEET Encode = SSMCCM.Mode)
        {
            try
            {
                Text = SHL.Text(Text, SSMCCM.Text);

                using SHA256 SHA256 = SHA256.Create();

                return SHF.Formatter(SSHCCH.GetBuild(SHA256.ComputeHash(SHE.GetBytes(Text, Encode))), Upper, Invariant);
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
        public static async Task<string> TextToSHA256Async(string Text = SSMCCM.Text, bool Upper = SSMCCM.Upper, bool Invariant = SSMCCM.Invariant, SEET Encode = SSMCCM.Mode)
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
        public static string TextToSHA384(string Text = SSMCCM.Text, bool Upper = SSMCCM.Upper, bool Invariant = SSMCCM.Invariant, SEET Encode = SSMCCM.Mode)
        {
            try
            {
                Text = SHL.Text(Text, SSMCCM.Text);

                using SHA384 SHA384 = SHA384.Create();

                return SHF.Formatter(SSHCCH.GetBuild(SHA384.ComputeHash(SHE.GetBytes(Text, Encode))), Upper, Invariant);
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
        public static async Task<string> TextToSHA384Async(string Text = SSMCCM.Text, bool Upper = SSMCCM.Upper, bool Invariant = SSMCCM.Invariant, SEET Encode = SSMCCM.Mode)
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
        public static string TextToSHA512(string Text = SSMCCM.Text, bool Upper = SSMCCM.Upper, bool Invariant = SSMCCM.Invariant, SEET Encode = SSMCCM.Mode)
        {
            try
            {
                Text = SHL.Text(Text, SSMCCM.Text);

                using SHA512 SHA512 = SHA512.Create();

                return SHF.Formatter(SSHCCH.GetBuild(SHA512.ComputeHash(SHE.GetBytes(Text, Encode))), Upper, Invariant);
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
        public static async Task<string> TextToSHA512Async(string Text = SSMCCM.Text, bool Upper = SSMCCM.Upper, bool Invariant = SSMCCM.Invariant, SEET Encode = SSMCCM.Mode)
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
        public static string BaseToText(string Base = SSMCCM.Base, SEET Encode = SSMCCM.Encode)
        {
            try
            {
                Base = SHL.Text(Base, SSMCCM.Base);

                return SHE.GetString(SSHCCH.FromBase64String(Base), Encode);
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
        public static async Task<string> BaseToTextAsync(string Base = SSMCCM.Base, SEET Encode = SSMCCM.Encode)
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
        public static string AesToText(string Aes = SSMCCM.Aes, string IV = SSMCCM.IV, string Key = SSMCCM.Key, CipherMode Mode = SSMCCM.Cipher, SEET Encode = SSMCCM.Encode)
        {
            try
            {
                IV = SHA.Pin(IV, SSMCCM.IV, 16);
                Aes = SHL.Text(Aes, SSMCCM.Aes);
                Key = SHA.Pin(Key, SSMCCM.Key, 32);

                Aes Decryptor = System.Security.Cryptography.Aes.Create();

                Decryptor.Mode = Mode;
                Decryptor.IV = SHE.GetBytes(IV, Encode);
                Decryptor.Key = SHE.GetBytes(Key, Encode);

                MemoryStream MStream = new();

                ICryptoTransform CDecryptor = Decryptor.CreateDecryptor();

                CryptoStream CStream = new(MStream, CDecryptor, CryptoStreamMode.Write);

                string Result = string.Empty;

                try
                {
                    byte[] Bytes = SSHCCH.FromBase64String(Aes);

                    CStream.Write(Bytes, 0, Bytes.Length);
                    CStream.FlushFinalBlock();

                    Result = SHE.GetString(MStream.ToArray(), Encode);
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
        public static async Task<string> AesToTextAsync(string Aes = SSMCCM.Aes, string IV = SSMCCM.IV, string Key = SSMCCM.Key, CipherMode Mode = SSMCCM.Cipher, SEET Encode = SSMCCM.Encode)
        {
            return await Task.Run(() => AesToText(Aes, IV, Key, Mode, Encode));
        }
    }
}
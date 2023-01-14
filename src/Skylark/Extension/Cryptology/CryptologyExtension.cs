using System.Security.Cryptography;
using E = Skylark.Exception;
using EET = Skylark.Enum.EncodeType;
using HA = Skylark.Helper.Adaptation;
using HCH = Skylark.Helper.CryptologyHelper;
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
        public static string ToBase(string Text = MCM.Text, EET Encode = MCM.Encode)
        {
            try
            {
                Text = HL.Text(Text, MCM.Text);

                return HCH.ToBase64String(HCH.GetBytes(Text, Encode));
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
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string ToAes(string Text = MCM.Text, string IV = MCM.IV, string Key = MCM.Key, CipherMode Mode = MCM.Cipher)
        {
            try
            {
                IV = HA.Pin(IV, MCM.IV, 16);
                Key = HA.Pin(Key, MCM.Key, 32);
                Text = HL.Text(Text, MCM.Text);

                Aes Encryptor = Aes.Create();

                Encryptor.Mode = Mode;
                Encryptor.IV = HCH.GetBytes(IV, EET.UTF8);
                Encryptor.Key = HCH.GetBytes(Key, EET.UTF8);

                ICryptoTransform Create = Encryptor.CreateEncryptor();

                MemoryStream MStream = new();
                CryptoStream CStream = new(MStream, Create, CryptoStreamMode.Write);

                string Result = string.Empty;

                try
                {
                    byte[] Bytes = HCH.GetBytes(Text, EET.ASCII);

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
        /// <param name="Upper"></param>
        /// <param name="Encode"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string ToMD5(string Text = MCM.Text, bool Upper = MCM.Upper, EET Encode = MCM.Mode)
        {
            try
            {
                Text = HL.Text(Text, MCM.Text);

                using MD5 MD5 = MD5.Create();

                return HF.Formatter(HCH.GetBuild(MD5.ComputeHash(HCH.GetBytes(Text, Encode))), Upper);
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
        /// <param name="Encode"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string ToSHA1(string Text = MCM.Text, bool Upper = MCM.Upper, EET Encode = MCM.Mode)
        {
            try
            {
                Text = HL.Text(Text, MCM.Text);

                using SHA1 SHA1 = SHA1.Create();

                return HF.Formatter(HCH.GetBuild(SHA1.ComputeHash(HCH.GetBytes(Text, Encode))), Upper);
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
        /// <param name="Encode"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string ToSHA256(string Text = MCM.Text, bool Upper = MCM.Upper, EET Encode = MCM.Mode)
        {
            try
            {
                Text = HL.Text(Text, MCM.Text);

                using SHA256 SHA256 = SHA256.Create();

                return HF.Formatter(HCH.GetBuild(SHA256.ComputeHash(HCH.GetBytes(Text, Encode))), Upper);
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
        /// <param name="Encode"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string ToSHA384(string Text = MCM.Text, bool Upper = MCM.Upper, EET Encode = MCM.Mode)
        {
            try
            {
                Text = HL.Text(Text, MCM.Text);

                using SHA384 SHA384 = SHA384.Create();

                return HF.Formatter(HCH.GetBuild(SHA384.ComputeHash(HCH.GetBytes(Text, Encode))), Upper);
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
        /// <param name="Encode"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string ToSHA512(string Text = MCM.Text, bool Upper = MCM.Upper, EET Encode = MCM.Mode)
        {
            try
            {
                Text = HL.Text(Text, MCM.Text);

                using SHA512 SHA512 = SHA512.Create();

                return HF.Formatter(HCH.GetBuild(SHA512.ComputeHash(HCH.GetBytes(Text, Encode))), Upper);
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
        /// <exception cref="E"></exception>
        public static string BaseToText(string Base = MCM.Base, EET Encode = MCM.Encode)
        {
            try
            {
                Base = HL.Text(Base, MCM.Base);

                try
                {
                    return HCH.GetString(HCH.FromBase64String(Base), Encode);
                }
                catch
                {
                    if (Base.EndsWith("==="))
                    {
                        try
                        {
                            return HCH.GetString(HCH.FromBase64String(Base.Replace("===", "")), Encode);
                        }
                        catch { }
                    }

                    if (Base.EndsWith("=="))
                    {
                        try
                        {
                            return HCH.GetString(HCH.FromBase64String(Base.Replace("==", "")), Encode);
                        }
                        catch { }
                    }

                    if (Base.EndsWith("="))
                    {
                        try
                        {
                            return HCH.GetString(HCH.FromBase64String(Base.Replace("=", "")), Encode);
                        }
                        catch { }
                    }

                    try
                    {
                        return BaseToText($"{Base}=", Encode);
                    }
                    catch
                    {
                        try
                        {
                            return BaseToText($"{Base}==", Encode);
                        }
                        catch
                        {
                            return BaseToText($"{Base}===", Encode);
                        }
                    }
                }
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }
    }
}
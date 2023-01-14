using System.Security.Cryptography;
using E = Skylark.Exception;
using EET = Skylark.Enum.EncodeType;
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

                return Convert.ToBase64String(HCH.GetBytes(Text, Encode));
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
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string ToMD5(string Text = MCM.Text, bool Upper = MCM.Upper)
        {
            try
            {
                Text = HL.Text(Text, MCM.Text);

                using MD5 MD5 = MD5.Create();

                return HF.Formatter(HCH.GetBuild(MD5.ComputeHash(HCH.GetBytes(Text, EET.ASCII))), Upper);
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
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string ToSHA1(string Text = MCM.Text, bool Upper = MCM.Upper)
        {
            try
            {
                Text = HL.Text(Text, MCM.Text);

                using SHA1 SHA1 = SHA1.Create();

                return HF.Formatter(HCH.GetBuild(SHA1.ComputeHash(HCH.GetBytes(Text, EET.ASCII))), Upper);
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
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string ToSHA256(string Text = MCM.Text, bool Upper = MCM.Upper)
        {
            try
            {
                Text = HL.Text(Text, MCM.Text);

                using SHA256 SHA256 = SHA256.Create();

                return HF.Formatter(HCH.GetBuild(SHA256.ComputeHash(HCH.GetBytes(Text, EET.ASCII))), Upper);
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
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string ToSHA384(string Text = MCM.Text, bool Upper = MCM.Upper)
        {
            try
            {
                Text = HL.Text(Text, MCM.Text);

                using SHA384 SHA384 = SHA384.Create();

                return HF.Formatter(HCH.GetBuild(SHA384.ComputeHash(HCH.GetBytes(Text, EET.ASCII))), Upper);
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
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string ToSHA512(string Text = MCM.Text, bool Upper = MCM.Upper)
        {
            try
            {
                Text = HL.Text(Text, MCM.Text);

                using SHA512 SHA512 = SHA512.Create();

                return HF.Formatter(HCH.GetBuild(SHA512.ComputeHash(HCH.GetBytes(Text, EET.ASCII))), Upper);
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

                return HCH.GetString(Convert.FromBase64String(Base.Replace("=", "")), Encode);
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }
    }
}
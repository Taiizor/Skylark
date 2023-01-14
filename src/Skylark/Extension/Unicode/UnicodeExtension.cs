using E = Skylark.Exception;
using EET = Skylark.Enum.EncodeType;
using HE = Skylark.Helper.Encode;
using HL = Skylark.Helper.Length;
using MUM = Skylark.Manage.UnicodeManage;

namespace Skylark.Extension
{
    /// <summary>
    /// 
    /// </summary>
    public class UnicodeExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Split"></param>
        /// <param name="Encode"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string TextToASCII(string Text = MUM.Text, char Split = MUM.Split, EET Encode = MUM.Encode)
        {
            try
            {
                Text = HL.Text(Text, MUM.Text);

                return string.Join($"{Split}", HE.GetBytes(Text, Encode).Select(Byte => $"{Byte}"));
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ASCII"></param>
        /// <param name="Split"></param>
        /// <param name="Encode"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string ASCIIToText(string ASCII = MUM.ASCII, char Split = MUM.Split, EET Encode = MUM.Encode)
        {
            try
            {
                ASCII = HL.Text(ASCII, MUM.ASCII);

                return HE.GetString(ASCII.Split(Split).Select(Code => Convert.ToByte(Code)).ToArray(), Encode);
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }
    }
}
using E = Skylark.Exception;
using EET = Skylark.Enum.EncodeType;
using HE = Skylark.Helper.Encode;
using HL = Skylark.Helper.Length;
using MUUM = Skylark.Standard.Manage.Unicode.UnicodeManage;

namespace Skylark.Standard.Extension.Unicode
{
    /// <summary>
    /// 
    /// </summary>
    public static class UnicodeExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Split"></param>
        /// <param name="Encode"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string TextToASCII(string Text = MUUM.Text, char Split = MUUM.Split, EET Encode = MUUM.Encode)
        {
            try
            {
                Text = HL.Text(Text, MUUM.Text);

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
        /// <param name="Text"></param>
        /// <param name="Split"></param>
        /// <param name="Encode"></param>
        /// <returns></returns>
        public static Task<string> TextToASCIIAsync(string Text = MUUM.Text, char Split = MUUM.Split, EET Encode = MUUM.Encode)
        {
            return Task.Run(() => TextToASCII(Text, Split, Encode));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ASCII"></param>
        /// <param name="Split"></param>
        /// <param name="Encode"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string ASCIIToText(string ASCII = MUUM.ASCII, char Split = MUUM.Split, EET Encode = MUUM.Encode)
        {
            try
            {
                ASCII = HL.Text(ASCII, MUUM.ASCII);

                return HE.GetString(ASCII.Split(Split).Select(Code => Convert.ToByte(Code)).ToArray(), Encode);
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
        public static Task<string> ASCIIToTextAsync(string ASCII = MUUM.ASCII, char Split = MUUM.Split, EET Encode = MUUM.Encode)
        {
            return Task.Run(() => ASCIIToText(ASCII, Split, Encode));
        }
    }
}
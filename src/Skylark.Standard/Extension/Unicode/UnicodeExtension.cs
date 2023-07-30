using SE = Skylark.Exception;
using SEET = Skylark.Enum.EncodeType;
using SHE = Skylark.Helper.Encode;
using SHL = Skylark.Helper.Length;
using SSMUUM = Skylark.Standard.Manage.Unicode.UnicodeManage;

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
        /// <exception cref="SE"></exception>
        public static string TextToASCII(string Text = MUUM.Text, char Split = MUUM.Split, EET Encode = MUUM.Encode)
        {
            try
            {
                Text = HL.Text(Text, MUUM.Text);

                return string.Join($"{Split}", HE.GetBytes(Text, Encode).Select(Byte => $"{Byte}"));
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
        /// <param name="Split"></param>
        /// <param name="Encode"></param>
        /// <returns></returns>
        public static async Task<string> TextToASCIIAsync(string Text = MUUM.Text, char Split = MUUM.Split, EET Encode = MUUM.Encode)
        {
            return await Task.Run(() => TextToASCII(Text, Split, Encode));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ASCII"></param>
        /// <param name="Split"></param>
        /// <param name="Encode"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static string ASCIIToText(string ASCII = MUUM.ASCII, char Split = MUUM.Split, EET Encode = MUUM.Encode)
        {
            try
            {
                ASCII = HL.Text(ASCII, MUUM.ASCII);

                return HE.GetString(ASCII.Split(Split).Select(Code => Convert.ToByte(Code)).ToArray(), Encode);
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ASCII"></param>
        /// <param name="Split"></param>
        /// <param name="Encode"></param>
        /// <returns></returns>
        public static async Task<string> ASCIIToTextAsync(string ASCII = MUUM.ASCII, char Split = MUUM.Split, EET Encode = MUUM.Encode)
        {
            return await Task.Run(() => ASCIIToText(ASCII, Split, Encode));
        }
    }
}
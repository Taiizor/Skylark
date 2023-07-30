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
        public static string TextToASCII(string Text = SSMUUM.Text, char Split = SSMUUM.Split, SEET Encode = SSMUUM.Encode)
        {
            try
            {
                Text = SHL.Text(Text, SSMUUM.Text);

                return string.Join($"{Split}", SHE.GetBytes(Text, Encode).Select(Byte => $"{Byte}"));
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
        public static async Task<string> TextToASCIIAsync(string Text = SSMUUM.Text, char Split = SSMUUM.Split, SEET Encode = SSMUUM.Encode)
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
        public static string ASCIIToText(string ASCII = SSMUUM.ASCII, char Split = SSMUUM.Split, SEET Encode = SSMUUM.Encode)
        {
            try
            {
                ASCII = SHL.Text(ASCII, SSMUUM.ASCII);

                return SHE.GetString(ASCII.Split(Split).Select(Code => Convert.ToByte(Code)).ToArray(), Encode);
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
        public static async Task<string> ASCIIToTextAsync(string ASCII = SSMUUM.ASCII, char Split = SSMUUM.Split, SEET Encode = SSMUUM.Encode)
        {
            return await Task.Run(() => ASCIIToText(ASCII, Split, Encode));
        }
    }
}
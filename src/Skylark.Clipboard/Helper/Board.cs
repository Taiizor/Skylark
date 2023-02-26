using System.IO;
using SWFC = System.Windows.Forms.Clipboard;

namespace Skylark.Helper
{
    /// <summary>
    /// 
    /// </summary>
    public static class Board
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Format"></param>
        /// <param name="Data"></param>
        public static void CopyData(string Format, object Data)
        {
            SWFC.SetData(Format, Data);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Format"></param>
        /// <param name="Data"></param>
        /// <returns></returns>
        public static Task CopyDataAsync(string Format, object Data)
        {
            CopyData(Format, Data);
            return Task.CompletedTask;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Bytes"></param>
        public static void CopyAudio(byte[] Bytes)
        {
            SWFC.SetAudio(Bytes);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Bytes"></param>
        /// <returns></returns>
        public static Task CopyAudioAsync(byte[] Bytes)
        {
            CopyAudio(Bytes);
            return Task.CompletedTask;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Stream"></param>
        public static void CopyAudio(Stream Stream)
        {
            SWFC.SetAudio(Stream);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Stream"></param>
        /// <returns></returns>
        public static Task CopyAudioAsync(Stream Stream)
        {
            CopyAudio(Stream);
            return Task.CompletedTask;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Image"></param>
        public static void CopyImage(Image Image)
        {
            SWFC.SetImage(Image);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Image"></param>
        /// <returns></returns>
        public static Task CopyImageAsync(Image Image)
        {
            CopyImage(Image);
            return Task.CompletedTask;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Format"></param>
        public static void CopyText(string Text, TextDataFormat Format = TextDataFormat.Text)
        {
            SWFC.SetText(Text, Format);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Format"></param>
        /// <returns></returns>
        public static Task CopyTextAsync(string Text, TextDataFormat Format = TextDataFormat.Text)
        {
            CopyText(Text, Format);
            return Task.CompletedTask;
        }










        /// <summary>
        /// 
        /// </summary>
        private static object Clipboard = null;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        public static void Copy(object Value)
        {
            Clipboard = Value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        public static Task CopyAsync(object Value)
        {
            Copy(Value);
            return Task.CompletedTask;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Clear"></param>
        /// <param name="Back"></param>
        /// <returns></returns>
        public static object Paste(bool Clear = false, object Back = null)
        {
            object Value = Clipboard;

            if (Clear)
            {
                Clipboard = null;
            }

            if (Value == null)
            {
                return Back;
            }
            else
            {
                return Value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Clear"></param>
        /// <param name="Back"></param>
        /// <returns></returns>
        public static Task<object> PasteAsync(bool Clear = false, object Back = null)
        {
            return Task.Run(() => Paste(Clear, Back));
        }
    }
}
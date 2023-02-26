using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using SCSSC = System.Collections.Specialized.StringCollection;
using SWFC = System.Windows.Forms.Clipboard;

namespace Skylark.Clipboard.Helper
{
    /// <summary>
    /// 
    /// </summary>
    public static class Board
    {
        /// <summary>
        /// 
        /// </summary>
        public static void Clear()
        {
            SWFC.Clear();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Format"></param>
        /// <param name="Data"></param>
        public static void SetData(string Format, object Data)
        {
            SWFC.SetData(Format, Data);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Format"></param>
        /// <param name="Data"></param>
        /// <returns></returns>
        public static Task SetDataAsync(string Format, object Data)
        {
            SetData(Format, Data);
            return Task.CompletedTask;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Format"></param>
        /// <returns></returns>
        public static object GetData(string Format)
        {
            return SWFC.GetData(Format);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Format"></param>
        /// <returns></returns>
        public static Task<object> GetDataAsync(string Format)
        {
            return Task.Run(() => GetData(Format));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Format"></param>
        /// <returns></returns>
        public static bool ContainsData(string Format)
        {
            return SWFC.ContainsData(Format);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Format"></param>
        /// <returns></returns>
        public static Task<bool> ContainsDataAsync(string Format)
        {
            return Task.Run(() => ContainsData(Format));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Bytes"></param>
        public static void SetAudio(byte[] Bytes)
        {
            SWFC.SetAudio(Bytes);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Bytes"></param>
        /// <returns></returns>
        public static Task SetAudioAsync(byte[] Bytes)
        {
            SetAudio(Bytes);
            return Task.CompletedTask;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Stream"></param>
        public static void SetAudio(Stream Stream)
        {
            SWFC.SetAudio(Stream);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Stream"></param>
        /// <returns></returns>
        public static Task SetAudioAsync(Stream Stream)
        {
            SetAudio(Stream);
            return Task.CompletedTask;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Stream GetAudio()
        {
            return SWFC.GetAudioStream();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Task<Stream> GetAudioAsync()
        {
            return Task.Run(GetAudio);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static bool ContainsAudio()
        {
            return SWFC.ContainsAudio();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Task<bool> ContainsAudioAsync()
        {
            return Task.Run(ContainsAudio);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Image"></param>
        public static void SetImage(Image Image)
        {
            SWFC.SetImage(Image);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Image"></param>
        /// <returns></returns>
        public static Task SetImageAsync(Image Image)
        {
            SetImage(Image);
            return Task.CompletedTask;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Image GetImage()
        {
            return SWFC.GetImage();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Task<Image> GetImageAsync()
        {
            return Task.Run(GetImage);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static bool ContainsImage()
        {
            return SWFC.ContainsImage();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Task<bool> ContainsImageAsync()
        {
            return Task.Run(ContainsImage);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Data"></param>
        /// <param name="Set"></param>
        public static void SetDataObject(object Data, bool Set)
        {
            SWFC.SetDataObject(Data, Set);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Data"></param>
        /// <param name="Set"></param>
        /// <returns></returns>
        public static Task SetDataObjectAsync(object Data, bool Set)
        {
            SetDataObject(Data, Set);
            return Task.CompletedTask;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static IDataObject GetDataObject()
        {
            return SWFC.GetDataObject();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Task<IDataObject> GetDataObjectAsync()
        {
            return Task.Run(GetDataObject);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Paths"></param>
        public static void SetFileDropList(SCSSC Paths)
        {
            SWFC.SetFileDropList(Paths);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Paths"></param>
        /// <returns></returns>
        public static Task SetFileDropListAsync(SCSSC Paths)
        {
            SetFileDropList(Paths);
            return Task.CompletedTask;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static SCSSC GetFileDropList()
        {
            return SWFC.GetFileDropList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Task<SCSSC> GetFileDropListAsync()
        {
            return Task.Run(GetFileDropList);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static bool ContainsFileDropList()
        {
            return SWFC.ContainsFileDropList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Task<bool> ContainsFileDropListAsync()
        {
            return Task.Run(ContainsFileDropList);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Format"></param>
        public static void SetText(string Text, TextDataFormat Format = TextDataFormat.Text)
        {
            SWFC.SetText(Text, Format);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="Format"></param>
        /// <returns></returns>
        public static Task SetTextAsync(string Text, TextDataFormat Format = TextDataFormat.Text)
        {
            SetText(Text, Format);
            return Task.CompletedTask;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Format"></param>
        /// <returns></returns>
        public static string GetText(TextDataFormat Format = TextDataFormat.Text)
        {
            return SWFC.GetText(Format);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Format"></param>
        /// <returns></returns>
        public static Task<string> GetTextAsync(TextDataFormat Format = TextDataFormat.Text)
        {
            return Task.Run(() => GetText(Format));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Format"></param>
        /// <returns></returns>
        public static bool ContainsText(TextDataFormat Format = TextDataFormat.Text)
        {
            return SWFC.ContainsText(Format);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Format"></param>
        /// <returns></returns>
        public static Task<bool> ContainsTextAsync(TextDataFormat Format = TextDataFormat.Text)
        {
            return Task.Run(() => ContainsText(Format));
        }
    }
}
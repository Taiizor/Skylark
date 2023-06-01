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
        public static async Task SetDataAsync(string Format, object Data)
        {
            await Task.Run(() => SetData(Format, Data));
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
        public static async Task<object> GetDataAsync(string Format)
        {
            return await Task.Run(() => GetData(Format));
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
        public static async Task<bool> ContainsDataAsync(string Format)
        {
            return await Task.Run(() => ContainsData(Format));
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
        public static async Task SetAudioAsync(byte[] Bytes)
        {
            await Task.Run(() => SetAudio(Bytes));
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
        public static async Task SetAudioAsync(Stream Stream)
        {
            await Task.Run(() => SetAudio(Stream));
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
        public static async Task<Stream> GetAudioAsync()
        {
            return await Task.Run(GetAudio);
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
        public static async Task<bool> ContainsAudioAsync()
        {
            return await Task.Run(ContainsAudio);
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
        public static async Task SetImageAsync(Image Image)
        {
            await Task.Run(() => SetImage(Image));
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
        public static async Task<Image> GetImageAsync()
        {
            return await Task.Run(GetImage);
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
        public static async Task<bool> ContainsImageAsync()
        {
            return await Task.Run(ContainsImage);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Data"></param>
        /// <param name="Copy"></param>
        public static void SetDataObject(object Data, bool Copy)
        {
            SWFC.SetDataObject(Data, Copy);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Data"></param>
        /// <param name="Copy"></param>
        /// <returns></returns>
        public static async Task SetDataObjectAsync(object Data, bool Copy)
        {
            await Task.Run(() => SetDataObject(Data, Copy));
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
        public static async Task<IDataObject> GetDataObjectAsync()
        {
            return await Task.Run(GetDataObject);
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
        public static async Task SetFileDropListAsync(SCSSC Paths)
        {
            await Task.Run(() => SetFileDropList(Paths));
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
        public static async Task<SCSSC> GetFileDropListAsync()
        {
            return await Task.Run(GetFileDropList);
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
        public static async Task<bool> ContainsFileDropListAsync()
        {
            return await Task.Run(ContainsFileDropList);
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
        public static async Task SetTextAsync(string Text, TextDataFormat Format = TextDataFormat.Text)
        {
            await Task.Run(() => SetText(Text, Format));
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
        public static async Task<string> GetTextAsync(TextDataFormat Format = TextDataFormat.Text)
        {
            return await Task.Run(() => GetText(Format));
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
        public static async Task<bool> ContainsTextAsync(TextDataFormat Format = TextDataFormat.Text)
        {
            return await Task.Run(() => ContainsText(Format));
        }
    }
}
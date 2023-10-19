using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using SCSSC = System.Collections.Specialized.StringCollection;
using SE = Skylark.Exception;
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
        /// <exception cref="SE"></exception>
        public static void Clear()
        {
            try
            {
                SWFC.Clear();
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static async Task ClearAsync()
        {
            await Task.Run(Clear);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Format"></param>
        /// <param name="Data"></param>
        /// <exception cref="SE"></exception>
        public static void SetData(string Format, object Data)
        {
            try
            {
                SWFC.SetData(Format, Data);
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
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
        /// <exception cref="SE"></exception>
        public static object GetData(string Format)
        {
            try
            {
                return SWFC.GetData(Format);
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
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
        /// <exception cref="SE"></exception>
        public static bool ContainsData(string Format)
        {
            try
            {
                return SWFC.ContainsData(Format);
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
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
        /// <exception cref="SE"></exception>
        public static void SetAudio(byte[] Bytes)
        {
            try
            {
                SWFC.SetAudio(Bytes);
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
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
        /// <exception cref="SE"></exception>
        public static void SetAudio(Stream Stream)
        {
            try
            {
                SWFC.SetAudio(Stream);
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
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
        /// <exception cref="SE"></exception>
        public static Stream GetAudio()
        {
            try
            {
                return SWFC.GetAudioStream();
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
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
        /// <exception cref="SE"></exception>
        public static bool ContainsAudio()
        {
            try
            {
                return SWFC.ContainsAudio();
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
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
        /// <exception cref="SE"></exception>
        public static void SetImage(Image Image)
        {
            try
            {
                SWFC.SetImage(Image);
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
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
        /// <exception cref="SE"></exception>
        public static Image GetImage()
        {
            try
            {
                return SWFC.GetImage();
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
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
        /// <exception cref="SE"></exception>
        public static bool ContainsImage()
        {
            try
            {
                return SWFC.ContainsImage();
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
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
        /// <exception cref="SE"></exception>
        public static void SetDataObject(object Data, bool Copy)
        {
            try
            {
                SWFC.SetDataObject(Data, Copy);
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
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
        /// <exception cref="SE"></exception>
        public static IDataObject GetDataObject()
        {
            try
            {
                return SWFC.GetDataObject();
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
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
        /// <exception cref="SE"></exception>
        public static void SetFileDropList(SCSSC Paths)
        {
            try
            {
                SWFC.SetFileDropList(Paths);
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
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
        /// <exception cref="SE"></exception>
        public static SCSSC GetFileDropList()
        {
            try
            {
                return SWFC.GetFileDropList();
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
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
        /// <exception cref="SE"></exception>
        public static bool ContainsFileDropList()
        {
            try
            {
                return SWFC.ContainsFileDropList();
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
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
        /// <exception cref="SE"></exception>
        public static void SetText(string Text, TextDataFormat Format = TextDataFormat.UnicodeText)
        {
            try
            {
                SWFC.SetText(Text, Format);
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
        /// <param name="Format"></param>
        /// <returns></returns>
        public static async Task SetTextAsync(string Text, TextDataFormat Format = TextDataFormat.UnicodeText)
        {
            await Task.Run(() => SetText(Text, Format));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Format"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static string GetText(TextDataFormat Format = TextDataFormat.UnicodeText)
        {
            try
            {
                return SWFC.GetText(Format);
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Format"></param>
        /// <returns></returns>
        public static async Task<string> GetTextAsync(TextDataFormat Format = TextDataFormat.UnicodeText)
        {
            return await Task.Run(() => GetText(Format));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Format"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static bool ContainsText(TextDataFormat Format = TextDataFormat.UnicodeText)
        {
            try
            {
                return SWFC.ContainsText(Format);
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Format"></param>
        /// <returns></returns>
        public static async Task<bool> ContainsTextAsync(TextDataFormat Format = TextDataFormat.UnicodeText)
        {
            return await Task.Run(() => ContainsText(Format));
        }
    }
}
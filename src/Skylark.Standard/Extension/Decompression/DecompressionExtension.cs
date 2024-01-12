using System.IO.Compression;
using SE = Skylark.Exception;
using SEDT = Skylark.Enum.DecompressionType;
using SSDDS = Skylark.Struct.Decompression.DecompressionStruct;
using SSHDDH = Skylark.Standard.Helper.Decompression.DecompressionHelper;
using SSMDDM = Skylark.Standard.Manage.Decompression.DecompressionManage;

namespace Skylark.Standard.Extension.Compression
{
    /// <summary>
    /// 
    /// </summary>
    public static class DecompressionExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Data"></param>
        /// <param name="Type"></param>
        /// <param name="Level"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static SSDDS Decompress(byte[] Data, SEDT Type = SSMDDM.Type, CompressionLevel Level = SSMDDM.Level)
        {
            try
            {
                SSHDDH.DataControl(Data);

                SSDDS Result = new();

                using (MemoryStream MStream = new(Data))
                {
                    if (Type == SEDT.GZip)
                    {
                        using GZipStream GStream = new(MStream, CompressionMode.Decompress);
                        using StreamReader Reader = new(GStream);

                        Result.DecompressedData = Reader.ReadToEnd();
                    }
#if NETSTANDARD2_1
                    else if (Type == SEDT.Brotli)
                    {
                        using BrotliStream BStream = new(MStream, CompressionMode.Decompress);
                        using StreamReader Reader = new(BStream);

                        Result.DecompressedData = Reader.ReadToEnd();
                    }
#endif
                    else
                    {
                        using DeflateStream DStream = new(MStream, CompressionMode.Decompress);
                        using StreamReader Reader = new(DStream);

                        Result.DecompressedData = Reader.ReadToEnd();
                    }

                    Result.Data = Data;
                    Result.Length = Data.Length;
                    Result.DecompressedLength = Result.DecompressedData.Length;
                    Result.DecompressionLength = Result.DecompressedLength - Result.Length;
                    Result.DecompressionPercentage = (double)Result.DecompressionLength / Result.DecompressedLength * 100d;
                }

                return Result;
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
        /// <param name="Type"></param>
        /// <param name="Level"></param>
        /// <returns></returns>
        public static async Task<SSDDS> DecompressAsync(byte[] Data, SEDT Type = SSMDDM.Type, CompressionLevel Level = SSMDDM.Level)
        {
            return await Task.Run(() => Decompress(Data, Type, Level));
        }
    }
}
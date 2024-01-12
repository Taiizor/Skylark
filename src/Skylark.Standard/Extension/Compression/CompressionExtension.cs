using System.IO.Compression;
using SE = Skylark.Exception;
using SECT = Skylark.Enum.CompressionType;
using SHL = Skylark.Helper.Length;
using SSCCS = Skylark.Struct.Compression.CompressionStruct;
using SSMCCM = Skylark.Standard.Manage.Compression.CompressionManage;

namespace Skylark.Standard.Extension.Compression
{
    /// <summary>
    /// 
    /// </summary>
    public static class CompressionExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Data"></param>
        /// <param name="Type"></param>
        /// <param name="Level"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static SSCCS Compress(string Data = SSMCCM.Data, SECT Type = SSMCCM.Type, CompressionLevel Level = SSMCCM.Level)
        {
            try
            {
                Data = SHL.Text(Data, SSMCCM.Data);

                SSCCS Result = new();

                using (MemoryStream MStream = new())
                {
                    if (Type == SECT.GZip)
                    {
                        using GZipStream GStream = new(MStream, Level);
                        using StreamWriter Writer = new(GStream);

                        Writer.Write(Data);
                    }
#if NETSTANDARD2_1
                    else if (Type == SECT.Brotli)
                    {
                        using BrotliStream BStream = new(MStream, Level);
                        using StreamWriter Writer = new(BStream);

                        Writer.Write(Data);
                    }
#endif
                    else
                    {
                        using DeflateStream DStream = new(MStream, Level);
                        using StreamWriter Writer = new(DStream);

                        Writer.Write(Data);
                    }

                    Result.Data = Data;
                    Result.Length = Data.Length;
                    Result.CompressedData = MStream.ToArray();
                    Result.CompressedLength = Result.CompressedData.Length;
                    Result.CompressionLength = Result.Length - Result.CompressedLength;
                    Result.CompressionPercentage = (double)Result.CompressionLength / Result.Length * 100d;
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
        public static async Task<SSCCS> CompressAsync(string Data = SSMCCM.Data, SECT Type = SSMCCM.Type, CompressionLevel Level = SSMCCM.Level)
        {
            return await Task.Run(() => Compress(Data, Type, Level));
        }
    }
}
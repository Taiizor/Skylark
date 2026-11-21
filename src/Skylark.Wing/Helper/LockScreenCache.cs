#region Imports

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using SELFT = Skylark.Enum.LockScreenFitType;

#endregion

namespace Skylark.Wing.Helper
{
    /// <summary>
    /// Helper for managing and generating Windows lock screen first-frame (.bgra) caches.
    /// </summary>
    public static class LockScreenCache
    {
        #region Constants

        private const uint CacheMagic = 0x4C565734; // "LVW4"
        private const ulong FnvOffsetBasis = 1469598103934665603UL;
        private const ulong FnvPrime = 1099511628211UL;

        #endregion

        #region Methods

        /// <summary>
        /// Computes 64-bit FNV-1a hash matching the C++ native core implementation.
        /// </summary>
        /// <param name="Text"></param>
        /// <returns></returns>
        public static ulong ComputeFnv1a(string Text)
        {
            if (string.IsNullOrEmpty(Text))
            {
                return 0;
            }

            ulong Hash = FnvOffsetBasis;
            foreach (char C in Text)
            {
                Hash ^= C;
                Hash *= FnvPrime;
            }
            return Hash;
        }

        /// <summary>
        /// Gets the expected cache file path for the given media and dimensions.
        /// </summary>
        /// <param name="CacheDirectory"></param>
        /// <param name="MediaPath"></param>
        /// <param name="Width"></param>
        /// <param name="Height"></param>
        /// <param name="FitMode"></param>
        /// <returns></returns>
        public static string GetCacheFilePath(string CacheDirectory, string MediaPath, int Width, int Height, SELFT FitMode)
        {
            string Key = $"{MediaPath}|{Width}|{Height}|{(int)FitMode}|raw";
            ulong Hash = ComputeFnv1a(Key);
            string FileName = $"frame_{(uint)(Hash >> 32):X8}{(uint)Hash:X8}.bgra";
            return Path.Combine(CacheDirectory, FileName);
        }

        /// <summary>
        /// Saves raw BGRA pixel bytes to disk with the LVW4 cache header.
        /// </summary>
        /// <param name="FilePath"></param>
        /// <param name="BgraPixels"></param>
        /// <param name="Width"></param>
        /// <param name="Height"></param>
        /// <returns></returns>
        public static bool SaveRawCache(string FilePath, byte[] BgraPixels, int Width, int Height)
        {
            if (BgraPixels == null || BgraPixels.Length != Width * Height * 4)
            {
                return false;
            }

            try
            {
                string Dir = Path.GetDirectoryName(FilePath);
                if (!string.IsNullOrEmpty(Dir) && !Directory.Exists(Dir))
                {
                    Directory.CreateDirectory(Dir);
                }

                using FileStream Fs = new(FilePath, FileMode.Create, FileAccess.Write, FileShare.None);
                using BinaryWriter Bw = new(Fs);
                Bw.Write(CacheMagic);
                Bw.Write((uint)Width);
                Bw.Write((uint)Height);
                Bw.Write((uint)0); // padding
                Bw.Write(BgraPixels);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Generates and saves a cache file from a GDI+ Bitmap, scaling according to fit mode.
        /// </summary>
        /// <param name="SourceImage"></param>
        /// <param name="TargetFilePath"></param>
        /// <param name="TargetWidth"></param>
        /// <param name="TargetHeight"></param>
        /// <param name="FitMode"></param>
        /// <returns></returns>
        public static bool GenerateCacheFromBitmap(Bitmap SourceImage, string TargetFilePath, int TargetWidth, int TargetHeight, SELFT FitMode)
        {
            if (SourceImage == null || TargetWidth <= 0 || TargetHeight <= 0)
            {
                return false;
            }

            try
            {
                using Bitmap Canvas = new(TargetWidth, TargetHeight, PixelFormat.Format32bppArgb);
                using (Graphics G = Graphics.FromImage(Canvas))
                {
                    G.Clear(Color.Black);
                    G.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    G.PixelOffsetMode = PixelOffsetMode.HighQuality;
                    G.SmoothingMode = SmoothingMode.HighQuality;

                    float ScaleX, ScaleY;
                    switch (FitMode)
                    {
                        case SELFT.Fill:
                            ScaleX = (float)TargetWidth / SourceImage.Width;
                            ScaleY = (float)TargetHeight / SourceImage.Height;
                            break;
                        case SELFT.Fit:
                            ScaleX = ScaleY = Math.Min((float)TargetWidth / SourceImage.Width, (float)TargetHeight / SourceImage.Height);
                            break;
                        case SELFT.Center:
                            ScaleX = ScaleY = 1.0f;
                            break;
                        default: // Cover
                            ScaleX = ScaleY = Math.Max((float)TargetWidth / SourceImage.Width, (float)TargetHeight / SourceImage.Height);
                            break;
                    }

                    float DestW = SourceImage.Width * ScaleX;
                    float DestH = SourceImage.Height * ScaleY;
                    float DestX = (TargetWidth - DestW) * 0.5f;
                    float DestY = (TargetHeight - DestH) * 0.5f;

                    G.DrawImage(SourceImage, DestX, DestY, DestW, DestH);
                }

                BitmapData BmpData = Canvas.LockBits(new Rectangle(0, 0, TargetWidth, TargetHeight),
                                                     ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
                byte[] Pixels = new byte[TargetWidth * TargetHeight * 4];
                Marshal.Copy(BmpData.Scan0, Pixels, 0, Pixels.Length);
                Canvas.UnlockBits(BmpData);

                return SaveRawCache(TargetFilePath, Pixels, TargetWidth, TargetHeight);
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Prunes older cache files keeping only the newest specified count.
        /// </summary>
        /// <param name="CacheDirectory"></param>
        /// <param name="MaxToKeep"></param>
        public static void PruneCache(string CacheDirectory, int MaxToKeep = 5)
        {
            if (!Directory.Exists(CacheDirectory))
            {
                return;
            }

            try
            {
                DirectoryInfo Di = new(CacheDirectory);
                FileInfo[] Files = Di.GetFiles("frame_*.bgra");
                if (Files.Length <= MaxToKeep)
                {
                    return;
                }

                Array.Sort(Files, (A, B) => B.LastWriteTimeUtc.CompareTo(A.LastWriteTimeUtc));
                for (int I = MaxToKeep; I < Files.Length; I++)
                {
                    try { Files[I].Delete(); } catch { }
                }
            }
            catch { }
        }

        #endregion
    }
}
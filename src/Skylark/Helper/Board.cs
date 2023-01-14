using E = Skylark.Exception;
using MS = Skylark.Manage.Special;

namespace Skylark.Helper
{
    /// <summary>
    /// 
    /// </summary>
    public class Board
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Byte"></param>
        /// <exception cref="E"></exception>
        public static void Copy(byte[] Byte)
        {
            try
            {
                MS.BoardBytes = Byte;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="String"></param>
        /// <exception cref="E"></exception>
        public static void Copy(string String)
        {
            try
            {
                MS.BoardText = String;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Integer"></param>
        /// <exception cref="E"></exception>
        public static void Copy(int Integer)
        {
            try
            {
                MS.BoardNumber = Integer;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Boolean"></param>
        /// <exception cref="E"></exception>
        public static void Copy(bool Boolean)
        {
            try
            {
                MS.BoardBool = Boolean;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Clear"></param>
        /// <param name="Back"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static byte[] Paste(bool Clear = false, byte[] Back = null)
        {
            try
            {
                byte[] Byte = MS.BoardBytes;

                if (Clear)
                {
                    MS.BoardBytes = Array.Empty<byte>();
                }

                if (Byte == null)
                {
                    return Back;
                }
                else
                {
                    return Byte;
                }
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Clear"></param>
        /// <param name="Back"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static Stream Paste(bool Clear = false, Stream Back = null)
        {
            try
            {
                Stream Stream = new MemoryStream(MS.BoardBytes);

                if (Clear)
                {
                    MS.BoardBytes = Array.Empty<byte>();
                }

                if (Stream == null)
                {
                    return Back;
                }
                else
                {
                    return Stream;
                }
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Clear"></param>
        /// <param name="Back"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static string Paste(bool Clear = false, string Back = "Empty!")
        {
            try
            {
                string String = MS.BoardText;

                if (Clear)
                {
                    MS.BoardText = string.Empty;
                }

                if (string.IsNullOrEmpty(String))
                {
                    return Back;
                }
                else
                {
                    return String;
                }
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Clear"></param>
        /// <param name="Back"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static int Paste(bool Clear = false, int Back = 0)
        {
            try
            {
                int Integer = MS.BoardNumber;

                if (Clear)
                {
                    MS.BoardNumber = 0;
                }

                if (Integer > 0)
                {
                    return Back;
                }
                else
                {
                    return Integer;
                }
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Clear"></param>
        /// <param name="Back"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static bool Paste(bool Clear = false, bool Back = false)
        {
            try
            {
                bool Boolean = MS.BoardBool;

                if (Clear)
                {
                    MS.BoardBool = false;
                }

                if (Boolean != true)
                {
                    return Back;
                }
                else
                {
                    return Boolean;
                }
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }
    }
}
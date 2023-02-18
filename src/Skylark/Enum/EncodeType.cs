using System.Text;

namespace Skylark.Enum
{
    /// <summary>
    /// 
    /// </summary>
    public enum EncodeType
    {
        /// <summary>
        /// 
        /// </summary>
        UTF7,
        /// <summary>
        /// 
        /// </summary>
        UTF8,
        /// <summary>
        /// 
        /// </summary>
        UTF32,
        /// <summary>
        /// 
        /// </summary>
        ASCII,
        /// <summary>
        /// 
        /// </summary>
        Unicode,
        /// <summary>
        /// 
        /// </summary>
        Default,
        /// <summary>
        /// 
        /// </summary>
        BigEndianUnicode
    }

    public static class EncodeTypeHelper
    {
        public static Encoding GetEncoding
            (this EncodeType encodeType, bool useUtf8IfNotValid = false, string errorMessage = "Invalid encoding")
        {
            if (!System.Enum.IsDefined(typeof(EncodeType), encodeType))
            {
                if (useUtf8IfNotValid)
                    return Encoding.UTF8;
                throw new Skylark.Exception(errorMessage);
            }
            
            return encodeType switch
            {
                EncodeType.UTF8 => Encoding.UTF8,
                EncodeType.UTF32 => Encoding.UTF32,
                EncodeType.ASCII => Encoding.ASCII,
                EncodeType.Unicode => Encoding.Unicode,
                EncodeType.UTF7 => Encoding.UTF7,
                EncodeType.BigEndianUnicode => Encoding.BigEndianUnicode,
                _ => Encoding.Default
            };
        }
    }
}
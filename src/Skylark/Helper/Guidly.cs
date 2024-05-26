namespace Skylark.Helper
{
    /// <summary>
    /// 
    /// </summary>
    public static class Guidly
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Base"></param>
        /// <returns></returns>
        public static Guid BaseToGuid(string Base)
        {
            Base = Base.Replace("_", "/").Replace("-", "+");

            switch (Base.Length % 4)
            {
                case 2:
                    Base += "==";
                    break;
                case 3:
                    Base += "=";
                    break;
            }

            byte[] Bytes = Convert.FromBase64String(Base);

            return ByteToGuid(Bytes);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Base"></param>
        /// <returns></returns>
        public static async Task<Guid> BaseToGuidAsync(string Base)
        {
            return await Task.Run(() => BaseToGuid(Base));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Byte"></param>
        /// <returns></returns>
        public static Guid ByteToGuid(byte[] Byte)
        {
            return new Guid(Byte);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Byte"></param>
        /// <returns></returns>
        public static async Task<Guid> ByteToGuidAsync(byte[] Byte)
        {
            return await Task.Run(() => ByteToGuid(Byte));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Guid"></param>
        /// <returns></returns>
        public static string GuidToBase(Guid Guid)
        {
            byte[] Bytes = GuidToByte(Guid);

            string Base64 = Convert.ToBase64String(Bytes);

            return Base64.Replace("/", "_").Replace("+", "-").TrimEnd('=');
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Guid"></param>
        /// <returns></returns>
        public static async Task<string> GuidToBaseAsync(Guid Guid)
        {
            return await Task.Run(() => GuidToBase(Guid));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Guid"></param>
        /// <returns></returns>
        public static byte[] GuidToByte(Guid Guid)
        {
            return Guid.ToByteArray();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Guid"></param>
        /// <returns></returns>
        public static async Task<byte[]> GuidToByteAsync(Guid Guid)
        {
            return await Task.Run(() => GuidToByte(Guid));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <returns></returns>
        public static Guid TextToGuid(string Text)
        {
            return new Guid(Text);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Text"></param>
        /// <returns></returns>
        public static async Task<Guid> TextToGuidAsync(string Text)
        {
            return await Task.Run(() => TextToGuid(Text));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Guid"></param>
        /// <param name="Format"></param>
        /// <returns></returns>
        public static string GuidToText(Guid Guid, string Format = "D")
        {
            return Guid.ToString(Format);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Guid"></param>
        /// <param name="Format"></param>
        /// <returns></returns>
        public static async Task<string> GuidToTextAsync(Guid Guid, string Format = "D")
        {
            return await Task.Run(() => GuidToText(Guid, Format));
        }
    }
}
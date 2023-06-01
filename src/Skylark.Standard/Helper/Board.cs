namespace Skylark.Standard.Helper
{
    /// <summary>
    /// 
    /// </summary>
    public static class Board
    {
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
        public static async Task CopyAsync(object Value)
        {
            await Task.Run(() => Copy(Value));
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
        public static async Task<object> PasteAsync(bool Clear = false, object Back = null)
        {
            return await Task.Run(() => Paste(Clear, Back));
        }
    }
}
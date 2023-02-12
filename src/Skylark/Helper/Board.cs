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
        public static Task CopyAsync(object Value)
        {
            Copy(Value);
            return Task.CompletedTask;
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
        public static Task<object> PasteAsync(bool Clear = false, object Back = null)
        {
            return Task.Run(() => Paste(Clear, Back));
        }
    }
}
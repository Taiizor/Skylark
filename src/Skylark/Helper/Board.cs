using E = Skylark.Exception;

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
        /// <exception cref="E"></exception>
        public static void Copy(object Value)
        {
            try
            {
                Clipboard = Value;
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
        public static object Paste(bool Clear = false, object Back = null)
        {
            try
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
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }
    }
}
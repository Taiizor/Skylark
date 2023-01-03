namespace Skylark.Helper
{
    /// <summary>
    /// 
    /// </summary>
    internal class Detect
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static char Symbol()
        {
            if ($"{10 / 3f}".Contains('.'))
            {
                return '.';
            }
            else
            {
                return ',';
            }
        }
    }
}
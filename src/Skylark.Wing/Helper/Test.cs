using E = Skylark.Exception;

namespace Skylark.Wing.Helper
{
    /// <summary>
    /// 
    /// </summary>
    public static class Test
    {
        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="E"></exception>
        public static void Skylark()
        {
            try
            {
                return;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }
    }
}
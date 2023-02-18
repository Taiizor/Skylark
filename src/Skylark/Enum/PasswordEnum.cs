using Skylark.Helper;
using System.Diagnostics;

namespace Skylark.Enum
{
    /// <summary>
    /// 
    /// </summary>
    public enum MeterPasswordType
    {
        /// <summary>
        /// 
        /// </summary>
        Dead = 0,
        /// <summary>
        /// 
        /// </summary>
        Weak = 20,
        /// <summary>
        /// 
        /// </summary>
        Medium = 40,
        /// <summary>
        /// 
        /// </summary>
        Normal = 60,
        /// <summary>
        /// 
        /// </summary>
        Strong = 80,
        /// <summary>
        /// 
        /// </summary>
        Legend = 100
    }

    public static class MeterPasswordTypeHelper // Move this class?
    {
        // If more password strengths are removed or added, this will compute it automatically
        public static readonly int LowestPasswordStrength = typeof(MeterPasswordType)
            .GetEnumValues()
            .Cast<int>()
            .Min();

        public static readonly int HighestPasswordStrength = typeof(MeterPasswordType)
            .GetEnumValues()
            .Cast<int>()
            .Max();

        public static MeterPasswordType UpgradeMeterLevel(this MeterPasswordType meterPasswordType)
        {
            int result = (int)meterPasswordType + 20;

            Skymath.Clamp(result, LowestPasswordStrength, HighestPasswordStrength);
            Debug.Assert(result % 20 == 0);
            return (MeterPasswordType)result;
        }

        public static MeterPasswordType DowngradeMeterLevel(this MeterPasswordType meterPasswordType)
        {
            int result = (int)meterPasswordType - 20;

            Skymath.Clamp(result, LowestPasswordStrength, HighestPasswordStrength);
            Debug.Assert(result % 20 == 0);
            return (MeterPasswordType)result;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public enum SpecialPasswordType
    {
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Mixed,
        /// <summary>
        /// 
        /// </summary>
        Number,
        /// <summary>
        /// 
        /// </summary>
        Symbol
    }

    /// <summary>
    /// 
    /// </summary>
    public enum AlphabeticPasswordType
    {
        /// <summary>
        /// 
        /// </summary>
        Big,
        /// <summary>
        /// 
        /// </summary>
        None,
        /// <summary>
        /// 
        /// </summary>
        Small,
        /// <summary>
        /// 
        /// </summary>
        Mixed
    }
}
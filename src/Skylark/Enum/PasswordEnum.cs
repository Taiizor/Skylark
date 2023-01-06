namespace Skylark.Enum
{
    /// <summary>
    /// 
    /// </summary>
    public enum MeterPasswordType
    {
        Dead = 0,
        Weak = 20,
        Medium = 40,
        Normal = 60,
        Strong = 80,
        Legend = 100
    }

    /// <summary>
    /// 
    /// </summary>
    public enum SpecialPasswordType
    {
        None,
        Mixed,
        Number,
        Symbol
    }

    /// <summary>
    /// 
    /// </summary>
    public enum AlphabeticPasswordType
    {
        Big,
        None,
        Small,
        Mixed
    }
}
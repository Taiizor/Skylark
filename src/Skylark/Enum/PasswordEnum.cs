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

    /// <summary>
    /// 
    /// </summary>
    public enum SimilarPasswordType
    {
        /// <summary>
        /// 
        /// </summary>
        Cosine,
        /// <summary>
        /// 
        /// </summary>
        Jaccard,
        /// <summary>
        /// 
        /// </summary>
        Jaccardy,
        /// <summary>
        /// 
        /// </summary>
        Levenshtein
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
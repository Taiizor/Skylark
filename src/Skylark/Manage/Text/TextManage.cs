using ETT = Skylark.Enum.TextType;

namespace Skylark.Manage.Text
{
    /// <summary>
    /// 
    /// </summary>
    internal static class TextManage
    {
        /// <summary>
        /// 
        /// </summary>
        public const int Pass = 0;

        /// <summary>
        /// 
        /// </summary>
        public const int Word = 5;
        /// <summary>
        /// 
        /// </summary>
        public const int MinWord = 1;
        /// <summary>
        /// 
        /// </summary>
        public const int MaxWord = 1024;

        /// <summary>
        /// 
        /// </summary>
        public const int List = 5;
        /// <summary>
        /// 
        /// </summary>
        public const int MinList = 1;
        /// <summary>
        /// 
        /// </summary>
        public const int MaxList = 100;

        /// <summary>
        /// 
        /// </summary>
        public const int Length = 10;
        /// <summary>
        /// 
        /// </summary>
        public const int MinLength = 1;
        /// <summary>
        /// 
        /// </summary>
        public const int MaxLength = 500000;

        /// <summary>
        /// 
        /// </summary>
        public const int Paragraph = 3;
        /// <summary>
        /// 
        /// </summary>
        public const int MinParagraph = 1;
        /// <summary>
        /// 
        /// </summary>
        public const int MaxParagraph = 50;

        /// <summary>
        /// 
        /// </summary>
        public const ETT CutMethod = ETT.End;
        /// <summary>
        /// 
        /// </summary>
        public const string CutSymbol = "...";

        /// <summary>
        /// 
        /// </summary>
        public const char ListSymbol = '●';

        /// <summary>
        /// 
        /// </summary>
        public const string Unknown = "Unknown";

        /// <summary>
        /// 
        /// </summary>
        public const string Text = "Taiizor Skylark";

        /// <summary>
        /// 
        /// </summary>
        public const string Error = "Method variable not selected.";

        /// <summary>
        /// 
        /// </summary>
        public static readonly string[] Words = new string[] { "Lorem", "ipsum", "dolor", "sit", "amet,", "consectetur", "adipiscing", "elit,", "sed", "do", "eiusmod", "tempor", "incididunt", "ut", "labore", "et", "dolore", "magna", "aliqua.", "Ut", "enim", "ad", "minim", "veniam,", "quis", "nostrud", "exercitation", "ullamco", "laboris", "nisi", "ut", "aliquip", "ex", "ea", "commodo", "consequat.", "Duis", "aute", "irure", "dolor", "in", "reprehenderit", "in", "voluptate", "velit", "esse", "cillum", "dolore", "eu", "fugiat", "nulla", "pariatur.", "Excepteur", "sint", "occaecat", "cupidatat", "non", "proident,", "sunt", "in", "culpa", "qui", "officia", "deserunt", "mollit", "anim", "id", "est", "laborum." };
    }
}
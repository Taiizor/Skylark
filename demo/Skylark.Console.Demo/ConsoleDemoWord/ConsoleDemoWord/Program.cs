using Skylark.Standard.Extension.Word;
using Skylark.Struct.Word;
using System.Text;

namespace ConsoleDemoWord
{
    internal class Program
    {
        private const string Word = "World Earth Space";
        private const string List = "Skylark - A lightweight .NET library with multipurpose tools.";

        static void Main()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            WordDataStruct Data = WordExtension.Data(List);
            Console.WriteLine($"Word Count: {Data.Word}");
            Console.WriteLine($"Char Count: {Data.Char}");

            Console.WriteLine();

            WordCombineStruct Combine = WordExtension.Combine(Word);
            Console.WriteLine($"Combine Count: {Combine.Count}");
            Console.WriteLine($"Combine Result: {Combine.Result}");

            Console.ReadKey();
        }
    }
}
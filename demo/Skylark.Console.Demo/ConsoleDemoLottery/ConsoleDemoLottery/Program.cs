using Skylark.Standard.Extension.Lottery;
using Skylark.Struct.Lottery;
using System.Text;

namespace ConsoleDemoLottery
{
    internal class Program
    {
        private const string List = "Taiizor\nReaLTaiizor\nSkylark\nConforyon\nStarterkit\nReaLTaiizor\nTaiizor";

        static void Main()
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            LotteryDrawStruct Draw = LotteryExtension.Draw(List, 2, 3, false);
            foreach (string Winner in Draw.Winners)
            {
                Console.WriteLine($"Winner {Draw.Winners.IndexOf(Winner) + 1}: {Winner}");
            }
            foreach (string Reserve in Draw.Reserve)
            {
                Console.WriteLine($"Reserve {Draw.Reserve.IndexOf(Reserve) + 1}: {Reserve}");
            }

            Console.WriteLine();

            string Suffle1 = LotteryExtension.Suffle(List, false);
            Console.WriteLine(Suffle1);

            Console.WriteLine("=====^^=====");

            string Suffle2 = LotteryExtension.Suffle(List, true);
            Console.WriteLine(Suffle2);

            Console.ReadKey();
        }
    }
}
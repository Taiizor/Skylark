using Skylark.Enum;
using Skylark.Extension;

namespace ConsoleDemoText
{
    internal class Program
    {
        static void Main()
        {
            string Text = TextExtension.Text(11);
            Console.WriteLine(Text);

            Console.WriteLine();

            string List = TextExtension.List(5, '*', 12);
            Console.WriteLine(List);

            Console.WriteLine();

            string Paragraph = TextExtension.Paragraph(3, 111);
            Console.WriteLine(Paragraph);

            Console.WriteLine();

            string Cut = TextExtension.Cut(Text, 50, "...", TextType.Mid);
            Console.WriteLine(Cut);

            Console.ReadKey();
        }
    }
}
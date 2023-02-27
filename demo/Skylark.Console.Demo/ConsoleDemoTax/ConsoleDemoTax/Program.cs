using Skylark.Enum;
using Skylark.Standard.Extension.Tax;
using Skylark.Standard.Helper;
using Skylark.Struct.Tax;

namespace ConsoleDemoTax
{
    internal class Program
    {
        static void Main()
        {
            TaxCalcStruct Calc1 = TaxExtension.Calc("100.00", "1.00", TaxType.Amount, true);
            Console.WriteLine($"Price: {Calc1.Price} {Currency.SymbolName}");
            Console.WriteLine($"Vat Price: {Calc1.VatPrice} {Currency.SymbolName}");
            Console.WriteLine($"Total Price: {Calc1.TotalPrice} {Currency.SymbolName}");

            Console.WriteLine();

            TaxCalcStruct Calc2 = TaxExtension.Calc("100,00", "1,00", TaxType.Internal, true);
            Console.WriteLine($"Price: {Calc2.Price} {Currency.SymbolName}");
            Console.WriteLine($"Vat Price: {Calc2.VatPrice} {Currency.SymbolName}");
            Console.WriteLine($"Total Price: {Calc2.TotalPrice} {Currency.SymbolName}");

            Console.WriteLine();

            TaxCalcStruct Calc3 = TaxExtension.Calc("100.00", "25.00", TaxType.External, true);
            Console.WriteLine($"Price: {Calc3.Price} {Currency.SymbolName}");
            Console.WriteLine($"Vat Price: {Calc3.VatPrice} {Currency.SymbolName}");
            Console.WriteLine($"Total Price: {Calc3.TotalPrice} {Currency.SymbolName}");

            Console.ReadKey();
        }
    }
}
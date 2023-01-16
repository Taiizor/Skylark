using System.Globalization;
using E = Skylark.Exception;
using ETT = Skylark.Enum.TaxType;
using HC = Skylark.Helper.Converter;
using HL = Skylark.Helper.Length;
using HTH = Skylark.Helper.TaxHelper;
using MTM = Skylark.Manage.TaxManage;
using STCS = Skylark.Struct.TaxCalcStruct;

namespace Skylark.Extension
{
    /// <summary>
    /// 
    /// </summary>
    public class TaxExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Percent"></param>
        /// <param name="Type"></param>
        /// <param name="Decimal"></param>
        /// <returns></returns>
        public static STCS Calc(string Value = MTM.Value, string Percent = MTM.Percent, string Type = MTM.DefaultType, bool Decimal = MTM.Decimal)
        {
            return Calc(Value, Percent, HC.Convert(Type, MTM.TaxType), Decimal);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Percent"></param>
        /// <param name="Type"></param>
        /// <param name="Decimal"></param>
        /// <returns></returns>
        public static STCS Calc(string Value = MTM.Value, string Percent = MTM.Percent, ETT Type = MTM.TaxType, bool Decimal = MTM.Decimal)
        {
            try
            {
                Value = HTH.GetConvert(HL.Parameter(Value, MTM.Value));
                Percent = HTH.GetConvert(HL.Parameter(Percent, MTM.Percent));

                string Price;
                string VatPrice;
                string TotalPrice;

                double Tax = Convert.ToDouble(Value, CultureInfo.CurrentCulture);
                double Vat = Convert.ToDouble(Percent, CultureInfo.CurrentCulture);

                switch (Type)
                {
                    case ETT.Internal:
                        Price = $"{Tax / (1 + (Vat / 100d))}";
                        VatPrice = $"{Tax - (Tax / (1 + (Vat / 100d)))}";
                        TotalPrice = $"{Tax}";
                        break;
                    case ETT.External:
                        Price = $"{Tax}";
                        VatPrice = $"{Tax * Vat / 100d}";
                        TotalPrice = $"{Tax + (Tax * Vat / 100d)}";
                        break;
                    default:
                        Price = $"{Tax * 100d / Vat}";
                        VatPrice = $"{Tax}";
                        TotalPrice = $"{Tax + (Tax * 100d / Vat)}";
                        break;
                }

                return new()
                {
                    Price = $"{HTH.GetPlaces(Math.Round(decimal.Parse(Price), 2), Decimal)}",
                    VatPrice = $"{HTH.GetPlaces(Math.Round(decimal.Parse(VatPrice), 2), Decimal)}",
                    TotalPrice = $"{HTH.GetPlaces(Math.Round(decimal.Parse(TotalPrice), 2), Decimal)}",
                };
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }
    }
}
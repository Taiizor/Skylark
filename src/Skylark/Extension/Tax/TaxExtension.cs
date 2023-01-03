using System.Globalization;
using ETT = Skylark.Enum.TaxType;
using HL = Skylark.Helper.Length;
using HTH = Skylark.Helper.TaxHelper;
using MTM = Skylark.Manage.TaxManage;
using STCS = Skylark.Struct.TaxCalcStruct;

namespace Skylark.Extension
{
    public class TaxExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Percent"></param>
        /// <param name="Type"></param>
        /// <param name="Separator"></param>
        /// <returns></returns>
        public static STCS Calc(string Value = MTM.Value, string Percent = MTM.Percent, ETT Type = MTM.TaxType, bool Separator = MTM.Separator)
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
                    Price = $"{HTH.GetPlaces(Math.Round(decimal.Parse(Price), 2), Separator)}",
                    VatPrice = $"{HTH.GetPlaces(Math.Round(decimal.Parse(VatPrice), 2), Separator)}",
                    TotalPrice = $"{HTH.GetPlaces(Math.Round(decimal.Parse(TotalPrice), 2), Separator)}",
                };
            }
            catch
            {
                return new()
                {
                    Price = HTH.GetConvert(MTM.Value),
                    VatPrice = HTH.GetConvert(MTM.Percent),
                    TotalPrice = HTH.GetConvert(MTM.Total)
                };
            }
        }
    }
}
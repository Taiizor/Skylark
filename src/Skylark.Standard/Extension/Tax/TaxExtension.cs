using System.Globalization;
using SE = Skylark.Exception;
using SETT = Skylark.Enum.TaxType;
using SHC = Skylark.Helper.Converter;
using SHL = Skylark.Helper.Length;
using SSHTTH = Skylark.Standard.Helper.Tax.TaxHelper;
using SSMTTM = Skylark.Standard.Manage.Tax.TaxManage;
using SSTTCS = Skylark.Struct.Tax.TaxCalcStruct;

namespace Skylark.Standard.Extension.Tax
{
    /// <summary>
    /// 
    /// </summary>
    public static class TaxExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Percent"></param>
        /// <param name="Type"></param>
        /// <param name="Decimal"></param>
        /// <returns></returns>
        public static STTCS Calc(string Value = MTTM.Value, string Percent = MTTM.Percent, string Type = MTTM.DefaultType, bool Decimal = MTTM.Decimal)
        {
            return Calc(Value, Percent, HC.Convert(Type, MTTM.TaxType), Decimal);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Percent"></param>
        /// <param name="Type"></param>
        /// <param name="Decimal"></param>
        /// <returns></returns>
        public static async Task<STTCS> CalcAsync(string Value = MTTM.Value, string Percent = MTTM.Percent, string Type = MTTM.DefaultType, bool Decimal = MTTM.Decimal)
        {
            return await Task.Run(() => Calc(Value, Percent, Type, Decimal));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Percent"></param>
        /// <param name="Type"></param>
        /// <param name="Decimal"></param>
        /// <returns></returns>
        public static STTCS Calc(string Value = MTTM.Value, string Percent = MTTM.Percent, ETT Type = MTTM.TaxType, bool Decimal = MTTM.Decimal)
        {
            try
            {
                Value = HTTH.GetConvert(HL.Parameter(Value, MTTM.Value));
                Percent = HTTH.GetConvert(HL.Parameter(Percent, MTTM.Percent));

                string Price, VatPrice, TotalPrice;

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
                    Price = $"{HTTH.GetPlaces(Math.Round(decimal.Parse(Price), 2), Decimal)}",
                    VatPrice = $"{HTTH.GetPlaces(Math.Round(decimal.Parse(VatPrice), 2), Decimal)}",
                    TotalPrice = $"{HTTH.GetPlaces(Math.Round(decimal.Parse(TotalPrice), 2), Decimal)}",
                };
            }
            catch (SE Ex)
            {
                throw new SE(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Percent"></param>
        /// <param name="Type"></param>
        /// <param name="Decimal"></param>
        /// <returns></returns>
        public static async Task<STTCS> CalcAsync(string Value = MTTM.Value, string Percent = MTTM.Percent, ETT Type = MTTM.TaxType, bool Decimal = MTTM.Decimal)
        {
            return await Task.Run(() => Calc(Value, Percent, Type, Decimal));
        }
    }
}
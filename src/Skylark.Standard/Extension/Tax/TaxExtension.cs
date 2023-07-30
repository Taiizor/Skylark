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
        public static SSTTCS Calc(string Value = SSMTTM.Value, string Percent = SSMTTM.Percent, string Type = SSMTTM.DefaultType, bool Decimal = SSMTTM.Decimal)
        {
            return Calc(Value, Percent, SHC.Convert(Type, SSMTTM.TaxType), Decimal);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Percent"></param>
        /// <param name="Type"></param>
        /// <param name="Decimal"></param>
        /// <returns></returns>
        public static async Task<SSTTCS> CalcAsync(string Value = SSMTTM.Value, string Percent = SSMTTM.Percent, string Type = SSMTTM.DefaultType, bool Decimal = SSMTTM.Decimal)
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
        /// <exception cref="SE"></exception>
        public static SSTTCS Calc(string Value = SSMTTM.Value, string Percent = SSMTTM.Percent, SETT Type = SSMTTM.TaxType, bool Decimal = SSMTTM.Decimal)
        {
            try
            {
                Value = SSHTTH.GetConvert(SHL.Parameter(Value, SSMTTM.Value));
                Percent = SSHTTH.GetConvert(SHL.Parameter(Percent, SSMTTM.Percent));

                string Price, VatPrice, TotalPrice;

                double Tax = Convert.ToDouble(Value, CultureInfo.CurrentCulture);
                double Vat = Convert.ToDouble(Percent, CultureInfo.CurrentCulture);

                switch (Type)
                {
                    case SETT.Internal:
                        Price = $"{Tax / (1 + (Vat / 100d))}";
                        VatPrice = $"{Tax - (Tax / (1 + (Vat / 100d)))}";
                        TotalPrice = $"{Tax}";
                        break;
                    case SETT.External:
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
                    Price = $"{SSHTTH.GetPlaces(Math.Round(decimal.Parse(Price), 2), Decimal)}",
                    VatPrice = $"{SSHTTH.GetPlaces(Math.Round(decimal.Parse(VatPrice), 2), Decimal)}",
                    TotalPrice = $"{SSHTTH.GetPlaces(Math.Round(decimal.Parse(TotalPrice), 2), Decimal)}",
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
        public static async Task<SSTTCS> CalcAsync(string Value = SSMTTM.Value, string Percent = SSMTTM.Percent, SETT Type = SSMTTM.TaxType, bool Decimal = SSMTTM.Decimal)
        {
            return await Task.Run(() => Calc(Value, Percent, Type, Decimal));
        }
    }
}
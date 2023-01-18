using E = Skylark.Exception;
using HL = Skylark.Helper.Length;
using HC = Skylark.Helper.Converter;
using HSH = Skylark.Helper.StorageHelper;
using MSM = Skylark.Manage.StorageManage;
using EST = Skylark.Enum.StorageType;

namespace Skylark.Extension
{
    /// <summary>
    /// 
    /// </summary>
    public class StorageExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Input"></param>
        /// <param name="Output"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal Convert(decimal Value = MSM.Value, EST Input = MSM.InputType, EST Output = MSM.OutputType)
        {
            try
            {
                switch (Input)
                {
                    case EST.Bit:
                        return Value / HSH.GetValue(Input, Output);
                    case EST.Byte:
                        break;
                    case EST.Kilobyte:
                        break;
                    case EST.Megabyte:
                        break;
                    case EST.Gigabyte:
                        break;
                    case EST.Terabyte:
                        break;
                    case EST.Petabyte:
                        break;
                    case EST.Exabyte:
                        break;
                    case EST.Zetabyte:
                        break;
                    case EST.Yottabyte:
                        break;
                    default:
                        throw new E(MSM.Error);
                }

                return Value;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }
    }
}
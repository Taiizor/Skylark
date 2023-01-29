using E = Skylark.Exception;
using ECNT = Skylark.Enum.ClearNumericType;
using EST = Skylark.Enum.StorageType;
using HC = Skylark.Helper.Converter;
using HN = Skylark.Helper.Numeric;
using HSH = Skylark.Helper.StorageHelper;
using MSM = Skylark.Manage.StorageManage;
using SSS = Skylark.Struct.StorageStruct;

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
        public static double Convert(double Value = MSM.Value, string Input = MSM.DefaultInput, string Output = MSM.DefaultOutput)
        {
            return Convert(Value, HC.Convert(Input, MSM.InputType), HC.Convert(Output, MSM.OutputType));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Input"></param>
        /// <param name="Output"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static double Convert(double Value = MSM.Value, EST Input = MSM.InputType, EST Output = MSM.OutputType)
        {
            try
            {
                return Input switch
                {
                    EST.Bit or EST.Byte or EST.Kilobyte or EST.Megabyte or EST.Gigabyte or EST.Terabyte or EST.Petabyte or EST.Exabyte or EST.Zetabyte or EST.Yottabyte => HSH.GetCalc(Value, HSH.GetValue(Input, Output)),
                    _ => throw new E(MSM.Error),
                };
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Input"></param>
        /// <returns></returns>
        public static SSS AutoConvert(double Value = MSM.Value, string Input = MSM.DefaultInput)
        {
            return AutoConvert(Value, HC.Convert(Input, MSM.InputType));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Input"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static SSS AutoConvert(double Value = MSM.Value, EST Input = MSM.InputType)
        {
            try
            {
                return Input switch
                {
                    EST.Bit or EST.Byte or EST.Kilobyte or EST.Megabyte or EST.Gigabyte or EST.Terabyte or EST.Petabyte or EST.Exabyte or EST.Zetabyte or EST.Yottabyte => AutoDetect(Value, Input),
                    _ => throw new E(MSM.Error),
                };
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Input"></param>
        /// <returns></returns>
        private static SSS AutoDetect(double Value, EST Input)
        {
            try
            {
                SSS Result = MSM.Result;

                EST Active = Input;

                for (int i = (int)EST.Bit; i <= (int)EST.Yottabyte; i++)
                {
                    if (HN.Numeral(Convert(Value, Input, (EST)i), false, false, Clear: ECNT.Decimal) == "0")
                    {
                        Active = (EST)i - 1;
                        break;
                    }
                    else
                    {
                        if ((EST)i == EST.Yottabyte)
                        {
                            Active = (EST)i;
                        }
                    }
                }

                Result.Type = Active;
                Result.Text = $"{Active}";
                Result.Value = Convert(Value, Input, Active);

                return Result;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }
    }
}
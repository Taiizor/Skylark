using E = Skylark.Exception;
using ECNT = Skylark.Enum.ClearNumericType;
using EMST = Skylark.Enum.ModeStorageType;
using EST = Skylark.Enum.StorageType;
using HC = Skylark.Helper.Converter;
using HN = Skylark.Helper.Numeric;
using HSH = Skylark.Helper.Storage.StorageHelper;
using MSM = Skylark.Manage.Storage.StorageManage;
using SSS = Skylark.Struct.Storage.StorageStruct;

namespace Skylark.Extension.Storage
{
    /// <summary>
    /// 
    /// </summary>
    public static class StorageExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Input"></param>
        /// <param name="Output"></param>
        /// <param name="Mode"></param>
        /// <returns></returns>
        public static double Convert(double Value = MSM.Value, string Input = MSM.DefaultInput, string Output = MSM.DefaultOutput, string Mode = MSM.DefaultMode)
        {
            return Convert(Value, HC.Convert(Input, MSM.InputType), HC.Convert(Output, MSM.OutputType), HC.Convert(Mode, MSM.ModeType));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Input"></param>
        /// <param name="Output"></param>
        /// <param name="Mode"></param>
        /// <returns></returns>
        public static Task<double> ConvertAsync(double Value = MSM.Value, string Input = MSM.DefaultInput, string Output = MSM.DefaultOutput, string Mode = MSM.DefaultMode)
        {
            return Task.Run(() => Convert(Value, Input, Output, Mode));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Input"></param>
        /// <param name="Output"></param>
        /// <param name="Mode"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static double Convert(double Value = MSM.Value, EST Input = MSM.InputType, EST Output = MSM.OutputType, EMST Mode = MSM.ModeType)
        {
            try
            {
                return Input switch
                {
                    EST.Bit or EST.Byte or EST.Kilobyte or EST.Megabyte or EST.Gigabyte or EST.Terabyte or EST.Petabyte or EST.Exabyte or EST.Zetabyte or EST.Yottabyte => HSH.GetCalc(Value, HSH.GetValue(Input, Output, Mode)),
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
        /// <param name="Output"></param>
        /// <param name="Mode"></param>
        /// <returns></returns>
        public static Task<double> ConvertAsync(double Value = MSM.Value, EST Input = MSM.InputType, EST Output = MSM.OutputType, EMST Mode = MSM.ModeType)
        {
            return Task.Run(() => Convert(Value, Input, Output, Mode));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Input"></param>
        /// <param name="Mode"></param>
        /// <returns></returns>
        public static SSS AutoConvert(double Value = MSM.Value, string Input = MSM.DefaultInput, string Mode = MSM.DefaultMode)
        {
            return AutoConvert(Value, HC.Convert(Input, MSM.InputType), HC.Convert(Mode, MSM.ModeType));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Input"></param>
        /// <param name="Mode"></param>
        /// <returns></returns>
        public static Task<SSS> AutoConvertAsync(double Value = MSM.Value, string Input = MSM.DefaultInput, string Mode = MSM.DefaultMode)
        {
            return Task.Run(() => AutoConvert(Value, Input, Mode));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Input"></param>
        /// <param name="Mode"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static SSS AutoConvert(double Value = MSM.Value, EST Input = MSM.InputType, EMST Mode = MSM.ModeType)
        {
            try
            {
                return Input switch
                {
                    EST.Bit or EST.Byte or EST.Kilobyte or EST.Megabyte or EST.Gigabyte or EST.Terabyte or EST.Petabyte or EST.Exabyte or EST.Zetabyte or EST.Yottabyte => AutoDetect(Value, Input, Mode),
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
        /// <param name="Mode"></param>
        /// <returns></returns>
        public static Task<SSS> AutoConvertAsync(double Value = MSM.Value, EST Input = MSM.InputType, EMST Mode = MSM.ModeType)
        {
            return Task.Run(() => AutoConvert(Value, Input, Mode));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Input"></param>
        /// <param name="Mode"></param>
        /// <returns></returns>
        private static SSS AutoDetect(double Value, EST Input, EMST Mode)
        {
            SSS Result = MSM.Result;

            EST Active = Input;

            for (int i = (int)EST.Bit; i <= (int)EST.Yottabyte; i++)
            {
                if (HN.Numeral(Convert(Value, Input, (EST)i, Mode), false, false, Clear: ECNT.Decimal) == "0")
                {
                    if ((EST)i - 1 <= 0)
                    {
                        Active = (EST)i;
                    }
                    else
                    {
                        Active = (EST)i - 1;
                    }
                    break;
                }
                else
                {
                    if ((EST)i >= EST.Yottabyte)
                    {
                        Active = (EST)i;
                    }
                }
            }

            Result.Type = Active;
            Result.Text = $"{Active}";
            Result.Value = Convert(Value, Input, Active, Mode);

            return Result;
        }
    }
}
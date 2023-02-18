using E = Skylark.Exception;
using ECNT = Skylark.Enum.ClearNumericType;
using EMST = Skylark.Enum.ModeStorageType;
using EST = Skylark.Enum.StorageType;
using HC = Skylark.Helper.Converter;
using HN = Skylark.Helper.Numeric;
using HSSH = Skylark.Helper.Storage.StorageHelper;
using MSSM = Skylark.Manage.Storage.StorageManage;
using SSSS = Skylark.Struct.Storage.StorageStruct;

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
        public static double Convert(double Value = MSSM.Value, string Input = MSSM.DefaultInput, string Output = MSSM.DefaultOutput, string Mode = MSSM.DefaultMode)
        {
            return Convert(Value, HC.Convert(Input, MSSM.InputType), HC.Convert(Output, MSSM.OutputType), HC.Convert(Mode, MSSM.ModeType));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Input"></param>
        /// <param name="Output"></param>
        /// <param name="Mode"></param>
        /// <returns></returns>
        public static Task<double> ConvertAsync(double Value = MSSM.Value, string Input = MSSM.DefaultInput, string Output = MSSM.DefaultOutput, string Mode = MSSM.DefaultMode)
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
        public static double Convert(double Value = MSSM.Value, EST Input = MSSM.InputType, EST Output = MSSM.OutputType, EMST Mode = MSSM.ModeType)
        {
            try
            {
                return Input switch
                {
                    EST.Bit or EST.Byte or EST.Kilobyte or EST.Megabyte or EST.Gigabyte or EST.Terabyte or EST.Petabyte or EST.Exabyte or EST.Zetabyte or EST.Yottabyte => HSSH.GetCalc(Value, HSSH.GetValue(Input, Output, Mode)),
                    _ => throw new E(MSSM.Error),
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
        public static Task<double> ConvertAsync(double Value = MSSM.Value, EST Input = MSSM.InputType, EST Output = MSSM.OutputType, EMST Mode = MSSM.ModeType)
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
        public static SSSS AutoConvert(double Value = MSSM.Value, string Input = MSSM.DefaultInput, string Mode = MSSM.DefaultMode)
        {
            return AutoConvert(Value, HC.Convert(Input, MSSM.InputType), HC.Convert(Mode, MSSM.ModeType));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Input"></param>
        /// <param name="Mode"></param>
        /// <returns></returns>
        public static Task<SSSS> AutoConvertAsync(double Value = MSSM.Value, string Input = MSSM.DefaultInput, string Mode = MSSM.DefaultMode)
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
        public static SSSS AutoConvert(double Value = MSSM.Value, EST Input = MSSM.InputType, EMST Mode = MSSM.ModeType)
        {
            try
            {
                return Input switch
                {
                    EST.Bit or EST.Byte or EST.Kilobyte or EST.Megabyte or EST.Gigabyte or EST.Terabyte or EST.Petabyte or EST.Exabyte or EST.Zetabyte or EST.Yottabyte => AutoDetect(Value, Input, Mode),
                    _ => throw new E(MSSM.Error),
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
        public static Task<SSSS> AutoConvertAsync(double Value = MSSM.Value, EST Input = MSSM.InputType, EMST Mode = MSSM.ModeType)
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
        private static SSSS AutoDetect(double Value, EST Input, EMST Mode)
        {
            SSSS Result = MSSM.Result;

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
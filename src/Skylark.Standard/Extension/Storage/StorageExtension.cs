using SE = Skylark.Exception;
using SECNT = Skylark.Enum.ClearNumericType;
using SEMST = Skylark.Enum.ModeStorageType;
using SEST = Skylark.Enum.StorageType;
using SHC = Skylark.Helper.Converter;
using SHN = Skylark.Helper.Numeric;
using SSHSSH = Skylark.Standard.Helper.Storage.StorageHelper;
using SSMSSM = Skylark.Standard.Manage.Storage.StorageManage;
using SSSSS = Skylark.Struct.Storage.StorageStruct;

namespace Skylark.Standard.Extension.Storage
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
        public static async Task<double> ConvertAsync(double Value = MSSM.Value, string Input = MSSM.DefaultInput, string Output = MSSM.DefaultOutput, string Mode = MSSM.DefaultMode)
        {
            return await Task.Run(() => Convert(Value, Input, Output, Mode));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Input"></param>
        /// <param name="Output"></param>
        /// <param name="Mode"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static double Convert(double Value = MSSM.Value, EST Input = MSSM.InputType, EST Output = MSSM.OutputType, EMST Mode = MSSM.ModeType)
        {
            try
            {
                return Input switch
                {
                    EST.Bit or EST.Byte or EST.Kilobyte or EST.Megabyte or EST.Gigabyte or EST.Terabyte or EST.Petabyte or EST.Exabyte or EST.Zetabyte or EST.Yottabyte => HSSH.GetCalc(Value, HSSH.GetValue(Input, Output, Mode)),
                    _ => throw new SE(MSSM.Error),
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
        /// <param name="Input"></param>
        /// <param name="Output"></param>
        /// <param name="Mode"></param>
        /// <returns></returns>
        public static async Task<double> ConvertAsync(double Value = MSSM.Value, EST Input = MSSM.InputType, EST Output = MSSM.OutputType, EMST Mode = MSSM.ModeType)
        {
            return await Task.Run(() => Convert(Value, Input, Output, Mode));
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
        public static async Task<SSSS> AutoConvertAsync(double Value = MSSM.Value, string Input = MSSM.DefaultInput, string Mode = MSSM.DefaultMode)
        {
            return await Task.Run(() => AutoConvert(Value, Input, Mode));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Input"></param>
        /// <param name="Mode"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static SSSS AutoConvert(double Value = MSSM.Value, EST Input = MSSM.InputType, EMST Mode = MSSM.ModeType)
        {
            try
            {
                return Input switch
                {
                    EST.Bit or EST.Byte or EST.Kilobyte or EST.Megabyte or EST.Gigabyte or EST.Terabyte or EST.Petabyte or EST.Exabyte or EST.Zetabyte or EST.Yottabyte => AutoDetect(Value, Input, Mode),
                    _ => throw new SE(MSSM.Error),
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
        /// <param name="Input"></param>
        /// <param name="Mode"></param>
        /// <returns></returns>
        public static async Task<SSSS> AutoConvertAsync(double Value = MSSM.Value, EST Input = MSSM.InputType, EMST Mode = MSSM.ModeType)
        {
            return await Task.Run(() => AutoConvert(Value, Input, Mode));
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
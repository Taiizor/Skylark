using SE = Skylark.Exception;
using SECNT = Skylark.Enum.ClearNumericType;
using SEMST = Skylark.Enum.ModeStorageType;
using SESST = Skylark.Enum.ShortStorageType;
using SELST = Skylark.Enum.LongStorageType;
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
        public static double Convert(double Value = SSMSSM.Value, string Input = SSMSSM.DefaultInput, string Output = SSMSSM.DefaultOutput, string Mode = SSMSSM.DefaultMode)
        {
            return Convert(Value, SHC.Convert(Input, SSMSSM.InputType), SHC.Convert(Output, SSMSSM.OutputType), SHC.Convert(Mode, SSMSSM.ModeType));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Input"></param>
        /// <param name="Output"></param>
        /// <param name="Mode"></param>
        /// <returns></returns>
        public static async Task<double> ConvertAsync(double Value = SSMSSM.Value, string Input = SSMSSM.DefaultInput, string Output = SSMSSM.DefaultOutput, string Mode = SSMSSM.DefaultMode)
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
        public static double Convert(double Value = SSMSSM.Value, SEST Input = SSMSSM.InputType, SEST Output = SSMSSM.OutputType, SEMST Mode = SSMSSM.ModeType)
        {
            try
            {
                return Input switch
                {
                    SEST.Bit or SEST.Byte or SEST.Kilobyte or SEST.Megabyte or SEST.Gigabyte or SEST.Terabyte or SEST.Petabyte or SEST.Exabyte or SEST.Zetabyte or SEST.Yottabyte => SSHSSH.GetCalc(Value, SSHSSH.GetValue(Input, Output, Mode)),
                    _ => throw new SE(SSMSSM.Error),
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
        public static async Task<double> ConvertAsync(double Value = SSMSSM.Value, SEST Input = SSMSSM.InputType, SEST Output = SSMSSM.OutputType, SEMST Mode = SSMSSM.ModeType)
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
        public static SSSSS AutoConvert(double Value = SSMSSM.Value, string Input = SSMSSM.DefaultInput, string Mode = SSMSSM.DefaultMode)
        {
            return AutoConvert(Value, SHC.Convert(Input, SSMSSM.InputType), SHC.Convert(Mode, SSMSSM.ModeType));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Input"></param>
        /// <param name="Mode"></param>
        /// <returns></returns>
        public static async Task<SSSSS> AutoConvertAsync(double Value = SSMSSM.Value, string Input = SSMSSM.DefaultInput, string Mode = SSMSSM.DefaultMode)
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
        public static SSSSS AutoConvert(double Value = SSMSSM.Value, SEST Input = SSMSSM.InputType, SEMST Mode = SSMSSM.ModeType)
        {
            try
            {
                return Input switch
                {
                    SEST.Bit or SEST.Byte or SEST.Kilobyte or SEST.Megabyte or SEST.Gigabyte or SEST.Terabyte or SEST.Petabyte or SEST.Exabyte or SEST.Zetabyte or SEST.Yottabyte => AutoDetect(Value, Input, Mode),
                    _ => throw new SE(SSMSSM.Error),
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
        public static async Task<SSSSS> AutoConvertAsync(double Value = SSMSSM.Value, SEST Input = SSMSSM.InputType, SEMST Mode = SSMSSM.ModeType)
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
        private static SSSSS AutoDetect(double Value, SEST Input, SEMST Mode)
        {
            SSSSS Result = SSMSSM.Result;

            SEST Active = Input;

            if (Value > 0)
            {
                for (int i = (int)SEST.Bit; i <= (int)SEST.Yottabyte; i++)
                {
                    if (SHN.Numeral(Convert(Value, Input, (SEST)i, Mode), false, false, Clear: SECNT.Decimal) == "0")
                    {
                        if ((SEST)i - 1 <= 0)
                        {
                            Active = (SEST)i;
                        }
                        else
                        {
                            Active = (SEST)i - 1;
                        }

                        break;
                    }
                    else
                    {
                        if ((SEST)i >= SEST.Yottabyte)
                        {
                            Active = (SEST)i;
                        }
                    }
                }
            }

            Result.Type = Active;
            Result.Text = $"{Active}";
            Result.Long = (SELST)Active;
            Result.Short = (SESST)Active;
            Result.Value = Convert(Value, Input, Active, Mode);
            Result.More = SHN.Numeral(Result.Value, false, false, 0, Clear: SECNT.Decimal) != "1";

            return Result;
        }
    }
}
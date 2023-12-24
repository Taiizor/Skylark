using SE = Skylark.Exception;
using SECNT = Skylark.Enum.ClearNumericType;
using SESTT = Skylark.Enum.ShortTimeType;
using SETT = Skylark.Enum.TimeType;
using SHC = Skylark.Helper.Converter;
using SHN = Skylark.Helper.Numeric;
using SSHTTH = Skylark.Standard.Helper.Time.TimeHelper;
using SSMTTM = Skylark.Standard.Manage.Time.TimeManage;
using SSTTS = Skylark.Struct.Time.TimeStruct;

namespace Skylark.Standard.Extension.Time
{
    /// <summary>
    /// 
    /// </summary>
    public static class TimeExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Input"></param>
        /// <param name="Output"></param>
        /// <returns></returns>
        public static double Convert(double Value = SSMTTM.Value, string Input = SSMTTM.DefaultInput, string Output = SSMTTM.DefaultOutput)
        {
            return Convert(Value, SHC.Convert(Input, SSMTTM.InputType), SHC.Convert(Output, SSMTTM.OutputType));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Input"></param>
        /// <param name="Output"></param>
        /// <returns></returns>
        public static async Task<double> ConvertAsync(double Value = SSMTTM.Value, string Input = SSMTTM.DefaultInput, string Output = SSMTTM.DefaultOutput)
        {
            return await Task.Run(() => Convert(Value, Input, Output));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Input"></param>
        /// <param name="Output"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static double Convert(double Value = SSMTTM.Value, SETT Input = SSMTTM.InputType, SETT Output = SSMTTM.OutputType)
        {
            try
            {
                return Input switch
                {
                    SETT.Attosecond or SETT.Femtosecond or SETT.Picosecond or SETT.Nanosecond or SETT.Microsecond or SETT.Millisecond or SETT.Second or SETT.Minute or SETT.Hour or SETT.Day or SETT.Week or SETT.Year or SETT.Decade or SETT.Century or SETT.Millennium => SSHTTH.GetCalc(Value, SSHTTH.GetValue(Input, Output)),
                    _ => throw new SE(SSMTTM.Error),
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
        /// <returns></returns>
        public static async Task<double> ConvertAsync(double Value = SSMTTM.Value, SETT Input = SSMTTM.InputType, SETT Output = SSMTTM.OutputType)
        {
            return await Task.Run(() => Convert(Value, Input, Output));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Input"></param>
        /// <returns></returns>
        public static SSTTS AutoConvert(double Value = SSMTTM.Value, string Input = SSMTTM.DefaultInput)
        {
            return AutoConvert(Value, SHC.Convert(Input, SSMTTM.InputType));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Input"></param>
        /// <returns></returns>
        public static async Task<SSTTS> AutoConvertAsync(double Value = SSMTTM.Value, string Input = SSMTTM.DefaultInput)
        {
            return await Task.Run(() => AutoConvert(Value, Input));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Input"></param>
        /// <returns></returns>
        /// <exception cref="SE"></exception>
        public static SSTTS AutoConvert(double Value = SSMTTM.Value, SETT Input = SSMTTM.InputType)
        {
            try
            {
                return Input switch
                {
                    SETT.Attosecond or SETT.Femtosecond or SETT.Picosecond or SETT.Nanosecond or SETT.Microsecond or SETT.Millisecond or SETT.Second or SETT.Minute or SETT.Hour or SETT.Day or SETT.Week or SETT.Year or SETT.Decade or SETT.Century or SETT.Millennium => AutoDetect(Value, Input),
                    _ => throw new SE(SSMTTM.Error),
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
        /// <returns></returns>
        public static async Task<SSTTS> AutoConvertAsync(double Value = SSMTTM.Value, SETT Input = SSMTTM.InputType)
        {
            return await Task.Run(() => AutoConvert(Value, Input));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Input"></param>
        /// <returns></returns>
        private static SSTTS AutoDetect(double Value, SETT Input)
        {
            SSTTS Result = SSMTTM.Result;

            SETT Active = Input;

            if (Value > 0)
            {
                for (int i = (int)SETT.Attosecond; i <= (int)SETT.Millennium; i++)
                {
                    if (SHN.Numeral(Convert(Value, Input, (SETT)i), false, false, Clear: SECNT.Decimal) == "0")
                    {
                        if ((SETT)i - 1 <= 0)
                        {
                            Active = (SETT)i;
                        }
                        else
                        {
                            Active = (SETT)i - 1;
                        }

                        break;
                    }
                    else
                    {
                        if ((SETT)i >= SETT.Millennium)
                        {
                            Active = (SETT)i;
                        }
                    }
                }
            }

            Result.Type = Active;
            Result.Text = $"{Active}";
            Result.Short = (SESTT)Active;
            Result.Value = Convert(Value, Input, Active);

            return Result;
        }
    }
}
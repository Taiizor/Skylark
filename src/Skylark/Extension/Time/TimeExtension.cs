using E = Skylark.Exception;
using ECNT = Skylark.Enum.ClearNumericType;
using ETT = Skylark.Enum.TimeType;
using HC = Skylark.Helper.Converter;
using HN = Skylark.Helper.Numeric;
using HTTH = Skylark.Helper.Time.TimeHelper;
using MTTM = Skylark.Manage.Time.TimeManage;
using STTS = Skylark.Struct.Time.TimeStruct;

namespace Skylark.Extension.Time
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
        public static double Convert(double Value = MTTM.Value, string Input = MTTM.DefaultInput, string Output = MTTM.DefaultOutput)
        {
            return Convert(Value, HC.Convert(Input, MTTM.InputType), HC.Convert(Output, MTTM.OutputType));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Input"></param>
        /// <param name="Output"></param>
        /// <returns></returns>
        public static Task<double> ConvertAsync(double Value = MTTM.Value, string Input = MTTM.DefaultInput, string Output = MTTM.DefaultOutput)
        {
            return Task.Run(() => Convert(Value, Input, Output));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Input"></param>
        /// <param name="Output"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static double Convert(double Value = MTTM.Value, ETT Input = MTTM.InputType, ETT Output = MTTM.OutputType)
        {
            try
            {
                return Input switch
                {
                    ETT.Attosecond or ETT.Femtosecond or ETT.Picosecond or ETT.Nanosecond or ETT.Microsecond or ETT.Millisecond or ETT.Second or ETT.Minute or ETT.Hour or ETT.Day or ETT.Week or ETT.Year or ETT.Decade or ETT.Century or ETT.Millennium => HTTH.GetCalc(Value, HTTH.GetValue(Input, Output)),
                    _ => throw new E(MTTM.Error),
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
        /// <returns></returns>
        public static Task<double> ConvertAsync(double Value = MTTM.Value, ETT Input = MTTM.InputType, ETT Output = MTTM.OutputType)
        {
            return Task.Run(() => Convert(Value, Input, Output));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Input"></param>
        /// <returns></returns>
        public static STTS AutoConvert(double Value = MTTM.Value, string Input = MTTM.DefaultInput)
        {
            return AutoConvert(Value, HC.Convert(Input, MTTM.InputType));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Input"></param>
        /// <returns></returns>
        public static Task<STTS> AutoConvertAsync(double Value = MTTM.Value, string Input = MTTM.DefaultInput)
        {
            return Task.Run(() => AutoConvert(Value, Input));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Input"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static STTS AutoConvert(double Value = MTTM.Value, ETT Input = MTTM.InputType)
        {
            try
            {
                return Input switch
                {
                    ETT.Attosecond or ETT.Femtosecond or ETT.Picosecond or ETT.Nanosecond or ETT.Microsecond or ETT.Millisecond or ETT.Second or ETT.Minute or ETT.Hour or ETT.Day or ETT.Week or ETT.Year or ETT.Decade or ETT.Century or ETT.Millennium => AutoDetect(Value, Input),
                    _ => throw new E(MTTM.Error),
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
        public static Task<STTS> AutoConvertAsync(double Value = MTTM.Value, ETT Input = MTTM.InputType)
        {
            return Task.Run(() => AutoConvert(Value, Input));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Input"></param>
        /// <returns></returns>
        private static STTS AutoDetect(double Value, ETT Input)
        {
            STTS Result = MTTM.Result;

            ETT Active = Input;

            for (int i = (int)ETT.Attosecond; i <= (int)ETT.Millennium; i++)
            {
                if (HN.Numeral(Convert(Value, Input, (ETT)i), false, false, Clear: ECNT.Decimal) == "0")
                {
                    if ((ETT)i - 1 <= 0)
                    {
                        Active = (ETT)i;
                    }
                    else
                    {
                        Active = (ETT)i - 1;
                    }
                    break;
                }
                else
                {
                    if ((ETT)i >= ETT.Millennium)
                    {
                        Active = (ETT)i;
                    }
                }
            }

            Result.Type = Active;
            Result.Text = $"{Active}";
            Result.Value = Convert(Value, Input, Active);

            return Result;
        }
    }
}
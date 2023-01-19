﻿using E = Skylark.Exception;
using ETT = Skylark.Enum.TimeType;
using HC = Skylark.Helper.Converter;
using HN = Skylark.Helper.Numeric;
using HTH = Skylark.Helper.TimeHelper;
using MTM = Skylark.Manage.TimeManage;
using STS = Skylark.Struct.TimeStruct;

namespace Skylark.Extension
{
    /// <summary>
    /// 
    /// </summary>
    public class TimeExtension
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Input"></param>
        /// <param name="Output"></param>
        /// <returns></returns>
        public static decimal Convert(decimal Value = MTM.Value, string Input = MTM.DefaultInput, string Output = MTM.DefaultOutput)
        {
            return Convert(Value, HC.Convert(Input, MTM.InputType), HC.Convert(Output, MTM.OutputType));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Input"></param>
        /// <param name="Output"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static decimal Convert(decimal Value = MTM.Value, ETT Input = MTM.InputType, ETT Output = MTM.OutputType)
        {
            try
            {
                return Input switch
                {
                    ETT.Attosecond or ETT.Femtosecond or ETT.Picosecond or ETT.Nanosecond or ETT.Microsecond or ETT.Millisecond or ETT.Centisecond or ETT.Second or ETT.Minute or ETT.Hour or ETT.Day or ETT.Week or ETT.Year or ETT.Decade or ETT.Century or ETT.Millennium => HTH.GetCalc(Value, HTH.GetValue(Input, Output)),
                    _ => throw new E(MTM.Error),
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
        public static STS AutoConvert(decimal Value = MTM.Value, string Input = MTM.DefaultInput)
        {
            return AutoConvert(Value, HC.Convert(Input, MTM.InputType));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="Input"></param>
        /// <returns></returns>
        /// <exception cref="E"></exception>
        public static STS AutoConvert(decimal Value = MTM.Value, ETT Input = MTM.InputType)
        {
            try
            {
                return Input switch
                {
                    ETT.Attosecond or ETT.Femtosecond or ETT.Picosecond or ETT.Nanosecond or ETT.Microsecond or ETT.Millisecond or ETT.Centisecond or ETT.Second or ETT.Minute or ETT.Hour or ETT.Day or ETT.Week or ETT.Year or ETT.Decade or ETT.Century or ETT.Millennium => AutoDetect(Value, Input),
                    _ => throw new E(MTM.Error),
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
        private static STS AutoDetect(decimal Value, ETT Input)
        {
            STS Result = MTM.Result;

            ETT Active = Input;

            for (int i = (int)Input; i <= (int)ETT.Millennium; i++)
            {
                if (HN.Numeral(Convert(Value, Input, (ETT)i), false, false) == "0")
                {
                    Active = (ETT)i - 1;
                    break;
                }
                else
                {
                    if ((ETT)i == ETT.Millennium)
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
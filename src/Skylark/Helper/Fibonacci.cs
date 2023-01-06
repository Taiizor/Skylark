﻿using E = Skylark.Exception;
using HL = Skylark.Helper.Length;

namespace Skylark.Helper
{
    /// <summary>
    /// 
    /// </summary>
    public class Fibonacci
    {
        /// <summary>
        /// 
        /// </summary>
        public static int[] Int(int Count = 2)
        {
            try
            {
                Count = HL.Number(Count, 2, 47);

                int[] Result = new int[Count];

                Result[0] = 0;
                Result[1] = 1;

                for (int i = 2; i < Count; i++)
                {
                    Result[i] = Result[i - 2] + Result[i - 1];
                }

                return Result;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Count"></param>
        /// <returns></returns>
        public static long[] Long(int Count = 2)
        {
            try
            {
                Count = HL.Number(Count, 2, 93);

                long[] Result = new long[Count];

                Result[0] = 0;
                Result[1] = 1;

                for (int i = 2; i < Count; i++)
                {
                    Result[i] = Result[i - 2] + Result[i - 1];
                }

                return Result;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Count"></param>
        /// <returns></returns>
        public static decimal[] Decimal(int Count = 2)
        {
            try
            {
                Count = HL.Number(Count, 2, 140);

                decimal[] Result = new decimal[Count];

                Result[0] = 0;
                Result[1] = 1;

                for (int i = 2; i < Count; i++)
                {
                    Result[i] = Result[i - 2] + Result[i - 1];
                }

                return Result;
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }
    }
}
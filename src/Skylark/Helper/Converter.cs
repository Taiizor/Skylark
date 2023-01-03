using EAPT = Skylark.Enum.AlphabeticPasswordType;
using ECWT = Skylark.Enum.CompressWebType;
using ESPT = Skylark.Enum.SpecialPasswordType;
using ETT = Skylark.Enum.TaxType;
using MPM = Skylark.Manage.PasswordManage;
using MTM = Skylark.Manage.TaxManage;
using MWM = Skylark.Manage.WebManage;

namespace Skylark.Helper
{
    internal class Converter
    {
        public static ETT Convert(string Type, ETT Back = MTM.TaxType)
        {
            foreach (ETT Types in (ETT[])System.Enum.GetValues(typeof(ETT)))
            {
                if (Check(Type, Types))
                {
                    return Types;
                }
            }

            return Back;
        }

        public static ESPT Convert(string Type, ESPT Back = MPM.SpecialType)
        {
            foreach (ESPT Types in (ESPT[])System.Enum.GetValues(typeof(ESPT)))
            {
                if (Check(Type, Types))
                {
                    return Types;
                }
            }

            return Back;
        }

        public static ECWT Convert(string Type, ECWT Back = MWM.CompressType)
        {
            foreach (ECWT Types in (ECWT[])System.Enum.GetValues(typeof(ECWT)))
            {
                if (Check(Type, Types))
                {
                    return Types;
                }
            }

            return Back;
        }

        public static EAPT Convert(string Type, EAPT Back = MPM.AlphabeticType)
        {
            foreach (EAPT Types in (EAPT[])System.Enum.GetValues(typeof(EAPT)))
            {
                if (Check(Type, Types))
                {
                    return Types;
                }
            }

            return Back;
        }

        private static bool Check(object Text, object Type)
        {
            return Check($"{Text}", $"{Type}");
        }

        private static bool Check(string Text, string Type)
        {
            if (Text == Type || Text.ToUpper() == Type || Text.ToUpperInvariant() == Type || Text == Type.ToLower() || Text == Type.ToLowerInvariant())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
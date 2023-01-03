using EAPT = Skylark.Enum.AlphabeticPasswordType;
using ESPT = Skylark.Enum.SpecialPasswordType;
using MPM = Skylark.Manage.PasswordManage;

namespace Skylark.Helper
{
    internal class PasswordHelper
    {
        public static string GetSpecial(ESPT Mode)
        {
            return Mode switch
            {
                ESPT.None => string.Empty,
                ESPT.Number => MPM.Number,
                ESPT.Symbol => MPM.Symbol,
                _ => MPM.Number + MPM.Symbol,
            };
        }

        public static string GetAlphabetic(EAPT Mode)
        {
            return Mode switch
            {
                EAPT.Big => MPM.Big,
                EAPT.None => string.Empty,
                EAPT.Small => MPM.Small,
                _ => MPM.Big + MPM.Small,
            };
        }
    }
}
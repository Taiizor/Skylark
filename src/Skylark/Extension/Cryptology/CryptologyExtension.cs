using System.Drawing;
using E = Skylark.Exception;
using HCH = Skylark.Helper.CryptologyHelper;
using HL = Skylark.Helper.Length;
using MCM = Skylark.Manage.CryptologyManage;

namespace Skylark.Extension
{
    /// <summary>
    /// 
    /// </summary>
    public class CryptologyExtension
    {
        
        public static string ToBase64(string Text = MCM.Text)
        {
            try
            {
                return $"hex()";
            }
            catch (E Ex)
            {
                throw new E(Ex.Message, Ex);
            }
        }
    }
}
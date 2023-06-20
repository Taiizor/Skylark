using System;
using System.Windows.Forms;

namespace Skylark.Wing.Helper
{
    /// <summary>
    /// 
    /// </summary>
    public static class FormInterop
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Form"></param>
        /// <returns></returns>
        public static IntPtr Owner(Form Form)
        {
            return Form.Owner.Handle;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Form"></param>
        /// <returns></returns>
        public static IntPtr Handle(Form Form)
        {
            return Form.Handle;
        }
    }
}
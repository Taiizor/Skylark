using System.Windows.Forms;

namespace Skylark.UI
{
    internal class Memory
    {
        public static void Copy(string Text, bool Copy = true)
        {
            try
            {
                Clipboard.SetDataObject(Text, Copy);
            }
            catch
            {
                return;
            }
        }

        public static string Paste(bool Clear = false, string Back = "Empty!", string Error = "Error!")
        {
            try
            {
                IDataObject IData = Clipboard.GetDataObject();

                if (Clear)
                {
                    Clipboard.Clear();
                }

                if (IData.GetDataPresent(DataFormats.Text))
                {
                    return IData.GetData(DataFormats.Text) as string;
                }
                else
                {
                    return Back;
                }
            }
            catch
            {
                return Error;
            }
        }
    }
}
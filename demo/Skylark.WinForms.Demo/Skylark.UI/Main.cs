using Skylark.Enum;
using Skylark.Extension;
using Skylark.Helper;
using Skylark.Struct;
using System;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TextCopy;

namespace Skylark.UI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private StorageType Selection1, Selection2;
        private TimeType Selection18, Selection19;
        private string Selection6, Selection12, Selection13, Selection14, Selection17, Selection26;
        private bool Selection3, Selection4, Selection5, Selection8, Selection9, Selection10, Selection11, Selection15, Selection16, Selection20, Selection21, Selection22, Selection23, Selection24;

        private void ComboBox()
        {
            try
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    Selection1 = StorageType.Bit;
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    Selection1 = StorageType.Byte;
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    Selection1 = StorageType.Kilobyte;
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    Selection1 = StorageType.Megabyte;
                }
                else if (comboBox1.SelectedIndex == 4)
                {
                    Selection1 = StorageType.Gigabyte;
                }
                else if (comboBox1.SelectedIndex == 5)
                {
                    Selection1 = StorageType.Terabyte;
                }
                else if (comboBox1.SelectedIndex == 6)
                {
                    Selection1 = StorageType.Petabyte;
                }
                else if (comboBox1.SelectedIndex == 7)
                {
                    Selection1 = StorageType.Exabyte;
                }
                else if (comboBox1.SelectedIndex == 8)
                {
                    Selection1 = StorageType.Zetabyte;
                }
                else if (comboBox1.SelectedIndex == 9)
                {
                    Selection1 = StorageType.Yottabyte;
                }

                if (comboBox2.SelectedIndex == 0)
                {
                    Selection2 = StorageType.Bit;
                }
                else if (comboBox2.SelectedIndex == 1)
                {
                    Selection2 = StorageType.Byte;
                }
                else if (comboBox2.SelectedIndex == 2)
                {
                    Selection2 = StorageType.Kilobyte;
                }
                else if (comboBox2.SelectedIndex == 3)
                {
                    Selection2 = StorageType.Megabyte;
                }
                else if (comboBox2.SelectedIndex == 4)
                {
                    Selection2 = StorageType.Gigabyte;
                }
                else if (comboBox2.SelectedIndex == 5)
                {
                    Selection2 = StorageType.Terabyte;
                }
                else if (comboBox2.SelectedIndex == 6)
                {
                    Selection2 = StorageType.Petabyte;
                }
                else if (comboBox2.SelectedIndex == 7)
                {
                    Selection2 = StorageType.Exabyte;
                }
                else if (comboBox2.SelectedIndex == 8)
                {
                    Selection2 = StorageType.Zetabyte;
                }
                else if (comboBox2.SelectedIndex == 9)
                {
                    Selection2 = StorageType.Yottabyte;
                }

                if (comboBox3.SelectedIndex == 0)
                {
                    Selection3 = true;
                }
                else
                {
                    Selection3 = false;
                }

                if (comboBox4.SelectedIndex == 0)
                {
                    Selection4 = true;
                }
                else
                {
                    Selection4 = false;
                }

                if (comboBox5.SelectedIndex == 0)
                {
                    Selection5 = true;
                }
                else
                {
                    Selection5 = false;
                }

                if (comboBox6.SelectedIndex == 0)
                {
                    Selection6 = "K=>C";
                }
                else if (comboBox6.SelectedIndex == 1)
                {
                    Selection6 = "K=>F";
                }
                else if (comboBox6.SelectedIndex == 2)
                {
                    Selection6 = "C=>K";
                }
                else if (comboBox6.SelectedIndex == 3)
                {
                    Selection6 = "C=>F";
                }
                else if (comboBox6.SelectedIndex == 4)
                {
                    Selection6 = "F=>K";
                }
                else
                {
                    Selection6 = "F=>C";
                }

                if (comboBox8.SelectedIndex == 0)
                {
                    Selection8 = true;
                }
                else
                {
                    Selection8 = false;
                }

                if (comboBox9.SelectedIndex == 0)
                {
                    Selection9 = true;
                }
                else
                {
                    Selection9 = false;
                }

                if (comboBox10.SelectedIndex == 0)
                {
                    Selection10 = true;
                }
                else
                {
                    Selection10 = false;
                }

                if (comboBox11.SelectedIndex == 0)
                {
                    Selection11 = true;
                }
                else
                {
                    Selection11 = false;
                }

                if (comboBox12.SelectedIndex == 0)
                {
                    Selection12 = "Text=>Base";
                }
                else if (comboBox12.SelectedIndex == 1)
                {
                    Selection12 = "Text=>MD5";
                }
                else if (comboBox12.SelectedIndex == 2)
                {
                    Selection12 = "Text=>SHA1";
                }
                else if (comboBox12.SelectedIndex == 3)
                {
                    Selection12 = "Text=>SHA256";
                }
                else if (comboBox12.SelectedIndex == 4)
                {
                    Selection12 = "Text=>SHA384";
                }
                else if (comboBox12.SelectedIndex == 5)
                {
                    Selection12 = "Text=>SHA512";
                }
                else if (comboBox12.SelectedIndex == 6)
                {
                    Selection12 = "Base=>Text";
                }
                else if (comboBox12.SelectedIndex == 7)
                {
                    Selection12 = "Aes=>Encrypt";
                }
                else
                {
                    Selection12 = "Aes=>Decrypt";
                }

                if (comboBox17.SelectedIndex == 0)
                {
                    Selection13 = "INCH";
                }
                else if (comboBox17.SelectedIndex == 1)
                {
                    Selection13 = "CM";
                }
                else
                {
                    Selection13 = "PX";
                }

                if (comboBox13.SelectedIndex == 0)
                {
                    Selection14 = "INCH";
                }
                else if (comboBox13.SelectedIndex == 1)
                {
                    Selection14 = "CM";
                }
                else
                {
                    Selection14 = "PX";
                }

                if (comboBox16.SelectedIndex == 0)
                {
                    Selection15 = true;
                }
                else
                {
                    Selection15 = false;
                }

                if (comboBox15.SelectedIndex == 0)
                {
                    Selection16 = true;
                }
                else
                {
                    Selection16 = false;
                }

                if (comboBox14.SelectedIndex == 0)
                {
                    Selection17 = "FILE=>MD5";
                }
                else if (comboBox14.SelectedIndex == 1)
                {
                    Selection17 = "FILE=>SHA1";
                }
                else if (comboBox14.SelectedIndex == 2)
                {
                    Selection17 = "FILE=>SHA256";
                }
                else if (comboBox14.SelectedIndex == 3)
                {
                    Selection17 = "FILE=>SHA384";
                }
                else if (comboBox14.SelectedIndex == 4)
                {
                    Selection17 = "FILE=>SHA512";
                }

                if (comboBox22.SelectedIndex == 0)
                {
                    Selection18 = TimeType.Attosecond;
                }
                else if (comboBox22.SelectedIndex == 1)
                {
                    Selection18 = TimeType.Femtosecond;
                }
                else if (comboBox22.SelectedIndex == 2)
                {
                    Selection18 = TimeType.Picosecond;
                }
                else if (comboBox22.SelectedIndex == 3)
                {
                    Selection18 = TimeType.Nanosecond;
                }
                else if (comboBox22.SelectedIndex == 4)
                {
                    Selection18 = TimeType.Microsecond;
                }
                else if (comboBox22.SelectedIndex == 5)
                {
                    Selection18 = TimeType.Millisecond;
                }
                else if (comboBox22.SelectedIndex == 6)
                {
                    Selection18 = TimeType.Second;
                }
                else if (comboBox22.SelectedIndex == 7)
                {
                    Selection18 = TimeType.Minute;
                }
                else if (comboBox22.SelectedIndex == 8)
                {
                    Selection18 = TimeType.Hour;
                }
                else if (comboBox22.SelectedIndex == 9)
                {
                    Selection18 = TimeType.Day;
                }
                else if (comboBox22.SelectedIndex == 10)
                {
                    Selection18 = TimeType.Week;
                }
                else if (comboBox22.SelectedIndex == 11)
                {
                    Selection18 = TimeType.Year;
                }
                else if (comboBox22.SelectedIndex == 12)
                {
                    Selection18 = TimeType.Decade;
                }
                else if (comboBox22.SelectedIndex == 13)
                {
                    Selection18 = TimeType.Century;
                }
                else if (comboBox22.SelectedIndex == 14)
                {
                    Selection18 = TimeType.Millennium;
                }

                if (comboBox19.SelectedIndex == 0)
                {
                    Selection19 = TimeType.Attosecond;
                }
                else if (comboBox19.SelectedIndex == 1)
                {
                    Selection19 = TimeType.Femtosecond;
                }
                else if (comboBox19.SelectedIndex == 2)
                {
                    Selection19 = TimeType.Picosecond;
                }
                else if (comboBox19.SelectedIndex == 3)
                {
                    Selection19 = TimeType.Nanosecond;
                }
                else if (comboBox19.SelectedIndex == 4)
                {
                    Selection19 = TimeType.Microsecond;
                }
                else if (comboBox19.SelectedIndex == 5)
                {
                    Selection19 = TimeType.Millisecond;
                }
                else if (comboBox19.SelectedIndex == 6)
                {
                    Selection19 = TimeType.Second;
                }
                else if (comboBox19.SelectedIndex == 7)
                {
                    Selection19 = TimeType.Minute;
                }
                else if (comboBox19.SelectedIndex == 8)
                {
                    Selection19 = TimeType.Hour;
                }
                else if (comboBox19.SelectedIndex == 9)
                {
                    Selection19 = TimeType.Day;
                }
                else if (comboBox19.SelectedIndex == 10)
                {
                    Selection19 = TimeType.Week;
                }
                else if (comboBox19.SelectedIndex == 11)
                {
                    Selection19 = TimeType.Year;
                }
                else if (comboBox19.SelectedIndex == 12)
                {
                    Selection19 = TimeType.Decade;
                }
                else if (comboBox19.SelectedIndex == 13)
                {
                    Selection19 = TimeType.Century;
                }
                else if (comboBox19.SelectedIndex == 14)
                {
                    Selection19 = TimeType.Millennium;
                }

                if (comboBox21.SelectedIndex == 0)
                {
                    Selection20 = true;
                }
                else
                {
                    Selection20 = false;
                }

                if (comboBox20.SelectedIndex == 0)
                {
                    Selection21 = true;
                }
                else
                {
                    Selection21 = false;
                }

                if (comboBox18.SelectedIndex == 0)
                {
                    Selection22 = true;
                }
                else
                {
                    Selection22 = false;
                }

                if (comboBox23.SelectedIndex == 0)
                {
                    Selection23 = true;
                }
                else
                {
                    Selection23 = false;
                }

                if (comboBox24.SelectedIndex == 0)
                {
                    Selection24 = true;
                }
                else
                {
                    Selection24 = false;
                }

                if (comboBox26.SelectedIndex == 0)
                {
                    Selection26 = "MPH => KPH";
                }
                else
                {
                    Selection26 = "KPH => MPH";
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void TextBox_Tuş(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox1.Text, "[^0-9]"))
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox5.Text, "[^0-9]"))
            {
                textBox5.Text = textBox5.Text.Remove(textBox5.Text.Length - 1);
            }
        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox6.Text, "[^0-9]"))
            {
                textBox6.Text = textBox6.Text.Remove(textBox6.Text.Length - 1);
            }
        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox7.Text, "[^0-9]"))
            {
                textBox7.Text = textBox7.Text.Remove(textBox7.Text.Length - 1);
            }
        }

        private void TextBox9_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox9.Text, "[^0-9]"))
            {
                textBox9.Text = textBox9.Text.Remove(textBox9.Text.Length - 1);
            }
        }

        private void TextBox10_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox10.Text, "[^0-9]"))
            {
                textBox10.Text = textBox10.Text.Remove(textBox10.Text.Length - 1);
            }
        }

        private void TextBox15_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(textBox15.Text, "[^0-9]"))
            {
                textBox15.Text = textBox15.Text.Remove(textBox15.Text.Length - 1);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                ComboBox();
                if (string.IsNullOrEmpty(textBox7.Text))
                {
                    textBox7.Text = "1";
                }

                textBox4.Text = Numeric.Numeral(StorageExtension.Convert(Convert.ToDouble(textBox3.Text), Selection1, Selection2), Selection3, Selection4, Convert.ToInt32(textBox7.Text), '0', true);
                button4.Cursor = Cursors.Hand;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                ComboBox();
                if (string.IsNullOrEmpty(textBox7.Text))
                {
                    textBox7.Text = "1";
                }

                StorageStruct Result = StorageExtension.AutoConvert(Convert.ToDouble(textBox3.Text), Selection1);

                if (Selection5)
                {
                    textBox4.Text = Numeric.Numeral(Result.Value, Selection3, Selection4, Convert.ToInt32(textBox7.Text), '0', true) + " " + Result.Text;
                }
                else
                {
                    textBox4.Text = Numeric.Numeral(Result.Value, Selection3, Selection4, Convert.ToInt32(textBox7.Text), '0', true);
                }

                button4.Cursor = Cursors.Hand;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                int C1 = comboBox1.SelectedIndex;
                int C2 = comboBox2.SelectedIndex;
                comboBox1.SelectedIndex = C2;
                comboBox2.SelectedIndex = C1;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (button4.Cursor == Cursors.Hand)
                {
                    button4.Cursor = Cursors.No;
                    Board.Copy(textBox4);
                    ClipboardService.SetText(textBox4.Text);

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                ComboBox();
                if (string.IsNullOrEmpty(textBox5.Text))
                {
                    textBox5.Text = "1";
                }

                if (Selection6 == "K=>C")
                {
                    textBox2.Text = Numeric.Numeral(TemperatureExtension.KelvinToCelsius(Convert.ToDecimal(textBox1.Text)), Selection9, Selection8, Convert.ToInt32(textBox5.Text), '0', true);
                }
                else if (Selection6 == "K=>F")
                {
                    textBox2.Text = Numeric.Numeral(TemperatureExtension.KelvinToFahrenheit(Convert.ToDecimal(textBox1.Text)), Selection9, Selection8, Convert.ToInt32(textBox5.Text), '0', true);
                }
                else if (Selection6 == "C=>K")
                {
                    textBox2.Text = Numeric.Numeral(TemperatureExtension.CelsiusToKelvin(Convert.ToDecimal(textBox1.Text)), Selection9, Selection8, Convert.ToInt32(textBox5.Text), '0', true);
                }
                else if (Selection6 == "C=>F")
                {
                    textBox2.Text = Numeric.Numeral(TemperatureExtension.CelsiusToFahrenheit(Convert.ToDecimal(textBox1.Text)), Selection9, Selection8, Convert.ToInt32(textBox5.Text), '0', true);
                }
                else if (Selection6 == "F=>K")
                {
                    textBox2.Text = Numeric.Numeral(TemperatureExtension.FahrenheitToKelvin(Convert.ToDecimal(textBox1.Text)), Selection9, Selection8, Convert.ToInt32(textBox5.Text), '0', true);
                }
                else
                {
                    textBox2.Text = Numeric.Numeral(TemperatureExtension.FahrenheitToCelsius(Convert.ToDecimal(textBox1.Text)), Selection9, Selection8, Convert.ToInt32(textBox5.Text), '0', true);
                }

                button6.Cursor = Cursors.Hand;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (button6.Cursor == Cursors.Hand)
                {
                    button6.Cursor = Cursors.No;
                    ClipboardService.SetText(textBox2.Text);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox6.SelectedIndex == 0)
                {
                    comboBox6.SelectedIndex = 2;
                }
                else if (comboBox6.SelectedIndex == 1)
                {
                    comboBox6.SelectedIndex = 4;
                }
                else if (comboBox6.SelectedIndex == 2)
                {
                    comboBox6.SelectedIndex = 0;
                }
                else if (comboBox6.SelectedIndex == 3)
                {
                    comboBox6.SelectedIndex = 5;
                }
                else if (comboBox6.SelectedIndex == 4)
                {
                    comboBox6.SelectedIndex = 1;
                }
                else
                {
                    comboBox6.SelectedIndex = 3;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox10.SelectedIndex == 0)
                {
                    comboBox10.SelectedIndex = 1;
                }
                else
                {
                    comboBox10.SelectedIndex = 0;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            try
            {
                if (button9.Cursor == Cursors.Hand)
                {
                    button9.Cursor = Cursors.No;
                    ClipboardService.SetText(textBox8.Text);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Button26_Click(object sender, EventArgs e)
        {
            try
            {
                ComboBox();
                if (string.IsNullOrEmpty(textBox21.Text))
                {
                    textBox21.Text = "1";
                }

                TimeStruct Result = TimeExtension.AutoConvert(Convert.ToDouble(textBox23.Text), Selection18);

                if (Selection22)
                {
                    textBox22.Text = Numeric.Numeral(Result.Value, Selection20, Selection21, Convert.ToInt32(textBox21.Text), '0', true) + " " + Result.Text;
                }
                else
                {
                    textBox22.Text = Numeric.Numeral(Result.Value, Selection20, Selection21, Convert.ToInt32(textBox21.Text), '0', true);
                }

                button24.Cursor = Cursors.Hand;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Button28_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox26.SelectedIndex == 0)
                {
                    comboBox26.SelectedIndex = 1;
                }
                else
                {
                    comboBox26.SelectedIndex = 0;
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Button30_Click(object sender, EventArgs e)
        {
            try
            {
                ComboBox();
                if (string.IsNullOrEmpty(textBox24.Text))
                {
                    textBox24.Text = "1";
                }

                if (Selection26 == "MPH => KPH")
                {
                    textBox25.Text = Numeric.Numeral(SpeedExtension.MphToKph(Convert.ToDecimal(textBox26.Text)), Selection23, Selection24, Convert.ToInt32(textBox24.Text), '0', true);
                }
                else
                {
                    textBox25.Text = Numeric.Numeral(SpeedExtension.KphToMph(Convert.ToDecimal(textBox26.Text)), Selection23, Selection24, Convert.ToInt32(textBox24.Text), '0', true);
                }

                button29.Cursor = Cursors.Hand;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Button23_Click(object sender, EventArgs e)
        {
            try
            {
                if (button23.Cursor == Cursors.Hand)
                {
                    button23.Cursor = Cursors.No;
                    ClipboardService.SetText(textBox19.Text);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Button25_Click(object sender, EventArgs e)
        {
            try
            {
                int C1 = comboBox22.SelectedIndex;
                int C2 = comboBox19.SelectedIndex;
                comboBox22.SelectedIndex = C2;
                comboBox19.SelectedIndex = C1;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Button27_Click(object sender, EventArgs e)
        {
            try
            {
                ComboBox();
                if (string.IsNullOrEmpty(textBox21.Text))
                {
                    textBox21.Text = "1";
                }

                textBox22.Text = Numeric.Numeral(TimeExtension.Convert(Convert.ToDouble(textBox23.Text), Selection18, Selection19), Selection20, Selection21, Convert.ToInt32(textBox21.Text), '0', true);
                button24.Cursor = Cursors.Hand;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Button24_Click(object sender, EventArgs e)
        {
            try
            {
                if (button24.Cursor == Cursors.Hand)
                {
                    button24.Cursor = Cursors.No;
                    ClipboardService.SetText(textBox22.Text);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Button22_Click(object sender, EventArgs e)
        {
            try
            {
                ComboBox();
                if (Selection17 == "FILE=>MD5")
                {
                    textBox19.Text = HashExtension.FileToMD5(textBox20.Text, "", false);
                }
                else if (Selection17 == "FILE=>SHA1")
                {
                    textBox19.Text = HashExtension.FileToSHA1(textBox20.Text, "", false);
                }
                else if (Selection17 == "FILE=>SHA256")
                {
                    textBox19.Text = HashExtension.FileToSHA256(textBox20.Text, "", false);
                }
                else if (Selection17 == "FILE=>SHA384")
                {
                    textBox19.Text = HashExtension.FileToSHA384(textBox20.Text, "", false);
                }
                else if (Selection17 == "FILE=>SHA512")
                {
                    textBox19.Text = HashExtension.FileToSHA512(textBox20.Text, "", false);
                }

                button23.Cursor = Cursors.Hand;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            try
            {
                if (button10.Cursor == Cursors.Hand)
                {
                    button10.Cursor = Cursors.No;
                    ClipboardService.SetText(textBox6.Text + ", " + textBox9.Text + ", " + textBox10.Text);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void Button11_Click(object sender, EventArgs e)
        {
            try
            {
                ComboBox();
                if (Selection10)
                {
                    textBox8.Text = ColorExtension.RGBToHex(Convert.ToInt32(textBox6.Text), Convert.ToInt32(textBox9.Text), Convert.ToInt32(textBox10.Text), false, false).TrimStart("hex(".ToCharArray()).TrimEnd(")".ToCharArray());
                }
                else
                {
                    string Result = ColorExtension.HexToRGB(textBox8.Text);

                    string[] Values = Result.TrimStart("rgb(".ToCharArray()).TrimEnd(")".ToCharArray()).Split(',');

                    textBox6.Text = Values[0].Trim();
                    textBox9.Text = Values[1].Trim();
                    textBox10.Text = Values[2].Trim();
                }

                button9.Cursor = Cursors.Hand;
                button10.Cursor = Cursors.Hand;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            if (comboBox11.SelectedIndex == 0)
            {
                comboBox11.SelectedIndex = 1;
            }
            else
            {
                comboBox11.SelectedIndex = 0;
            }
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            try
            {
                if (button13.Cursor == Cursors.Hand)
                {
                    button13.Cursor = Cursors.No;
                    ClipboardService.SetText(textBox11.Text);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            try
            {
                if (button14.Cursor == Cursors.Hand)
                {
                    button14.Cursor = Cursors.No;
                    ClipboardService.SetText(textBox12.Text);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            try
            {
                ComboBox();
                if (Selection11)
                {
                    textBox12.Text = UnicodeExtension.TextToASCII(textBox11.Text, textBox18.Text.ToCharArray()[0]);
                }
                else
                {
                    textBox11.Text = UnicodeExtension.ASCIIToText(textBox12.Text, textBox18.Text.ToCharArray()[0]);
                }

                button13.Cursor = Cursors.Hand;
                button14.Cursor = Cursors.Hand;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            try
            {
                ComboBox();
                if (Selection12 == "Text=>Base")
                {
                    textBox13.Text = CryptologyExtension.TextToBase(textBox14.Text);
                }
                else if (Selection12 == "Text=>MD5")
                {
                    textBox13.Text = CryptologyExtension.TextToMD5(textBox14.Text, false);
                }
                else if (Selection12 == "Text=>SHA1")
                {
                    textBox13.Text = CryptologyExtension.TextToSHA1(textBox14.Text, false);
                }
                else if (Selection12 == "Text=>SHA256")
                {
                    textBox13.Text = CryptologyExtension.TextToSHA256(textBox14.Text, false);
                }
                else if (Selection12 == "Text=>SHA384")
                {
                    textBox13.Text = CryptologyExtension.TextToSHA384(textBox14.Text, false);
                }
                else if (Selection12 == "Text=>SHA512")
                {
                    textBox13.Text = CryptologyExtension.TextToSHA512(textBox14.Text, false);
                }
                else if (Selection12 == "Base=>Text")
                {
                    textBox13.Text = CryptologyExtension.BaseToText(textBox14.Text);
                }
                else if (Selection12 == "Aes=>Encrypt")
                {
                    textBox13.Text = CryptologyExtension.TextToAes(textBox14.Text, textBox27.Text, textBox28.Text, (CipherMode)comboBox27.SelectedIndex + 1);
                }
                else if (Selection12 == "Aes=>Decrypt")
                {
                    textBox13.Text = CryptologyExtension.AesToText(textBox14.Text, textBox27.Text, textBox28.Text, (CipherMode)comboBox27.SelectedIndex + 1);
                }

                button17.Cursor = Cursors.Hand;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            if (button17.Cursor == Cursors.Hand)
            {
                button17.Cursor = Cursors.No;
                ClipboardService.SetText(textBox13.Text);
            }
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            if (button18.Cursor == Cursors.Hand)
            {
                button18.Cursor = Cursors.No;
                ClipboardService.SetText(textBox16.Text);
            }
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            if (comboBox12.SelectedIndex == 0)
            {
                comboBox12.SelectedIndex = 6;
            }
            else if (comboBox12.SelectedIndex == 6)
            {
                comboBox12.SelectedIndex = 0;
            }
            else if (comboBox12.SelectedIndex == 7)
            {
                comboBox12.SelectedIndex = 8;
            }
            else if (comboBox12.SelectedIndex == 8)
            {
                comboBox12.SelectedIndex = 7;
            }
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            try
            {
                int C1 = comboBox17.SelectedIndex;
                int C2 = comboBox13.SelectedIndex;
                comboBox17.SelectedIndex = C2;
                comboBox13.SelectedIndex = C1;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            try
            {
                ComboBox();
                if (string.IsNullOrEmpty(textBox15.Text))
                {
                    textBox15.Text = "1";
                }

                if (Selection13 == "INCH")
                {
                    if (Selection14 == "CM")
                    {
                        textBox16.Text = Numeric.Numeral(TypographyExtension.InchToCentimeter(Convert.ToDecimal(textBox17.Text)), Selection15, Selection16, Convert.ToInt32(textBox15.Text), '0', true);
                    }
                    else if (Selection14 == "PX")
                    {
                        textBox16.Text = Numeric.Numeral(TypographyExtension.InchToPixel(Convert.ToDecimal(textBox17.Text)), Selection15, Selection16, Convert.ToInt32(textBox15.Text), '0', true);
                    }
                    else
                    {
                        textBox16.Text = "Error!";
                    }
                }
                else if (Selection13 == "CM")
                {
                    if (Selection14 == "INCH")
                    {
                        textBox16.Text = Numeric.Numeral(TypographyExtension.CentimeterToInch(Convert.ToDecimal(textBox17.Text)), Selection15, Selection16, Convert.ToInt32(textBox15.Text), '0', true);
                    }
                    else if (Selection14 == "PX")
                    {
                        textBox16.Text = Numeric.Numeral(TypographyExtension.CentimeterToPixel(Convert.ToDecimal(textBox17.Text)), Selection15, Selection16, Convert.ToInt32(textBox15.Text), '0', true);
                    }
                    else
                    {
                        textBox16.Text = "Error!";
                    }
                }
                else if (Selection13 == "PX")
                {
                    if (Selection14 == "INCH")
                    {
                        textBox16.Text = Numeric.Numeral(TypographyExtension.PixelToInch(Convert.ToDecimal(textBox17.Text)), Selection15, Selection16, Convert.ToInt32(textBox15.Text), '0', true);
                    }
                    else if (Selection14 == "CM")
                    {
                        textBox16.Text = Numeric.Numeral(TypographyExtension.PixelToCentimeter(Convert.ToDecimal(textBox17.Text)), Selection15, Selection16, Convert.ToInt32(textBox15.Text), '0', true);
                    }
                    else
                    {
                        textBox16.Text = "Error!";
                    }
                }
                button18.Cursor = Cursors.Hand;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                CenterToScreen();
                comboBox1.SelectedIndex = comboBox1.Items.IndexOf("GigaByte");
                comboBox2.SelectedIndex = comboBox2.Items.IndexOf("MegaByte");
                comboBox3.SelectedIndex = comboBox3.Items.IndexOf("Decimal On");
                comboBox4.SelectedIndex = comboBox4.Items.IndexOf("Fraction Off");
                comboBox5.SelectedIndex = comboBox5.Items.IndexOf("ADC Type On");
                comboBox6.SelectedIndex = comboBox6.Items.IndexOf("C - Celsius => F - Fahrenheit");
                comboBox8.SelectedIndex = comboBox8.Items.IndexOf("Fraction On");
                comboBox9.SelectedIndex = comboBox9.Items.IndexOf("Decimal On");
                comboBox10.SelectedIndex = comboBox10.Items.IndexOf("RGB => HEX");
                comboBox11.SelectedIndex = comboBox11.Items.IndexOf("Char => ASCII");
                comboBox12.SelectedIndex = comboBox12.Items.IndexOf("Text => Base");
                comboBox14.SelectedIndex = comboBox14.Items.IndexOf("FILE => MD5");
                comboBox13.SelectedIndex = comboBox13.Items.IndexOf("CM");
                comboBox17.SelectedIndex = comboBox17.Items.IndexOf("INCH");
                comboBox15.SelectedIndex = comboBox15.Items.IndexOf("Fraction On");
                comboBox16.SelectedIndex = comboBox16.Items.IndexOf("Decimal On");
                comboBox22.SelectedIndex = comboBox22.Items.IndexOf("Day");
                comboBox19.SelectedIndex = comboBox19.Items.IndexOf("Second");
                comboBox21.SelectedIndex = comboBox21.Items.IndexOf("Decimal On");
                comboBox20.SelectedIndex = comboBox20.Items.IndexOf("Fraction Off");
                comboBox18.SelectedIndex = comboBox18.Items.IndexOf("ATC Type On");
                comboBox23.SelectedIndex = comboBox23.Items.IndexOf("Decimal On");
                comboBox24.SelectedIndex = comboBox24.Items.IndexOf("Fraction Off");
                comboBox26.SelectedIndex = comboBox26.Items.IndexOf("Miles Per Hour => Kilometers Per Hour");
                comboBox27.SelectedIndex = comboBox27.Items.IndexOf("CBC");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
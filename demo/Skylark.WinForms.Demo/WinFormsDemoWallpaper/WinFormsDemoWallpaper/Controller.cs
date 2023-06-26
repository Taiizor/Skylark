using System.Linq;
using System.Windows.Forms;

namespace WinFormsDemoWallpaper
{
    public partial class Controller : Form
    {
        public bool State { get; set; } = true;

        public Controller()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, System.EventArgs e)
        {
            if (State)
            {
                State = false;

                for (int C = 0; C < Screen.AllScreens.Length; C++)
                {
                    Form Wall = new Main(C);
                    Wall.Show();
                }
            }
        }

        private void Button2_Click(object sender, System.EventArgs e)
        {
            if (!State)
            {
                State = true;

                foreach (Form Form in Application.OpenForms.Cast<Form>().ToList())
                {
                    if (Form.Text == "Skylark Wallpaper")
                    {
                        Form.Close();
                    }
                }
            }
        }
    }
}
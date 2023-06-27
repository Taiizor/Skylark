using Skylark.Wing.Utility;
using System;
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

        private void Button1_Click(object sender, EventArgs e)
        {
            if (State)
            {
                State = false;

                for (int C = 0; C < Screen.AllScreens.Length; C++)
                {
                    ScreenWall Wall = new(C);
                    Wall.Show();
                }
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (State)
            {
                State = false;

                ExpandWall Wall = new();
                Wall.Show();
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (State)
            {
                State = false;

                DuplicateWall Wall = new();
                Wall.Show();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (!State)
            {
                State = true;

                foreach (Form Form in Application.OpenForms.Cast<Form>().ToList())
                {
                    if (Form.Text != "Skylark Controller")
                    {
                        Form.Close();
                    }
                }

                Desktop.RefreshDesktop();
            }
        }
    }
}
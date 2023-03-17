using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Executor
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        #region UI Events

        private void Options_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        #region Options

        private void TopMostOption_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = TopMostOption.Checked;
            Program.exec.TopMost = TopMostOption.Checked;
            Program.exec.scriptHub.TopMost = TopMostOption.Checked;
        }

        #endregion

        #region Bottom Bar

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        #endregion

        #region UI Design

        private void Button_Leave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                button.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
                button.NotifyDefault(false);
            }
        }

        private void Button_Enter(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                button.FlatAppearance.BorderColor = Color.FromArgb(134, 134, 134);
                button.NotifyDefault(false);
            }
        }

        private void Button_Down(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                button.FlatAppearance.BorderColor = Color.FromArgb(22, 83, 145);
                button.NotifyDefault(false);
            }
        }

        private void Button_Up(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                button.FlatAppearance.BorderColor = Color.FromArgb(134, 134, 134);
                button.NotifyDefault(false);
            }
        }

        #endregion

        #region UI Drag

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        private void Movable(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion

        #endregion

    }
}

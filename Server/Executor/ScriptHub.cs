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
    public partial class ScriptHub : Form
    {
        public ScriptHub()
        {
            InitializeComponent();
        }

        
        #region UI Events

        private void ScriptHub_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        #region Script Hub

        private String script = "";

        private void Scripts_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                switch (Scripts.SelectedItem.ToString())
                {
                    
                    case "Dark Dex":
                        script = "local a=rawget(game:GetObjects('rbxassetid://3567096419'),0X1)if type(syn)=='table'and type(syn.protect_gui)=='function'then xpcall(syn.protect_gui,warn,a)end;a.Name,a.Parent='SynapseDex',game:GetService('CoreGui')function Load(b)if b:IsA('Script')then xpcall(coroutine.wrap(function()local c,d,e,f={},{},{script=b},loadstring(b.Source,'='..b:GetFullName())d.__index=function(g,h)if e[h]==nil then return getfenv()[h]else return e[h]end end;d.__newindex=function(g,h,i)if e[h]==nil then getfenv()[h]=i else e[h]=i end end;setmetatable(c,d)setfenv(f,c)return f()end),warn)end;for j,k in pairs(b:GetChildren())do xpcall(Load,warn,k)end end;xpcall(Load,warn,a)";
                        Description.Text = "A version of the popular Dex explorer with patches specifically for Synapse X.";
                        Showcase.Image = Properties.Resources.darkDex;
                        break;

                }
            }
            catch { }
        }

        private void Execute_Click(object sender, EventArgs e)
        {
            Program.exec.Loadstring(script);
        }

        #endregion

        #region Bottom Bar

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        #endregion

        #region Top Bar

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

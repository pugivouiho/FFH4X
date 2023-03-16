using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace Executor
{
    public partial class Executor : Form
    {
        public WebSocketServer ws = new WebSocketServer("ws://127.0.0.1:8080");

        public Executor()
        {
            InitializeComponent();
        }
        private void Executor_Load(object sender, EventArgs e)
        {
            ws.Start();
            ws.AddWebSocketService<WebSocket>("/");

            // set FastColoredTextBox custom syntax
            SyntaxHighlighter syntaxHighlighter = new SyntaxHighlighter(ScriptBox);
            syntaxHighlighter.StringStyle = new TextStyle(new SolidBrush(Color.FromArgb(149, 199, 149)), null, FontStyle.Regular);
            syntaxHighlighter.CommentStyle = new TextStyle(new SolidBrush(Color.FromArgb(153, 153, 153)), null, FontStyle.Regular);
            syntaxHighlighter.NumberStyle = new TextStyle(new SolidBrush(Color.FromArgb(249, 145, 87)), null, FontStyle.Regular);
            syntaxHighlighter.KeywordStyle = new TextStyle(new SolidBrush(Color.FromArgb(204,153,204)), null, FontStyle.Regular);
            syntaxHighlighter.FunctionsStyle = new TextStyle(new SolidBrush(Color.FromArgb(99, 148, 197)), null, FontStyle.Regular);
            ScriptBox.SyntaxHighlighter = syntaxHighlighter;
        }

        private void Loadstring(string script)
        {
            ws.WebSocketServices.Broadcast(Encoding.ASCII.GetBytes(script));
        }

        #region UI Events

        #region Bottom Bar

        private void Execute_Click(object sender, EventArgs e)
        {
            Loadstring(ScriptBox.Text);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            ScriptBox.Text = "";
        }

        private void Open_Click(object sender, EventArgs e)
        {
            ofd.InitialDirectory = $"{Application.StartupPath}\\scripts";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                String file = File.ReadAllText($"{ofd.FileName}");
                ScriptBox.Text = file;
            }
        }

        private void ExecuteFile_Click(object sender, EventArgs e)
        {
            ofd.InitialDirectory = $"{Application.StartupPath}\\scripts";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                String file = File.ReadAllText($"{ofd.FileName}");
                Loadstring(file);
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(sfd.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(ScriptBox.Text);
                    sw.Close();
                }
            }
        }

        #endregion

        #region Top Bar

        private void Logo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WebSocket X was developed by mov-ebx on GitHub.\nhttps://github.com/game-hax/Roblox-Websocket-Executor\n\nAdditional credits:\n    - sta/websocket-sharp: C# WebSocket library used\n    - PavelTorgashov/FastColoredTextBox - Script box", "WebSocket X", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            ws.Stop();
            Process.GetCurrentProcess().Kill();
        }

        #endregion

        #region UI Design

        private void Button_Leave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                button.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 60);
            }
        }

        private void Button_Enter(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                button.FlatAppearance.BorderColor = Color.FromArgb(134, 134, 134);
            }
        }

        private void Button_Down(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                button.FlatAppearance.BorderColor = Color.FromArgb(22, 83, 145);
            }
        }

        private void Button_Up(object sender, MouseEventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                button.FlatAppearance.BorderColor = Color.FromArgb(134, 134, 134);
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
    internal class WebSocket : WebSocketBehavior
    {
        protected override void OnOpen()
        {
            Console.WriteLine(base.ID + " has connected.");
        }

        protected override void OnMessage(MessageEventArgs e)
        {
            if (e.Data == "autoexec")
            {
                base.Sessions.Broadcast(Encoding.ASCII.GetBytes("print('WELCOME!!')"));
            }
            else if (e.Data.StartsWith("print "))
            {
                //MessageBox.Show(e.Data.Substring("print ".Length), "Print");
            }
            else if (e.Data.StartsWith("warn "))
            {
                //MessageBox.Show(e.Data.Substring("warn ".Length), "Warn");
            }
            else if (e.Data.StartsWith("error "))
            {
                //MessageBox.Show(e.Data.Substring("error ".Length), "Error");
            }
        }
    }
}

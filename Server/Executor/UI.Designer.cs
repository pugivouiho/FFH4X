
using System;

namespace Executor
{
    partial class Executor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Executor));
            this.Execute = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.ExecuteFile = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.ScriptHub = new System.Windows.Forms.Button();
            this.Options = new System.Windows.Forms.Button();
            this.Top = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.Minimize = new System.Windows.Forms.Button();
            this.Scripts = new System.Windows.Forms.ListBox();
            this.ScriptBox = new FastColoredTextBoxNS.FastColoredTextBox();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.sfd = new System.Windows.Forms.SaveFileDialog();
            this.updateScripts = new System.Windows.Forms.Timer(this.components);
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScriptBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Execute
            // 
            this.Execute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Execute.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Execute.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(102)))));
            this.Execute.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.Execute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Execute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Execute.ForeColor = System.Drawing.Color.White;
            this.Execute.Location = new System.Drawing.Point(5, 316);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(91, 33);
            this.Execute.TabIndex = 2;
            this.Execute.Text = "Execute";
            this.Execute.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Execute.UseVisualStyleBackColor = false;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            this.Execute.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_Down);
            this.Execute.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.Execute.MouseLeave += new System.EventHandler(this.Button_Leave);
            this.Execute.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_Up);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Clear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(102)))));
            this.Clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Clear.ForeColor = System.Drawing.Color.White;
            this.Clear.Location = new System.Drawing.Point(102, 316);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(91, 33);
            this.Clear.TabIndex = 4;
            this.Clear.Text = "Clear";
            this.Clear.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            this.Clear.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_Down);
            this.Clear.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.Clear.MouseLeave += new System.EventHandler(this.Button_Leave);
            this.Clear.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_Up);
            // 
            // Open
            // 
            this.Open.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Open.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Open.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(102)))));
            this.Open.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.Open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Open.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Open.ForeColor = System.Drawing.Color.White;
            this.Open.Location = new System.Drawing.Point(199, 316);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(91, 33);
            this.Open.TabIndex = 5;
            this.Open.Text = "Open File";
            this.Open.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Open.UseVisualStyleBackColor = false;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            this.Open.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_Down);
            this.Open.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.Open.MouseLeave += new System.EventHandler(this.Button_Leave);
            this.Open.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_Up);
            // 
            // ExecuteFile
            // 
            this.ExecuteFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ExecuteFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ExecuteFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(102)))));
            this.ExecuteFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.ExecuteFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExecuteFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ExecuteFile.ForeColor = System.Drawing.Color.White;
            this.ExecuteFile.Location = new System.Drawing.Point(296, 316);
            this.ExecuteFile.Name = "ExecuteFile";
            this.ExecuteFile.Size = new System.Drawing.Size(91, 33);
            this.ExecuteFile.TabIndex = 6;
            this.ExecuteFile.Text = "Execute File";
            this.ExecuteFile.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ExecuteFile.UseCompatibleTextRendering = true;
            this.ExecuteFile.UseVisualStyleBackColor = false;
            this.ExecuteFile.Click += new System.EventHandler(this.ExecuteFile_Click);
            this.ExecuteFile.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_Down);
            this.ExecuteFile.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.ExecuteFile.MouseLeave += new System.EventHandler(this.Button_Leave);
            this.ExecuteFile.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_Up);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(102)))));
            this.Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Save.ForeColor = System.Drawing.Color.White;
            this.Save.Location = new System.Drawing.Point(393, 316);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(91, 33);
            this.Save.TabIndex = 7;
            this.Save.Text = "Save File";
            this.Save.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            this.Save.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_Down);
            this.Save.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.Save.MouseLeave += new System.EventHandler(this.Button_Leave);
            this.Save.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_Up);
            // 
            // ScriptHub
            // 
            this.ScriptHub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ScriptHub.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ScriptHub.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(102)))));
            this.ScriptHub.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.ScriptHub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScriptHub.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ScriptHub.ForeColor = System.Drawing.Color.White;
            this.ScriptHub.Location = new System.Drawing.Point(706, 316);
            this.ScriptHub.Name = "ScriptHub";
            this.ScriptHub.Size = new System.Drawing.Size(91, 33);
            this.ScriptHub.TabIndex = 8;
            this.ScriptHub.Text = "Script Hub";
            this.ScriptHub.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.ScriptHub.UseVisualStyleBackColor = false;
            this.ScriptHub.Click += new System.EventHandler(this.ScriptHub_Click);
            this.ScriptHub.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_Down);
            this.ScriptHub.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.ScriptHub.MouseLeave += new System.EventHandler(this.Button_Leave);
            this.ScriptHub.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_Up);
            // 
            // Options
            // 
            this.Options.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Options.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Options.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(102)))));
            this.Options.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.Options.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Options.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Options.ForeColor = System.Drawing.Color.White;
            this.Options.Location = new System.Drawing.Point(490, 316);
            this.Options.Name = "Options";
            this.Options.Size = new System.Drawing.Size(91, 33);
            this.Options.TabIndex = 9;
            this.Options.Text = "Options";
            this.Options.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Options.UseVisualStyleBackColor = false;
            this.Options.Click += new System.EventHandler(this.Options_Click);
            this.Options.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_Down);
            this.Options.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.Options.MouseLeave += new System.EventHandler(this.Button_Leave);
            this.Options.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_Up);
            // 
            // Top
            // 
            this.Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Top.Controls.Add(this.Logo);
            this.Top.Controls.Add(this.Minimize);
            this.Top.Controls.Add(this.Exit);
            this.Top.Controls.Add(this.Title);
            this.Top.Location = new System.Drawing.Point(0, 0);
            this.Top.Name = "Top";
            this.Top.Size = new System.Drawing.Size(801, 30);
            this.Top.TabIndex = 10;
            this.Top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Movable);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Title.Location = new System.Drawing.Point(357, 6);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(127, 15);
            this.Title.TabIndex = 0;
            this.Title.Text = "Websocket X - v1.1.0b";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Movable);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(102)))));
            this.Exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(780, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(21, 21);
            this.Exit.TabIndex = 11;
            this.Exit.Text = "X";
            this.Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Exit.UseCompatibleTextRendering = true;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            this.Exit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_Down);
            this.Exit.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.Exit.MouseLeave += new System.EventHandler(this.Button_Leave);
            this.Exit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_Up);
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Minimize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(102)))));
            this.Minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Minimize.ForeColor = System.Drawing.Color.White;
            this.Minimize.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Minimize.Location = new System.Drawing.Point(759, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(21, 21);
            this.Minimize.TabIndex = 12;
            this.Minimize.Text = "_";
            this.Minimize.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Minimize.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Minimize.UseCompatibleTextRendering = true;
            this.Minimize.UseVisualStyleBackColor = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            this.Minimize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_Down);
            this.Minimize.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.Minimize.MouseLeave += new System.EventHandler(this.Button_Leave);
            this.Minimize.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_Up);
            // 
            // Scripts
            // 
            this.Scripts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Scripts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Scripts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Scripts.ForeColor = System.Drawing.Color.White;
            this.Scripts.FormattingEnabled = true;
            this.Scripts.HorizontalScrollbar = true;
            this.Scripts.ItemHeight = 15;
            this.Scripts.Location = new System.Drawing.Point(679, 37);
            this.Scripts.Name = "Scripts";
            this.Scripts.Size = new System.Drawing.Size(119, 270);
            this.Scripts.TabIndex = 15;
            this.Scripts.SelectedIndexChanged += new System.EventHandler(this.Scripts_SelectedIndexChanged);
            // 
            // ScriptBox
            // 
            this.ScriptBox.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.ScriptBox.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>.+)\r\n";
            this.ScriptBox.AutoScrollMinSize = new System.Drawing.Size(53, 13);
            this.ScriptBox.BackBrush = null;
            this.ScriptBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ScriptBox.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.ScriptBox.CaretColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(86)))), ((int)(((byte)(86)))));
            this.ScriptBox.CharHeight = 13;
            this.ScriptBox.CharWidth = 7;
            this.ScriptBox.CommentPrefix = "--";
            this.ScriptBox.CurrentLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.ScriptBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ScriptBox.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.ScriptBox.Font = new System.Drawing.Font("Courier New", 9F);
            this.ScriptBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ScriptBox.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ScriptBox.IsReplaceMode = false;
            this.ScriptBox.Language = FastColoredTextBoxNS.Language.Lua;
            this.ScriptBox.LeftBracket = '(';
            this.ScriptBox.LeftBracket2 = '{';
            this.ScriptBox.LineNumberColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.ScriptBox.Location = new System.Drawing.Point(3, 36);
            this.ScriptBox.Name = "ScriptBox";
            this.ScriptBox.Paddings = new System.Windows.Forms.Padding(0);
            this.ScriptBox.ReservedCountOfLineNumberChars = 5;
            this.ScriptBox.RightBracket = ')';
            this.ScriptBox.RightBracket2 = '}';
            this.ScriptBox.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.ScriptBox.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("ScriptBox.ServiceColors")));
            this.ScriptBox.ServiceLinesColor = System.Drawing.Color.Transparent;
            this.ScriptBox.Size = new System.Drawing.Size(673, 275);
            this.ScriptBox.TabIndex = 12;
            this.ScriptBox.Zoom = 100;
            // 
            // ofd
            // 
            this.ofd.Filter = "Script Files|*.lua;*.txt";
            // 
            // sfd
            // 
            this.sfd.Filter = "Script Files|*.lua;*.txt";
            // 
            // updateScripts
            // 
            this.updateScripts.Enabled = true;
            this.updateScripts.Tick += new System.EventHandler(this.updateScripts_Tick);
            // 
            // Logo
            // 
            this.Logo.BackgroundImage = global::Executor.Properties.Resources.icon;
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logo.Location = new System.Drawing.Point(5, 2);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(25, 25);
            this.Logo.TabIndex = 13;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // Executor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(801, 355);
            this.Controls.Add(this.ScriptBox);
            this.Controls.Add(this.Scripts);
            this.Controls.Add(this.Top);
            this.Controls.Add(this.Options);
            this.Controls.Add(this.ScriptHub);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.ExecuteFile);
            this.Controls.Add(this.Open);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Execute);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Executor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Executor";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Executor_FormClosing);
            this.Load += new System.EventHandler(this.Executor_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Movable);
            this.Top.ResumeLayout(false);
            this.Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScriptBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Button ExecuteFile;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button ScriptHub;
        private System.Windows.Forms.Button Options;
        private System.Windows.Forms.Panel Top;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.ListBox Scripts;
        private System.Windows.Forms.PictureBox Logo;
        private FastColoredTextBoxNS.FastColoredTextBox ScriptBox;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.SaveFileDialog sfd;
        private System.Windows.Forms.Timer updateScripts;
    }
}


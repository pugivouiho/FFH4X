
namespace Executor
{
    partial class ScriptHub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScriptHub));
            this.Top = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Minimize = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.Scripts = new System.Windows.Forms.ListBox();
            this.Execute = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.Showcase = new System.Windows.Forms.PictureBox();
            this.Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Showcase)).BeginInit();
            this.SuspendLayout();
            // 
            // Top
            // 
            this.Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Top.Controls.Add(this.Logo);
            this.Top.Controls.Add(this.Minimize);
            this.Top.Controls.Add(this.Title);
            this.Top.Location = new System.Drawing.Point(0, 0);
            this.Top.Name = "Top";
            this.Top.Size = new System.Drawing.Size(439, 30);
            this.Top.TabIndex = 11;
            this.Top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Movable);
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
            this.Minimize.Location = new System.Drawing.Point(418, 0);
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
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Title.Location = new System.Drawing.Point(154, 6);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(145, 15);
            this.Title.TabIndex = 0;
            this.Title.Text = "Websocket X - Script Hub";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Movable);
            // 
            // Scripts
            // 
            this.Scripts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Scripts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Scripts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Scripts.ForeColor = System.Drawing.Color.White;
            this.Scripts.FormattingEnabled = true;
            this.Scripts.ItemHeight = 15;
            this.Scripts.Items.AddRange(new object[] {
            "Dark Dex"});
            this.Scripts.Location = new System.Drawing.Point(10, 40);
            this.Scripts.Name = "Scripts";
            this.Scripts.Size = new System.Drawing.Size(115, 285);
            this.Scripts.TabIndex = 15;
            this.Scripts.SelectedIndexChanged += new System.EventHandler(this.Scripts_SelectedIndexChanged);
            // 
            // Execute
            // 
            this.Execute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Execute.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Execute.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(70)))), ((int)(((byte)(102)))));
            this.Execute.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.Execute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Execute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Execute.ForeColor = System.Drawing.Color.White;
            this.Execute.Location = new System.Drawing.Point(131, 301);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(147, 24);
            this.Execute.TabIndex = 13;
            this.Execute.Text = "Execute";
            this.Execute.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Execute.UseVisualStyleBackColor = false;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            this.Execute.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_Down);
            this.Execute.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.Execute.MouseLeave += new System.EventHandler(this.Button_Leave);
            this.Execute.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_Up);
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
            this.Exit.Location = new System.Drawing.Point(283, 301);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(147, 24);
            this.Exit.TabIndex = 14;
            this.Exit.Text = "Close";
            this.Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            this.Exit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_Down);
            this.Exit.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.Exit.MouseLeave += new System.EventHandler(this.Button_Leave);
            this.Exit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_Up);
            // 
            // Description
            // 
            this.Description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Description.ForeColor = System.Drawing.Color.White;
            this.Description.Location = new System.Drawing.Point(131, 214);
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Size = new System.Drawing.Size(299, 80);
            this.Description.TabIndex = 15;
            this.Description.Text = "";
            // 
            // Showcase
            // 
            this.Showcase.Location = new System.Drawing.Point(134, 40);
            this.Showcase.Name = "Showcase";
            this.Showcase.Size = new System.Drawing.Size(294, 170);
            this.Showcase.TabIndex = 16;
            this.Showcase.TabStop = false;
            this.Showcase.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Movable);
            // 
            // ScriptHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(439, 336);
            this.Controls.Add(this.Showcase);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Execute);
            this.Controls.Add(this.Scripts);
            this.Controls.Add(this.Top);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ScriptHub";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Script Hub";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScriptHub_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Movable);
            this.Top.ResumeLayout(false);
            this.Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Showcase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Top;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.ListBox Scripts;
        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.RichTextBox Description;
        private System.Windows.Forms.PictureBox Showcase;
    }
}
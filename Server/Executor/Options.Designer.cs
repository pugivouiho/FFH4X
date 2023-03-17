
namespace Executor
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.Top = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.TopMostOption = new System.Windows.Forms.CheckBox();
            this.Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Top
            // 
            this.Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.Top.Controls.Add(this.Logo);
            this.Top.Controls.Add(this.Title);
            this.Top.Location = new System.Drawing.Point(0, 0);
            this.Top.Name = "Top";
            this.Top.Size = new System.Drawing.Size(270, 30);
            this.Top.TabIndex = 11;
            this.Top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Movable);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Title.Location = new System.Drawing.Point(75, 6);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(130, 15);
            this.Title.TabIndex = 0;
            this.Title.Text = "Websocket X - Options";
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
            this.Exit.Location = new System.Drawing.Point(11, 323);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(249, 27);
            this.Exit.TabIndex = 12;
            this.Exit.Text = "Close";
            this.Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            this.Exit.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Button_Down);
            this.Exit.MouseEnter += new System.EventHandler(this.Button_Enter);
            this.Exit.MouseLeave += new System.EventHandler(this.Button_Leave);
            this.Exit.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Button_Up);
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
            // TopMostOption
            // 
            this.TopMostOption.AutoSize = true;
            this.TopMostOption.BackColor = System.Drawing.Color.Transparent;
            this.TopMostOption.Checked = true;
            this.TopMostOption.CheckState = System.Windows.Forms.CheckState.Checked;
            this.TopMostOption.FlatAppearance.BorderSize = 0;
            this.TopMostOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.TopMostOption.Location = new System.Drawing.Point(95, 36);
            this.TopMostOption.Name = "TopMostOption";
            this.TopMostOption.Size = new System.Drawing.Size(81, 20);
            this.TopMostOption.TabIndex = 13;
            this.TopMostOption.Text = "TopMost";
            this.TopMostOption.UseVisualStyleBackColor = false;
            this.TopMostOption.CheckedChanged += new System.EventHandler(this.TopMostOption_CheckedChanged);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(270, 360);
            this.Controls.Add(this.TopMostOption);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Top);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Options_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Movable);
            this.Top.ResumeLayout(false);
            this.Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Top;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.CheckBox TopMostOption;
    }
}
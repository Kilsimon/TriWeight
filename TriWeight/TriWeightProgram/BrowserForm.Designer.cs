﻿namespace Wishlist
{
    partial class BrowserForm
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
            this.wbShop = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // wbShop
            // 
            this.wbShop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbShop.Location = new System.Drawing.Point(0, 0);
            this.wbShop.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbShop.Name = "wbShop";
            this.wbShop.Size = new System.Drawing.Size(828, 565);
            this.wbShop.TabIndex = 0;
            // 
            // BrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 565);
            this.Controls.Add(this.wbShop);
            this.Name = "BrowserForm";
            this.Text = "BrowserForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbShop;
    }
}
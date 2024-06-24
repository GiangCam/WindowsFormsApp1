namespace WindowsFormsApp1
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiệnIchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giaiPtbac2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.địnhDạngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngKýMônHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.tiệnIchToolStripMenuItem,
            this.trToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1088, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thoátToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống ";
            // 
            // tiệnIchToolStripMenuItem
            // 
            this.tiệnIchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.giaiPtbac2ToolStripMenuItem,
            this.địnhDạngToolStripMenuItem,
            this.đăngKýMônHọcToolStripMenuItem});
            this.tiệnIchToolStripMenuItem.Name = "tiệnIchToolStripMenuItem";
            this.tiệnIchToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.tiệnIchToolStripMenuItem.Text = "Tiện Ich";
            // 
            // trToolStripMenuItem
            // 
            this.trToolStripMenuItem.Name = "trToolStripMenuItem";
            this.trToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.trToolStripMenuItem.Text = "Trợ giúp";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // giaiPtbac2ToolStripMenuItem
            // 
            this.giaiPtbac2ToolStripMenuItem.Name = "giaiPtbac2ToolStripMenuItem";
            this.giaiPtbac2ToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.giaiPtbac2ToolStripMenuItem.Text = "Giai Phuong Trinh Bac 2";
            this.giaiPtbac2ToolStripMenuItem.Click += new System.EventHandler(this.giaiPtbac2ToolStripMenuItem_Click);
            // 
            // địnhDạngToolStripMenuItem
            // 
            this.địnhDạngToolStripMenuItem.Name = "địnhDạngToolStripMenuItem";
            this.địnhDạngToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.địnhDạngToolStripMenuItem.Text = "Định Dạng";
            this.địnhDạngToolStripMenuItem.Click += new System.EventHandler(this.địnhDạngToolStripMenuItem_Click);
            // 
            // đăngKýMônHọcToolStripMenuItem
            // 
            this.đăngKýMônHọcToolStripMenuItem.Name = "đăngKýMônHọcToolStripMenuItem";
            this.đăngKýMônHọcToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.đăngKýMônHọcToolStripMenuItem.Text = "Đăng Ký Môn Học";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1088, 637);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiệnIchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giaiPtbac2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem địnhDạngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngKýMônHọcToolStripMenuItem;
    }
}


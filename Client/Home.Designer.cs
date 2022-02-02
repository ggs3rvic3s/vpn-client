namespace Client
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.Wallpaper = new AxWMPLib.AxWindowsMediaPlayer();
            this.btn_Connect = new MaterialSkin.Controls.MaterialButton();
            this.btn_Disconnect = new MaterialSkin.Controls.MaterialButton();
            this.btn_dev = new MaterialSkin.Controls.MaterialButton();
            this.btn_OpenSource = new MaterialSkin.Controls.MaterialButton();
            this.notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Exit = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.Wallpaper)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Wallpaper
            // 
            this.Wallpaper.Enabled = true;
            this.Wallpaper.Location = new System.Drawing.Point(-5, 0);
            this.Wallpaper.Name = "Wallpaper";
            this.Wallpaper.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Wallpaper.OcxState")));
            this.Wallpaper.Size = new System.Drawing.Size(1177, 640);
            this.Wallpaper.TabIndex = 0;
            // 
            // btn_Connect
            // 
            this.btn_Connect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Connect.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Connect.Depth = 0;
            this.btn_Connect.HighEmphasis = true;
            this.btn_Connect.Icon = null;
            this.btn_Connect.Location = new System.Drawing.Point(7, 532);
            this.btn_Connect.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Connect.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Connect.Size = new System.Drawing.Size(89, 36);
            this.btn_Connect.TabIndex = 1;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Connect.UseAccentColor = false;
            this.btn_Connect.UseVisualStyleBackColor = true;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // btn_Disconnect
            // 
            this.btn_Disconnect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Disconnect.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Disconnect.Depth = 0;
            this.btn_Disconnect.HighEmphasis = true;
            this.btn_Disconnect.Icon = null;
            this.btn_Disconnect.Location = new System.Drawing.Point(7, 532);
            this.btn_Disconnect.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Disconnect.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Disconnect.Name = "btn_Disconnect";
            this.btn_Disconnect.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Disconnect.Size = new System.Drawing.Size(112, 36);
            this.btn_Disconnect.TabIndex = 2;
            this.btn_Disconnect.Text = "Disconnect";
            this.btn_Disconnect.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Disconnect.UseAccentColor = false;
            this.btn_Disconnect.UseVisualStyleBackColor = true;
            this.btn_Disconnect.Click += new System.EventHandler(this.btn_Disconnect_Click);
            // 
            // btn_dev
            // 
            this.btn_dev.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_dev.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_dev.Depth = 0;
            this.btn_dev.HighEmphasis = true;
            this.btn_dev.Icon = null;
            this.btn_dev.Location = new System.Drawing.Point(1039, 532);
            this.btn_dev.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_dev.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_dev.Name = "btn_dev";
            this.btn_dev.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_dev.Size = new System.Drawing.Size(124, 36);
            this.btn_dev.TabIndex = 4;
            this.btn_dev.Text = "GGS-Network";
            this.btn_dev.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_dev.UseAccentColor = false;
            this.btn_dev.UseVisualStyleBackColor = true;
            this.btn_dev.Click += new System.EventHandler(this.btn_dev_Click);
            // 
            // btn_OpenSource
            // 
            this.btn_OpenSource.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_OpenSource.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_OpenSource.Depth = 0;
            this.btn_OpenSource.HighEmphasis = true;
            this.btn_OpenSource.Icon = null;
            this.btn_OpenSource.Location = new System.Drawing.Point(873, 532);
            this.btn_OpenSource.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_OpenSource.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_OpenSource.Name = "btn_OpenSource";
            this.btn_OpenSource.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_OpenSource.Size = new System.Drawing.Size(157, 36);
            this.btn_OpenSource.TabIndex = 5;
            this.btn_OpenSource.Text = "OpenSource Code";
            this.btn_OpenSource.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_OpenSource.UseAccentColor = false;
            this.btn_OpenSource.UseVisualStyleBackColor = true;
            this.btn_OpenSource.Click += new System.EventHandler(this.btn_OpenSource_Click);
            // 
            // notify
            // 
            this.notify.Visible = true;
            this.notify.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notify_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(134, 92);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Exit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Exit.Depth = 0;
            this.btn_Exit.HighEmphasis = true;
            this.btn_Exit.Icon = null;
            this.btn_Exit.Location = new System.Drawing.Point(1099, 12);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Exit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Exit.Size = new System.Drawing.Size(64, 36);
            this.btn_Exit.TabIndex = 8;
            this.btn_Exit.Text = "X";
            this.btn_Exit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Exit.UseAccentColor = false;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 577);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_OpenSource);
            this.Controls.Add(this.btn_dev);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.btn_Disconnect);
            this.Controls.Add(this.Wallpaper);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.Move += new System.EventHandler(this.Home_Move);
            ((System.ComponentModel.ISupportInitialize)(this.Wallpaper)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer Wallpaper;
        private MaterialSkin.Controls.MaterialButton btn_Connect;
        private MaterialSkin.Controls.MaterialButton btn_Disconnect;
        private MaterialSkin.Controls.MaterialButton btn_dev;
        private MaterialSkin.Controls.MaterialButton btn_OpenSource;
        private System.Windows.Forms.NotifyIcon notify;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private MaterialSkin.Controls.MaterialButton btn_Exit;
    }
}
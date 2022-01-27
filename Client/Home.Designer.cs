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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.btn_Connect = new MetroFramework.Controls.MetroButton();
            this.btn_Disconnect = new MetroFramework.Controls.MetroButton();
            this.btn_deleteOVPN = new MetroFramework.Controls.MetroButton();
            this.btn_tap6 = new MetroFramework.Controls.MetroButton();
            this.btn_ovpngui = new MetroFramework.Controls.MetroButton();
            this.btn_cache = new MetroFramework.Controls.MetroButton();
            this.Wallpaper = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.Wallpaper)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(11, 494);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(213, 29);
            this.btn_Connect.TabIndex = 2;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // btn_Disconnect
            // 
            this.btn_Disconnect.Location = new System.Drawing.Point(11, 494);
            this.btn_Disconnect.Name = "btn_Disconnect";
            this.btn_Disconnect.Size = new System.Drawing.Size(213, 29);
            this.btn_Disconnect.TabIndex = 3;
            this.btn_Disconnect.Text = "Disconnect";
            this.btn_Disconnect.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_Disconnect.Click += new System.EventHandler(this.btn_Disconnect_Click);
            // 
            // btn_deleteOVPN
            // 
            this.btn_deleteOVPN.Location = new System.Drawing.Point(230, 494);
            this.btn_deleteOVPN.Name = "btn_deleteOVPN";
            this.btn_deleteOVPN.Size = new System.Drawing.Size(163, 29);
            this.btn_deleteOVPN.TabIndex = 4;
            this.btn_deleteOVPN.Text = "Delete OVPN Driver";
            this.btn_deleteOVPN.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_deleteOVPN.Click += new System.EventHandler(this.btn_deleteOVPN_Click);
            // 
            // btn_tap6
            // 
            this.btn_tap6.Location = new System.Drawing.Point(705, 494);
            this.btn_tap6.Margin = new System.Windows.Forms.Padding(2);
            this.btn_tap6.Name = "btn_tap6";
            this.btn_tap6.Size = new System.Drawing.Size(222, 29);
            this.btn_tap6.TabIndex = 5;
            this.btn_tap6.Text = "Add TAP6 Virtual Network Adapter";
            this.btn_tap6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_tap6.Click += new System.EventHandler(this.btn_tap6_Click);
            // 
            // btn_ovpngui
            // 
            this.btn_ovpngui.Location = new System.Drawing.Point(941, 494);
            this.btn_ovpngui.Name = "btn_ovpngui";
            this.btn_ovpngui.Size = new System.Drawing.Size(132, 29);
            this.btn_ovpngui.TabIndex = 8;
            this.btn_ovpngui.Text = "Open OpenVPN GUI";
            this.btn_ovpngui.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_ovpngui.Click += new System.EventHandler(this.btn_ovpngui_Click);
            // 
            // btn_cache
            // 
            this.btn_cache.Location = new System.Drawing.Point(941, 459);
            this.btn_cache.Name = "btn_cache";
            this.btn_cache.Size = new System.Drawing.Size(132, 29);
            this.btn_cache.TabIndex = 9;
            this.btn_cache.Text = "Delete Cache";
            this.btn_cache.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_cache.Click += new System.EventHandler(this.btn_cache_Click);
            // 
            // Wallpaper
            // 
            this.Wallpaper.Enabled = true;
            this.Wallpaper.Location = new System.Drawing.Point(-1, 0);
            this.Wallpaper.Name = "Wallpaper";
            this.Wallpaper.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Wallpaper.OcxState")));
            this.Wallpaper.Size = new System.Drawing.Size(1087, 612);
            this.Wallpaper.TabIndex = 10;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 547);
            this.Controls.Add(this.btn_cache);
            this.Controls.Add(this.btn_ovpngui);
            this.Controls.Add(this.btn_tap6);
            this.Controls.Add(this.btn_deleteOVPN);
            this.Controls.Add(this.btn_Disconnect);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.Wallpaper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Wallpaper)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton btn_Connect;
        private MetroFramework.Controls.MetroButton btn_Disconnect;
        private MetroFramework.Controls.MetroButton btn_deleteOVPN;
        private MetroFramework.Controls.MetroButton btn_tap6;
        private MetroFramework.Controls.MetroButton btn_ovpngui;
        private MetroFramework.Controls.MetroButton btn_cache;
        private AxWMPLib.AxWindowsMediaPlayer Wallpaper;
    }
}
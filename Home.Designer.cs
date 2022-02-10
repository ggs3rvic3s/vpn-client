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
            this.Wallpaper = new AxWMPLib.AxWindowsMediaPlayer();
            this.WallpaperAudio = new AxWMPLib.AxWindowsMediaPlayer();
            this.btn_Connect = new MaterialSkin.Controls.MaterialButton();
            this.btn_Disconnect = new MaterialSkin.Controls.MaterialButton();
            this.chromiumWebBrowser1 = new CefSharp.WinForms.ChromiumWebBrowser();
            this.DayNews = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.Wallpaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WallpaperAudio)).BeginInit();
            this.SuspendLayout();
            // 
            // Wallpaper
            // 
            this.Wallpaper.Enabled = true;
            this.Wallpaper.Location = new System.Drawing.Point(-3, -3);
            this.Wallpaper.Name = "Wallpaper";
            this.Wallpaper.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Wallpaper.OcxState")));
            this.Wallpaper.Size = new System.Drawing.Size(993, 622);
            this.Wallpaper.TabIndex = 0;
            // 
            // WallpaperAudio
            // 
            this.WallpaperAudio.Enabled = true;
            this.WallpaperAudio.Location = new System.Drawing.Point(222, 282);
            this.WallpaperAudio.Name = "WallpaperAudio";
            this.WallpaperAudio.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WallpaperAudio.OcxState")));
            this.WallpaperAudio.Size = new System.Drawing.Size(258, 104);
            this.WallpaperAudio.TabIndex = 1;
            // 
            // btn_Connect
            // 
            this.btn_Connect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Connect.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Connect.Depth = 0;
            this.btn_Connect.HighEmphasis = true;
            this.btn_Connect.Icon = null;
            this.btn_Connect.Location = new System.Drawing.Point(13, 496);
            this.btn_Connect.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Connect.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Connect.Size = new System.Drawing.Size(89, 36);
            this.btn_Connect.TabIndex = 2;
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
            this.btn_Disconnect.Location = new System.Drawing.Point(13, 496);
            this.btn_Disconnect.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Disconnect.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Disconnect.Name = "btn_Disconnect";
            this.btn_Disconnect.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Disconnect.Size = new System.Drawing.Size(112, 36);
            this.btn_Disconnect.TabIndex = 3;
            this.btn_Disconnect.Text = "Disconnect";
            this.btn_Disconnect.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Disconnect.UseAccentColor = false;
            this.btn_Disconnect.UseVisualStyleBackColor = true;
            this.btn_Disconnect.Click += new System.EventHandler(this.btn_Disconnect_Click);
            // 
            // chromiumWebBrowser1
            // 
            this.chromiumWebBrowser1.ActivateBrowserOnCreation = false;
// TODO: Ausnahme "Ungültiger primitiver Typ: System.IntPtr. Verwenden Sie CodeObjectCreateExpression." beim Generieren des Codes für "".
            this.chromiumWebBrowser1.Location = new System.Drawing.Point(712, 31);
            this.chromiumWebBrowser1.Name = "chromiumWebBrowser1";
            this.chromiumWebBrowser1.Size = new System.Drawing.Size(263, 501);
            this.chromiumWebBrowser1.TabIndex = 4;
            // 
            // DayNews
            // 
            this.DayNews.AutoSize = true;
            this.DayNews.Depth = 0;
            this.DayNews.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DayNews.Location = new System.Drawing.Point(709, 9);
            this.DayNews.MouseState = MaterialSkin.MouseState.HOVER;
            this.DayNews.Name = "DayNews";
            this.DayNews.Size = new System.Drawing.Size(25, 19);
            this.DayNews.TabIndex = 5;
            this.DayNews.Text = "???";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 547);
            this.Controls.Add(this.DayNews);
            this.Controls.Add(this.chromiumWebBrowser1);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.btn_Disconnect);
            this.Controls.Add(this.Wallpaper);
            this.Controls.Add(this.WallpaperAudio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Wallpaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WallpaperAudio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer Wallpaper;
        private AxWMPLib.AxWindowsMediaPlayer WallpaperAudio;
        private MaterialSkin.Controls.MaterialButton btn_Connect;
        private MaterialSkin.Controls.MaterialButton btn_Disconnect;
        private CefSharp.WinForms.ChromiumWebBrowser chromiumWebBrowser1;
        private MaterialSkin.Controls.MaterialLabel DayNews;
    }
}
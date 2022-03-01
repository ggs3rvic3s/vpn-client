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
            this.btn_Connect = new MaterialSkin.Controls.MaterialButton();
            this.btn_Disconnect = new MaterialSkin.Controls.MaterialButton();
            this.DayNews = new MaterialSkin.Controls.MaterialLabel();
            this.webTimer = new System.Windows.Forms.Timer(this.components);
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.btn_reload = new MaterialSkin.Controls.MaterialButton();
            this.btn_settings = new MaterialSkin.Controls.MaterialButton();
            this.btn_managed_account = new MaterialSkin.Controls.MaterialButton();
            this.label_joinedsince = new MaterialSkin.Controls.MaterialLabel();
            this.label_user_email = new MaterialSkin.Controls.MaterialLabel();
            this.label_user_username = new MaterialSkin.Controls.MaterialLabel();
            this.webBrowserProfile = new System.Windows.Forms.WebBrowser();
            this.label_user_lastname = new MaterialSkin.Controls.MaterialLabel();
            this.label_user_firstname = new MaterialSkin.Controls.MaterialLabel();
            this.label_user_id = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.Wallpaper = new AxWMPLib.AxWindowsMediaPlayer();
            this.WallpaperAudio = new AxWMPLib.AxWindowsMediaPlayer();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Wallpaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WallpaperAudio)).BeginInit();
            this.SuspendLayout();
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
            // DayNews
            // 
            this.DayNews.AutoSize = true;
            this.DayNews.Depth = 0;
            this.DayNews.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DayNews.Location = new System.Drawing.Point(17, 520);
            this.DayNews.MouseState = MaterialSkin.MouseState.HOVER;
            this.DayNews.Name = "DayNews";
            this.DayNews.Size = new System.Drawing.Size(25, 19);
            this.DayNews.TabIndex = 5;
            this.DayNews.Text = "???";
            // 
            // webTimer
            // 
            this.webTimer.Interval = 300;
            this.webTimer.Tick += new System.EventHandler(this.webTimer_Tick);
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(987, -3);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(199, 553);
            this.webBrowser.TabIndex = 6;
            this.webBrowser.Url = new System.Uri("https://ggs-network.de", System.UriKind.Absolute);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.btn_reload);
            this.materialCard1.Controls.Add(this.btn_settings);
            this.materialCard1.Controls.Add(this.btn_managed_account);
            this.materialCard1.Controls.Add(this.label_joinedsince);
            this.materialCard1.Controls.Add(this.label_user_email);
            this.materialCard1.Controls.Add(this.label_user_username);
            this.materialCard1.Controls.Add(this.DayNews);
            this.materialCard1.Controls.Add(this.webBrowserProfile);
            this.materialCard1.Controls.Add(this.label_user_lastname);
            this.materialCard1.Controls.Add(this.label_user_firstname);
            this.materialCard1.Controls.Add(this.label_user_id);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(987, -3);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(301, 553);
            this.materialCard1.TabIndex = 7;
            // 
            // btn_reload
            // 
            this.btn_reload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_reload.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_reload.Depth = 0;
            this.btn_reload.HighEmphasis = true;
            this.btn_reload.Icon = null;
            this.btn_reload.Location = new System.Drawing.Point(10, 430);
            this.btn_reload.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_reload.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_reload.Size = new System.Drawing.Size(77, 36);
            this.btn_reload.TabIndex = 8;
            this.btn_reload.Text = "Reload";
            this.btn_reload.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_reload.UseAccentColor = false;
            this.btn_reload.UseVisualStyleBackColor = true;
            this.btn_reload.Click += new System.EventHandler(this.btn_reload_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_settings.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_settings.Depth = 0;
            this.btn_settings.HighEmphasis = true;
            this.btn_settings.Icon = null;
            this.btn_settings.Location = new System.Drawing.Point(175, 478);
            this.btn_settings.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_settings.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_settings.Size = new System.Drawing.Size(90, 36);
            this.btn_settings.TabIndex = 9;
            this.btn_settings.Text = "Settings";
            this.btn_settings.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_settings.UseAccentColor = false;
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_managed_account
            // 
            this.btn_managed_account.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_managed_account.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_managed_account.Depth = 0;
            this.btn_managed_account.HighEmphasis = true;
            this.btn_managed_account.Icon = null;
            this.btn_managed_account.Location = new System.Drawing.Point(12, 478);
            this.btn_managed_account.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_managed_account.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_managed_account.Name = "btn_managed_account";
            this.btn_managed_account.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_managed_account.Size = new System.Drawing.Size(155, 36);
            this.btn_managed_account.TabIndex = 8;
            this.btn_managed_account.Text = "Manage Account";
            this.btn_managed_account.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_managed_account.UseAccentColor = false;
            this.btn_managed_account.UseVisualStyleBackColor = true;
            this.btn_managed_account.Click += new System.EventHandler(this.btn_managed_account_Click);
            // 
            // label_joinedsince
            // 
            this.label_joinedsince.AutoSize = true;
            this.label_joinedsince.Depth = 0;
            this.label_joinedsince.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label_joinedsince.Location = new System.Drawing.Point(17, 382);
            this.label_joinedsince.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_joinedsince.Name = "label_joinedsince";
            this.label_joinedsince.Size = new System.Drawing.Size(25, 19);
            this.label_joinedsince.TabIndex = 7;
            this.label_joinedsince.Text = "???";
            // 
            // label_user_email
            // 
            this.label_user_email.AutoSize = true;
            this.label_user_email.Depth = 0;
            this.label_user_email.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label_user_email.Location = new System.Drawing.Point(17, 363);
            this.label_user_email.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_user_email.Name = "label_user_email";
            this.label_user_email.Size = new System.Drawing.Size(25, 19);
            this.label_user_email.TabIndex = 6;
            this.label_user_email.Text = "???";
            // 
            // label_user_username
            // 
            this.label_user_username.AutoSize = true;
            this.label_user_username.Depth = 0;
            this.label_user_username.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label_user_username.Location = new System.Drawing.Point(17, 344);
            this.label_user_username.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_user_username.Name = "label_user_username";
            this.label_user_username.Size = new System.Drawing.Size(25, 19);
            this.label_user_username.TabIndex = 5;
            this.label_user_username.Text = "???";
            // 
            // webBrowserProfile
            // 
            this.webBrowserProfile.AllowNavigation = false;
            this.webBrowserProfile.AllowWebBrowserDrop = false;
            this.webBrowserProfile.Location = new System.Drawing.Point(17, 34);
            this.webBrowserProfile.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserProfile.Name = "webBrowserProfile";
            this.webBrowserProfile.ScrollBarsEnabled = false;
            this.webBrowserProfile.Size = new System.Drawing.Size(250, 250);
            this.webBrowserProfile.TabIndex = 4;
            // 
            // label_user_lastname
            // 
            this.label_user_lastname.AutoSize = true;
            this.label_user_lastname.Depth = 0;
            this.label_user_lastname.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label_user_lastname.Location = new System.Drawing.Point(17, 325);
            this.label_user_lastname.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_user_lastname.Name = "label_user_lastname";
            this.label_user_lastname.Size = new System.Drawing.Size(25, 19);
            this.label_user_lastname.TabIndex = 3;
            this.label_user_lastname.Text = "???";
            // 
            // label_user_firstname
            // 
            this.label_user_firstname.AutoSize = true;
            this.label_user_firstname.Depth = 0;
            this.label_user_firstname.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label_user_firstname.Location = new System.Drawing.Point(17, 306);
            this.label_user_firstname.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_user_firstname.Name = "label_user_firstname";
            this.label_user_firstname.Size = new System.Drawing.Size(25, 19);
            this.label_user_firstname.TabIndex = 2;
            this.label_user_firstname.Text = "???";
            // 
            // label_user_id
            // 
            this.label_user_id.AutoSize = true;
            this.label_user_id.Depth = 0;
            this.label_user_id.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label_user_id.Location = new System.Drawing.Point(17, 287);
            this.label_user_id.MouseState = MaterialSkin.MouseState.HOVER;
            this.label_user_id.Name = "label_user_id";
            this.label_user_id.Size = new System.Drawing.Size(25, 19);
            this.label_user_id.TabIndex = 1;
            this.label_user_id.Text = "???";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(9, 12);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(51, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Profile:";
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
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 547);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.btn_Disconnect);
            this.Controls.Add(this.Wallpaper);
            this.Controls.Add(this.WallpaperAudio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
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
        private MaterialSkin.Controls.MaterialLabel DayNews;
        private System.Windows.Forms.Timer webTimer;
        private System.Windows.Forms.WebBrowser webBrowser;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel label_user_id;
        private MaterialSkin.Controls.MaterialLabel label_user_firstname;
        private MaterialSkin.Controls.MaterialLabel label_user_lastname;
        private System.Windows.Forms.WebBrowser webBrowserProfile;
        private MaterialSkin.Controls.MaterialLabel label_user_username;
        private MaterialSkin.Controls.MaterialLabel label_user_email;
        private MaterialSkin.Controls.MaterialLabel label_joinedsince;
        private MaterialSkin.Controls.MaterialButton btn_managed_account;
        private MaterialSkin.Controls.MaterialButton btn_settings;
        private MaterialSkin.Controls.MaterialButton btn_reload;
    }
}
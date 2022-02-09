namespace Client
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Wallpaper = new AxWMPLib.AxWindowsMediaPlayer();
            this.txt_Password = new MaterialSkin.Controls.MaterialTextBox2();
            this.txt_Username = new MaterialSkin.Controls.MaterialTextBox2();
            this.btn_Login = new MaterialSkin.Controls.MaterialButton();
            this.btn_Register = new MaterialSkin.Controls.MaterialButton();
            this.WallpaperAudio = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.Wallpaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WallpaperAudio)).BeginInit();
            this.SuspendLayout();
            // 
            // Wallpaper
            // 
            this.Wallpaper.Enabled = true;
            this.Wallpaper.Location = new System.Drawing.Point(-2, -2);
            this.Wallpaper.Name = "Wallpaper";
            this.Wallpaper.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Wallpaper.OcxState")));
            this.Wallpaper.Size = new System.Drawing.Size(993, 622);
            this.Wallpaper.TabIndex = 0;
            // 
            // txt_Password
            // 
            this.txt_Password.AnimateReadOnly = false;
            this.txt_Password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_Password.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Password.Depth = 0;
            this.txt_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Password.HideSelection = true;
            this.txt_Password.Hint = "Password";
            this.txt_Password.LeadingIcon = null;
            this.txt_Password.Location = new System.Drawing.Point(21, 448);
            this.txt_Password.MaxLength = 32767;
            this.txt_Password.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '\0';
            this.txt_Password.PrefixSuffixText = null;
            this.txt_Password.ReadOnly = false;
            this.txt_Password.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Password.SelectedText = "";
            this.txt_Password.SelectionLength = 0;
            this.txt_Password.SelectionStart = 0;
            this.txt_Password.ShortcutsEnabled = true;
            this.txt_Password.Size = new System.Drawing.Size(299, 48);
            this.txt_Password.TabIndex = 1;
            this.txt_Password.TabStop = false;
            this.txt_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Password.TrailingIcon = null;
            this.txt_Password.UseSystemPasswordChar = false;
            // 
            // txt_Username
            // 
            this.txt_Username.AnimateReadOnly = false;
            this.txt_Username.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txt_Username.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_Username.Depth = 0;
            this.txt_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Username.HideSelection = true;
            this.txt_Username.Hint = "Username";
            this.txt_Username.LeadingIcon = null;
            this.txt_Username.Location = new System.Drawing.Point(21, 394);
            this.txt_Username.MaxLength = 32767;
            this.txt_Username.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.PasswordChar = '\0';
            this.txt_Username.PrefixSuffixText = null;
            this.txt_Username.ReadOnly = false;
            this.txt_Username.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txt_Username.SelectedText = "";
            this.txt_Username.SelectionLength = 0;
            this.txt_Username.SelectionStart = 0;
            this.txt_Username.ShortcutsEnabled = true;
            this.txt_Username.Size = new System.Drawing.Size(299, 48);
            this.txt_Username.TabIndex = 2;
            this.txt_Username.TabStop = false;
            this.txt_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Username.TrailingIcon = null;
            this.txt_Username.UseSystemPasswordChar = false;
            // 
            // btn_Login
            // 
            this.btn_Login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Login.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Login.Depth = 0;
            this.btn_Login.HighEmphasis = true;
            this.btn_Login.Icon = null;
            this.btn_Login.Location = new System.Drawing.Point(21, 505);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Login.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Login.Size = new System.Drawing.Size(64, 36);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "Login";
            this.btn_Login.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Login.UseAccentColor = false;
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Register
            // 
            this.btn_Register.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Register.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Register.Depth = 0;
            this.btn_Register.HighEmphasis = true;
            this.btn_Register.Icon = null;
            this.btn_Register.Location = new System.Drawing.Point(157, 505);
            this.btn_Register.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Register.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Register.Size = new System.Drawing.Size(89, 36);
            this.btn_Register.TabIndex = 4;
            this.btn_Register.Text = "Register";
            this.btn_Register.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Register.UseAccentColor = false;
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // WallpaperAudio
            // 
            this.WallpaperAudio.Enabled = true;
            this.WallpaperAudio.Location = new System.Drawing.Point(498, 193);
            this.WallpaperAudio.Name = "WallpaperAudio";
            this.WallpaperAudio.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WallpaperAudio.OcxState")));
            this.WallpaperAudio.Size = new System.Drawing.Size(204, 171);
            this.WallpaperAudio.TabIndex = 5;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 547);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.Wallpaper);
            this.Controls.Add(this.WallpaperAudio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Wallpaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WallpaperAudio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer Wallpaper;
        private MaterialSkin.Controls.MaterialTextBox2 txt_Password;
        private MaterialSkin.Controls.MaterialTextBox2 txt_Username;
        private MaterialSkin.Controls.MaterialButton btn_Login;
        private MaterialSkin.Controls.MaterialButton btn_Register;
        private AxWMPLib.AxWindowsMediaPlayer WallpaperAudio;
    }
}
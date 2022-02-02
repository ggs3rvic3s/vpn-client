namespace Client
{
    partial class Login
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btn_Login = new MaterialSkin.Controls.MaterialButton();
            this.Wallpaper = new AxWMPLib.AxWindowsMediaPlayer();
            this.txt_Username = new MaterialSkin.Controls.MaterialTextBox();
            this.txt_Password = new MaterialSkin.Controls.MaterialTextBox();
            this.btn_Register = new MaterialSkin.Controls.MaterialButton();
            this.btn_Exit = new MaterialSkin.Controls.MaterialButton();
            this.btn_Mini = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.Wallpaper)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Login
            // 
            this.btn_Login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Login.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Login.Depth = 0;
            this.btn_Login.HighEmphasis = true;
            this.btn_Login.Icon = null;
            this.btn_Login.Location = new System.Drawing.Point(44, 531);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Login.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Login.Size = new System.Drawing.Size(64, 36);
            this.btn_Login.TabIndex = 0;
            this.btn_Login.Text = "Login";
            this.btn_Login.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Login.UseAccentColor = false;
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // Wallpaper
            // 
            this.Wallpaper.Enabled = true;
            this.Wallpaper.Location = new System.Drawing.Point(-3, -3);
            this.Wallpaper.Name = "Wallpaper";
            this.Wallpaper.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Wallpaper.OcxState")));
            this.Wallpaper.Size = new System.Drawing.Size(1070, 651);
            this.Wallpaper.TabIndex = 2;
            // 
            // txt_Username
            // 
            this.txt_Username.AnimateReadOnly = false;
            this.txt_Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Username.Depth = 0;
            this.txt_Username.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Username.Hint = "Username";
            this.txt_Username.LeadingIcon = null;
            this.txt_Username.Location = new System.Drawing.Point(44, 416);
            this.txt_Username.MaxLength = 50;
            this.txt_Username.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Username.Multiline = false;
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(320, 50);
            this.txt_Username.TabIndex = 3;
            this.txt_Username.Text = "";
            this.txt_Username.TrailingIcon = null;
            // 
            // txt_Password
            // 
            this.txt_Password.AnimateReadOnly = false;
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Password.Depth = 0;
            this.txt_Password.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_Password.Hint = "Password";
            this.txt_Password.LeadingIcon = null;
            this.txt_Password.Location = new System.Drawing.Point(44, 472);
            this.txt_Password.MaxLength = 50;
            this.txt_Password.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_Password.Multiline = false;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Password = true;
            this.txt_Password.Size = new System.Drawing.Size(320, 50);
            this.txt_Password.TabIndex = 4;
            this.txt_Password.Text = "";
            this.txt_Password.TrailingIcon = null;
            // 
            // btn_Register
            // 
            this.btn_Register.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Register.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Register.Depth = 0;
            this.btn_Register.HighEmphasis = true;
            this.btn_Register.Icon = null;
            this.btn_Register.Location = new System.Drawing.Point(173, 531);
            this.btn_Register.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Register.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Register.Size = new System.Drawing.Size(89, 36);
            this.btn_Register.TabIndex = 1;
            this.btn_Register.Text = "Register";
            this.btn_Register.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Register.UseAccentColor = false;
            this.btn_Register.UseVisualStyleBackColor = true;
            // 
            // btn_Exit
            // 
            this.btn_Exit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Exit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Exit.Depth = 0;
            this.btn_Exit.HighEmphasis = true;
            this.btn_Exit.Icon = null;
            this.btn_Exit.Location = new System.Drawing.Point(994, 9);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Exit.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Exit.Size = new System.Drawing.Size(64, 36);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "X";
            this.btn_Exit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Exit.UseAccentColor = false;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Mini
            // 
            this.btn_Mini.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Mini.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_Mini.Depth = 0;
            this.btn_Mini.HighEmphasis = true;
            this.btn_Mini.Icon = null;
            this.btn_Mini.Location = new System.Drawing.Point(922, 9);
            this.btn_Mini.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_Mini.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_Mini.Name = "btn_Mini";
            this.btn_Mini.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_Mini.Size = new System.Drawing.Size(64, 36);
            this.btn_Mini.TabIndex = 6;
            this.btn_Mini.Text = "_";
            this.btn_Mini.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_Mini.UseAccentColor = false;
            this.btn_Mini.UseVisualStyleBackColor = true;
            this.btn_Mini.Click += new System.EventHandler(this.btn_Mini_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 576);
            this.Controls.Add(this.btn_Mini);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.Wallpaper);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login - VPN Client by GGS-Network";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Wallpaper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialButton btn_Login;
        private AxWMPLib.AxWindowsMediaPlayer Wallpaper;
        private MaterialSkin.Controls.MaterialTextBox txt_Username;
        private MaterialSkin.Controls.MaterialTextBox txt_Password;
        private MaterialSkin.Controls.MaterialButton btn_Register;
        private MaterialSkin.Controls.MaterialButton btn_Exit;
        private MaterialSkin.Controls.MaterialButton btn_Mini;
    }
}


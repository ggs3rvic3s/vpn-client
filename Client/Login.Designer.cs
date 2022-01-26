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
            this.btn_login = new MetroFramework.Controls.MetroButton();
            this.btn_register = new MetroFramework.Controls.MetroButton();
            this.txtUsername = new MetroFramework.Controls.MetroTextBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.btn_logincache = new MetroFramework.Controls.MetroButton();
            this.Wallpaper = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.Wallpaper)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(38, 453);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(207, 52);
            this.btn_login.TabIndex = 1;
            this.btn_login.Text = "Login";
            this.btn_login.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(251, 453);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(207, 52);
            this.btn_register.TabIndex = 2;
            this.btn_register.Text = "Register";
            this.btn_register.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(38, 393);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PromptText = "Username";
            this.txtUsername.Size = new System.Drawing.Size(420, 24);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(38, 423);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PromptText = "Password";
            this.txtPassword.Size = new System.Drawing.Size(420, 24);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btn_logincache
            // 
            this.btn_logincache.Location = new System.Drawing.Point(38, 511);
            this.btn_logincache.Name = "btn_logincache";
            this.btn_logincache.Size = new System.Drawing.Size(420, 20);
            this.btn_logincache.TabIndex = 5;
            this.btn_logincache.Text = "Login with CacheFiles";
            this.btn_logincache.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_logincache.Click += new System.EventHandler(this.btn_logincache_Click);
            // 
            // Wallpaper
            // 
            this.Wallpaper.Enabled = true;
            this.Wallpaper.Location = new System.Drawing.Point(-1, -1);
            this.Wallpaper.Name = "Wallpaper";
            this.Wallpaper.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Wallpaper.OcxState")));
            this.Wallpaper.Size = new System.Drawing.Size(1087, 612);
            this.Wallpaper.TabIndex = 6;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 547);
            this.Controls.Add(this.btn_logincache);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.Wallpaper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.Enter += new System.EventHandler(this.Login_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.Wallpaper)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton btn_login;
        private MetroFramework.Controls.MetroButton btn_register;
        private MetroFramework.Controls.MetroTextBox txtUsername;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroButton btn_logincache;
        private AxWMPLib.AxWindowsMediaPlayer Wallpaper;
    }
}


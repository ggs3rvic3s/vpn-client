namespace Client
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.SplashPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.SplashPlayerAudio = new AxWMPLib.AxWindowsMediaPlayer();
            this.BackgroundPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.SplashPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplashPlayerAudio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // SplashPlayer
            // 
            this.SplashPlayer.Enabled = true;
            this.SplashPlayer.Location = new System.Drawing.Point(0, 0);
            this.SplashPlayer.Name = "SplashPlayer";
            this.SplashPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("SplashPlayer.OcxState")));
            this.SplashPlayer.Size = new System.Drawing.Size(802, 512);
            this.SplashPlayer.TabIndex = 0;
            this.SplashPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.SplashPlayer_PlayStateChange);
            // 
            // SplashPlayerAudio
            // 
            this.SplashPlayerAudio.Enabled = true;
            this.SplashPlayerAudio.Location = new System.Drawing.Point(350, 120);
            this.SplashPlayerAudio.Name = "SplashPlayerAudio";
            this.SplashPlayerAudio.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("SplashPlayerAudio.OcxState")));
            this.SplashPlayerAudio.Size = new System.Drawing.Size(251, 190);
            this.SplashPlayerAudio.TabIndex = 1;
            // 
            // BackgroundPlayer
            // 
            this.BackgroundPlayer.Enabled = true;
            this.BackgroundPlayer.Location = new System.Drawing.Point(127, 165);
            this.BackgroundPlayer.Name = "BackgroundPlayer";
            this.BackgroundPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("BackgroundPlayer.OcxState")));
            this.BackgroundPlayer.Size = new System.Drawing.Size(153, 122);
            this.BackgroundPlayer.TabIndex = 2;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SplashPlayer);
            this.Controls.Add(this.SplashPlayerAudio);
            this.Controls.Add(this.BackgroundPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.Load += new System.EventHandler(this.SplasgScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SplashPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SplashPlayerAudio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer SplashPlayer;
        private AxWMPLib.AxWindowsMediaPlayer SplashPlayerAudio;
        private AxWMPLib.AxWindowsMediaPlayer BackgroundPlayer;
    }
}


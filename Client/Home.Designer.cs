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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Connect = new MetroFramework.Controls.MetroButton();
            this.btn_Disconnect = new MetroFramework.Controls.MetroButton();
            this.btn_deleteOVPN = new MetroFramework.Controls.MetroButton();
            this.btn_tap6 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btn_ovpngui = new MetroFramework.Controls.MetroButton();
            this.btn_cache = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(758, 406);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Connect
            // 
            this.btn_Connect.Location = new System.Drawing.Point(12, 365);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(163, 29);
            this.btn_Connect.TabIndex = 2;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // btn_Disconnect
            // 
            this.btn_Disconnect.Location = new System.Drawing.Point(12, 365);
            this.btn_Disconnect.Name = "btn_Disconnect";
            this.btn_Disconnect.Size = new System.Drawing.Size(163, 29);
            this.btn_Disconnect.TabIndex = 3;
            this.btn_Disconnect.Text = "Disconnect";
            this.btn_Disconnect.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_Disconnect.Click += new System.EventHandler(this.btn_Disconnect_Click);
            // 
            // btn_deleteOVPN
            // 
            this.btn_deleteOVPN.Location = new System.Drawing.Point(181, 365);
            this.btn_deleteOVPN.Name = "btn_deleteOVPN";
            this.btn_deleteOVPN.Size = new System.Drawing.Size(163, 29);
            this.btn_deleteOVPN.TabIndex = 4;
            this.btn_deleteOVPN.Text = "Delete OVPN Driver";
            this.btn_deleteOVPN.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_deleteOVPN.Click += new System.EventHandler(this.btn_deleteOVPN_Click);
            // 
            // btn_tap6
            // 
            this.btn_tap6.Location = new System.Drawing.Point(11, 60);
            this.btn_tap6.Margin = new System.Windows.Forms.Padding(2);
            this.btn_tap6.Name = "btn_tap6";
            this.btn_tap6.Size = new System.Drawing.Size(222, 29);
            this.btn_tap6.TabIndex = 5;
            this.btn_tap6.Text = "Add TAP6 Virtual Network Adapter";
            this.btn_tap6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_tap6.Click += new System.EventHandler(this.btn_tap6_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 39);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "System:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btn_ovpngui
            // 
            this.btn_ovpngui.Location = new System.Drawing.Point(614, 365);
            this.btn_ovpngui.Name = "btn_ovpngui";
            this.btn_ovpngui.Size = new System.Drawing.Size(132, 29);
            this.btn_ovpngui.TabIndex = 8;
            this.btn_ovpngui.Text = "Open OpenVPN GUI";
            this.btn_ovpngui.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_ovpngui.Click += new System.EventHandler(this.btn_ovpngui_Click);
            // 
            // btn_cache
            // 
            this.btn_cache.Location = new System.Drawing.Point(614, 330);
            this.btn_cache.Name = "btn_cache";
            this.btn_cache.Size = new System.Drawing.Size(132, 29);
            this.btn_cache.TabIndex = 9;
            this.btn_cache.Text = "Delete Cache";
            this.btn_cache.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btn_cache.Click += new System.EventHandler(this.btn_cache_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 406);
            this.Controls.Add(this.btn_cache);
            this.Controls.Add(this.btn_ovpngui);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btn_tap6);
            this.Controls.Add(this.btn_deleteOVPN);
            this.Controls.Add(this.btn_Disconnect);
            this.Controls.Add(this.btn_Connect);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btn_Connect;
        private MetroFramework.Controls.MetroButton btn_Disconnect;
        private MetroFramework.Controls.MetroButton btn_deleteOVPN;
        private MetroFramework.Controls.MetroButton btn_tap6;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btn_ovpngui;
        private MetroFramework.Controls.MetroButton btn_cache;
    }
}
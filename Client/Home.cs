using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Client
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue800, Primary.LightBlue900, Primary.LightBlue500, Accent.LightBlue200, TextShade.BLACK);
        }

        private void Home_Load(object sender, EventArgs e)
        {
            webTimer.Enabled = true;
            webBrowser.Visible = config_cs.config_cs.Client_Client_Browser_Visible;
            webBrowser.Navigate(config_cs.config_cs.Client_Client_Browser_URL);

            DayNews.Text = config_cs.config_cs.Client_Client_DayNews;

            //set profile data
            webBrowserProfile.Navigate(auth_cs.auth_cs.user_profilePicture);
            label_user_id.Text = "ID: " + auth_cs.auth_cs.user_id.ToString();
            label_user_firstname.Text = "First Name: " + auth_cs.auth_cs.user_firstName;
            label_user_lastname.Text = "Last Name: " + auth_cs.auth_cs.user_lastName;
            label_user_username.Text = "Username: " + auth_cs.auth_cs.user_username;
            label_user_email.Text = "Email: " + auth_cs.auth_cs.user_email;
            label_joinedsince.Text = "Member since: " + auth_cs.auth_cs.user_join_time;

            btn_Disconnect.Visible = false;
            btn_Connect.Visible = true;
            Wallpaper.URL = config_cs.config_cs.Video_Wallpaper_URL;
            Wallpaper.settings.volume = config_cs.config_cs.Video_Wallpaper_Volume;
            WallpaperAudio.URL = config_cs.config_cs.Video_Wallpaper_Audio_URL;
            WallpaperAudio.settings.volume = config_cs.config_cs.Video_Wallpaper_Audio_Volume;
            Wallpaper.Ctlcontrols.play();
            WallpaperAudio.Ctlcontrols.play();

            btn_Connect.Text = lang_cs.lang_cs.Lang_Connect;
            btn_Disconnect.Text = lang_cs.lang_cs.Lang_Disconnect;
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            btn_Disconnect.Visible = true;
            btn_Connect.Visible = false;
            vpn_cs.vpn_cs.ovpnProfile();
            vpn_cs.vpn_cs.connect();
        }

        private void btn_Disconnect_Click(object sender, EventArgs e)
        {
            btn_Disconnect.Visible = false;
            btn_Connect.Visible = true;
            vpn_cs.vpn_cs.disconnect();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            vpn_cs.vpn_cs.disconnect();
        }

        private void webTimer_Tick(object sender, EventArgs e)
        {
            config_cs.config_cs.getConfig();
            if ((config_cs.config_cs.Banned == true))
            {
                MessageBox.Show(config_cs.config_cs.BannedReason, $"{lang_cs.lang_cs.Lang_Banned} - VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Error);
                assets_cs.assets_cs.error(false, "");
            }
        }

        private void btn_managed_account_Click(object sender, EventArgs e)
        {
            Process.Start($"https://account.ggs-network.de/login_s.php?session=" + auth_cs.auth_cs.user_session);
        }
    }
}

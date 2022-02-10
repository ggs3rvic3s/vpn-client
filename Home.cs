using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            //config.cs
            chromiumWebBrowser1.Visible = config_cs.config_cs.Client_Client_Browser_Visible;

            DayNews.Text = config_cs.config_cs.Client_Client_DayNews;

            btn_Disconnect.Visible = false;
            btn_Connect.Visible = true;
            Wallpaper.URL = config_cs.config_cs.Video_Wallpaper_URL;
            Wallpaper.settings.volume = config_cs.config_cs.Video_Wallpaper_Volume;
            WallpaperAudio.URL = config_cs.config_cs.Video_Wallpaper_Audio_URL;
            WallpaperAudio.settings.volume = config_cs.config_cs.Video_Wallpaper_Audio_Volume;
            Wallpaper.Ctlcontrols.play();
            WallpaperAudio.Ctlcontrols.play();
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
    }
}

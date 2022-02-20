using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplasgScreen_Load(object sender, EventArgs e)
        {
            SplashPlayer.URL = config_cs.config_cs.Video_Splash_URL;
            SplashPlayer.settings.volume = config_cs.config_cs.Video_Splash_Volume;
            SplashPlayerAudio.URL = config_cs.config_cs.Video_Splash_Audio_URL;
            SplashPlayerAudio.settings.volume = config_cs.config_cs.Video_Splash_Audio_Volume;
            SplashPlayer.Ctlcontrols.play();
            SplashPlayerAudio.Ctlcontrols.play();
        }

        private void SplashPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 8)
            {
                if ((config_cs.config_cs.Banned == true))
                {
                    MessageBox.Show(config_cs.config_cs.BannedReason, $"{lang_cs.lang_cs.Lang_Banned} - VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    assets_cs.assets_cs.error(false, "");
                }
                if ((config_cs.config_cs.Banned == false))
                {
                    SplashPlayer.Ctlcontrols.stop();
                    SplashPlayerAudio.Ctlcontrols.stop();
                    if (( config_cs.config_cs.Background_Player_URL == ""))
                    {}
                    else
                    {
                        BackgroundPlayer.settings.setMode("loop", true);
                        BackgroundPlayer.URL = config_cs.config_cs.Background_Player_URL;
                        BackgroundPlayer.settings.volume = config_cs.config_cs.Background_Player_Volume;
                        BackgroundPlayer.Ctlcontrols.play();
                    }

                    this.Hide();
                    int num = (int)new Login().ShowDialog();
                    this.Close();
                }
            }
        }
    }
}

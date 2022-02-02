using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using config_cs;

namespace Client
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            SplashPlayer.URL = config_cs.config_cs.Video_Splash;
            SplashPlayer.Ctlcontrols.play();
        }

        private void SplashPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 8)
            {
                if ((config_cs.config_cs.Banned == true))
                {
                    MessageBox.Show(config_cs.config_cs.BannedReason, $"{lang_cs.lang_cs.Lang_Banned} - VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if ((config_cs.config_cs.Banned == false))
                {
                    this.Hide();
                    int num = (int)new Login().ShowDialog();
                    this.Close();
                }
            }
        }
    }
}

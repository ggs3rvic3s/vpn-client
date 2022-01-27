using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

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
            try
            {
                var request = (HttpWebRequest)WebRequest.Create("https://assets.ggs-network.de/config.json");

                var response = (HttpWebResponse)request.GetResponse();
                string responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                dynamic responseParse = JsonConvert.DeserializeObject(responseString);
                SplashPlayer.URL = responseParse.Video.Splash;
                SplashPlayer.Ctlcontrols.play();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex, "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SplashPlayer_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 8)
            {
                try
                {
                    var request = (HttpWebRequest)WebRequest.Create("https://assets.ggs-network.de/config.json");

                    var response = (HttpWebResponse)request.GetResponse();
                    string responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                    dynamic responseParse = JsonConvert.DeserializeObject(responseString);
                    bool Banned = responseParse.Client.Banned;
                    if ((Banned == false))
                    {
                        this.Hide();
                        int num = (int)new Login().ShowDialog();
                        this.Close();
                    }
                    if ((Banned == true))
                    {
                        MessageBox.Show("All Clients are banned. Maybe a server problem is avaible. Please show on https//account.ggs-network.de/status.php for more information.", "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        Application.Exit();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR:" + ex, "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

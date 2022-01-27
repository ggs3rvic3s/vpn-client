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
using System.Diagnostics;

namespace Client
{
    public partial class SplashScreen : Form
    {
        string sysUsername = Environment.UserName;
        public SplashScreen()
        {
            InitializeComponent();
        }
        private void SplashScreen_Load(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(@"C:\Program Files\OpenVPN\bin\openvpn.exe") && File.Exists(@"C:\Program Files\OpenVPN\bin\openvpn-gui.exe"))
                {
                    
                }
                else
                {
                    MessageBox.Show("OpenGUI not found. The cient will be installed it!", "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    try
                    {
                        WebClient webClient = new WebClient();
                        webClient.DownloadFile("https://swupdate.openvpn.org/community/releases/OpenVPN-2.5.5-I602-amd64.msi", $@"C:\Users\{sysUsername}\AppData\Local\Temp\ovpn-gui.msi");
                        try
                        {
                            Process.Start($@"C:\Users\{sysUsername}\AppData\Local\Temp\ovpn-gui.msi");
                            Application.Exit();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("ERROR:" + ex, "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch(Exception ex) 
                    {
                        MessageBox.Show("ERROR:" + ex, "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex, "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

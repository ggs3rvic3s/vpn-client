using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordRpcInjection;
using WMPLib;

namespace Client
{
    public partial class Home : Form
    {
        public bool connected;
        string sysUsername = Environment.UserName;
        private DiscordRpc.EventHandlers handlers;
        private DiscordRpc.RichPresence presence;
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            Wallpaper.URL = "https://rr1---sn-h0jelnes.googlevideo.com/videoplayback?expire=1643232548&ei=xGjxYcuGMpq81wLjyqKYBw&ip=216.131.109.161&id=o-ANtqdmtS_jAtfkY1Tn03pbr4_26ULOgwz1MQ735zIwNb&itag=22&source=youtube&requiressl=yes&vprv=1&mime=video%2Fmp4&ns=pfU2eXMefvFsxtNEuw7cSW4G&cnr=14&ratebypass=yes&dur=3610.076&lmt=1589361998976281&fexp=24001373,24007246&c=WEB&txp=5432432&n=Y_UEYoNcOrvTOA&sparams=expire%2Cei%2Cip%2Cid%2Citag%2Csource%2Crequiressl%2Cvprv%2Cmime%2Cns%2Ccnr%2Cratebypass%2Cdur%2Clmt&sig=AOq0QJ8wRAIgY6jWnT0q2DhKqaeSx0wWpyI4NQam-QKRRL7CFlfYvvcCIEHMB0ewplHL1IAKbUwYmV7poSBa3k9p_ZpntrnMRvFC&title=Amazing%20Hologram%20of%20Earth%20%7C%201%20Hour%204K%20Relaxing%20Screensaver!%2060FPS%20for%20Meditation.%20Relax%20music&rm=sn-n02xgoxufvg3-2gbl7e,sn-2gbek76&req_id=301a74cd9f34a3ee&redirect_counter=2&cms_redirect=yes&ipbypass=yes&mh=fk&mip=2a02:8071:3ed5:2f00:f944:f68c:1a1b:bd37&mm=29&mn=sn-h0jelnes&ms=rdu&mt=1643210471&mv=m&mvi=1&pl=45&lsparams=ipbypass,mh,mip,mm,mn,ms,mv,mvi,pl&lsig=AG3C_xAwRgIhAOwW5fI-uovcoWwbw9btcyzlDDeVHfCeHPUPSZl0R21jAiEA-NXA8pkTf8Ev-QLiNNOtNviBR5SxSV3_eWEFU-_-Rgw%3D";
            Wallpaper.Ctlcontrols.play();
            btn_deleteOVPN.Visible = false;
            btn_Connect.Visible = true;
            btn_Disconnect.Visible = false;
            if (File.Exists($@"AddTAP6.bat") && File.Exists($@"TAP-control.bat"))
            {

            }
            else
            {
                try
                {

                    WebClient webClient = new WebClient();
                    webClient.DownloadFile("https://assets.ggs-network.de/download.php?path=TAP-control.exe", $@"TAP-control.bat");
                    webClient.DownloadFile("https://assets.ggs-network.de/download.php?path=AddTAP6.bat", $@"AddTAP6.bat");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR:" + ex, "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (File.Exists(@"C:\Program Files (x86)\OVPN-Driver\OpenVPN\bin\openvpn.exe"))
            {
                btn_deleteOVPN.Visible = true;
                btn_Connect.Enabled = true;
                if(File.Exists($@"OVPN-Control.bat") && File.Exists($@"killOVPN.bat"))
                {
                   
                }
                else
                {
                    try
                    {

                        WebClient webClient = new WebClient();
                        webClient.DownloadFile("https://assets.ggs-network.de/download.php?path=OVPN-Control.bat", $@"OVPN-Control.bat");
                        webClient.DownloadFile("https://assets.ggs-network.de/download.php?path=killOVPN.bat", $@"killOVPN.bat");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR:" + ex, "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                btn_Connect.Enabled = false;
                try
                {
                    MessageBox.Show("OpenVPN Driver not found!", "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    try
                    {
                        WebClient webClient = new WebClient();
                        webClient.DownloadFile("https://assets.ggs-network.de/download.php?path=ovpn-driver.exe", $@"C:\Users\{sysUsername}\AppData\Local\Temp\ovpn-driver.exe");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR:" + ex, "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    try
                    {
                        Process.Start($@"C:\Users\{sysUsername}\AppData\Local\Temp\ovpn-driver.exe");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR:" + ex, "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR:" + ex, "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("854090411140579339", ref this.handlers, true, null);
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("854090411140579339", ref this.handlers, true, null);
            this.presence.details = "Home - VPN Client";
            this.presence.largeImageKey = "1024x1024";
            this.presence.largeImageText = "VPN Client by GGS-Network";
            DiscordRpc.UpdatePresence(ref this.presence);
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists($@"C:\Users\{sysUsername}\AppData\Roaming\GGS-Network\client.ovpn"))
                {

                }
                else
                {
                    try
                    {
                        WebClient webClient = new WebClient();
                        webClient.DownloadFile("https://assets.ggs-network.de/download.php?path=ggs-networkde.ovpn", $@"C:\Users\{sysUsername}\AppData\Roaming\GGS-Network\client.ovpn");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR:" + ex, "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                File.Delete($@"{Directory.GetCurrentDirectory()}\client.ovpn");
                File.Move($@"C:\Users\{sysUsername}\AppData\Roaming\GGS-Network\client.ovpn", $@"{Directory.GetCurrentDirectory()}\client.ovpn");
                connected = true;
                btn_Connect.Visible = false;
                btn_Disconnect.Visible = true;
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.FileName = @"C:\Program Files (x86)\OVPN-Driver\OpenVPN\bin\openvpn.exe";
                startInfo.Arguments = "--config client.ovpn";
                startInfo.Verb = "runas";
                process.StartInfo = startInfo;
                process.Start();
                this.presence.details = "Home - VPN Client";
                this.presence.state = "Connected to GERMANY SERVER";
                this.presence.largeImageKey = "1024x1024";
                this.presence.largeImageText = "VPN Client by GGS-Network";
                this.presence.startTimestamp = 1;
                this.presence.partySize = 1;
                this.presence.partyMax = 1;
                this.presence.partyId = "ae488379-351d-4a4f-ad32-2b9b01c91657";
                this.presence.joinSecret = "MTI4NzM0OjFpMmhuZToxMjMxMjM= ";
                DiscordRpc.UpdatePresence(ref this.presence);
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR:" + ex, "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Disconnect_Click(object sender, EventArgs e)
        {
            try
            {
                connected = false;
                btn_Connect.Visible = true;
                btn_Disconnect.Visible = false;
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.FileName = @"OVPN-Control.bat";
                process.StartInfo = startInfo;
                process.Start();
                File.Delete($@"{Directory.GetCurrentDirectory()}\client.ovpn");
                this.presence.details = "Home - VPN Client";
                this.presence.state = "Disconnected";
                this.presence.largeImageKey = "1024x1024";
                this.presence.largeImageText = "VPN Client by GGS-Network";
                DiscordRpc.UpdatePresence(ref this.presence);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex, "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_deleteOVPN_Click(object sender, EventArgs e)
        {
            btn_deleteOVPN.Visible = false;
            btn_Connect.Enabled = false;
            try
            {
                Process.Start(@"C:\Program Files (x86)\OVPN-Driver\Uninstall OpenVPN Driver by GGS-Network.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex, "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_tap6_Click(object sender, EventArgs e)
        {
            try
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.FileName = @"TAP-control.bat";
                process.StartInfo = startInfo;
                process.Start();
                MessageBox.Show("TAP6 Virtual Network Adapter was succesful add!", "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR:" + ex, "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_ovpngui_Click(object sender, EventArgs e)
        {
            try
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.FileName = @"C:\Program Files (x86)\OVPN-Driver\OpenVPN\bin\openvpn-gui.exe";
                startInfo.Verb = "runas";
                process.StartInfo = startInfo;
                process.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex, "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cache_Click(object sender, EventArgs e)
        {
            if(File.Exists($@"C:\Users\{sysUsername}\AppData\Roaming\GGS-Network\account.json"))
            {
                MessageBox.Show("Cache deleted!", "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Information);
                File.Delete($@"C:\Users\{sysUsername}\AppData\Roaming\GGS-Network\account.json");
            }
            else
            {
                MessageBox.Show("Cache not avaible!", "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("The client will be close the VPN Connection beacuse you close the client!", "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                connected = false;
                btn_Connect.Visible = true;
                btn_Disconnect.Visible = false;
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.FileName = @"OVPN-Control.bat";
                process.StartInfo = startInfo;
                process.Start();
                File.Delete($@"{Directory.GetCurrentDirectory()}\client.ovpn");
                this.presence.details = "Home - VPN Client";
                this.presence.state = "Disconnected";
                this.presence.largeImageKey = "1024x1024";
                this.presence.largeImageText = "VPN Client by GGS-Network";
                DiscordRpc.UpdatePresence(ref this.presence);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex, "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

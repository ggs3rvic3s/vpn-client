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
            btn_deleteOVPN.Visible = false;
            btn_Connect.Visible = true;
            btn_Disconnect.Visible = false;
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
                startInfo.FileName = @"C:\Program Files (x86)\OVPN-Driver\OpenVPN\bin\tapctl.exe";
                startInfo.Arguments = "create --hwid root\tap0901";
                startInfo.Verb = "runas";
                process.StartInfo = startInfo;
                process.Start();
                MessageBox.Show("TAP6 Virtual Network Adapter was succesful add!", "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR:" + ex, "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_winTUN_Click(object sender, EventArgs e)
        {
            try
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.FileName = @"C:\Program Files (x86)\OVPN-Driver\OpenVPN\bin\tapctl.exe";
                startInfo.Arguments = "create --hwid wintun";
                startInfo.Verb = "runas";
                process.StartInfo = startInfo;
                process.Start();
                MessageBox.Show("WinTUN Network Tunnel was succesful add!", "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
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
    }
}

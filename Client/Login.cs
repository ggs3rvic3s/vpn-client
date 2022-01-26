using Newtonsoft.Json;
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
    public partial class Login : Form
    {
        string username;
        string password;
        string sysUsername = Environment.UserName;
        private DiscordRpc.EventHandlers handlers;
        private DiscordRpc.RichPresence presence;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Wallpaper.URL = "https://rr1---sn-h0jelnes.googlevideo.com/videoplayback?expire=1643232548&ei=xGjxYcuGMpq81wLjyqKYBw&ip=216.131.109.161&id=o-ANtqdmtS_jAtfkY1Tn03pbr4_26ULOgwz1MQ735zIwNb&itag=22&source=youtube&requiressl=yes&vprv=1&mime=video%2Fmp4&ns=pfU2eXMefvFsxtNEuw7cSW4G&cnr=14&ratebypass=yes&dur=3610.076&lmt=1589361998976281&fexp=24001373,24007246&c=WEB&txp=5432432&n=Y_UEYoNcOrvTOA&sparams=expire%2Cei%2Cip%2Cid%2Citag%2Csource%2Crequiressl%2Cvprv%2Cmime%2Cns%2Ccnr%2Cratebypass%2Cdur%2Clmt&sig=AOq0QJ8wRAIgY6jWnT0q2DhKqaeSx0wWpyI4NQam-QKRRL7CFlfYvvcCIEHMB0ewplHL1IAKbUwYmV7poSBa3k9p_ZpntrnMRvFC&title=Amazing%20Hologram%20of%20Earth%20%7C%201%20Hour%204K%20Relaxing%20Screensaver!%2060FPS%20for%20Meditation.%20Relax%20music&rm=sn-n02xgoxufvg3-2gbl7e,sn-2gbek76&req_id=301a74cd9f34a3ee&redirect_counter=2&cms_redirect=yes&ipbypass=yes&mh=fk&mip=2a02:8071:3ed5:2f00:f944:f68c:1a1b:bd37&mm=29&mn=sn-h0jelnes&ms=rdu&mt=1643210471&mv=m&mvi=1&pl=45&lsparams=ipbypass,mh,mip,mm,mn,ms,mv,mvi,pl&lsig=AG3C_xAwRgIhAOwW5fI-uovcoWwbw9btcyzlDDeVHfCeHPUPSZl0R21jAiEA-NXA8pkTf8Ev-QLiNNOtNviBR5SxSV3_eWEFU-_-Rgw%3D";
            Wallpaper.Ctlcontrols.play();
            try
            {
                Directory.CreateDirectory($@"C:\Users\{sysUsername}\AppData\Roaming\GGS-Network");
            }
            catch 
            {
            }
            if (File.Exists($@"C:\Users\{sysUsername}\AppData\Roaming\GGS-Network\account.json"))
            {
                string cache = File.ReadAllText($@"C:\Users\{sysUsername}\AppData\Roaming\GGS-Network\account.json");
                dynamic cacheParse = JsonConvert.DeserializeObject(cache);

                txtUsername.Text = cacheParse.username;
                btn_logincache.Visible = false;
            }
            else
            {
                btn_logincache.Visible = false;
            }
            if(File.Exists("discord-rpc-w32.dll"))
            {
                this.handlers = default(DiscordRpc.EventHandlers);
                DiscordRpc.Initialize("854090411140579339", ref this.handlers, true, null);
                this.handlers = default(DiscordRpc.EventHandlers);
                DiscordRpc.Initialize("854090411140579339", ref this.handlers, true, null);
                this.presence.details = "Login - VPN Client";
                this.presence.largeImageKey = "1024x1024";
                this.presence.largeImageText = "VPN Client by GGS-Network";
                DiscordRpc.UpdatePresence(ref this.presence);
            }
            else
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFile("https://assets.ggs-network.de/download.php?path=discord-rpc-w32.dll", "discord-rpc-w32.dll");
                    this.handlers = default(DiscordRpc.EventHandlers);
                    DiscordRpc.Initialize("854090411140579339", ref this.handlers, true, null);
                    this.handlers = default(DiscordRpc.EventHandlers);
                    DiscordRpc.Initialize("854090411140579339", ref this.handlers, true, null);
                    this.presence.details = "Login - VPN Client";
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
        private void btn_login_Click(object sender, EventArgs e)
        {
            username = txtUsername.Text;
            password = txtPassword.Text;


            var request = (HttpWebRequest)WebRequest.Create("https://auth.ggs-network.de/auth/login.php");

            var postData = "username=" + Uri.EscapeDataString(username);
            postData += "&password=" + Uri.EscapeDataString(password);
            var data = Encoding.ASCII.GetBytes(postData);

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }
            try
            {
                var response = (HttpWebResponse)request.GetResponse();

                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                dynamic responseParse = JsonConvert.DeserializeObject(responseString);

                if (responseParse.success == true)
                {   
                    string[] account = { "{ username: '" + username + "',", "password: '" + "" + "' }" };
                    File.WriteAllLines($@"C:\Users\{sysUsername}\AppData\Roaming\GGS-Network\account.json", account);
                    MessageBox.Show("Successful logged in!", "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Wallpaper.Ctlcontrols.stop();
                    this.Hide();
                    int num = (int)new Home().ShowDialog();
                    this.Close();
                }
                if (responseParse.success == false)
                {
                    MessageBox.Show($"{responseParse.message}", "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex, "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            Process.Start("https://account.ggs-network.de/register.php");
        }

        private void Login_Enter(object sender, EventArgs e)
        {
        }

        private void btn_logincache_Click(object sender, EventArgs e)
        {
            if(File.Exists($@"C:\Users\{sysUsername}\AppData\Roaming\GGS-Network\account.json"))
            {
                string cache = File.ReadAllText($@"C:\Users\{sysUsername}\AppData\Roaming\GGS-Network\account.json");
                dynamic cacheParse = JsonConvert.DeserializeObject(cache);

                string username = cacheParse.username;
                string password = cacheParse.password;

                var request = (HttpWebRequest)WebRequest.Create("https://auth.ggs-network.de/auth/login.php");

                var postData = "username=" + Uri.EscapeDataString(username);
                postData += "&password=" + Uri.EscapeDataString(password);
                var data = Encoding.ASCII.GetBytes(postData);

                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = data.Length;

                using (var stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }
                try
                {
                    var response = (HttpWebResponse)request.GetResponse();

                    var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                    dynamic responseParse = JsonConvert.DeserializeObject(responseString);

                    if (responseParse.success == true)
                    {
                        MessageBox.Show("Successful logged in!", "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        int num = (int)new Home().ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(responseParse.message, "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR:" + ex, "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("CACHE ERROR", "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

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

using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Newtonsoft.Json;
using DiscordRpcInjection;

namespace Client
{
    public partial class Login : MaterialForm
    {
        private DiscordRpc.RichPresence presence;
        private DiscordRpc.EventHandlers handlers;
        public Login()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue800, Primary.LightBlue900, Primary.LightBlue500, Accent.LightBlue200, TextShade.BLACK);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize("854090411140579339", ref this.handlers, true, null);
            this.presence.state = "Login";
            this.presence.largeImageKey = "1024x1024";
            this.presence.largeImageText = "VPN Client by GGS-Network";
            DiscordRpc.UpdatePresence(ref this.presence);

            //Set Lang
            btn_Login.Text = lang_cs.lang_cs.Lang_Login;
            btn_Register.Text = lang_cs.lang_cs.Lang_Register;

            //Set Wallpaper Player
            Wallpaper.URL = config_cs.config_cs.Video_Wallpaper;
            Wallpaper.Ctlcontrols.play();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            auth_cs.auth_cs.Username = txt_Username.Text;
            auth_cs.auth_cs.Password = txt_Password.Text;
            
            var request = (HttpWebRequest)WebRequest.Create("https://auth.ggs-network.de/auth/login.php");

            var postData = "username=" + Uri.EscapeDataString(auth_cs.auth_cs.Username);
            postData += "&password=" + Uri.EscapeDataString(auth_cs.auth_cs.Password);
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

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.Exit();
        }

        private void btn_Mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

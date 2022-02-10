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
using System.Diagnostics;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Client
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue800, Primary.LightBlue900, Primary.LightBlue500, Accent.LightBlue200, TextShade.BLACK);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Wallpaper.URL = config_cs.config_cs.Video_Wallpaper_URL;
            Wallpaper.settings.volume = config_cs.config_cs.Video_Wallpaper_Volume;
            WallpaperAudio.URL = config_cs.config_cs.Video_Wallpaper_Audio_URL;
            WallpaperAudio.settings.volume = config_cs.config_cs.Video_Wallpaper_Audio_Volume;
            Wallpaper.Ctlcontrols.play();
            WallpaperAudio.Ctlcontrols.play();
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
                    auth_cs.auth_cs.saveCredentials();
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

        private void btn_Register_Click(object sender, EventArgs e)
        {
            Process.Start("https://account.ggs-network.de/register.php");
        }
    }
}

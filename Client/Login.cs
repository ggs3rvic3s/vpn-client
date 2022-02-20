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

            btn_Login.Text = lang_cs.lang_cs.Lang_Login;
            btn_Register.Text = lang_cs.lang_cs.Lang_Register;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            var request = (HttpWebRequest)WebRequest.Create("https://auth.ggs-network.de/auth/login");

            var postData = "mail=" + Uri.EscapeDataString(txt_Email.Text);
            postData += "&password=" + Uri.EscapeDataString(txt_Password.Text);
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
                dynamic outputJson = JsonConvert.DeserializeObject(responseString);

                if (outputJson.success == true)
                {
                    auth_cs.auth_cs.token = outputJson.token;
                    auth_cs.auth_cs.user_id = outputJson.user.id;
                    auth_cs.auth_cs.user_firstName = outputJson.user.firstName;
                    auth_cs.auth_cs.user_lastName = outputJson.user.lastName;
                    auth_cs.auth_cs.user_profilePicture = outputJson.user.profilePicture;
                    auth_cs.auth_cs.user_username = outputJson.user.username;
                    auth_cs.auth_cs.user_email = outputJson.user.email;
                    auth_cs.auth_cs.user_password = outputJson.user.password;
                    auth_cs.auth_cs.user_session = outputJson.user.session;
                    auth_cs.auth_cs.user_admin = outputJson.user.admin;
                    auth_cs.auth_cs.user_verified = outputJson.user.verified;
                    auth_cs.auth_cs.user_join_time = outputJson.user.joinned_time;

                    MessageBox.Show($"{outputJson.msg}", "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Wallpaper.Ctlcontrols.stop();
                    this.Hide();
                    int num = (int)new Home().ShowDialog();
                    this.Close();
                }
                if (outputJson.success == false)
                {
                    MessageBox.Show($"{outputJson.msg}", "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Stop);
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

//External NuGet
using Newtonsoft.Json;
using BCrypt.Net;

//System
using System;
using System.Text;
using System.IO;
using System.Net;
using System.Windows.Forms;


namespace auth_cs
{
    internal class auth_cs
    {
        public static string EmailTXT;
        public static string PasswordTXT;

        //Put json ouput in strings
        public static string token;
        public static int user_id;
        public static string user_firstName;
        public static string user_lastName;
        public static string user_profilePicture;
        public static string user_username;
        public static string user_email;
        public static string user_password;
        public static string user_session;
        public static int user_admin;
        public static int user_verified;
        public static int user_vpn_enable;
        public static string user_join_time;

        public static bool verfiedCredentials = false;

        public static int failLoad;
        public static void reloadProfile()
        {
            var request = (HttpWebRequest)WebRequest.Create("https://auth.ggs-network.de/auth/login");

            var postData = "mail=" + Uri.EscapeDataString(auth_cs.EmailTXT);
            postData += "&password=" + Uri.EscapeDataString(auth_cs.PasswordTXT);
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
                    auth_cs.token = outputJson.token;
                    auth_cs.user_id = outputJson.user.id;
                    auth_cs.user_firstName = outputJson.user.firstName;
                    auth_cs.user_lastName = outputJson.user.lastName;
                    auth_cs.user_profilePicture = outputJson.user.profilePicture;
                    auth_cs.user_username = outputJson.user.username;
                    auth_cs.user_email = outputJson.user.email;
                    auth_cs.user_password = outputJson.user.password;
                    auth_cs.user_session = outputJson.user.session;
                    auth_cs.user_admin = outputJson.user.admin;
                    auth_cs.user_verified = outputJson.user.verified;
                    auth_cs.user_vpn_enable = outputJson.user.vpn_enable;
                    auth_cs.user_join_time = outputJson.user.joinned_time;

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
    }
}

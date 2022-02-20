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
        public static string user_join_time;

        public static bool verfiedCredentials = false;

        public static int failLoad;
        public static void reloadProfile()
        {
            var request = (HttpWebRequest)WebRequest.Create("https://auth.ggs-network.de/auth/get-user");

            var postData = "token=" + Uri.EscapeDataString(auth_cs.token);
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
                    auth_cs.user_id = outputJson.data.id;
                    auth_cs.user_firstName = outputJson.data.firstName;
                    auth_cs.user_lastName = outputJson.data.lastName;
                    auth_cs.user_profilePicture = outputJson.data.profilePicture;
                    auth_cs.user_username = outputJson.data.username;
                    auth_cs.user_email = outputJson.data.email;
                    auth_cs.user_password = outputJson.data.password;
                    auth_cs.user_session = outputJson.data.session;
                    auth_cs.user_admin = outputJson.data.admin;
                    auth_cs.user_verified = outputJson.data.verified;
                    auth_cs.user_join_time = outputJson.data.joinned_time;
                }
                if (outputJson.success == false)
                {
                    var request2 = (HttpWebRequest)WebRequest.Create("https://auth.ggs-network.de/auth/login");

                    var postData2 = "mail=" + Uri.EscapeDataString(auth_cs.user_email);
                    postData2 += "&password=" + Uri.EscapeDataString(auth_cs.user_password);
                    var data2 = Encoding.ASCII.GetBytes(postData2);

                    request2.Method = "POST";
                    request2.ContentType = "application/x-www-form-urlencoded";
                    request2.ContentLength = data2.Length;

                    using (var stream2 = request2.GetRequestStream())
                    {
                        stream2.Write(data2, 0, data2.Length);
                    }
                    try
                    {
                        var response2 = (HttpWebResponse)request.GetResponse();

                        var responseString2 = new StreamReader(response.GetResponseStream()).ReadToEnd();
                        dynamic outputJson2 = JsonConvert.DeserializeObject(responseString2);

                        if (outputJson.success == true)
                        {
                            auth_cs.token = outputJson2.token;
                        }
                        if (outputJson.success == false)
                        {
                            MessageBox.Show($"{outputJson.msg}", "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR:" + ex.Message, "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex.Message, "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

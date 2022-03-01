//External NuGet
using Newtonsoft.Json;
using BCrypt.Net;

//System
using System;
using System.Text;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace handler_cs
{
    internal class handler_cs
    {
        // change firstname and lastname
        public static void changeName(string firstname, string lastname)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://account.ggs-network.de/ajax/request/account/change_name.php");
            request.CookieContainer = new CookieContainer();
            request.CookieContainer.Add(new Cookie("user_session", $"{auth_cs.auth_cs.user_session}", "/", "account.ggs-network.de"));
            var postData = "firstName=" + Uri.EscapeDataString(firstname);
            postData += "&lastName=" + Uri.EscapeDataString(lastname);
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
                    MessageBox.Show($"{outputJson.message}", "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                if (outputJson.success == false)
                {
                    MessageBox.Show($"{outputJson.message}", "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex, "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // change password
        public static void changePassord(string cr_password, string nw_password)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://account.ggs-network.de/ajax/request/account/change_password.php");
            request.CookieContainer = new CookieContainer();
            request.CookieContainer.Add(new Cookie("user_session", $"{auth_cs.auth_cs.user_session}", "/", "account.ggs-network.de"));
            var postData = "cr_password=" + Uri.EscapeDataString(cr_password);
            postData += "&nw_password=" + Uri.EscapeDataString(nw_password);
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
                    MessageBox.Show($"{outputJson.message}", "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                if (outputJson.success == false)
                {
                    MessageBox.Show($"{outputJson.message}", "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex, "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

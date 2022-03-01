//External NuGet
using Newtonsoft.Json;
using BCrypt.Net;

//System
using System;
using System.Text;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;

namespace vpn_cs
{
    internal class vpn_cs
    {
        public static void connect()
        {
            try
            {
                File.Move($@"{AppData_cs.AppData_cs.AppDataPath}\client.ovpn", $@"{config_cs.config_cs.sysPath}\client.ovpn");
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.FileName = @"C:\Program Files (x86)\OVPN-Driver\OpenVPN\bin\openvpn.exe";
                startInfo.Arguments = "--config client.ovpn";
                startInfo.Verb = "runas";
                process.StartInfo = startInfo;
                process.Start();
                Thread.Sleep(200);
                try
                {
                    File.Delete($@"{config_cs.config_cs.sysPath}\client.ovpn");
                    File.Delete($@"{AppData_cs.AppData_cs.AppDataPath}\client.ovpn");
                }
                catch (Exception ex)
                { 

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex, "VPN Client by GGS-Network - vpn_cs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void disconnect()
        {
            try
            {
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.FileName = $@"OVPN-Control.bat";
                process.StartInfo = startInfo;
                process.Start();
                try
                {
                    File.Delete($@"{config_cs.config_cs.sysPath}\client.ovpn");
                    File.Delete($@"{AppData_cs.AppData_cs.AppDataPath}\client.ovpn");
                }
                catch (Exception ex)
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex, "VPN Client by GGS-Network - vpn_cs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void ovpnProfile()
        {
            if (auth_cs.auth_cs.user_vpn_enable == 1)
            {
                try
                {
                    var request = (HttpWebRequest)WebRequest.Create("https://auth.ggs-network.de/auth/ovpn");

                    var postData = "mail=" + Uri.EscapeDataString(auth_cs.auth_cs.EmailTXT);
                    postData += "&password=" + Uri.EscapeDataString(auth_cs.auth_cs.PasswordTXT);
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

                        var responseString = new StreamReader(response.GetResponseStream());
                        string ovpnFile = responseString.ReadToEnd();
                        responseString.Close();

                        try
                        {
                            File.Delete($@"{AppData_cs.AppData_cs.AppDataPath}\client.ovpn");
                        }
                        catch (Exception ex)
                        {

                        }
                        var sw = new StreamWriter($@"{AppData_cs.AppData_cs.AppDataPath}\client.ovpn", false);
                        sw.Write(ovpnFile);
                        sw.Flush();
                        sw.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR:" + ex, "VPN Client by GGS-Network - vpn_cs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR:" + ex, "VPN Client by GGS-Network - vpn_cs", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"Please generate a VPN Profile! Home => Settings => Generate VPN Profile", "VPN Client by GGS-Network - auth_cs", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        public static void genProfile()
        {
            var request = (HttpWebRequest)WebRequest.Create("https://auth.ggs-network.de/auth/create");

            var postData = "mail=" + Uri.EscapeDataString(auth_cs.auth_cs.EmailTXT);
            postData += "&password=" + Uri.EscapeDataString(auth_cs.auth_cs.PasswordTXT);
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
                    MessageBox.Show($"VPN Profile successful generated!", "VPN Client by GGS-Network - auth_cs", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (outputJson.success == false)
                {
                    MessageBox.Show($"{outputJson.msg}", "VPN Client by GGS-Network - auth_cs", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex, "VPN Client by GGS-Network - vpn_cs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

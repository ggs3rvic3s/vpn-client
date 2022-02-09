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
        public static string Email;
        public static string Username;
        public static string Password;
        public static string hashedPassword;

        // only for reading Hash
        public static string Password_For_Hash;
        public static string hashedPassword_For_Hash;

        public static bool verfiedCredentials = false;
        public static void saveCredentials()
        {
            string[] CredentialsStringLines = { "{ 'username': " + $"'{auth_cs.Username}'" + ",", "'password': " + $"'{auth_cs.hashedPassword}'" + ",", "'hashPassword': " + $"'{auth_cs.Password_For_Hash}'" + ",", "'HashRate': " + $"'{config_cs.config_cs.HashRate}'" };

            try
            {
                var request = (HttpWebRequest)WebRequest.Create("https://auth.ggs-network.de/auth/login.php");

                var postData = "username=" + Uri.EscapeDataString(Username);
                postData += "&password=" + Uri.EscapeDataString(Password);
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
                        if ((config_cs.config_cs.HashRate == "SHA384"))
                        {
                            auth_cs.hashedPassword = BCrypt.Net.BCrypt.EnhancedHashPassword(auth_cs.Password, hashType: HashType.SHA384);
                            auth_cs.hashedPassword_For_Hash = BCrypt.Net.BCrypt.EnhancedHashPassword(auth_cs.Password_For_Hash, hashType: HashType.SHA384);
                            File.WriteAllLines($@"C:\Users\{config_cs.config_cs.sysUsername}\AppData\Roaming\GGS-Network\account.json", CredentialsStringLines);
                        }

                        if ((config_cs.config_cs.HashRate == "SHA512"))
                        {
                            auth_cs.hashedPassword = BCrypt.Net.BCrypt.EnhancedHashPassword(auth_cs.Password, hashType: HashType.SHA512);
                            auth_cs.hashedPassword_For_Hash = BCrypt.Net.BCrypt.EnhancedHashPassword(auth_cs.Password_For_Hash, hashType: HashType.SHA512);
                            File.WriteAllLines($@"C:\Users\{config_cs.config_cs.sysUsername}\AppData\Roaming\GGS-Network\account.json", CredentialsStringLines);
                        }
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
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex, "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void readCredentials()
        {
            string CredentialsStringLines = File.ReadAllText($@"C:\Users\{config_cs.config_cs.sysUsername}\AppData\Roaming\GGS-Network\account.json");
            dynamic CredentialsStringLinesParse = JsonConvert.DeserializeObject(CredentialsStringLines);

            if ((CredentialsStringLinesParse.HashRate == "SHA384"))
            {
                string validateHashPassword = BCrypt.Net.BCrypt.EnhancedVerify(auth_cs.Password_For_Hash, CredentialsStringLinesParse.hashPassword, hashType: HashType.SHA384);
                string validatePassword = BCrypt.Net.BCrypt.EnhancedVerify(auth_cs.Password, CredentialsStringLinesParse.pasword, hashType: HashType.SHA384);

                if ((hashedPassword == validateHashPassword))
                {
                    var request = (HttpWebRequest)WebRequest.Create("https://auth.ggs-network.de/auth/login.php");

                    var postData = "username=" + Uri.EscapeDataString(CredentialsStringLinesParse.username);
                    postData += "&password=" + Uri.EscapeDataString(validatePassword);
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
                            auth_cs.verfiedCredentials = true;
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
            }

            if ((CredentialsStringLinesParse.HashRate == "SHA512"))
            {
                string validateHashPassword = BCrypt.Net.BCrypt.EnhancedVerify(auth_cs.Password_For_Hash, CredentialsStringLinesParse.hashPassword, hashType: HashType.SHA512);
                string validatePassword = BCrypt.Net.BCrypt.EnhancedVerify(auth_cs.Password, CredentialsStringLinesParse.pasword, hashType: HashType.SHA512);

                if ((hashedPassword == validateHashPassword))
                {
                    var request = (HttpWebRequest)WebRequest.Create("https://auth.ggs-network.de/auth/login.php");

                    var postData = "username=" + Uri.EscapeDataString(CredentialsStringLinesParse.username);
                    postData += "&password=" + Uri.EscapeDataString(validatePassword);
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
                            auth_cs.verfiedCredentials = true;
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
            }
        }
    }
}

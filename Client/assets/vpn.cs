//System
using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace vpn_cs
{
    internal class vpn_cs
    {
        static string first;
        static string second;

        static string fullPath;
        public static void connect()
        {
            try
            {
                File.Move($@"{vpn_cs.fullPath}\client.ovpn", $@"{config_cs.config_cs.sysPath}\client.ovpn");
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
                    Directory.Delete($@"C:\Users\{config_cs.config_cs.sysUsername}\AppData\Local\Temp\{first}");
                    Directory.Delete($@"C:\Users\{config_cs.config_cs.sysUsername}\AppData\Local\Temp\{first}\{second}");

                    File.Delete($@"{config_cs.config_cs.sysPath}\client.ovpn");
                    File.Delete($@"{fullPath}\client.ovpn");
                }
                catch (Exception ex)
                { }
                vpn_cs.fullPath = "";
            }
            catch (Exception ex)
            {
                assets_cs.assets_cs.error(false, ex.Message);
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
            }
            catch (Exception ex)
            {
                assets_cs.assets_cs.error(false, ex.Message);
            }
        }
        public static void ovpnProfile()
        {
            first = createPath(7);
            second = createPath(7);
            fullPath = $@"C:\Users\{config_cs.config_cs.sysUsername}\AppData\Local\Temp\{first}\{second}";
            MessageBox.Show($"{fullPath}");
            try
            {
                Directory.CreateDirectory($@"C:\Users\{config_cs.config_cs.sysUsername}\AppData\Local\Temp\{first}");
                Directory.CreateDirectory($@"C:\Users\{config_cs.config_cs.sysUsername}\AppData\Local\Temp\{first}\{second}");
                try
                {
                    config_cs.config_cs.webClient.DownloadFile("https://assets.ggs-network.de/download.php?path=ggs-networkde.ovpn", $@"{fullPath}\client.ovpn");
                }
                catch (Exception ex)
                {
                    assets_cs.assets_cs.error(false, ex.Message);
                }
            }
            catch(Exception ex)
            {
                assets_cs.assets_cs.error(false, ex.Message);
            }
        }
        public static string createPath(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }
    }
}

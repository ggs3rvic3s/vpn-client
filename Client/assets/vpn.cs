using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace vpn_cs
{
    internal class vpn_cs
    {
        public static void connect()
        {
            try
            {
                if (File.Exists($@"C:\Users\{config_cs.config_cs.sysUsername}\AppData\Roaming\GGS-Network\client.ovpn"))
                {

                }
                else
                {
                    try
                    {
                        config_cs.config_cs.webClient.DownloadFile("https://assets.ggs-network.de/download.php?path=ggs-networkde.ovpn", $@"C:\Users\{config_cs.config_cs.sysUsername}\AppData\Roaming\GGS-Network\client.ovpn");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR:" + ex, "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                File.Delete($@"{config_cs.config_cs.sysPath}\client.ovpn");
                File.Move($@"C:\Users\{config_cs.config_cs.sysUsername}\AppData\Roaming\GGS-Network\client.ovpn", $@"{config_cs.config_cs.sysPath}\client.ovpn");
                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.WindowStyle = ProcessWindowStyle.Hidden;
                startInfo.FileName = @"C:\Program Files (x86)\OVPN-Driver\OpenVPN\bin\openvpn.exe";
                startInfo.Arguments = "--config client.ovpn";
                startInfo.Verb = "runas";
                process.StartInfo = startInfo;
                process.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex, "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                File.Delete($@"{config_cs.config_cs.sysPath}\client.ovpn");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR:" + ex, "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

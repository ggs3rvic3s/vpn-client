//System
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace AppData_cs
{
    internal class AppData_cs
    {
        public static string AppDataPath = $@"C:\Users\{config_cs.config_cs.sysUsername}\AppData\Roaming\GGS-Network";
        public static void checkAppData()
        {

        }
        public static void checkModules()
        {
            try
            {
                config_cs.config_cs.webClient.DownloadFile("https://assets.ggs-network.de/download.php?path=discord-rpc-w32.dll", "discord-rpc-w32.dll");
            }
            catch (Exception ex)
            {

            }
            try
            {
                Directory.CreateDirectory(AppData_cs.AppDataPath);
                Directory.CreateDirectory($@"{AppData_cs.AppDataPath}\Modules");
            }
            catch (Exception ex)
            {

            }
            if (File.Exists($@"AddTAP6.bat") && File.Exists($@"TAP-control.bat"))
            {

            }
            else
            {
                try
                {
                    config_cs.config_cs.webClient.DownloadFile("https://assets.ggs-network.de/download.php?path=TAP-control.bat", $@"TAP-control.bat");
                    config_cs.config_cs.webClient.DownloadFile("https://assets.ggs-network.de/download.php?path=AddTAP6.bat", $@"AddTAP6.bat");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR:" + ex, "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (File.Exists(@"C:\Program Files (x86)\OVPN-Driver\OpenVPN\bin\openvpn.exe"))
            {
                if (File.Exists($@"OVPN-Control.bat") && File.Exists($@"killOVPN.bat"))
                {

                }
                else
                {
                    try
                    {
                        config_cs.config_cs.webClient.DownloadFile("https://assets.ggs-network.de/download.php?path=OVPN-Control.bat", $@"OVPN-Control.bat");
                        config_cs.config_cs.webClient.DownloadFile("https://assets.ggs-network.de/download.php?path=killOVPN.bat", $@"killOVPN.bat");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR:" + ex, "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                try
                {
                    MessageBox.Show("OpenVPN Driver not found!", "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    try
                    {
                        config_cs.config_cs.webClient.DownloadFile("https://assets.ggs-network.de/download.php?path=ovpn-driver.exe", $@"C:\Users\{config_cs.config_cs.sysUsername}\AppData\Local\Temp\ovpn-driver.exe");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR:" + ex, "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    try
                    {
                        Process.Start($@"C:\Users\{config_cs.config_cs.sysUsername}\AppData\Local\Temp\ovpn-driver.exe");
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
        }
    }
}

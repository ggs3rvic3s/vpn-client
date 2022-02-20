//System
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace assets_cs
{
    internal class assets_cs
    {
        public static void error(bool error, string ex)
        {
            MessageBox.Show("ERROR:" + ex, "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if ((error == true))
            {
                Application.Exit();
            }
        }
        public static void checkVersion(string version)
        {
            MessageBox.Show(config_cs.config_cs.Client_Version, config_cs.config_cs.Client_GUID);
            if ((version == config_cs.config_cs.Client_Version))
            {
                
            }
            else
            {
                MessageBox.Show("Old version of this client is installed. Please restart the client to update it!", "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
    }
}

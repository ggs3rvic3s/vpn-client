using System;
using System.Diagnostics;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Client
{
    public partial class Home : MaterialForm
    {
        public Home()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue800, Primary.LightBlue900, Primary.LightBlue500, Accent.LightBlue200, TextShade.BLACK);
        }

        private void Home_Load(object sender, EventArgs e)
        {
            //Set Wallpaper Player
            Wallpaper.URL = config_cs.config_cs.Video_Wallpaper;
            Wallpaper.Ctlcontrols.play();
            btn_Disconnect.Visible = false;
            disconnectToolStripMenuItem.Visible = false;
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            btn_Disconnect.Visible = true;
            btn_Connect.Visible = false;
            connectToolStripMenuItem.Visible = false;
            disconnectToolStripMenuItem.Visible = true;
            vpn_cs.vpn_cs.connect();
        }

        private void btn_Disconnect_Click(object sender, EventArgs e)
        {
            btn_Disconnect.Visible = false;
            btn_Connect.Visible = true;
            connectToolStripMenuItem.Visible = true;
            disconnectToolStripMenuItem.Visible = false;
            vpn_cs.vpn_cs.disconnect();
        }

        private void btn_dev_Click(object sender, EventArgs e)
        {
            Process.Start("https://ggs-network.de");
        }

        private void btn_OpenSource_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Good-Game-Services/vpn-client");
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_Disconnect.Visible = true;
            btn_Connect.Visible = false;
            connectToolStripMenuItem.Visible = false;
            disconnectToolStripMenuItem.Visible = true;
            vpn_cs.vpn_cs.connect();
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_Disconnect.Visible = false;
            btn_Connect.Visible = true;
            connectToolStripMenuItem.Visible = true;
            disconnectToolStripMenuItem.Visible = false;
            vpn_cs.vpn_cs.disconnect();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vpn_cs.vpn_cs.disconnect();
<<<<<<< HEAD
            Wallpaper.Ctlcontrols.stop();
=======
>>>>>>> 8be0361a5866967e57878336e419215a8b7269c4
            this.Hide();
            Application.Exit();
        }

        private void notify_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void Home_Move(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notify.ShowBalloonTip(1000, "Important notice", "Something important has come up. Click this to know more.", ToolTipIcon.Info);
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            vpn_cs.vpn_cs.disconnect();
<<<<<<< HEAD
            Wallpaper.Ctlcontrols.stop();
=======
>>>>>>> 8be0361a5866967e57878336e419215a8b7269c4
            this.Hide();
            Application.Exit();
        }
    }
}

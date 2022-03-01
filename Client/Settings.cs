using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.LightBlue800, Primary.LightBlue900, Primary.LightBlue500, Accent.LightBlue200, TextShade.BLACK);
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            auth_cs.auth_cs.reloadProfile();
        }

        private void btn_change_name_Click(object sender, EventArgs e)
        {
            auth_cs.auth_cs.reloadProfile();
            handler_cs.handler_cs.changeName(txt_Firstname.Text, txt_Lastname.Text);
        }

        private void btn_change_password_Click(object sender, EventArgs e)
        {
            auth_cs.auth_cs.reloadProfile();
            if (txt_nw_password.Text == txt_nw_password_re.Text)
            {
                handler_cs.handler_cs.changePassord(txt_cr_password.Text, txt_nw_password.Text);
            }
            else
            {
                MessageBox.Show($"Password deson't match.", "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btn_session_Click(object sender, EventArgs e)
        {
            auth_cs.auth_cs.reloadProfile();
            MessageBox.Show($"Session: {auth_cs.auth_cs.user_session}", "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_gen_profile_Click(object sender, EventArgs e)
        {
            auth_cs.auth_cs.reloadProfile();
            vpn_cs.vpn_cs.genProfile();
        }
    }
}

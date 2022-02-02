using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Globalization;

namespace config_cs
{
    internal class config_cs
    {
        public static string _config;

        //Webclient
        public static WebClient webClient = new WebClient();

        //Default
        public static string sysUsername = Environment.UserName;
        public static string sysPath = Directory.GetCurrentDirectory();

        //Video config URL
        public static string Video_Wallpaper;
        public static string Video_Splash;

        //Banned State
        public static bool Banned = false;
        public static string BannedReason;

        public static void getConfig()
        {
            try
            {
                var request = (HttpWebRequest)WebRequest.Create("https://assets.ggs-network.de/beta.json");

                var response = (HttpWebResponse)request.GetResponse();
                string responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                dynamic responseParse = JsonConvert.DeserializeObject(responseString);


                //Video config URL
                Video_Wallpaper = responseParse.Client.Video.Wallpaper;
                Video_Splash = responseParse.Client.Video.Splash;

                //Banned State
                Banned = responseParse.Client.Banned.Banned;
                BannedReason = responseParse.Client.Banned.BannedReason;

                //DE
                lang_cs.lang_cs.DE_Login = responseParse.Lang.DE.Login;
                lang_cs.lang_cs.DE_Register = responseParse.Lang.DE.Register;
                lang_cs.lang_cs.DE_Connect = responseParse.Lang.DE.Connect;
                lang_cs.lang_cs.DE_Disconnect = responseParse.Lang.DE.Disconnect;
                lang_cs.lang_cs.DE_Banned = responseParse.Lang.DE.Banned;
                lang_cs.lang_cs.DE_Succesful = responseParse.Lang.DE.Succesful;

                //FR
                lang_cs.lang_cs.FR_Login = responseParse.Lang.FR.Login;
                lang_cs.lang_cs.FR_Register = responseParse.Lang.FR.Register;
                lang_cs.lang_cs.FR_Connect = responseParse.Lang.FR.Connect;
                lang_cs.lang_cs.FR_Disconnect = responseParse.Lang.FR.Disconnect;
                lang_cs.lang_cs.FR_Banned = responseParse.Lang.FR.Banned;
                lang_cs.lang_cs.FR_Succesful = responseParse.Lang.FR.Succesful;

                //EN
                lang_cs.lang_cs.EN_Login = responseParse.Lang.EN.Login;
                lang_cs.lang_cs.EN_Register = responseParse.Lang.EN.Register;
                lang_cs.lang_cs.EN_Connect = responseParse.Lang.EN.Connect;
                lang_cs.lang_cs.EN_Disconnect = responseParse.Lang.EN.Disconnect;
                lang_cs.lang_cs.EN_Banned = responseParse.Lang.EN.Banned;
                lang_cs.lang_cs.EN_Succesful = responseParse.Lang.EN.Succesful;

            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR:" + ex, "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
        public static void setLang()
        {
            try
            {
                //Get Lang
                CultureInfo ci = CultureInfo.InstalledUICulture;
                ci = CultureInfo.CurrentCulture;

                //Set Lang
                if (ci.Name == "de-DE")
                {
                    lang_cs.lang_cs.Lang_Login = lang_cs.lang_cs.DE_Login;
                    lang_cs.lang_cs.Lang_Register = lang_cs.lang_cs.DE_Register;
                    lang_cs.lang_cs.Lang_Connect = lang_cs.lang_cs.DE_Connect;
                    lang_cs.lang_cs.Lang_Disconnect = lang_cs.lang_cs.DE_Disconnect;
                    lang_cs.lang_cs.Lang_Banned = lang_cs.lang_cs.DE_Banned;
                    lang_cs.lang_cs.Lang_Succesful = lang_cs.lang_cs.DE_Succesful;
                }
                else
                {
                    //Set Global Lang
                    lang_cs.lang_cs.Lang_Login = lang_cs.lang_cs.EN_Login;
                    lang_cs.lang_cs.Lang_Register = lang_cs.lang_cs.EN_Register;
                    lang_cs.lang_cs.Lang_Connect = lang_cs.lang_cs.EN_Connect;
                    lang_cs.lang_cs.Lang_Disconnect = lang_cs.lang_cs.EN_Disconnect;
                    lang_cs.lang_cs.Lang_Banned = lang_cs.lang_cs.EN_Banned;
                    lang_cs.lang_cs.Lang_Succesful = lang_cs.lang_cs.EN_Succesful;
                }
                if (ci.Name == "fr-FR")
                {
                    lang_cs.lang_cs.Lang_Login = lang_cs.lang_cs.FR_Login;
                    lang_cs.lang_cs.Lang_Register = lang_cs.lang_cs.FR_Register;
                    lang_cs.lang_cs.Lang_Connect = lang_cs.lang_cs.FR_Connect;
                    lang_cs.lang_cs.Lang_Disconnect = lang_cs.lang_cs.FR_Disconnect;
                    lang_cs.lang_cs.Lang_Banned = lang_cs.lang_cs.FR_Banned;
                    lang_cs.lang_cs.Lang_Succesful = lang_cs.lang_cs.FR_Succesful;
                }
                else
                {
                    //Set Global Lang
                    lang_cs.lang_cs.Lang_Login = lang_cs.lang_cs.EN_Login;
                    lang_cs.lang_cs.Lang_Register = lang_cs.lang_cs.EN_Register;
                    lang_cs.lang_cs.Lang_Connect = lang_cs.lang_cs.EN_Connect;
                    lang_cs.lang_cs.Lang_Disconnect = lang_cs.lang_cs.EN_Disconnect;
                    lang_cs.lang_cs.Lang_Banned = lang_cs.lang_cs.EN_Banned;
                    lang_cs.lang_cs.Lang_Succesful = lang_cs.lang_cs.EN_Succesful;
                }
                if (ci.Name == "en-GB")
                {
                    lang_cs.lang_cs.Lang_Login = lang_cs.lang_cs.EN_Login;
                    lang_cs.lang_cs.Lang_Register = lang_cs.lang_cs.EN_Register;
                    lang_cs.lang_cs.Lang_Connect = lang_cs.lang_cs.EN_Connect;
                    lang_cs.lang_cs.Lang_Disconnect = lang_cs.lang_cs.EN_Disconnect;
                    lang_cs.lang_cs.Lang_Banned = lang_cs.lang_cs.EN_Banned;
                    lang_cs.lang_cs.Lang_Succesful = lang_cs.lang_cs.EN_Succesful;
                }
                else
                {
                    //Set Global Lang
                    // lang_cs.lang_cs.Lang_Login = lang_cs.lang_cs.EN_Login;
                    // lang_cs.lang_cs.Lang_Register = lang_cs.lang_cs.EN_Register;
                    // lang_cs.lang_cs.Lang_Connect = lang_cs.lang_cs.EN_Connect;
                    // lang_cs.lang_cs.Lang_Disconnect = lang_cs.lang_cs.EN_Disconnect;
                    // lang_cs.lang_cs.Lang_Banned = lang_cs.lang_cs.EN_Banned;
                    // lang_cs.lang_cs.Lang_Succesful = lang_cs.lang_cs.EN_Succesful;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR:" + ex, "VPN Client by GGS-Network", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
    }
}

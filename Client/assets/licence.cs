using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace licence_cs
{
    internal class licence_cs
    {
        public static void checkLicence()
        {
            try
            {
                if (File.Exists($@"{AppData_cs.AppData_cs.AppDataPath}\licence.file"))
                {
                    string value = File.ReadAllText($@"{AppData_cs.AppData_cs.AppDataPath}\licence.file");
                    if ((value == "yes"))
                    {

                    }
                    else
                    {
                        Application.Exit();
                    }
                }
            }
            catch(Exception ex) 
            {
                assets_cs.assets_cs.error(true, ex.Message);
            }
        }
    }
}

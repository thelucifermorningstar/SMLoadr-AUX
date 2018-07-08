using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMLoadrAUX.new_release
{
    class new_release
    {
        public void check()
        {
            string url = "https://github.com/thelucifermorningstar/SMLoadr-AUX/releases/download/1.0.6/SMA_1.0.6_x64.zip";
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            WebRequest request = WebRequest.Create(url);

            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                if (response.StatusDescription == "OK")
                {

                    DialogResult dialog = MessageBox.Show("A new version is available! (1.0.6) Go to Download?", "Update", MessageBoxButtons.YesNo);
                    if (dialog == DialogResult.Yes)
                    {
                        Process.Start("https://github.com/thelucifermorningstar/SMLoadr-AUX/releases/");
                    }
                }

            }
            catch
            {

            }
        }
            



    }
}

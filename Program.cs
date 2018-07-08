using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMLoadrAUX
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // check windows media player
            bool wmp = checWMP();

            if (wmp == false)
            {
                MessageBox.Show("In order to use SMLoadr AUX" + Environment.NewLine + "Windows Media Player must be installed." + Environment.NewLine + Environment.NewLine + "Go to:" + Environment.NewLine + "Control panel > Programs > Turn Windows features on/off" + Environment.NewLine + "Select Media Features from the list." + Environment.NewLine + Environment.NewLine + "Hit OK and restart. Retry again!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmSMLoadrAUX());
        }

        /// <summary>
        /// method that verifies if windows media player is installed
        /// </summary>
        /// <returns>Return true if is installed</returns>
        static bool checWMP()
        {
            bool installed = false;
            string WMP_64 = "22d6f312-b0f6-11d0-94ab-0080c74c7e95"; //Windows Media Player v6.4
            string WMP_7 = "6BF52A52-394A-11d3-B153-00C04F79FAA6";  //Windows Media Player v7 or later
            try
            {


                RegistryKey Key = Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Active Setup\Installed Components\{" + WMP_64 + "}");
                if (Key != null)
                {
                    installed = ((int)Key.GetValue("IsInstalled") == 1) ? true : false;
                    if (!installed)
                    {
                        Key = Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Active Setup\Installed Components\{" + WMP_7 + "}");
                        if (Key != null)
                            installed = ((int)Key.GetValue("IsInstalled") == 1) ? true : false;
                    }
                }

            }
            catch (Exception ex)
            {
                // On excepcion we assume it's not installed
                installed = false;
            }

            return installed;
        }
    }
}

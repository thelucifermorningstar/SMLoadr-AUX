using SMLoader.list;
using SMLoader.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SMLoader.manage
{
    class manager1
    {


        public void download(Label status, TextBox search, ComboBox quality, ListBox result, Process download, List<list.Info> info)
        {
            string qualitys = "";

            if (quality.SelectedIndex == 0)
            {
                qualitys = "MP3_128";

            }

            if (quality.SelectedIndex == 1)
            {
                qualitys = "MP3_320";
            }

            if (quality.SelectedIndex == 2)
            {
                qualitys = "FLAC";
            }


            if (search.Text != "" && result.SelectedIndex >= 0)
            {

                if (Settings.Default.sm != "")
                {
                    download.StartInfo.FileName = Settings.Default.sm;
                    string a = " -q " + qualitys + " -p " + Settings.Default.download + " " + info[result.SelectedIndex].link;
                    download.StartInfo.Arguments = a;
                    //status.Text = a;
                    
                }

            }

            download.Start();

        }

        public void copyToBackupB(List<list.InfoB> infob, List<list.Info> info)
        {
            infob.Clear();
            foreach (var b in info)
            {
                infob.Add(new list.InfoB()
                {
                    name = b.name,
                    link = b.link,
                    picture = b.picture,
                    preview = b.preview,
                    id = b.id
                });
            }
        }

        public void copyToBackupC(List<list.InfoC> infoc, List<list.Info> info)
        {
            infoc.Clear();
            foreach (var b in info)
            {
                infoc.Add(new list.InfoC()
                {
                    name = b.name,
                    link = b.link,
                    picture = b.picture,
                    preview = b.preview,
                    id = b.id
                });
            }
        }

        public void BToInfo(List<list.InfoB> infob, List<list.Info> info, ListBox result)
        {
            info.Clear();
            result.Items.Clear();
            int i = 1;
            foreach (var b in infob)
            {
                info.Add(new list.Info()
                {
                    name = b.name,
                    link = b.link,
                    picture = b.picture,
                    preview = b.preview,
                    id = b.id
                });
            }

            foreach (var listbox in info)
            {
                result.Items.Add(i.ToString() + " " + listbox.name);
                i++;
            }
        }

        public void CToInfo(List<list.InfoC> infoc, List<list.Info> info, ListBox result)
        {
            info.Clear();
            result.Items.Clear();
            int i = 1;
            foreach (var b in infoc)
            {
                info.Add(new list.Info()
                {
                    name = b.name,
                    link = b.link,
                    picture = b.picture,
                    preview = b.preview,
                    id = b.id
                });
            }

            foreach (var listbox in info)
            {
                result.Items.Add(i.ToString() + " " + listbox.name);
                i++;
            }
        }


    


           
        

    }
}


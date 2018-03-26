using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using SMLoader.Properties;
using System.Xml;
using System.IO;
using System.Net;
using System.Net.Http;

namespace SMLoader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            bgw_check_version.RunWorkerAsync();

            pbx_loading.Visible = true;



            cmb_quality.SelectedIndex = Settings.Default.qual;
            cmb_limit_results.SelectedIndex = Settings.Default.results;

            if (Settings.Default.download == "")
            {
                String path = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
                Settings.Default.download = path + @"\SM\";
                Settings.Default.Save();

            }

            txb_download_folder.Text = Settings.Default.download;
            txb_SM_exe.Text = Settings.Default.sm;

            if (Settings.Default.sm == "")
            {
                MessageBox.Show("Add a SMLoadr executable!");
                tabControl1.SelectTab(tabControl1.TabPages[1]);
            }



            txb_search.Text = "Chart";
            chart = true;
            limit = cmb_limit_results.Text;
            xmln = "/root/artists/data/artist";
            bgw_chart.RunWorkerAsync();

        }

        bool chart;

        //------------------------------------------

        public Process download = new Process();

        manage.manager1 manager = new manage.manager1();

        new_release.new_release check_release = new new_release.new_release();

        int lastPos1 = -1;
        int lastPos2 = -1;

        private void btn_go_Click(object sender, EventArgs e)
        {
            if (txb_search.Text != "" && lb_result.Items.Count > 0)
            {
                if (Settings.Default.sm != "")
                {
                    manager.download(lbl_status, txb_search, cmb_quality, lb_result, download, info);
                }
                else
                {
                    MessageBox.Show("Add a SMLoadr executable!");
                    tabControl1.SelectTab(tabControl1.TabPages[1]);
                }
            }

        }

        private void cmb_quality_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default.qual = cmb_quality.SelectedIndex;
            Settings.Default.Save();
        }


        private void lb_result_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbt_track.Checked == true)
                {
                    if (lb_result.SelectedIndex >= 0)
                    {
                        pbx_artist.ImageLocation = infoc[lastPos2].picture;
                        lbl_status.Text = "Download: " + info[lb_result.SelectedIndex].name;
                        lbl_info.Text = infoc[lastPos2].name;
                        lbl_link.Text = info[lb_result.SelectedIndex].link;
                        if (play == true)
                        {
                            axWindowsMediaPlayer1.URL = info[lb_result.SelectedIndex].preview;
                        }
                    }
                }
                else
                {
                    if (lb_result.SelectedIndex >= 0)
                    {
                        lbl_link.Text = info[lb_result.SelectedIndex].link;
                        pbx_artist.ImageLocation = info[lb_result.SelectedIndex].picture;
                        lbl_status.Text = "Download: " + info[lb_result.SelectedIndex].name;
                        lbl_info.Text = info[lb_result.SelectedIndex].name;
                    }
                }
            }
            catch
            {
            }
        }


        List<list.Info> info = new List<list.Info>();
        List<list.InfoB> infob = new List<list.InfoB>();
        List<list.InfoC> infoc = new List<list.InfoC>();
        string search;
        string limit;
        string XMLnode;
        string CLI;

        private void btn_search_Click(object sender, EventArgs e)
        {

            search = txb_search.Text;
            limit = cmb_limit_results.Text;

            res = false;


            if (rbt_artist.Checked == true)
            {
                start_artist = true;
                lb_result.Items.Clear();
                info.Clear();

                if (!bgw_artist.IsBusy)
                {
                    pbx_loading.Visible = true;
                    bgw_artist.RunWorkerAsync();
                    

                }

            }

            if (rbt_album.Checked == true)
            {
                lb_result.Items.Clear();
                info.Clear();
                if (!bgw_album.IsBusy)
                {
                    pbx_loading.Visible = true;
                    bgw_album.RunWorkerAsync();
                    
                }
            }

            if (rbt_track.Checked == true)
            {
                lb_result.Items.Clear();
                info.Clear();
                if (!bgw_track.IsBusy)
                {
                    pbx_loading.Visible = true;
                    bgw_track.RunWorkerAsync();
                    

                }
            }

            res = true;
        }

        private void rbt_artist_CheckedChanged(object sender, EventArgs e)
        {

            btn_preview.Enabled = false;
            btn_preview.BackgroundImage = Resources.if_play_circle_fill_326581Disable21;
            axWindowsMediaPlayer1.URL = "";
            play = false;
            if (txb_search.Text != "" && res == true)
            {
                btn_search_Click(sender, e);
            }

        }

        private void rbt_album_CheckedChanged(object sender, EventArgs e)
        {


            btn_preview.Enabled = false;
            btn_preview.BackgroundImage = Resources.if_play_circle_fill_326581Disable21;
            axWindowsMediaPlayer1.URL = "";
            play = false;
            if (txb_search.Text != "" && res == true)
            {
                btn_search_Click(sender, e);
            }

        }

        private void rbt_track_CheckedChanged(object sender, EventArgs e)
        {
            btn_preview.Enabled = true;
            btn_preview.BackgroundImage = Resources.if_play_circle_fill_326581;
            if (txb_search.Text != "" && res == true)
            {
                btn_search_Click(sender, e);
            }


            // pbx_artist.Image = Resources.Music_2123892;

        }

        private void txb_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                btn_search_Click(sender, e);

            }
        }

        private void btn_download_folder_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {

                    Settings.Default.download = folderDialog.SelectedPath + @"\";
                    Settings.Default.Save();
                    txb_download_folder.Text = Settings.Default.download;
                }
            }
        }
        bool play = false;

        private void btn_preview_Click(object sender, EventArgs e)
        {

            if (lb_result.SelectedIndex >= 0)
            {

                if (play == false)
                {
                    axWindowsMediaPlayer1.URL = info[lb_result.SelectedIndex].preview;
                    btn_preview.BackgroundImage = Resources.if_206_CircledStop_183323;
                    play = true;
                }

                else if (play == true)
                {
                    axWindowsMediaPlayer1.URL = "";
                    btn_preview.BackgroundImage = Resources.if_play_circle_fill_326581;
                    play = false;
                }

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_open_download_folder_Click(object sender, EventArgs e)
        {
            Process.Start(Settings.Default.download);
        }

        private void btn_monero_add_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("46VHMJMgN7hdcfc4TK1u3i7a414iGG4mhWPRxawnLbSfT2gTQ3aLstUVU6NEYpUJvxgTHdHt9fcb1RU8WxBAHmgHTwC85mJ");
            MessageBox.Show("Copied");
        }

        private void btn_bitcoin_add_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("1CcqM6Va6YdE2MNkD5N9CVBrxJTnF6wNn");
            MessageBox.Show("Copied");
        }

        private void btn_ether_add_Click(object sender, EventArgs e)
        {
            Clipboard.SetText("0x09c5059e19db51ff27B0d9E4AE547242Edb2b4CD");
            MessageBox.Show("Copied");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Executables|*.exe";
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Settings.Default.sm = openFileDialog1.FileName;
                Settings.Default.Save();
                txb_SM_exe.Text = Settings.Default.sm;

            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Reset Settings?", "Warning", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Settings.Default.Reset();
                txb_SM_exe.Text = Settings.Default.sm;
                cmb_quality.SelectedIndex = Settings.Default.qual;
            }
        }

        private void cmb_limit_results_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_limit_results_TextUpdate(object sender, EventArgs e)
        {

        }

        private void cmb_limit_results_SelectedValueChanged(object sender, EventArgs e)
        {
            Settings.Default.results = cmb_limit_results.SelectedIndex;
            Settings.Default.Save();
        }


        bool res;



        //--------------------

        //---------------------------

        private void lb_result_DoubleClick(object sender, EventArgs e)
        {

            res = false;


            //  manager.discover(lb_result, rbt_artist, rbt_track, rbt_album, doc, infob, infoc, info, cmb_limit_results);

            if (rbt_artist.Checked == true)
            {

                //search = info[lb_result.SelectedIndex].name;
                //  limit = cmb_limit_results.Text;
                id = info[lb_result.SelectedIndex].id;


                rbt_album.Checked = true;

                pbx_loading.Visible = true;


                manager.copyToBackupB(infob, info);

                lastPos1 = lb_result.SelectedIndex;

                lb_result.Items.Clear();
                info.Clear();
                // bgw_album.RunWorkerAsync();
                bgw_album_double.RunWorkerAsync();

            }

            else if (rbt_album.Checked == true)
            {

                id = info[lb_result.SelectedIndex].id;
                // search = info[lb_result.SelectedIndex].name;
                //limit = cmb_limit_results.Text;


                rbt_track.Checked = true;

                pbx_loading.Visible = true;


                manager.copyToBackupC(infoc, info);
                lastPos2 = lb_result.SelectedIndex;

                lb_result.Items.Clear();
                info.Clear();

                if (!bgw_track_double.IsBusy)
                {
                    bgw_track_double.RunWorkerAsync();
                }
            }


            if (lb_result.Items.Count > 0)
            {
                lb_result.SelectedIndex = 0;
            }





            res = true;


        }

        bool start_artist = false;


        private void btn_back_Click(object sender, EventArgs e)
        {
            res = false;
            if (rbt_track.Checked == true)
            {
                manager.CToInfo(infoc, info, lb_result);
                rbt_album.Checked = true;
                lb_result.SelectedIndex = lastPos2;
            }
            else if (rbt_album.Checked == true)
            {

                if (start_artist != false)
                {
                    rbt_artist.Checked = true;
                    if (lb_result.Items.Count > 0)
                    {
                        lb_result.SelectedIndex = lastPos1;
                    }
                    manager.BToInfo(infob, info, lb_result);
                }


            }

            if (lb_result.Items.Count > 0 && lastPos1 == -1 && lastPos2 == -1)
            {
                lb_result.SelectedIndex = 0;
            }

            // MessageBox.Show(lastPos1.ToString() + " - " + lastPos2.ToString());

            res = true;
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {


        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
        }

        private void bgw_artist_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void bgw_artist_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }



        string a;
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {


        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void btn_sort_Click(object sender, EventArgs e)
        {
            int i = 1;

            //info.Sort();

            lb_result.Items.Clear();

            foreach (var listbox in info)
            {
                lb_result.Items.Add(i.ToString() + " " + listbox.name);
                i++;
            }
        }

        private void bgw_artist_DoWork_1(object sender, DoWorkEventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("https://api.deezer.com/search/artist/?q=" + search + "&index=0&limit=" + limit + "&output=xml");

            //XmlElement root = doc.DocumentElement;

            XmlNodeList nodes = doc.DocumentElement.SelectNodes("/root/data/artist");

            //root.SelectNodes("/root/data/artist");


            foreach (XmlNode node in nodes)
            {

                info.Add(new list.Info()
                {
                    name = node["name"].InnerText,
                    link = node["link"].InnerText,
                    id = node["id"].InnerText,
                    picture = node["picture_medium"].InnerText
                });

            }


        }

        private void bgw_artist_RunWorkerCompleted_1(object sender, RunWorkerCompletedEventArgs e)
        {
            int i = 1;

            foreach (var listbox in info)
            {
                lb_result.Items.Add(i.ToString() + " " + listbox.name);
                i++;
            }
            pbx_loading.Visible = false;

            if (lb_result.Items.Count > 0)
            {
                lb_result.SelectedIndex = 0;
            }

        }

        private void bgw_album_DoWork(object sender, DoWorkEventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("https://api.deezer.com/search/album/?q=" + search + "&index=0&limit=" + limit + "&output=xml");



            XmlNodeList nodes = doc.DocumentElement.SelectNodes("/root/data/album");
            //XmlElement root = doc.DocumentElement;
            // XmlNodeList nodes = root.SelectNodes("");


            foreach (XmlNode node in nodes)
            {

                info.Add(new list.Info()
                {
                    name = node["title"].InnerText,
                    link = node["link"].InnerText,
                    picture = node["cover_medium"].InnerText,
                    id = node["id"].InnerText,
                    record_type = node["record_type"].InnerText


                });

            }
        }

        private void bgw_album_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            int i = 1;

            foreach (var listbox in info)
            {
                if (listbox.record_type != "album")
                {
                    lb_result.Items.Add(i.ToString() + " " + listbox.name + " (" + listbox.record_type + ")");
                }
                else
                {
                    lb_result.Items.Add(i.ToString() + " " + listbox.name);
                }
                i++;
            }
            pbx_loading.Visible = false;


            if (lb_result.Items.Count > 0)
            {
                lb_result.SelectedIndex = 0;
            }

        }

        private void bgw_track_DoWork(object sender, DoWorkEventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("https://api.deezer.com/search/?q=" + search + "&index=0&output=xml");
            XmlNodeList nodes = doc.DocumentElement.SelectNodes("/root/data/track");

            foreach (XmlNode node in nodes)
            {
                info.Add(new list.Info()
                {
                    name = node["title"].InnerText,
                    link = node["link"].InnerText,
                    preview = node["preview"].InnerText
                });

            }
        }

        private void bgw_track_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            int i = 1;

            foreach (var listbox in info)
            {
                lb_result.Items.Add(i.ToString() + " " + listbox.name);
                i++;
            }
            pbx_loading.Visible = false;


            if (lb_result.Items.Count > 0)
            {
                lb_result.SelectedIndex = 0;
            }

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            bgw_artist.CancelAsync();
            pbx_loading.Visible = false;
        }

        private void bgw_check_version_DoWork(object sender, DoWorkEventArgs e)
        {
            check_release.check();
        }

        string id;

        private void bgw_track_double_DoWork(object sender, DoWorkEventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("http://api.deezer.com/album/" + id + "&index=0&output=xml");

            XmlNodeList nodes = doc.DocumentElement.SelectNodes("/root/tracks/data/track");

            // copyToBackupB(infoB, info);

            foreach (XmlNode node in nodes)
            {

                info.Add(new list.Info()
                {
                    name = node["title"].InnerText,
                    link = node["link"].InnerText,
                    preview = node["preview"].InnerText
                });

            }
        }

        private void bgw_track_double_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            int i = 1;

            foreach (var listbox in info)
            {
                lb_result.Items.Add(i.ToString() + " " + listbox.name);
                i++;
            }
            pbx_loading.Visible = false;


            if (lb_result.Items.Count > 0)
            {
                lb_result.SelectedIndex = 0;
            }
        }

        private void bgw_album_double_DoWork(object sender, DoWorkEventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("http://api.deezer.com/artist/" + id + "/albums&output=xml");

            XmlNodeList nodes = doc.DocumentElement.SelectNodes("/root/data/album");

            // copyToBackupB(infoB, info);

            foreach (XmlNode node in nodes)
            {

                info.Add(new list.Info()
                {
                    name = node["title"].InnerText,
                    link = node["link"].InnerText,
                    picture = node["cover_medium"].InnerText,
                    id = node["id"].InnerText,
                    record_type = node["record_type"].InnerText


                });

            }
        }

        private void bgw_album_double_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            int i = 1;

            foreach (var listbox in info)
            {
                if (listbox.record_type != "album")
                {
                    lb_result.Items.Add(i.ToString() + " " + listbox.name + " (" + listbox.record_type + ")");
                }
                else
                {
                    lb_result.Items.Add(i.ToString() + " " + listbox.name);
                }
                //lb_result.Items.Add(i.ToString() + " " + listbox.name);
                i++;
            }

            pbx_loading.Visible = false;

            if (lb_result.Items.Count > 0)
            {
                lb_result.SelectedIndex = 0;
            }

        }

        private void bgw_search_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            int i = 1;
            foreach (var listbox in info)
            {
                lb_result.Items.Add(i.ToString() + " " + listbox.name);
                i++;
            }
            pbx_loading.Visible = false;


            if (lb_result.Items.Count > 0)
            {
                lb_result.SelectedIndex = 0;
            }
        }

        string xmln;

        private void bgw_search_DoWork(object sender, DoWorkEventArgs e)
        {


            XmlDocument doc = new XmlDocument();
            doc.Load("http://api.deezer.com/chart/&limit=" + limit + "&output=xml");

            XmlNodeList nodes = doc.DocumentElement.SelectNodes(xmln);

            // copyToBackupB(infoB, info);

            foreach (XmlNode node in nodes)
            {

                info.Add(new list.Info()
                {
                    name = node["name"].InnerText,
                    link = node["link"].InnerText,
                    picture = node["picture_medium"].InnerText,
                    id = node["id"].InnerText



                });

            }

        }

        private void lbl_link_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lbl_link.Text);
            MessageBox.Show("Link Copied");
        }

        private void lbl_link_MouseEnter(object sender, EventArgs e)
        {
            if (lbl_link.Text != "")
            {
                lbl_link.BackColor = Color.Gray;
            }
        }

        private void lbl_link_MouseLeave(object sender, EventArgs e)
        {
            lbl_link.BackColor = Color.Transparent;
        }

        private void txb_search_Click(object sender, EventArgs e)
        {
            if (chart == true)
            {
                txb_search.Text = "";
                chart = false;
            }
        }
    }
}








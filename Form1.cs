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
using System.Drawing.Text;

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



            if (Settings.Default.sm == "")
            {
                MessageBox.Show("Add a SMLoadr executable!");
                tabControl1.SelectTab(tabControl1.TabPages[1]);
            }


            //Custom Font





            pfc.AddFontFile("Roboto-Black.ttf");
            pfc.AddFontFile("Roboto-Regular.ttf");



            lb_result.Font = load_font(pfc, 11, Roboto);
            rbt_artist.Font = load_font(pfc, 12, Roboto_Black);
            rbt_album.Font = load_font(pfc, 12, Roboto_Black);
            txb_search.Font = load_font(pfc, 12, Roboto);
            cmb_limit_results.Font = load_font(pfc, 11, Roboto);
            lbl_title.Font = load_font(pfc, 10, Roboto_Black);
            lbl_title2.Font = load_font(pfc, 10, Roboto_Black);
            lbl_path.Font = load_font(pfc, 10, Roboto_Black);

            tabPage1.Font = load_font(pfc, 12, Roboto);


            tabPage2.Font = load_font(pfc, 12, Roboto);
            label5.Font = load_font(pfc, 12, Roboto_Black);
            label4.Font = load_font(pfc, 12, Roboto_Black);
            label1.Font = load_font(pfc, 12, Roboto_Black);
            button1.Font = load_font(pfc, 12, Roboto_Black);
            panel8.Font = load_font(pfc, 12, Roboto);
            btn_download_folder.Font = load_font(pfc, 12, Roboto_Black);
            btn_open_download_folder.Font = load_font(pfc, 12, Roboto_Black);
            btn_reset.Font = load_font(pfc, 12, Roboto_Black);
            label2.Font = load_font(pfc, 12, Roboto_Black);
            label3.Font = load_font(pfc, 12, Roboto);
            cmb_quality.Font = load_font(pfc, 12, Roboto);
            btn_monero_add.Font = load_font(pfc, 12, Roboto_Black);
            btn_bitcoin_add.Font = load_font(pfc, 12, Roboto_Black);
            btn_ether_add.Font = load_font(pfc, 12, Roboto_Black);



            txb_search.Select();

            //Chart load
            //start_artist = true;
            chart = true;
            limit = cmb_limit_results.Text;
            xmln = "/root/artists/data/artist";
            bgw_chart.RunWorkerAsync();


            txb_download_folder.Text = Settings.Default.download;
            txb_SM_exe.Text = Settings.Default.sm;
        }

        PrivateFontCollection pfc = new PrivateFontCollection();
        string Roboto = "Roboto";
        string Roboto_Black = "Roboto Black";

        public Font load_font(PrivateFontCollection fc, int size, string name)
        {
            return new Font(fc.Families.Where(x => x.Name == name).FirstOrDefault(), size, FontStyle.Regular);
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
            if (lb_result.Items.Count > 0)
            {
                if (Settings.Default.sm != "")
                {
                    manager.download(txb_search, cmb_quality, lb_result, download, info);
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


            if (lb_result.SelectedIndex >= 0)
            {
                pbx_artist.ImageLocation = info[lb_result.SelectedIndex].picture;
                browseOnWebToolStripMenuItem.Text = "Go to " + info[lb_result.SelectedIndex].link;
            }

                /*
                try
                {
                    
                }
                catch
                {

                }

                try
                {
                    if (track == true)
                    {
                        if (lb_result.SelectedIndex >= 0)
                        {

                            pbx_artist.ImageLocation = infoc[lastPos2].picture;
                            if (play == true)
                            {
                                axWindowsMediaPlayer1.URL = info[lb_result.SelectedIndex].preview;
                            }


                        }
                    }
                    else
                    {
                        pbx_artist.ImageLocation = info[lb_result.SelectedIndex].picture;
                    }

                    if (rbt_track.Checked == true)
                    {
                        pbx_artist.ImageLocation = info[lb_result.SelectedIndex].picture;
                        //pbx_artist.Image = Resources.empty_cover_v2;
                    }

                    /* else
                     {
                         if (lb_result.SelectedIndex >= 0)
                         {
                             this.lb_result.Invalidate();
                             pbx_artist.ImageLocation = info[lb_result.SelectedIndex].picture;

                         }
                     }
                }
                catch
                {
                }*/
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

            if (txb_search.Text != "")
            {

                search = txb_search.Text;
                limit = cmb_limit_results.Text;

                res = false;


                if (rbt_artist.Checked == true)
                {

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
        }

        private void rbt_artist_CheckedChanged(object sender, EventArgs e)
        {
            artist = true;
            album = false;
            track = false;
            btn_preview.Enabled = false;
            lbl_path.Text = "Artist";
            btn_preview.BackgroundImage = Resources.play_button_up;

            //Radio
            rb_album.BackgroundImage = Resources.radio_button_up;
            rb_artist.BackgroundImage = Resources.radio_button_down;
            rb_track.BackgroundImage = Resources.radio_button_up;

            axWindowsMediaPlayer1.URL = "";
            play = false;
            if (txb_search.Text != "" && res == true)
            {
                btn_search_Click(sender, e);
            }

        }

        private void rbt_album_CheckedChanged(object sender, EventArgs e)
        {

            artist = false;
            album = true;
            track = false;

            infob.Clear();

            lbl_path.Text = "Albuns";

            btn_preview.Enabled = false;
            btn_preview.BackgroundImage = Resources.play_button_up;

            //Radio
            rb_album.BackgroundImage = Resources.radio_button_down;
            rb_artist.BackgroundImage = Resources.radio_button_up;
            rb_track.BackgroundImage = Resources.radio_button_up;

            axWindowsMediaPlayer1.URL = "";
            play = false;
            if (txb_search.Text != "" && res == true)
            {
                btn_search_Click(sender, e);
            }

            res = true;
        }

        private void rbt_track_CheckedChanged(object sender, EventArgs e)
        {
            artist = false;
            album = false;
            track = true;
            infoc.Clear();
            lbl_path.Text = "Tracks";

            btn_preview.Enabled = true;


            //Radio
            rb_album.BackgroundImage = Resources.radio_button_up;
            rb_artist.BackgroundImage = Resources.radio_button_up;
            rb_track.BackgroundImage = Resources.radio_button_down;


            if (txb_search.Text != "" && res == true)
            {
                btn_search_Click(sender, e);
                pbx_artist.Image = Resources.empty_cover_v2;
            }




        }

        private void txb_search_KeyDown(object sender, KeyEventArgs e)
        {

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

                axWindowsMediaPlayer1.URL = info[lb_result.SelectedIndex].preview;
                btn_preview.BackgroundImage = Resources.play_button_down;


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

        bool artist = true;
        bool album, track;


        //--------------------

        //---------------------------

        string art;
        string alb;
        private void lb_result_DoubleClick(object sender, EventArgs e)
        {

            // res = false;


            // manager.discover(lb_result, rbt_artist, rbt_track, rbt_album, doc, infob, infoc, info, cmb_limit_results);

            if (artist == true)
            {
                album = true;
                artist = false;
                track = false;
                start_artist = true;


                //panel_double_click.Visible = true;

                art = "Albuns by " + lb_result.Text;

                lbl_path.Text = art;




                btn_back.Enabled = true;

                btn_back.BackgroundImage = Resources.back_button_up;


                //search = info[lb_result.SelectedIndex].name;
                // limit = cmb_limit_results.Text;
                id = info[lb_result.SelectedIndex].id;




                pbx_loading.Visible = true;


                manager.copyToBackupB(infob, info);

                lastPos1 = lb_result.SelectedIndex;

                lb_result.Items.Clear();
                info.Clear();
                // bgw_album.RunWorkerAsync();
                bgw_album_double.RunWorkerAsync();

            }

            else if (album == true)
            {
                album = false;
                artist = false;
                track = true;
                btn_preview.Enabled = true;

                btn_back.Enabled = true;

                btn_back.BackgroundImage = Resources.back_button_up;

                alb = "Tracks from " + lb_result.Text;

                lbl_path.Text = alb;

                




                id = info[lb_result.SelectedIndex].id;
                // search = info[lb_result.SelectedIndex].name;
                //limit = cmb_limit_results.Text;




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
            if (track == true)
            {
                artist = false;
                album = true;
                track = false;
                btn_preview.Enabled = false;
                axWindowsMediaPlayer1.URL = "";
                lbl_path.Text = art;


                if (start_artist == false)
                {
                    
                    timer1.Start();
                    //btn_back.BackgroundImage = Resources.back_button_disabled;
                    //btn_back.Enabled = false;
                    start_artist = false;
                }

                if (infoc.Count <= 0)
                {
                    if (txb_search.Text != "")
                    {
                        rbt_album.Checked = true;
                        btn_search_Click(sender, e);

                    }
                }
                else
                {
                    manager.CToInfo(infoc, info, lb_result);
                    lb_result.SelectedIndex = lastPos2;
                }



                //
            }
            else if (album == true)
            {

                artist = true;
                album = false;
                track = false;

                
                timer1.Start();
                //btn_back.BackgroundImage = Resources.back_button_disabled;
                 //btn_back.Enabled = false;
                start_artist = false;
                lbl_path.Text = "Search Results";




                if (infob.Count <= 0)
                {
                    if (txb_search.Text != "")
                    {
                        rbt_artist.Checked = true;
                        btn_search_Click(sender, e);
                    }
                }
                else
                {
                    manager.BToInfo(infob, info, lb_result);
                    lb_result.SelectedIndex = lastPos1;
                }





                //

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



        // string a;
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
                lb_result.Items.Add(listbox.name);
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


            foreach (var listbox in info)
            {
                lb_result.Items.Add(listbox.name);
            }
            pbx_loading.Visible = false;

            lbl_path.Text = "Results for '" + txb_search.Text+  "'";

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
                    record_type = node["record_type"].InnerText,
                    artist = node.SelectSingleNode("artist/name").InnerText


                });

            }
        }

        private void bgw_album_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {


            foreach (var listbox in info)
            {
                
                    lb_result.Items.Add(listbox.name);
               

            }
            pbx_loading.Visible = false;

            art = "Albuns by '" + txb_search.Text + "'";
            lbl_path.Text = art;

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
                    preview = node["preview"].InnerText,
                    picture = node.SelectSingleNode("artist/picture_medium").InnerText, 
                    album = node.SelectSingleNode("album/title").InnerText
                    //artist = node.SelectSingleNode("artist/picture_medium").InnerText
                });

            }
        }

        private void bgw_track_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {


            foreach (var listbox in info)
            {
                lb_result.Items.Add(listbox.name);

            }
            pbx_loading.Visible = false;

            alb = "Tracks by '" + txb_search.Text + "'";
            lbl_path.Text = alb;



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
                    preview = node["preview"].InnerText,
                    picture = node.SelectSingleNode("/root/cover_medium").InnerText,
                    album = node.SelectSingleNode("/root/title").InnerText
                });

            }
        }

        private void bgw_track_double_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            foreach (var listbox in info)
            {
                lb_result.Items.Add(listbox.name);
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
            foreach (var listbox in info)
            {
                if (listbox.record_type != "album")
                {
                    lb_result.Items.Add(listbox.name + " (" + listbox.record_type + ")");
                }
                else
                {
                    lb_result.Items.Add(listbox.name);
                }
            }

            pbx_loading.Visible = false;

            if (lb_result.Items.Count > 0)
            {

                lb_result.SelectedIndex = 0;
            }

        }

        private void bgw_search_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach (var listbox in info)
            {
                lb_result.Items.Add(listbox.name);
            }
            pbx_loading.Visible = false;

            lbl_path.Text = "Chart";

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

        }

        private void lbl_link_MouseEnter(object sender, EventArgs e)
        {

        }

        private void lbl_link_MouseLeave(object sender, EventArgs e)
        {

        }

        private void txb_search_Click(object sender, EventArgs e)
        {
            if (chart == true)
            {
                txb_search.Text = "";
                chart = false;
            }
        }

        private void btn_settings_MouseEnter(object sender, EventArgs e)
        {
            btn_settings.BackgroundImage = Resources.settings_mouse_over;
        }

        private void btn_settings_MouseLeave(object sender, EventArgs e)
        {
            btn_settings.BackgroundImage = Resources.settings_button_up;
        }

        private void btn_search_MouseDown(object sender, MouseEventArgs e)
        {
            //btn_search.BackgroundImage = Resources.searchbar_button_down;
        }

        private void btn_search_MouseUp(object sender, MouseEventArgs e)
        {
            //btn_search.BackgroundImage = Resources.searchbar_button_up;
        }

        private void btn_go_MouseEnter(object sender, EventArgs e)
        {
            btn_go.BackgroundImage = Resources.download_mouse_over;
        }

        private void btn_go_MouseLeave(object sender, EventArgs e)
        {
            btn_go.BackgroundImage = Resources.download_button_up;
        }

        private void btn_go_MouseDown(object sender, MouseEventArgs e)
        {
            btn_go.BackgroundImage = Resources.download_button_down;
        }

        private void btn_go_MouseUp(object sender, MouseEventArgs e)
        {
            btn_go.BackgroundImage = Resources.download_button_up;
        }

        private void btn_back_MouseEnter(object sender, EventArgs e)
        {
            btn_back.BackgroundImage = Resources.back_mouse_over;
        }

        private void btn_back_MouseLeave(object sender, EventArgs e)
        {

            btn_back.BackgroundImage = Resources.back_button_up;
        
    }

        private void btn_preview_MouseEnter(object sender, EventArgs e)
        {
            if (play != true)
            {
                btn_preview.BackgroundImage = Resources.play_mouse_over;
            }
        }

        private void btn_preview_MouseLeave(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState != WMPLib.WMPPlayState.wmppsPlaying)
            {
                btn_preview.BackgroundImage = Resources.play_button_up;
            }
            else
            {
                btn_preview.BackgroundImage = Resources.play_button_up_playing;
            }
            
        }

        private void txb_search_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                btn_search_Click(sender, e);

            }
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            //tabControl1.SelectedTab = tabPage2;
           
            tabControl1.SelectTab(1);
        }

        private void btn_tmain_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void btn_tmain_MouseEnter(object sender, EventArgs e)
        {
            btn_tmain.BackgroundImage = Resources.home_mouse_over;
        }

        private void btn_tmain_MouseLeave(object sender, EventArgs e)
        {
            btn_tmain.BackgroundImage = Resources.home_button_up;
        }

        private void rb_album_Click(object sender, EventArgs e)
        {
            rbt_album.Checked = true;
        }

        private void rb_artist_Click_1(object sender, EventArgs e)
        {
            rbt_artist.Checked = true;
        }

        private void rb_album_Click_1(object sender, EventArgs e)
        {
            rbt_album.Checked = true;
        }

        private void rb_track_Click_1(object sender, EventArgs e)
        {
            rbt_track.Checked = true;
        }

        private void rb_artist_MouseEnter_1(object sender, EventArgs e)
        {
            if (rbt_artist.Checked == false)
            {
                rb_artist.BackgroundImage = Resources.radio_mouse_over;
            }
        }

        private void rb_artist_MouseLeave_1(object sender, EventArgs e)
        {
            if (rbt_artist.Checked == false)
            {
                rb_artist.BackgroundImage = Resources.radio_button_up;
            }
        }

        private void rb_album_MouseEnter(object sender, EventArgs e)
        {
            if (rbt_album.Checked == false)
            {
                rb_album.BackgroundImage = Resources.radio_mouse_over;
            }
        }

        private void rb_album_MouseLeave(object sender, EventArgs e)
        {
            if (rbt_album.Checked == false)
            {
                rb_album.BackgroundImage = Resources.radio_button_up;
            }
        }

        private void rb_track_MouseEnter(object sender, EventArgs e)
        {
            if (rbt_track.Checked == false)
            {
                rb_track.BackgroundImage = Resources.radio_mouse_over;
            }
        }

        private void rb_track_MouseLeave(object sender, EventArgs e)
        {
            if (rbt_track.Checked == false)
            {
                rb_track.BackgroundImage = Resources.radio_button_up;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cmb_Click(object sender, EventArgs e)
        {
            cmb_limit_results.DroppedDown = true;

        }

        private void btn_cmb_MouseEnter(object sender, EventArgs e)
        {
            btn_cmb.BackgroundImage = Resources.limit_results_mouse_over;
        }

        private void btn_cmb_MouseLeave(object sender, EventArgs e)
        {
            btn_cmb.BackgroundImage = Resources.limit_results_button_up;
        }

        private void btn_cmb_MouseDown(object sender, MouseEventArgs e)
        {
            btn_cmb.BackgroundImage = Resources.limit_results_button_down;
        }

        private void btn_cmb_MouseUp(object sender, MouseEventArgs e)
        {
            btn_cmb.BackgroundImage = Resources.limit_results_button_up;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_close_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btn_close_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btn_close2_Click(object sender, EventArgs e)
        {
            btn_close_Click(sender, e);
        }

        private void btn_close2_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btn_close2_MouseLeave(object sender, EventArgs e)
        {

        }



        //Move Fomr
        bool moving;
        Point offset;
        Point original;

        private void panel_title_bar_MouseMove(object sender, MouseEventArgs e)
        {

            if (!moving)
                return;

            int x = original.X + MousePosition.X - offset.X;
            int y = original.Y + MousePosition.Y - offset.Y;

            this.Location = new Point(x, y);
        }

        private void panel_title_bar_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            panel_title_bar.Capture = true;
            offset = MousePosition;
            original = this.Location;

        }

        private void panel_title_bar_MouseUp(object sender, MouseEventArgs e)
        {

            moving = false;
            panel_title_bar.Capture = false;
        }

        private void panel_title_bar2_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            panel_title_bar2.Capture = true;
            offset = MousePosition;
            original = this.Location;
        }

        private void panel_title_bar2_MouseMove(object sender, MouseEventArgs e)
        {
            if (!moving)
                return;

            int x = original.X + MousePosition.X - offset.X;
            int y = original.Y + MousePosition.Y - offset.Y;

            this.Location = new Point(x, y);
        }

        private void panel_title_bar2_MouseUp(object sender, MouseEventArgs e)
        {

            moving = false;
            panel_title_bar2.Capture = false;
        }

        private void btn_back_MouseDown(object sender, MouseEventArgs e)
        {
            //btn_back.BackgroundImage = Resources.back_button_down;
        }

        private void btn_back_MouseUp(object sender, MouseEventArgs e)
        {
            if (btn_back.Enabled == false)
            {
                btn_back.BackgroundImage = Resources.back_button_up;
            }
        }

        private void btn_close_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Leave(object sender, EventArgs e)
        {
            panel_title_bar.BackgroundImage = Resources.topbar_button_down;
        }

        private void btn_close_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_close_MouseEnter_1(object sender, EventArgs e)
        {
            btn_close.BackgroundImage = Resources.close_mouse_over;
        }

        private void btn_close_MouseLeave_1(object sender, EventArgs e)
        {
            btn_close.BackgroundImage = Resources.close_button_up1;
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_minimize_MouseEnter(object sender, EventArgs e)
        {
            btn_minimize.BackgroundImage = Resources.minimize_mouse_over;
        }

        private void btn_minimize_MouseLeave(object sender, EventArgs e)
        {
            btn_minimize.BackgroundImage = Resources.minimize_button_up;
        }

        private void label6_Click(object sender, EventArgs e)
        {
           
        }

        private void txb_search_Leave(object sender, EventArgs e)
        {
            txb_search.ForeColor = Color.FromArgb(84, 84, 84);
            btn_search.BackgroundImage = Resources.searchbar_v2_button_up;
        }

        private void txb_search_Enter(object sender, EventArgs e)
        {
            txb_search.ForeColor = Color.FromArgb(0,120,215);
            btn_search.BackgroundImage = Resources.searchbar_v2_button_down;

        }

        private void lb_result_DrawItem(object sender, DrawItemEventArgs e)
        {
            /* int index = e.Index;
             Graphics g = e.Graphics;
             foreach (int selectedIndex in this.lb_result.SelectedIndices)
             {
                 if (index == selectedIndex)
                 {
                     // Draw the new background colour
                     e.DrawBackground();
                     g.FillRectangle(new SolidBrush(Color.FromArgb(28, 28, 30)), e.Bounds);
                 }
             }

             // Get the item details
             Font font = lb_result.Font;
             Color colour = lb_result.ForeColor;
             string text = lb_result.Items[index].ToString();

             // Print the text
             g.DrawString(text, font, new SolidBrush(Color.White), (float)e.Bounds.X, (float)e.Bounds.Y);
             e.DrawFocusRectangle();   */

        }

        private void lb_result_MeasureItem(object sender, MeasureItemEventArgs e)
        {
        }

        private void panel_title_bar2_MouseDown_1(object sender, MouseEventArgs e)
        {
            moving = true;
            panel_title_bar2.Capture = true;
            offset = MousePosition;
            original = this.Location;
        }

        private void panel_title_bar2_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (!moving)
                return;

            int x = original.X + MousePosition.X - offset.X;
            int y = original.Y + MousePosition.Y - offset.Y;

            this.Location = new Point(x, y);
        }

        private void panel_title_bar2_MouseUp_1(object sender, MouseEventArgs e)
        {
            moving = false;
            panel_title_bar2.Capture = false;
        }

        private void btn_close2_Click_1(object sender, EventArgs e)
        {
            btn_close_Click(sender,e);
        }

        private void btn_close2_MouseEnter_1(object sender, EventArgs e)
        {
            btn_close2.BackgroundImage = Resources.close_mouse_over;
        }

        private void btn_close2_MouseLeave_1(object sender, EventArgs e)
        {
            btn_close2.BackgroundImage = Resources.close_button_up1;
        }

        private void btn_minimize2_Click(object sender, EventArgs e)
        {
            btn_minimize_Click(sender, e);
        }

        private void btn_minimize2_MouseEnter(object sender, EventArgs e)
        {
            btn_minimize2.BackgroundImage = Resources.minimize_mouse_over;
        }

        private void btn_minimize2_MouseLeave(object sender, EventArgs e)
        {
            btn_minimize2.BackgroundImage = Resources.minimize_button_up;
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackgroundImage = Resources.change_mouse_over;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = Resources.change_button_up;
        }

        private void btn_download_folder_MouseEnter(object sender, EventArgs e)
        {
            btn_download_folder.BackgroundImage = Resources.change_mouse_over;
        }

        private void btn_download_folder_MouseLeave(object sender, EventArgs e)
        {
            btn_download_folder.BackgroundImage = Resources.change_button_up;
        }

        private void btn_open_download_folder_MouseEnter(object sender, EventArgs e)
        {
            btn_open_download_folder.BackgroundImage = Resources.open_mouse_over;
        }

        private void btn_open_download_folder_MouseLeave(object sender, EventArgs e)
        {
            btn_open_download_folder.BackgroundImage = Resources.open_button_up;
        }

        private void btn_reset_MouseEnter(object sender, EventArgs e)
        {
            btn_reset.BackgroundImage = Resources.reset_mouse_over;
        }

        private void btn_reset_MouseLeave(object sender, EventArgs e)
        {
            btn_reset.BackgroundImage = Resources.reset_button_up;
        }

        private void browseOnWebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lb_result.SelectedIndex >= 0)
            {
                Process.Start(info[lb_result.SelectedIndex].link);
            }
        }

        private void lb_result_MouseDown(object sender, MouseEventArgs e)
        {
            lb_result.SelectedIndex = lb_result.IndexFromPoint(e.X, e.Y);
        }

        private int x = 0;
        private int y = 100;

        string ping;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (btn_back.Enabled == true)
            {
                btn_back.BackgroundImage = Resources.back_button_disabled;
                btn_back.Enabled = false;
                timer1.Stop();
            }
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if(axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                btn_preview.BackgroundImage = Resources.play_button_up_playing;
            }
            else
            {
                btn_preview.BackgroundImage = Resources.play_button_up;

            }
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.BackgroundImage = Resources.change_button_down;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.BackgroundImage = Resources.change_button_up;
        }

        private void btn_download_folder_MouseDown(object sender, MouseEventArgs e)
        {
            btn_download_folder.BackgroundImage = Resources.change_button_down;
        }

        private void btn_download_folder_MouseUp(object sender, MouseEventArgs e)
        {
            btn_download_folder.BackgroundImage = Resources.change_button_up;
        }

        private void btn_open_download_folder_MouseDown(object sender, MouseEventArgs e)
        {
            btn_open_download_folder.BackgroundImage = Resources.open_button_down;
        }

        private void btn_open_download_folder_MouseUp(object sender, MouseEventArgs e)
        {
            btn_open_download_folder.BackgroundImage = Resources.open_button_up;
        }

        private void btn_reset_MouseDown(object sender, MouseEventArgs e)
        {
            btn_reset.BackgroundImage = Resources.reset_button_down;
        }

        private void btn_reset_MouseUp(object sender, MouseEventArgs e)
        {
            btn_reset.BackgroundImage = Resources.reset_button_up;
        }

        private void btn_bitcoin_add_MouseEnter(object sender, EventArgs e)
        {
            btn_bitcoin_add.BackgroundImage = Resources.copy_bitcoin_mouse_over;
        }

        private void btn_bitcoin_add_MouseLeave(object sender, EventArgs e)
        {
            btn_bitcoin_add.BackgroundImage = Resources.copy_bitcoin_button_up;
        }

        private void btn_ether_add_MouseEnter(object sender, EventArgs e)
        {
            btn_ether_add.BackgroundImage = Resources.copy_ethereum_mouse_over;
        }

        private void btn_ether_add_MouseLeave(object sender, EventArgs e)
        {
            btn_ether_add.BackgroundImage = Resources.copy_ethereum_button_up;
        }

        private void btn_monero_add_MouseEnter(object sender, EventArgs e)
        {
            btn_monero_add.BackgroundImage = Resources.copy_monero_mouse_over;
        }

        private void btn_back_Leave(object sender, EventArgs e)
        {

        }

        private void lb_result_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rbt_artist2_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void rbt_album2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rbt_track_2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rb_track2_Click(object sender, EventArgs e)
        {
           
        }

        private void rb_album2_Click(object sender, EventArgs e)
        {
            
        }

        private void rb_artist2_Click(object sender, EventArgs e)
        {
          
        }

        private void rbt_artist2_Click(object sender, EventArgs e)
        {
           

            /*rb_artist2.BackgroundImage = Resources.radio_button_down;
            rb_album2.BackgroundImage = Resources.radio_button_up;
            rb_track2.BackgroundImage = Resources.radio_button_up;*/
        }

        private void rbt_album2_Click(object sender, EventArgs e)
        {
           
            /*rb_artist2.BackgroundImage = Resources.radio_button_up;
            rb_album2.BackgroundImage = Resources.radio_button_down;
            rb_track2.BackgroundImage = Resources.radio_button_up;*/
        }

        private void rbt_track_2_Click(object sender, EventArgs e)
        {
            rb_track2_Click(sender, e);
        }

        private void btn_monero_add_MouseLeave(object sender, EventArgs e)
        {
            btn_monero_add.BackgroundImage = Resources.copy_monero_button_up;
        }
    }
}









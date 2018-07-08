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
using SMLoadrAUX.Properties;
using System.Xml;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Drawing.Text;
using System.Xml.Linq;


namespace SMLoadrAUX
{
    public partial class FrmSMLoadrAUX : Form
    {
        // Prevent Fire Radio Button Event
        bool doRunHandler = true;

        public FrmSMLoadrAUX()
        {
            InitializeComponent();
            
            bgw_check_version.RunWorkerAsync();
            pbx_loading.Visible = true;
            cmb_quality.SelectedIndex = Settings.Default.qual;

            if (Settings.Default.download == "")
            {
                String path = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
                Settings.Default.download = Path.GetFullPath(@"C:\SMLoadr\Downloads");
                Settings.Default.Save();
            }
            else
            {
                if (!Directory.Exists(Settings.Default.download))
                {
                    MessageBox.Show("Path " + Settings.Default.download + " not found or inaccessible",
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    using (var folderDialog = new FolderBrowserDialog())
                    {
                        if (folderDialog.ShowDialog() == DialogResult.OK)
                        {

                            // delete the slashes in case the selected directory is the root of a drive
                            Settings.Default.download = folderDialog.SelectedPath.TrimEnd('\\');
                            Settings.Default.Save();
                            txb_download_folder.Text = Settings.Default.download;
                        }
                        else
                        {
                            MessageBox.Show("The application will now close.", "SMLoadr AUX", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                            Environment.Exit(0);
                        }
                    }

                }
            }
                if (Settings.Default.sm == "")
            {
                MessageBox.Show("+  Results are now unlimited;                                  " + Environment.NewLine + Environment.NewLine + "+  If WMP is not installed user will get a message how to enable;" + Environment.NewLine + Environment.NewLine + "+  Radiobutton checked shows which mode you are in;" + Environment.NewLine + Environment.NewLine + "+  Download path can now be root of mounted volume;" + Environment.NewLine + Environment.NewLine + "+  Cleaned up code & resources.", "Changelog SMLoadr AUX v1.0.5");
                MessageBox.Show("Add the SMLoadr executable! e.g. 'SMLoadr-win-x64_v1.9.2.exe'", "Before you begin...");
                tabControl1.SelectTab(tabControl1.TabPages[1]);
            }


            //Custom Font
            pfc.AddFontFile("Roboto-Regular.ttf");
            
            lb_result.Font = load_font(pfc, 11, Roboto);
            rbt_artist.Font = load_font(pfc, 12, Roboto);
            rbt_album.Font = load_font(pfc, 12, Roboto);
            txb_search.Font = load_font(pfc, 12, Roboto);
            lbl_title.Font = load_font(pfc, 10, Roboto);
            lbl_title2.Font = load_font(pfc, 10, Roboto);
            lbl_path.Font = load_font(pfc, 10, Roboto);
            tabPage1.Font = load_font(pfc, 12, Roboto);
            tabPage2.Font = load_font(pfc, 12, Roboto);
            label5.Font = load_font(pfc, 12, Roboto);
            label4.Font = load_font(pfc, 12, Roboto);
            label1.Font = load_font(pfc, 12, Roboto);
            button1.Font = load_font(pfc, 12, Roboto);
            btn_download_folder.Font = load_font(pfc, 12, Roboto);
            btn_open_download_folder.Font = load_font(pfc, 12, Roboto);
            btn_reset.Font = load_font(pfc, 12, Roboto);
            cmb_quality.Font = load_font(pfc, 12, Roboto);
            btn_monero_add.Font = load_font(pfc, 12, Roboto);
            btn_bitcoin_add.Font = load_font(pfc, 12, Roboto);
            btn_ether_add.Font = load_font(pfc, 12, Roboto);
            
            txb_search.Select();

            //Chart load
            //start_artist = true;
            chart = true;
            xmln = "/root/artists/data/artist";
            bgw_chart.RunWorkerAsync();
            
            txb_download_folder.Text = Settings.Default.download;
            txb_SM_exe.Text = Settings.Default.sm;
        }






        PrivateFontCollection pfc = new PrivateFontCollection();
        string Roboto = "Roboto";
        
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
                    MessageBox.Show("Add the SMLoadr executable! e.g. 'SMLoadr-win-x64_v1.9.2.exe'");
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

                if (rbt_playlist.Checked == true)
                {
                    lb_result.Items.Clear();
                    info.Clear();
                    if (!bgw_playlist.IsBusy)
                    {
                        pbx_loading.Visible = true;
                        bgw_playlist.RunWorkerAsync();
                    }
                }

                if (rbt_url.Checked == true)
                {
                    lb_result.Items.Clear();
                    info.Clear();
                    if (!bgw_url.IsBusy)
                    {
                        pbx_loading.Visible = true;
                        bgw_url.RunWorkerAsync();
                    }
                }

                res = true;
            }
        }









        private void rbt_artist_CheckedChanged(object sender, EventArgs e)
        {
            // Check the handler
            if (!doRunHandler) return;

            artist = true;
            album = false;
            track = false;
            playlist = false;
            url = false;

            btn_preview.Enabled = false;
            lbl_path.Text = "Search by Artist name";
            btn_preview.BackgroundImage = Resources.play_button_up;

            axWindowsMediaPlayer1.URL = "";
            play = false;
            if (txb_search.Text != "" && res == true)
            {
                btn_search_Click(sender, e);
            }
        }









        private void rbt_album_CheckedChanged(object sender, EventArgs e)
        {
            // Check the handler
            if (!doRunHandler) return;

            artist = false;
            album = true;
            track = false;
            playlist = false;
            url = false;

            infob.Clear();

            lbl_path.Text = (txb_search.Text.Trim() == "") ? "Search by Album name" : "Album results for '" + txb_search.Text + "'";

            btn_preview.Enabled = false;
            btn_preview.BackgroundImage = Resources.play_button_up;



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

            // Check the handler
            if (!doRunHandler) return;


            artist = false;
            album = false;
            track = true;
            playlist = false;
            url = false;
            infoc.Clear();
            lbl_path.Text = (txb_search.Text.Trim() == "") ? "Search by Track name" : "Track results for '" + txb_search.Text + "'";

            btn_preview.Enabled = true;




            if (txb_search.Text != "" && res == true)
            {
                btn_search_Click(sender, e);
                pbx_artist.Image = Resources.empty_cover;
            }
        }









        private void rbt_playlist_CheckedChanged(object sender, EventArgs e)
        {
            // Check the handler
            if (!doRunHandler) return;

            artist = false;
            album = true;
            track = false;
            playlist = true;
            url = false;

            infob.Clear();

            lbl_path.Text = (txb_search.Text.Trim() == "") ? "Search by Playlist name" : "Playlist results for '" + txb_search.Text + "'";

            btn_preview.Enabled = false;
            btn_preview.BackgroundImage = Resources.play_button_up;



            axWindowsMediaPlayer1.URL = "";
            play = false;
            if (txb_search.Text != "" && res == true)
            {
                btn_search_Click(sender, e);
            }

            res = true;
        }









        private void rbt_playlist_CheckedChanged_1(object sender, EventArgs e)
        {
            // Check the handler
            if (!doRunHandler) return;

            artist = false;
            album = false;
            track = true;
            playlist = true;
            url = false;
            infoc.Clear();
            lbl_path.Text = "Search by Playlist name";

            btn_preview.Enabled = false;




            if (txb_search.Text != "" && res == true)
            {
                btn_search_Click(sender, e);
                pbx_artist.Image = Resources.empty_cover;
            }
        }









        private void rbt_url_CheckedChanged(object sender, EventArgs e)
        {
            // Check the handler
            if (!doRunHandler) return;

            artist = false;
            album = true;
            track = false;
            playlist = false;
            url = true;

            infob.Clear();

            lbl_path.Text = "Search by URL (playlist only)";

            btn_preview.Enabled = false;
            btn_preview.BackgroundImage = Resources.play_button_up;



            axWindowsMediaPlayer1.URL = "";
            play = false;
            if (txb_search.Text != "" && res == true)
            {
                btn_search_Click(sender, e);
            }

            res = true;
        }









        private void rbt_url_CheckedChanged_1(object sender, EventArgs e)
        {
            artist = false;
            album = false;
            track = true;
            playlist = true;
            url = true;
            infoc.Clear();
            lbl_path.Text = "Search by URL (playlist only)";

            btn_preview.Enabled = false;




            if (txb_search.Text != "" && res == true)
            {
                btn_search_Click(sender, e);
                pbx_artist.Image = Resources.empty_cover;
            }
        }









        private void btn_download_folder_Click(object sender, EventArgs e)
        {
            using (var folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    // delete the slashes in case the selected directory is the root of a drive
                    Settings.Default.download = folderDialog.SelectedPath.TrimEnd('\\');
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









        








        bool res;

        bool artist = true;
        bool album, track, playlist, url;

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

                art = "Album results for " + lb_result.Text;
                lbl_path.Text = art;

                btn_back.Enabled = true;
                btn_back.BackgroundImage = Resources.back_button_up;
                
                //search = info[lb_result.SelectedIndex].name;
                // limit = cmb_limit_results.Text;
                id = info[lb_result.SelectedIndex].id;

                // prevent fire event
                doRunHandler = false;   // disable event
                this.rbt_album.Checked = true;
                doRunHandler = true;    // enable event again

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
                
                // prevent fire event
                doRunHandler = false;   // disable event
                this.rbt_track.Checked = true;
                doRunHandler = true;    // enable event again

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
                playlist = false;
                url = false;

                doRunHandler = false;   // disable event
                this.rbt_album.Checked = true;
                doRunHandler = true;    // enable event again

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
                        doRunHandler = false;   // disable event
                        this.rbt_album.Checked = true;
                        doRunHandler = true;    // enable event again

                        btn_search_Click(sender, e);
                    }
                }
                else
                {
                    manager.CToInfo(infoc, info, lb_result);
                    lb_result.SelectedIndex = lastPos2;
                }

            }
            else if (album == true)
            {
                artist = true;
                album = false;
                track = false;
                playlist = false;
                url = false;

                doRunHandler = false;   // disable event
                this.rbt_artist.Checked = true;
                doRunHandler = true;    // enable event again

                timer1.Start();
                //btn_back.BackgroundImage = Resources.back_button_disabled;
                //btn_back.Enabled = false;
                start_artist = false;
                lbl_path.Text = "Artist results for '" + txb_search.Text + "'";
                
                if (infob.Count <= 0)
                {
                    if (txb_search.Text != "")
                    {
                        doRunHandler = false;   // disable event
                        this.rbt_artist.Checked = true;
                        doRunHandler = true;    // enable event again

                        btn_search_Click(sender, e);
                    }
                }
                else
                {
                    manager.BToInfo(infob, info, lb_result);
                    lb_result.SelectedIndex = lastPos1;
                }
            }

            if (lb_result.Items.Count > 0 && lastPos1 == -1 && lastPos2 == -1)
            {
                lb_result.SelectedIndex = 0;
            }

            // MessageBox.Show(lastPos1.ToString() + " - " + lastPos2.ToString());
            res = true;
        }









        // string a;
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
            List<XmlNode> artistList = new List<XmlNode>();
            XmlNodeList artist;
            string urlNextPage = "";

            // Search
            doc.Load("https://api.deezer.com/search/artist/?q=" + search + "&index=0&limit=0&output=xml");

            // Get next url [if exist]
            urlNextPage = (doc.DocumentElement.SelectNodes("/root/next").Count == 1) ? doc.DocumentElement.SelectNodes("/root/next").Item(0).InnerText : "";

            // looooooooop
            do
            {
                // if we got some url, get tracks and get next url
                if (urlNextPage != "")
                {
                    artist = doc.SelectNodes("/root/data/artist");
                    foreach (XmlNode item in artist)
                    {
                        artistList.Add(item);
                    }

                    doc.Load(urlNextPage);
                    urlNextPage = (doc.DocumentElement.SelectNodes("/root/next").Count == 1) ? doc.DocumentElement.SelectNodes("/root/next").Item(0).InnerText : "";
                }

            } while (urlNextPage != "");

            artist = doc.SelectNodes("/root/data/artist");
            foreach (XmlNode item in artist)
            {
                artistList.Add(item);
            }

            // Delete duplicate
            artistList = artistList.Distinct().ToList();

            // Add the tracks
            foreach (XmlNode node in artistList)
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

            lbl_path.Text = "Artist results for '" + txb_search.Text + "'";

            if (lb_result.Items.Count > 0)
            {
                lb_result.SelectedIndex = 0;
            }
        }









        private void bgw_album_DoWork(object sender, DoWorkEventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            List<XmlNode> albumList = new List<XmlNode>();
            XmlNodeList album;
            string urlNextPage = "";

            // Search
            doc.Load("https://api.deezer.com/search/album/?q=" + search + "&index=0&limit=0&output=xml");

            // Get next url [if exist]
            urlNextPage = (doc.DocumentElement.SelectNodes("/root/next").Count == 1) ? doc.DocumentElement.SelectNodes("/root/next").Item(0).InnerText : "";

            // looooooooop
            do
            {
                // if we got some url, get albums and get next url
                if (urlNextPage != "")
                {
                    album = doc.SelectNodes("/root/data/album");
                    foreach (XmlNode item in album)
                    {
                        albumList.Add(item);
                    }

                    doc.Load(urlNextPage);
                    urlNextPage = (doc.DocumentElement.SelectNodes("/root/next").Count == 1) ? doc.DocumentElement.SelectNodes("/root/next").Item(0).InnerText : "";
                }

            } while (urlNextPage != "");

            album = doc.SelectNodes("/root/data/album");
            foreach (XmlNode item in album)
            {
                albumList.Add(item);
            }

            // Delete duplicate
            albumList = albumList.Distinct().ToList();

            // Add the albums
            foreach (XmlNode node in albumList)
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

            art = "Album results for '" + txb_search.Text + "'";
            lbl_path.Text = art;

            if (lb_result.Items.Count > 0)
            {
                lb_result.SelectedIndex = 0;
            }
        }









        private void bgw_track_DoWork(object sender, DoWorkEventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            List<XmlNode> trackList = new List<XmlNode>();
            XmlNodeList track;
            string urlNextPage = "";

            // Search
            doc.Load("https://api.deezer.com/search/?q=" + search + "&index=0&limit=0&output=xml");

            // Get next url [if exist]
            urlNextPage = (doc.DocumentElement.SelectNodes("/root/next").Count == 1) ? doc.DocumentElement.SelectNodes("/root/next").Item(0).InnerText : "";

            // looooooooop
            do
            {
                // if we got some url, get tracks and get next url
                if (urlNextPage != "")
                {
                    track = doc.SelectNodes("/root/data/track");
                    foreach (XmlNode item in track)
                    {
                        trackList.Add(item);
                    }

                    doc.Load(urlNextPage);
                    urlNextPage = (doc.DocumentElement.SelectNodes("/root/next").Count == 1) ? doc.DocumentElement.SelectNodes("/root/next").Item(0).InnerText : "";
                }
            }

            while (urlNextPage != "");

            track = doc.SelectNodes("/root/data/track");
            foreach (XmlNode item in track)
            {
                trackList.Add(item);
            }

            // Delete duplicate
            trackList = trackList.Distinct().ToList();

            // Add the tracks
            foreach (XmlNode node in trackList)
            {
                info.Add(new list.Info()
                {
                    name = node["title"].InnerText,
                    link = node["link"].InnerText,
                    preview = node["preview"].InnerText,
                    picture = node.SelectSingleNode("artist/picture_medium").InnerText,
                    album = node.SelectSingleNode("album/title").InnerText,
                    duration = node["duration"].InnerText,
                    //artist = node.SelectSingleNode("artist/picture_medium").InnerText
                });
            }
        }









        private void bgw_track_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach (var listbox in info)
            {
                lb_result.Items.Add(listbox.name + " (" + getDuration(listbox.duration.ToString()) + ")");
            }
            pbx_loading.Visible = false;
            alb = "Track results for '" + txb_search.Text + "'";
            lbl_path.Text = alb;

            if (lb_result.Items.Count > 0)
            {
                lb_result.SelectedIndex = 0;
            }
        }









        private void bgw_playlist_DoWork_1(object sender, DoWorkEventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            List<XmlNode> playlistList = new List<XmlNode>();
            XmlNodeList playlist;
            string urlNextPage = "";

            // Search
            doc.Load("https://api.deezer.com/search/playlist/?q=" + search + "&index=0&limit=0&output=xml");

            // Get next url [if exist]
            urlNextPage = (doc.DocumentElement.SelectNodes("/root/next").Count == 1) ? doc.DocumentElement.SelectNodes("/root/next").Item(0).InnerText : "";

            // looooooooop
            do
            {
                // if we got some url, get tracks and get next url
                if (urlNextPage != "")
                {
                    playlist = doc.SelectNodes("/root/data/playlist");
                    foreach (XmlNode item in playlist)
                    {
                        playlistList.Add(item);
                    }

                    doc.Load(urlNextPage);
                    urlNextPage = (doc.DocumentElement.SelectNodes("/root/next").Count == 1) ? doc.DocumentElement.SelectNodes("/root/next").Item(0).InnerText : "";
                }
            }

            while (urlNextPage != "");

            playlist = doc.SelectNodes("/root/data/playlist");
            foreach (XmlNode item in playlist)
            {
                playlistList.Add(item);
            }

            // Delete duplicate
            playlistList = playlistList.Distinct().ToList();

            // Add the tracks
            foreach (XmlNode node in playlistList)
            {
                info.Add(new list.Info()
                {
                    name = node["title"].InnerText,
                    link = node["link"].InnerText,
                    id = node["id"].InnerText,
                    picture = node["picture_medium"].InnerText
                });
            }
        }









        private void bgw_playlist_RunWorkerCompleted_1(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach (var listbox in info)
            {
                lb_result.Items.Add(listbox.name);
            }
            pbx_loading.Visible = false;
            lbl_path.Text = "Playlist results for '" + txb_search.Text + "'";

            if (lb_result.Items.Count > 0)
            {
                lb_result.SelectedIndex = 0;
            }
        }









        string CleanDomainName(string url)
        {
            var uri = url.Contains("http://") ? new Uri(url) : new Uri("http://" + url);
            var parts = uri.Host.Split('.');
            return string.Join(".", parts.Skip(parts.Length - 2));
        }

        private void bgw_url_DoWork_1(object sender, DoWorkEventArgs e)
        {
            string queryResult = "";
            long n;

            // Check valid url before check format
            Uri uriResult;
            bool validUrl = Uri.TryCreate(search, UriKind.Absolute, out uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);

            if (validUrl == false) return;

            // Split the url
            Uri uriDeezer = new Uri(search);
            string[] urlDeezer = uriDeezer.Segments
                    .Select(s => s.EndsWith("/") ? s.Substring(0, s.Length - 1) : s)
                    .ToArray();
            bool isNumeric = long.TryParse(urlDeezer[3].Trim(), out n);


            if (urlDeezer[2].ToLower() != "playlist" || isNumeric == false)
            {
                // The url is invalid
                return;
            }

            // Get xml with the info
            using (WebClient wc = new WebClient())
            {
                queryResult = wc.DownloadString("http://api.deezer.com/playlist/" + urlDeezer[3] + "/?output=xml");
            }

            if (TryParseXml(queryResult) == false) return;


            XmlDocument docPlaylist = new XmlDocument();
            docPlaylist.LoadXml(queryResult);


            if (docPlaylist.SelectNodes("//root/error").Count == 0)
            {
                // Not error
                info.Add(new list.Info()
                {
                    name = (docPlaylist.SelectNodes("//root/title").Count == 1) ? docPlaylist.SelectNodes("//root/title").Item(0).InnerText : "",
                    link = (docPlaylist.SelectNodes("//root/link").Count == 1) ? docPlaylist.SelectNodes("//root/link").Item(0).InnerText : "",
                    id = (docPlaylist.SelectNodes("//root/id").Count == 1) ? docPlaylist.SelectNodes("//root/id").Item(0).InnerText : "",
                    picture = (docPlaylist.SelectNodes("//root/picture").Count == 1) ? docPlaylist.SelectNodes("//root/picture").Item(0).InnerText : ""
                });

            }
        }

        // check if xml is valid
        private bool TryParseXml(string xml)
        {
            try
            {
                XDocument.Parse(xml);
                return true;
            }
            catch (XmlException)
            {
                return false;
            }
        }









        private void bgw_url_RunWorkerCompleted_1(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach (var listbox in info)
            {
                lb_result.Items.Add(listbox.name);
            }
            pbx_loading.Visible = false;

            lbl_path.Text = "URL result for '" + txb_search.Text + "'";

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

        private void bgw_album_double_DoWork(object sender, DoWorkEventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            List<XmlNode> albumList = new List<XmlNode>();
            XmlNodeList album;
            string urlNextPage = "";

            // Search
            doc.Load("http://api.deezer.com/artist/" + id + "/albums/?index=0&limit=0&output=xml");

            // Get next url [if exist]
            urlNextPage = (doc.DocumentElement.SelectNodes("/root/next").Count == 1) ? doc.DocumentElement.SelectNodes("/root/next").Item(0).InnerText : "";

            // looooooooop
            do
            {
                // if we got some url, get albums and get next url
                if (urlNextPage != "")
                {
                    album = doc.SelectNodes("/root/data/album");
                    foreach (XmlNode item in album)
                    {
                        albumList.Add(item);
                    }

                    doc.Load(urlNextPage);
                    urlNextPage = (doc.DocumentElement.SelectNodes("/root/next").Count == 1) ? doc.DocumentElement.SelectNodes("/root/next").Item(0).InnerText : "";
                }

            } while (urlNextPage != "");

            album = doc.SelectNodes("/root/data/album");
            foreach (XmlNode item in album)
            {
                albumList.Add(item);
            }

            // Delete duplicate
            albumList = albumList.Distinct().ToList();

            // Add the albums
            foreach (XmlNode node in albumList)
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









        private void bgw_track_double_DoWork(object sender, DoWorkEventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            List<XmlNode> trackList = new List<XmlNode>();
            XmlNodeList track;
            string urlNextPage = "";

            // Search
            doc.Load("http://api.deezer.com/album/" + id + "/?index=0&limit=&output=xml");

            // Get next url [if exist]
            urlNextPage = (doc.DocumentElement.SelectNodes("/root/next").Count == 1) ? doc.DocumentElement.SelectNodes("/root/next").Item(0).InnerText : "";

            // looooooooop
            do
            {
                // if we got some url, get tracks and get next url
                if (urlNextPage != "")
                {
                    track = doc.SelectNodes("/root/tracks/data/track");
                    foreach (XmlNode item in track)
                    {
                        trackList.Add(item);
                    }

                    doc.Load(urlNextPage);
                    urlNextPage = (doc.DocumentElement.SelectNodes("/root/next").Count == 1) ? doc.DocumentElement.SelectNodes("/root/next").Item(0).InnerText : "";
                }

            } while (urlNextPage != "");

            track = doc.SelectNodes("/root/tracks/data/track");
            foreach (XmlNode item in track)
            {
                trackList.Add(item);
            }

            // Delete duplicate
            trackList = trackList.Distinct().ToList();

            // Add the tracks
            foreach (XmlNode node in trackList)
            {
                info.Add(new list.Info()
                {
                    name = node["title"].InnerText,
                    link = node["link"].InnerText,
                    preview = node["preview"].InnerText,
                    picture = node.SelectSingleNode("/root/cover_medium").InnerText,
                    album = node.SelectSingleNode("/root/title").InnerText,
                    duration = node["duration"].InnerText
                });

            }
        }










        private void bgw_track_double_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach (var listbox in info)
            {
                lb_result.Items.Add(listbox.name + " (" + getDuration(listbox.duration.ToString()) + ")");
            }
            pbx_loading.Visible = false;
            if (lb_result.Items.Count > 0)
            {
                lb_result.SelectedIndex = 0;
            }
        }









        private string getDuration(string seconds)
        {
            string duration = "";
            double result;
            try
            {
                if (double.TryParse(seconds, out result))
                {
                    TimeSpan timeSong = TimeSpan.FromSeconds(result);
                    duration = string.Format("{0}:{1:00}", (int)timeSong.TotalMinutes, timeSong.Seconds);
                }
                else
                {
                    duration = seconds;
                }
            }
            catch (Exception)
            {
                duration = seconds;
            }
            return duration;
        }









        private void bgw_search_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach (var listbox in info)
            {
                lb_result.Items.Add(listbox.name);
            }
            pbx_loading.Visible = false;
            lbl_path.Text = "Charts";

            if (lb_result.Items.Count > 0)
            {
                lb_result.SelectedIndex = 0;
            }
        }









        string xmln;


        private void bgw_search_DoWork(object sender, DoWorkEventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("http://api.deezer.com/chart/&limit=0&output=xml");

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
            btn_settings.BackgroundImage = Resources.SettingsButtonDown;
        }




        private void btn_settings_MouseLeave(object sender, EventArgs e)
        {
            btn_settings.BackgroundImage = Resources.SettingsButtonUp;
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
            btn_tmain.BackgroundImage = Resources.SearchButtonDown;
        }




        private void btn_tmain_MouseLeave(object sender, EventArgs e)
        {
            btn_tmain.BackgroundImage = Resources.SearchButtonUp;
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




        private void rb_playlist_Click_1(object sender, EventArgs e)
        {
            rbt_playlist.Checked = true;
        }




        private void rb_url_Click_1(object sender, EventArgs e)
        {
            rbt_url.Checked = true;
        }




        



       



       




       




       



        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }




        private void btn_close2_Click(object sender, EventArgs e)
        {
            btn_close_Click(sender, e);
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
            btn_back.BackgroundImage = Resources.back_button_down;
        }




        private void btn_back_MouseUp(object sender, MouseEventArgs e)
        {
            if (btn_back.Enabled == false)
            {
                btn_back.BackgroundImage = Resources.back_button_up;
            }
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
            btn_close.BackgroundImage = Resources.close_button_up;
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




        private void txb_search_Leave(object sender, EventArgs e)
        {
            txb_search.ForeColor = Color.FromArgb(93, 92, 101);
            btn_search.BackgroundImage = Resources.searchbar_button_up;
        }




        private void txb_search_Enter(object sender, EventArgs e)
        {
            txb_search.ForeColor = Color.FromArgb(251,250,255);
            btn_search.BackgroundImage = Resources.searchbar_button_down;
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
            btn_close2.BackgroundImage = Resources.close_button_up;
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btn_ether_add_MouseLeave(object sender, EventArgs e)
        {
            btn_ether_add.BackgroundImage = Resources.copy_ethereum_button_up;
        }




        private void btn_monero_add_MouseEnter(object sender, EventArgs e)
        {
            btn_monero_add.BackgroundImage = Resources.copy_monero_mouse_over;
        }




        private void btn_monero_add_MouseLeave(object sender, EventArgs e)
        {
            btn_monero_add.BackgroundImage = Resources.copy_monero_button_up;
        }
    }
}
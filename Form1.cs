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


namespace SMLoader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmb_quality.SelectedIndex = Settings.Default.qual;

            if(Settings.Default.download == "")
            {
                String path = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
                Settings.Default.download = path + @"\SM\";
                Settings.Default.Save();
                //MessageBox.Show(path + @"\SM\");
            }

            txb_download_folder.Text = Settings.Default.download;
            txb_SM_exe.Text = Settings.Default.sm;

            if(Settings.Default.sm == "")
            {
                MessageBox.Show("Add a SMLoadr executable!");
                tabControl1.SelectTab(tabControl1.TabPages[1]);
            }

        }
        public Process download = new Process();

        System.Media.SoundPlayer player = new System.Media.SoundPlayer();



        private void btn_go_Click(object sender, EventArgs e)
        {
            string quality = "";

            if (cmb_quality.SelectedIndex == 0)
            {
                quality = "MP3_128";

            }

            if (cmb_quality.SelectedIndex == 1)
            {
                quality = "MP3_320";
            }

            if (cmb_quality.SelectedIndex == 2)
            {
                quality = "FLAC";
            }


            if (txb_search.Text != "" && lb_result.SelectedIndex >= 0)
            {

                if (Settings.Default.sm != "")
                {
                    if (rbt_artist.Checked == true)
                    {
                        download.StartInfo.FileName = Settings.Default.sm;
                        string a = @"-q " + quality + " -p " + Settings.Default.download + " " + artist[lb_result.SelectedIndex].link + "";
                        download.StartInfo.Arguments = a;
                    }

                    if (rbt_album.Checked == true)
                    {
                        download.StartInfo.FileName = Settings.Default.sm;
                        string a = @"-q " + quality + " -p " + Settings.Default.download + " " + album[lb_result.SelectedIndex].link + "";
                        download.StartInfo.Arguments = a;
                    }

                    if (rbt_track.Checked == true)
                    {
                        download.StartInfo.FileName = Settings.Default.sm;
                        string a = @"-q " + quality + " -p " + Settings.Default.download + " " + track[lb_result.SelectedIndex].link + "";
                        download.StartInfo.Arguments = a;
                    }

                    download.Start();
                }
                else
                {
                    MessageBox.Show("Add a SMLoadr executable!");
                    tabControl1.SelectTab(tabControl1.TabPages[1]);
                }
            }


        }





        private void backgroundWorker1_DoWork_1(object sender, DoWorkEventArgs e)
        {
            while (!download.StandardOutput.EndOfStream)
            {
                string fa = download.StandardOutput.ReadLine();

            }
        }

        private void cmb_quality_SelectedIndexChanged(object sender, EventArgs e)
        {
            Settings.Default.qual = cmb_quality.SelectedIndex;
            Settings.Default.Save();

        }


        private void lb_result_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if (rbt_artist.Checked == true)
            {

                pbx_artist.ImageLocation = artist[lb_result.SelectedIndex].pic;
                btn_go.Text = "Download discography: " + lb_result.Text;
            }

            if (rbt_album.Checked == true)
            {
                pbx_artist.ImageLocation = album[lb_result.SelectedIndex].pic;

                btn_go.Text = "Download album: " + lb_result.Text;

            }

            if (rbt_track.Checked == true)
            {

                btn_go.Text = "Download track: " + lb_result.Text;

                if (lb_result.SelectedIndex >= 0)
                {
                    btn_preview.Enabled = true;
                }
            }


        }

        private void rbt_artist_CheckedChanged(object sender, EventArgs e)
        {
            btn_preview.Enabled = false;
            if (txb_search.Text != "")
            {
                btn_search_Click(sender, e);
            }
        }

        private void rbt_album_CheckedChanged(object sender, EventArgs e)
        {
            btn_preview.Enabled = false;
            if (txb_search.Text != "")
            {
                btn_search_Click(sender, e);
            }
        }

        private void rbt_track_CheckedChanged(object sender, EventArgs e)
        {
            if (txb_search.Text != "")
            {
                btn_search_Click(sender, e);
            }
            pbx_artist.Image = Resources.cd_icon_46229;
        }


        XmlDocument doc = new XmlDocument();

        List<list.Artist> artist = new List<list.Artist>();
        List<list.Album> album = new List<list.Album>();
        List<list.Track> track = new List<list.Track>();

        private void btn_search_Click(object sender, EventArgs e)
        {

            if (rbt_artist.Checked == true)
            {

                doc.Load("https://api.deezer.com/search/artist/?q=" + txb_search.Text + "&index=0&limit=50&output=xml");
                XmlElement root = doc.DocumentElement;
                XmlNodeList nodes = root.SelectNodes("/root/data/artist");
                lb_result.Items.Clear();
                artist.Clear();
                foreach (XmlNode node in nodes)
                {

                    artist.Add(new list.Artist() { name = node["name"].InnerText, link = node["link"].InnerText, pic = node["picture_medium"].InnerText });

                }
                foreach (var listbox in artist)
                {
                    lb_result.Items.Add(listbox.name);

                }
            }

            if (rbt_album.Checked == true)
            {
                doc.Load("https://api.deezer.com/search/album/?q=" + txb_search.Text + "&index=0&limit=50&output=xml");
                XmlElement root = doc.DocumentElement;
                XmlNodeList nodes = root.SelectNodes("/root/data/album");
                lb_result.Items.Clear();
                album.Clear();

                foreach (XmlNode node in nodes)
                {

                    album.Add(new list.Album()
                    {
                        title = node["title"].InnerText,
                        link = node["link"].InnerText,
                        pic = node["cover_medium"].InnerText


                    });

                }

                foreach (var listbox in album)
                {
                    lb_result.Items.Add(listbox.title);
                }
            }

            if (rbt_track.Checked == true)
            {
                doc.Load("https://api.deezer.com/search/?q=" + txb_search.Text + "&index=0&limit=50&output=xml");
                XmlElement root = doc.DocumentElement;
                XmlNodeList nodes = root.SelectNodes("/root/data/track");
                lb_result.Items.Clear();
                track.Clear();


                foreach (XmlNode node in nodes)
                {

                    track.Add(new list.Track() { title = node["title"].InnerText, link = node["link"].InnerText, mp3 = node["preview"].InnerText });

                }

                foreach (var listbox in track)
                {
                    lb_result.Items.Add(listbox.title);
                }
            }
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

        private void btn_preview_Click(object sender, EventArgs e)
        {

            axWindowsMediaPlayer1.URL = track[lb_result.SelectedIndex].mp3;
            // axWindowsMediaPlayer1.Ctlcontrols.play();
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
    }
}
    
    


    


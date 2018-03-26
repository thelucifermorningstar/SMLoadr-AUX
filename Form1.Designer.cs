namespace SMLoader
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmb_quality = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txb_search = new System.Windows.Forms.TextBox();
            this.lb_result = new System.Windows.Forms.ListBox();
            this.rbt_artist = new System.Windows.Forms.RadioButton();
            this.rbt_album = new System.Windows.Forms.RadioButton();
            this.rbt_track = new System.Windows.Forms.RadioButton();
            this.btn_download_folder = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pbx_loading = new System.Windows.Forms.PictureBox();
            this.lbl_info = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.btn_sort = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.cmb_limit_results = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_preview = new System.Windows.Forms.Button();
            this.btn_go = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.pbx_artist = new System.Windows.Forms.PictureBox();
            this.pbx_background = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_reset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txb_SM_exe = new System.Windows.Forms.TextBox();
            this.btn_ether_add = new System.Windows.Forms.Button();
            this.btn_bitcoin_add = new System.Windows.Forms.Button();
            this.btn_monero_add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_open_download_folder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_download_folder = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bgw_artist = new System.ComponentModel.BackgroundWorker();
            this.bgw_album = new System.ComponentModel.BackgroundWorker();
            this.bgw_track = new System.ComponentModel.BackgroundWorker();
            this.bgw_check_version = new System.ComponentModel.BackgroundWorker();
            this.bgw_track_double = new System.ComponentModel.BackgroundWorker();
            this.bgw_album_double = new System.ComponentModel.BackgroundWorker();
            this.bgw_search = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_loading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_artist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_background)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_quality
            // 
            this.cmb_quality.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_quality.FormattingEnabled = true;
            this.cmb_quality.Items.AddRange(new object[] {
            "MP3 128 kbps",
            "MP3 320 kbps",
            "FLAC 1411 kbps"});
            this.cmb_quality.Location = new System.Drawing.Point(143, 130);
            this.cmb_quality.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_quality.Name = "cmb_quality";
            this.cmb_quality.Size = new System.Drawing.Size(173, 27);
            this.cmb_quality.TabIndex = 2;
            this.cmb_quality.SelectedIndexChanged += new System.EventHandler(this.cmb_quality_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            // 
            // txb_search
            // 
            this.txb_search.BackColor = System.Drawing.Color.Gainsboro;
            this.txb_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_search.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_search.Location = new System.Drawing.Point(4, 38);
            this.txb_search.Margin = new System.Windows.Forms.Padding(4);
            this.txb_search.Multiline = true;
            this.txb_search.Name = "txb_search";
            this.txb_search.Size = new System.Drawing.Size(600, 27);
            this.txb_search.TabIndex = 5;
            this.txb_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_search_KeyDown);
            // 
            // lb_result
            // 
            this.lb_result.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_result.FormattingEnabled = true;
            this.lb_result.ItemHeight = 19;
            this.lb_result.Location = new System.Drawing.Point(4, 109);
            this.lb_result.Margin = new System.Windows.Forms.Padding(4);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(350, 232);
            this.lb_result.TabIndex = 6;
            this.lb_result.SelectedIndexChanged += new System.EventHandler(this.lb_result_SelectedIndexChanged);
            this.lb_result.DoubleClick += new System.EventHandler(this.lb_result_DoubleClick);
            // 
            // rbt_artist
            // 
            this.rbt_artist.AutoSize = true;
            this.rbt_artist.Checked = true;
            this.rbt_artist.Location = new System.Drawing.Point(203, 7);
            this.rbt_artist.Margin = new System.Windows.Forms.Padding(4);
            this.rbt_artist.Name = "rbt_artist";
            this.rbt_artist.Size = new System.Drawing.Size(81, 23);
            this.rbt_artist.TabIndex = 8;
            this.rbt_artist.TabStop = true;
            this.rbt_artist.Text = "Artist";
            this.rbt_artist.UseVisualStyleBackColor = true;
            this.rbt_artist.CheckedChanged += new System.EventHandler(this.rbt_artist_CheckedChanged);
            // 
            // rbt_album
            // 
            this.rbt_album.AutoSize = true;
            this.rbt_album.Location = new System.Drawing.Point(292, 7);
            this.rbt_album.Margin = new System.Windows.Forms.Padding(4);
            this.rbt_album.Name = "rbt_album";
            this.rbt_album.Size = new System.Drawing.Size(72, 23);
            this.rbt_album.TabIndex = 9;
            this.rbt_album.Text = "Album";
            this.rbt_album.UseVisualStyleBackColor = true;
            this.rbt_album.CheckedChanged += new System.EventHandler(this.rbt_album_CheckedChanged);
            // 
            // rbt_track
            // 
            this.rbt_track.AutoSize = true;
            this.rbt_track.Location = new System.Drawing.Point(372, 7);
            this.rbt_track.Margin = new System.Windows.Forms.Padding(4);
            this.rbt_track.Name = "rbt_track";
            this.rbt_track.Size = new System.Drawing.Size(72, 23);
            this.rbt_track.TabIndex = 12;
            this.rbt_track.Text = "Track";
            this.rbt_track.UseVisualStyleBackColor = true;
            this.rbt_track.CheckedChanged += new System.EventHandler(this.rbt_track_CheckedChanged);
            // 
            // btn_download_folder
            // 
            this.btn_download_folder.Location = new System.Drawing.Point(450, 93);
            this.btn_download_folder.Margin = new System.Windows.Forms.Padding(4);
            this.btn_download_folder.Name = "btn_download_folder";
            this.btn_download_folder.Size = new System.Drawing.Size(70, 27);
            this.btn_download_folder.TabIndex = 16;
            this.btn_download_folder.Text = "Change";
            this.btn_download_folder.UseVisualStyleBackColor = true;
            this.btn_download_folder.Click += new System.EventHandler(this.btn_download_folder_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(421, 296);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(226, 42);
            this.axWindowsMediaPlayer1.TabIndex = 17;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(662, 401);
            this.tabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pbx_loading);
            this.tabPage1.Controls.Add(this.lbl_info);
            this.tabPage1.Controls.Add(this.lbl_status);
            this.tabPage1.Controls.Add(this.btn_sort);
            this.tabPage1.Controls.Add(this.btn_back);
            this.tabPage1.Controls.Add(this.cmb_limit_results);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.rbt_artist);
            this.tabPage1.Controls.Add(this.btn_preview);
            this.tabPage1.Controls.Add(this.btn_go);
            this.tabPage1.Controls.Add(this.rbt_album);
            this.tabPage1.Controls.Add(this.rbt_track);
            this.tabPage1.Controls.Add(this.btn_search);
            this.tabPage1.Controls.Add(this.lb_result);
            this.tabPage1.Controls.Add(this.pbx_artist);
            this.tabPage1.Controls.Add(this.txb_search);
            this.tabPage1.Controls.Add(this.axWindowsMediaPlayer1);
            this.tabPage1.Controls.Add(this.pbx_background);
            this.tabPage1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(654, 369);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pbx_loading
            // 
            this.pbx_loading.Image = global::SMLoader.Properties.Resources.giphy;
            this.pbx_loading.Location = new System.Drawing.Point(4, 109);
            this.pbx_loading.Margin = new System.Windows.Forms.Padding(4);
            this.pbx_loading.Name = "pbx_loading";
            this.pbx_loading.Size = new System.Drawing.Size(350, 232);
            this.pbx_loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbx_loading.TabIndex = 26;
            this.pbx_loading.TabStop = false;
            this.pbx_loading.Visible = false;
            // 
            // lbl_info
            // 
            this.lbl_info.BackColor = System.Drawing.Color.White;
            this.lbl_info.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.Location = new System.Drawing.Point(415, 326);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(232, 15);
            this.lbl_info.TabIndex = 25;
            this.lbl_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_status
            // 
            this.lbl_status.BackColor = System.Drawing.Color.White;
            this.lbl_status.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.Location = new System.Drawing.Point(4, 342);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(351, 15);
            this.lbl_status.TabIndex = 24;
            this.lbl_status.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_sort
            // 
            this.btn_sort.Location = new System.Drawing.Point(380, 71);
            this.btn_sort.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(64, 27);
            this.btn_sort.TabIndex = 23;
            this.btn_sort.Text = "Sort";
            this.btn_sort.UseVisualStyleBackColor = true;
            this.btn_sort.Visible = false;
            this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackgroundImage = global::SMLoader.Properties.Resources.arrow_back_black_192x192;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Location = new System.Drawing.Point(4, 76);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(30, 30);
            this.btn_back.TabIndex = 22;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // cmb_limit_results
            // 
            this.cmb_limit_results.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_limit_results.FormattingEnabled = true;
            this.cmb_limit_results.Items.AddRange(new object[] {
            "1 ",
            "2 ",
            "3 ",
            "4 ",
            "5 ",
            "6 ",
            "7 ",
            "8 ",
            "9 ",
            "10 ",
            "11 ",
            "12 ",
            "13 ",
            "14 ",
            "15 ",
            "16 ",
            "17 ",
            "18 ",
            "19 ",
            "20 ",
            "21 ",
            "22 ",
            "23 ",
            "24 ",
            "25 ",
            "26 ",
            "27 ",
            "28 ",
            "29 ",
            "30 ",
            "31 ",
            "32 ",
            "33 ",
            "34 ",
            "35 ",
            "36 ",
            "37 ",
            "38 ",
            "39 ",
            "40 ",
            "41 ",
            "42 ",
            "43 ",
            "44 ",
            "45 ",
            "46 ",
            "47 ",
            "48 ",
            "49 ",
            "50 ",
            "51 ",
            "52 ",
            "53 ",
            "54 ",
            "55 ",
            "56 ",
            "57 ",
            "58 ",
            "59 ",
            "60 ",
            "61 ",
            "62 ",
            "63 ",
            "64 ",
            "65 ",
            "66 ",
            "67 ",
            "68 ",
            "69 ",
            "70 ",
            "71 ",
            "72 ",
            "73 ",
            "74 ",
            "75 ",
            "76 ",
            "77 ",
            "78 ",
            "79 ",
            "80 ",
            "81 ",
            "82 ",
            "83 ",
            "84 ",
            "85 ",
            "86 ",
            "87 ",
            "88 ",
            "89 ",
            "90 ",
            "91 ",
            "92 ",
            "93 ",
            "94 ",
            "95 ",
            "96 ",
            "97 ",
            "98 ",
            "99 ",
            "100 ",
            "101 ",
            "102 ",
            "103 ",
            "104 ",
            "105 ",
            "106 ",
            "107 ",
            "108 ",
            "109 ",
            "110 ",
            "111 ",
            "112 ",
            "113 ",
            "114 ",
            "115 ",
            "116 ",
            "117 ",
            "118 ",
            "119 ",
            "120 ",
            "121 ",
            "122 ",
            "123 ",
            "124 ",
            "125 ",
            "126 ",
            "127 ",
            "128 ",
            "129 ",
            "130 ",
            "131 ",
            "132 ",
            "133 ",
            "134 ",
            "135 ",
            "136 ",
            "137 ",
            "138 ",
            "139 ",
            "140 ",
            "141 ",
            "142 ",
            "143 ",
            "144 ",
            "145 ",
            "146 ",
            "147 ",
            "148 ",
            "149 ",
            "150 ",
            "151 ",
            "152 ",
            "153 ",
            "154 ",
            "155 ",
            "156 ",
            "157 ",
            "158 ",
            "159 ",
            "160 ",
            "161 ",
            "162 ",
            "163 ",
            "164 ",
            "165 ",
            "166 ",
            "167 ",
            "168 ",
            "169 ",
            "170 ",
            "171 ",
            "172 ",
            "173 ",
            "174 ",
            "175 ",
            "176 ",
            "177 ",
            "178 ",
            "179 ",
            "180 ",
            "181 ",
            "182 ",
            "183 ",
            "184 ",
            "185 ",
            "186 ",
            "187 ",
            "188 ",
            "189 ",
            "190 ",
            "191 ",
            "192 ",
            "193 ",
            "194 ",
            "195 ",
            "196 ",
            "197 ",
            "198 ",
            "199 ",
            "200"});
            this.cmb_limit_results.Location = new System.Drawing.Point(287, 76);
            this.cmb_limit_results.Name = "cmb_limit_results";
            this.cmb_limit_results.Size = new System.Drawing.Size(67, 27);
            this.cmb_limit_results.TabIndex = 21;
            this.cmb_limit_results.SelectedIndexChanged += new System.EventHandler(this.cmb_limit_results_SelectedIndexChanged);
            this.cmb_limit_results.TextUpdate += new System.EventHandler(this.cmb_limit_results_TextUpdate);
            this.cmb_limit_results.SelectedValueChanged += new System.EventHandler(this.cmb_limit_results_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(119, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 19);
            this.label6.TabIndex = 20;
            this.label6.Text = "Limit Results to:";
            // 
            // btn_preview
            // 
            this.btn_preview.BackColor = System.Drawing.Color.Transparent;
            this.btn_preview.BackgroundImage = global::SMLoader.Properties.Resources.if_play_circle_fill_326581Disable21;
            this.btn_preview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_preview.Enabled = false;
            this.btn_preview.FlatAppearance.BorderSize = 0;
            this.btn_preview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_preview.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_preview.Location = new System.Drawing.Point(362, 197);
            this.btn_preview.Margin = new System.Windows.Forms.Padding(0);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(45, 45);
            this.btn_preview.TabIndex = 18;
            this.btn_preview.UseVisualStyleBackColor = false;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // btn_go
            // 
            this.btn_go.BackgroundImage = global::SMLoader.Properties.Resources.if_178_Download_183297;
            this.btn_go.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_go.FlatAppearance.BorderSize = 0;
            this.btn_go.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_go.Location = new System.Drawing.Point(362, 293);
            this.btn_go.Margin = new System.Windows.Forms.Padding(4);
            this.btn_go.Name = "btn_go";
            this.btn_go.Size = new System.Drawing.Size(45, 45);
            this.btn_go.TabIndex = 1;
            this.btn_go.UseVisualStyleBackColor = true;
            this.btn_go.Click += new System.EventHandler(this.btn_go_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackgroundImage = global::SMLoader.Properties.Resources.search;
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Location = new System.Drawing.Point(612, 38);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(27, 27);
            this.btn_search.TabIndex = 13;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // pbx_artist
            // 
            this.pbx_artist.Image = global::SMLoader.Properties.Resources.Music_2123892;
            this.pbx_artist.Location = new System.Drawing.Point(415, 109);
            this.pbx_artist.Margin = new System.Windows.Forms.Padding(4);
            this.pbx_artist.Name = "pbx_artist";
            this.pbx_artist.Size = new System.Drawing.Size(232, 232);
            this.pbx_artist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_artist.TabIndex = 14;
            this.pbx_artist.TabStop = false;
            // 
            // pbx_background
            // 
            this.pbx_background.Location = new System.Drawing.Point(-4, 0);
            this.pbx_background.Margin = new System.Windows.Forms.Padding(4);
            this.pbx_background.Name = "pbx_background";
            this.pbx_background.Size = new System.Drawing.Size(662, 362);
            this.pbx_background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_background.TabIndex = 27;
            this.pbx_background.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_reset);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.txb_SM_exe);
            this.tabPage2.Controls.Add(this.btn_ether_add);
            this.tabPage2.Controls.Add(this.btn_bitcoin_add);
            this.tabPage2.Controls.Add(this.btn_monero_add);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btn_open_download_folder);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.txb_download_folder);
            this.tabPage2.Controls.Add(this.btn_download_folder);
            this.tabPage2.Controls.Add(this.cmb_quality);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(654, 369);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(450, 130);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(4);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(138, 27);
            this.btn_reset.TabIndex = 29;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 19);
            this.label5.TabIndex = 28;
            this.label5.Text = "SMLoadr Executable";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 19);
            this.label4.TabIndex = 27;
            this.label4.Text = "Download Folder";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(518, 30);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 27);
            this.button1.TabIndex = 26;
            this.button1.Text = "Change";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txb_SM_exe
            // 
            this.txb_SM_exe.Enabled = false;
            this.txb_SM_exe.Location = new System.Drawing.Point(7, 30);
            this.txb_SM_exe.Margin = new System.Windows.Forms.Padding(4);
            this.txb_SM_exe.Name = "txb_SM_exe";
            this.txb_SM_exe.ReadOnly = true;
            this.txb_SM_exe.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txb_SM_exe.Size = new System.Drawing.Size(503, 27);
            this.txb_SM_exe.TabIndex = 25;
            // 
            // btn_ether_add
            // 
            this.btn_ether_add.Location = new System.Drawing.Point(417, 321);
            this.btn_ether_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ether_add.Name = "btn_ether_add";
            this.btn_ether_add.Size = new System.Drawing.Size(166, 27);
            this.btn_ether_add.TabIndex = 24;
            this.btn_ether_add.Text = "Copy Ether Address";
            this.btn_ether_add.UseVisualStyleBackColor = true;
            this.btn_ether_add.Click += new System.EventHandler(this.btn_ether_add_Click);
            // 
            // btn_bitcoin_add
            // 
            this.btn_bitcoin_add.Location = new System.Drawing.Point(243, 321);
            this.btn_bitcoin_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_bitcoin_add.Name = "btn_bitcoin_add";
            this.btn_bitcoin_add.Size = new System.Drawing.Size(166, 27);
            this.btn_bitcoin_add.TabIndex = 23;
            this.btn_bitcoin_add.Text = "Copy Bitcoin Address";
            this.btn_bitcoin_add.UseVisualStyleBackColor = true;
            this.btn_bitcoin_add.Click += new System.EventHandler(this.btn_bitcoin_add_Click);
            // 
            // btn_monero_add
            // 
            this.btn_monero_add.Location = new System.Drawing.Point(69, 321);
            this.btn_monero_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_monero_add.Name = "btn_monero_add";
            this.btn_monero_add.Size = new System.Drawing.Size(166, 27);
            this.btn_monero_add.TabIndex = 22;
            this.btn_monero_add.Text = "Copy Monero Address";
            this.btn_monero_add.UseVisualStyleBackColor = true;
            this.btn_monero_add.Click += new System.EventHandler(this.btn_monero_add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "Set free some souls from hell today: Donate!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(239, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Coded in Hell by Lucifer";
            // 
            // btn_open_download_folder
            // 
            this.btn_open_download_folder.Location = new System.Drawing.Point(521, 93);
            this.btn_open_download_folder.Margin = new System.Windows.Forms.Padding(4);
            this.btn_open_download_folder.Name = "btn_open_download_folder";
            this.btn_open_download_folder.Size = new System.Drawing.Size(67, 27);
            this.btn_open_download_folder.TabIndex = 19;
            this.btn_open_download_folder.Text = "Open";
            this.btn_open_download_folder.UseVisualStyleBackColor = true;
            this.btn_open_download_folder.Click += new System.EventHandler(this.btn_open_download_folder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Download Quality";
            // 
            // txb_download_folder
            // 
            this.txb_download_folder.Enabled = false;
            this.txb_download_folder.Location = new System.Drawing.Point(7, 93);
            this.txb_download_folder.Margin = new System.Windows.Forms.Padding(4);
            this.txb_download_folder.Name = "txb_download_folder";
            this.txb_download_folder.ReadOnly = true;
            this.txb_download_folder.Size = new System.Drawing.Size(435, 27);
            this.txb_download_folder.TabIndex = 17;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // bgw_artist
            // 
            this.bgw_artist.WorkerSupportsCancellation = true;
            this.bgw_artist.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_artist_DoWork_1);
            this.bgw_artist.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_artist_RunWorkerCompleted_1);
            // 
            // bgw_album
            // 
            this.bgw_album.WorkerSupportsCancellation = true;
            this.bgw_album.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_album_DoWork);
            this.bgw_album.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_album_RunWorkerCompleted);
            // 
            // bgw_track
            // 
            this.bgw_track.WorkerSupportsCancellation = true;
            this.bgw_track.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_track_DoWork);
            this.bgw_track.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_track_RunWorkerCompleted);
            // 
            // bgw_check_version
            // 
            this.bgw_check_version.WorkerSupportsCancellation = true;
            this.bgw_check_version.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_check_version_DoWork);
            // 
            // bgw_track_double
            // 
            this.bgw_track_double.WorkerSupportsCancellation = true;
            this.bgw_track_double.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_track_double_DoWork);
            this.bgw_track_double.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_track_double_RunWorkerCompleted);
            // 
            // bgw_album_double
            // 
            this.bgw_album_double.WorkerSupportsCancellation = true;
            this.bgw_album_double.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_album_double_DoWork);
            this.bgw_album_double.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_album_double_RunWorkerCompleted);
            // 
            // bgw_search
            // 
            this.bgw_search.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_search_DoWork);
            this.bgw_search.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_search_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 393);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMLoadr AUX 1.0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_loading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_artist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_background)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_go;
        private System.Windows.Forms.ComboBox cmb_quality;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txb_search;
        private System.Windows.Forms.ListBox lb_result;
        private System.Windows.Forms.RadioButton rbt_artist;
        private System.Windows.Forms.RadioButton rbt_album;
        private System.Windows.Forms.RadioButton rbt_track;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.PictureBox pbx_artist;
        private System.Windows.Forms.Button btn_download_folder;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button btn_preview;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txb_download_folder;
        private System.Windows.Forms.Button btn_open_download_folder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_monero_add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_bitcoin_add;
        private System.Windows.Forms.Button btn_ether_add;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txb_SM_exe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_limit_results;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_sort;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_info;
        private System.ComponentModel.BackgroundWorker bgw_artist;
        private System.ComponentModel.BackgroundWorker bgw_album;
        private System.ComponentModel.BackgroundWorker bgw_track;
        private System.Windows.Forms.PictureBox pbx_loading;
        private System.ComponentModel.BackgroundWorker bgw_check_version;
        private System.ComponentModel.BackgroundWorker bgw_track_double;
        private System.ComponentModel.BackgroundWorker bgw_album_double;
        private System.Windows.Forms.PictureBox pbx_background;
        private System.ComponentModel.BackgroundWorker bgw_search;
    }
}


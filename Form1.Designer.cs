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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbl_path = new System.Windows.Forms.Label();
            this.panel_normal = new System.Windows.Forms.Panel();
            this.rbt_artist = new System.Windows.Forms.RadioButton();
            this.rbt_album = new System.Windows.Forms.RadioButton();
            this.rbt_track = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txb_search = new System.Windows.Forms.TextBox();
            this.lb_result = new System.Windows.Forms.ListBox();
            this.ctm_options = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.browseOnWebToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmb_limit_results = new System.Windows.Forms.ComboBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.bgw_artist = new System.ComponentModel.BackgroundWorker();
            this.bgw_album = new System.ComponentModel.BackgroundWorker();
            this.bgw_track = new System.ComponentModel.BackgroundWorker();
            this.bgw_check_version = new System.ComponentModel.BackgroundWorker();
            this.bgw_track_double = new System.ComponentModel.BackgroundWorker();
            this.bgw_album_double = new System.ComponentModel.BackgroundWorker();
            this.bgw_chart = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbx_loading = new System.Windows.Forms.PictureBox();
            this.rb_artist = new System.Windows.Forms.PictureBox();
            this.rb_album = new System.Windows.Forms.PictureBox();
            this.rb_track = new System.Windows.Forms.PictureBox();
            this.panel_title_bar = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_minimize = new System.Windows.Forms.PictureBox();
            this.btn_close = new System.Windows.Forms.PictureBox();
            this.btn_cmb = new System.Windows.Forms.Button();
            this.pbx_artist = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_main = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_preview = new System.Windows.Forms.Button();
            this.btn_go = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_bitcoin_add = new System.Windows.Forms.Button();
            this.btn_monero_add = new System.Windows.Forms.Button();
            this.btn_ether_add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txb_download_folder = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txb_SM_exe = new System.Windows.Forms.TextBox();
            this.btn_close2 = new System.Windows.Forms.PictureBox();
            this.btn_minimize2 = new System.Windows.Forms.PictureBox();
            this.panel_title_bar2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbl_title2 = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_open_download_folder = new System.Windows.Forms.Button();
            this.btn_download_folder = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_tmain = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel_normal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.ctm_options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_loading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rb_artist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rb_album)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rb_track)).BeginInit();
            this.panel_title_bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_artist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize2)).BeginInit();
            this.panel_title_bar2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_quality
            // 
            this.cmb_quality.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.cmb_quality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_quality.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_quality.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_quality.ForeColor = System.Drawing.Color.White;
            this.cmb_quality.FormattingEnabled = true;
            this.cmb_quality.Items.AddRange(new object[] {
            "MP3 128 kbps",
            "MP3 320 kbps",
            "FLAC 1411 kbps"});
            this.cmb_quality.Location = new System.Drawing.Point(158, 249);
            this.cmb_quality.Margin = new System.Windows.Forms.Padding(4);
            this.cmb_quality.Name = "cmb_quality";
            this.cmb_quality.Size = new System.Drawing.Size(130, 28);
            this.cmb_quality.TabIndex = 2;
            this.cmb_quality.SelectedIndexChanged += new System.EventHandler(this.cmb_quality_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-4, -28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(618, 470);
            this.tabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.tabPage1.Controls.Add(this.pbx_loading);
            this.tabPage1.Controls.Add(this.lbl_path);
            this.tabPage1.Controls.Add(this.panel_normal);
            this.tabPage1.Controls.Add(this.panel_title_bar);
            this.tabPage1.Controls.Add(this.btn_cmb);
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Controls.Add(this.pbx_artist);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.txb_search);
            this.tabPage1.Controls.Add(this.lb_result);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.btn_settings);
            this.tabPage1.Controls.Add(this.btn_main);
            this.tabPage1.Controls.Add(this.btn_back);
            this.tabPage1.Controls.Add(this.cmb_limit_results);
            this.tabPage1.Controls.Add(this.btn_preview);
            this.tabPage1.Controls.Add(this.btn_go);
            this.tabPage1.Controls.Add(this.btn_search);
            this.tabPage1.Controls.Add(this.axWindowsMediaPlayer1);
            this.tabPage1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.ForeColor = System.Drawing.Color.White;
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(610, 438);
            this.tabPage1.TabIndex = 0;
            // 
            // lbl_path
            // 
            this.lbl_path.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.lbl_path.Font = new System.Drawing.Font("Roboto Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_path.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.lbl_path.Location = new System.Drawing.Point(12, 179);
            this.lbl_path.Name = "lbl_path";
            this.lbl_path.Size = new System.Drawing.Size(346, 26);
            this.lbl_path.TabIndex = 50;
            this.lbl_path.Text = "Search Results";
            this.lbl_path.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_normal
            // 
            this.panel_normal.Controls.Add(this.rb_artist);
            this.panel_normal.Controls.Add(this.rbt_artist);
            this.panel_normal.Controls.Add(this.rb_album);
            this.panel_normal.Controls.Add(this.rb_track);
            this.panel_normal.Controls.Add(this.rbt_album);
            this.panel_normal.Controls.Add(this.rbt_track);
            this.panel_normal.Location = new System.Drawing.Point(196, 64);
            this.panel_normal.Name = "panel_normal";
            this.panel_normal.Size = new System.Drawing.Size(231, 39);
            this.panel_normal.TabIndex = 49;
            this.panel_normal.Paint += new System.Windows.Forms.PaintEventHandler(this.panel9_Paint);
            // 
            // rbt_artist
            // 
            this.rbt_artist.AutoSize = true;
            this.rbt_artist.Checked = true;
            this.rbt_artist.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_artist.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.rbt_artist.Location = new System.Drawing.Point(3, 3);
            this.rbt_artist.Margin = new System.Windows.Forms.Padding(4);
            this.rbt_artist.Name = "rbt_artist";
            this.rbt_artist.Size = new System.Drawing.Size(68, 25);
            this.rbt_artist.TabIndex = 8;
            this.rbt_artist.TabStop = true;
            this.rbt_artist.Text = "Artist";
            this.rbt_artist.UseVisualStyleBackColor = true;
            this.rbt_artist.CheckedChanged += new System.EventHandler(this.rbt_artist_CheckedChanged);
            // 
            // rbt_album
            // 
            this.rbt_album.AutoSize = true;
            this.rbt_album.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_album.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.rbt_album.Location = new System.Drawing.Point(81, 3);
            this.rbt_album.Margin = new System.Windows.Forms.Padding(4);
            this.rbt_album.Name = "rbt_album";
            this.rbt_album.Size = new System.Drawing.Size(74, 25);
            this.rbt_album.TabIndex = 9;
            this.rbt_album.Text = "Album";
            this.rbt_album.UseVisualStyleBackColor = true;
            this.rbt_album.CheckedChanged += new System.EventHandler(this.rbt_album_CheckedChanged);
            // 
            // rbt_track
            // 
            this.rbt_track.AutoSize = true;
            this.rbt_track.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_track.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.rbt_track.Location = new System.Drawing.Point(163, 4);
            this.rbt_track.Margin = new System.Windows.Forms.Padding(4);
            this.rbt_track.Name = "rbt_track";
            this.rbt_track.Size = new System.Drawing.Size(69, 23);
            this.rbt_track.TabIndex = 12;
            this.rbt_track.Text = "Track";
            this.rbt_track.UseVisualStyleBackColor = true;
            this.rbt_track.CheckedChanged += new System.EventHandler(this.rbt_track_CheckedChanged);
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(307, 140);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(18, 30);
            this.panel5.TabIndex = 44;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(359, 140);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(18, 30);
            this.panel3.TabIndex = 43;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(310, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(67, 5);
            this.panel2.TabIndex = 42;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(310, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(67, 5);
            this.panel1.TabIndex = 41;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(18, 30);
            this.panel4.TabIndex = 44;
            // 
            // txb_search
            // 
            this.txb_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.txb_search.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_search.ForeColor = System.Drawing.SystemColors.Window;
            this.txb_search.Location = new System.Drawing.Point(12, 110);
            this.txb_search.Multiline = true;
            this.txb_search.Name = "txb_search";
            this.txb_search.Size = new System.Drawing.Size(554, 22);
            this.txb_search.TabIndex = 32;
            this.txb_search.Enter += new System.EventHandler(this.txb_search_Enter);
            this.txb_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_search_KeyDown_1);
            this.txb_search.Leave += new System.EventHandler(this.txb_search_Leave);
            // 
            // lb_result
            // 
            this.lb_result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.lb_result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lb_result.ContextMenuStrip = this.ctm_options;
            this.lb_result.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_result.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lb_result.FormattingEnabled = true;
            this.lb_result.IntegralHeight = false;
            this.lb_result.ItemHeight = 19;
            this.lb_result.Location = new System.Drawing.Point(19, 209);
            this.lb_result.Margin = new System.Windows.Forms.Padding(4);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(330, 154);
            this.lb_result.TabIndex = 6;
            this.lb_result.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lb_result_DrawItem);
            this.lb_result.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.lb_result_MeasureItem);
            this.lb_result.SelectedIndexChanged += new System.EventHandler(this.lb_result_SelectedIndexChanged);
            this.lb_result.DoubleClick += new System.EventHandler(this.lb_result_DoubleClick);
            this.lb_result.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lb_result_MouseDoubleClick);
            this.lb_result.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb_result_MouseDown);
            // 
            // ctm_options
            // 
            this.ctm_options.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.browseOnWebToolStripMenuItem});
            this.ctm_options.Name = "ctm_options";
            this.ctm_options.Size = new System.Drawing.Size(139, 26);
            // 
            // browseOnWebToolStripMenuItem
            // 
            this.browseOnWebToolStripMenuItem.Name = "browseOnWebToolStripMenuItem";
            this.browseOnWebToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.browseOnWebToolStripMenuItem.Text = "Navigate to:";
            this.browseOnWebToolStripMenuItem.Click += new System.EventHandler(this.browseOnWebToolStripMenuItem_Click);
            // 
            // cmb_limit_results
            // 
            this.cmb_limit_results.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(32)))));
            this.cmb_limit_results.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_limit_results.DropDownWidth = 10;
            this.cmb_limit_results.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_limit_results.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_limit_results.ForeColor = System.Drawing.Color.White;
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
            "100"});
            this.cmb_limit_results.Location = new System.Drawing.Point(324, 141);
            this.cmb_limit_results.MaxDropDownItems = 5;
            this.cmb_limit_results.Name = "cmb_limit_results";
            this.cmb_limit_results.Size = new System.Drawing.Size(53, 27);
            this.cmb_limit_results.TabIndex = 21;
            this.cmb_limit_results.SelectedIndexChanged += new System.EventHandler(this.cmb_limit_results_SelectedIndexChanged);
            this.cmb_limit_results.TextUpdate += new System.EventHandler(this.cmb_limit_results_TextUpdate);
            this.cmb_limit_results.SelectedValueChanged += new System.EventHandler(this.cmb_limit_results_SelectedValueChanged);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(383, 317);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(157, 44);
            this.axWindowsMediaPlayer1.TabIndex = 47;
            this.axWindowsMediaPlayer1.Visible = false;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.tabPage2.Controls.Add(this.panel8);
            this.tabPage2.Controls.Add(this.panel7);
            this.tabPage2.Controls.Add(this.panel6);
            this.tabPage2.Controls.Add(this.btn_close2);
            this.tabPage2.Controls.Add(this.btn_minimize2);
            this.tabPage2.Controls.Add(this.panel_title_bar2);
            this.tabPage2.Controls.Add(this.btn_reset);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.cmb_quality);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.btn_open_download_folder);
            this.tabPage2.Controls.Add(this.btn_download_folder);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.btn_tmain);
            this.tabPage2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(610, 438);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 18);
            this.label5.TabIndex = 28;
            this.label5.Text = "SMLoadr Executable";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 18);
            this.label4.TabIndex = 27;
            this.label4.Text = "Download Folder";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Download Quality";
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
            // bgw_chart
            // 
            this.bgw_chart.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_search_DoWork);
            this.bgw_chart.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_search_RunWorkerCompleted);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbx_loading
            // 
            this.pbx_loading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.pbx_loading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbx_loading.Image = global::SMLoader.Properties.Resources.load;
            this.pbx_loading.Location = new System.Drawing.Point(20, 182);
            this.pbx_loading.Margin = new System.Windows.Forms.Padding(4);
            this.pbx_loading.Name = "pbx_loading";
            this.pbx_loading.Size = new System.Drawing.Size(330, 184);
            this.pbx_loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbx_loading.TabIndex = 26;
            this.pbx_loading.TabStop = false;
            this.pbx_loading.Visible = false;
            // 
            // rb_artist
            // 
            this.rb_artist.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rb_artist.BackgroundImage")));
            this.rb_artist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rb_artist.Location = new System.Drawing.Point(0, 8);
            this.rb_artist.Name = "rb_artist";
            this.rb_artist.Size = new System.Drawing.Size(16, 19);
            this.rb_artist.TabIndex = 36;
            this.rb_artist.TabStop = false;
            this.rb_artist.Click += new System.EventHandler(this.rb_artist_Click_1);
            this.rb_artist.MouseEnter += new System.EventHandler(this.rb_artist_MouseEnter_1);
            this.rb_artist.MouseLeave += new System.EventHandler(this.rb_artist_MouseLeave_1);
            // 
            // rb_album
            // 
            this.rb_album.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rb_album.BackgroundImage")));
            this.rb_album.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rb_album.Location = new System.Drawing.Point(78, 8);
            this.rb_album.Name = "rb_album";
            this.rb_album.Size = new System.Drawing.Size(16, 19);
            this.rb_album.TabIndex = 37;
            this.rb_album.TabStop = false;
            this.rb_album.Click += new System.EventHandler(this.rb_album_Click_1);
            this.rb_album.MouseEnter += new System.EventHandler(this.rb_album_MouseEnter);
            this.rb_album.MouseLeave += new System.EventHandler(this.rb_album_MouseLeave);
            // 
            // rb_track
            // 
            this.rb_track.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rb_track.BackgroundImage")));
            this.rb_track.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rb_track.Location = new System.Drawing.Point(160, 8);
            this.rb_track.Name = "rb_track";
            this.rb_track.Size = new System.Drawing.Size(16, 19);
            this.rb_track.TabIndex = 38;
            this.rb_track.TabStop = false;
            this.rb_track.Click += new System.EventHandler(this.rb_track_Click_1);
            this.rb_track.MouseEnter += new System.EventHandler(this.rb_track_MouseEnter);
            this.rb_track.MouseLeave += new System.EventHandler(this.rb_track_MouseLeave);
            // 
            // panel_title_bar
            // 
            this.panel_title_bar.BackColor = System.Drawing.Color.White;
            this.panel_title_bar.BackgroundImage = global::SMLoader.Properties.Resources.topbar_empty;
            this.panel_title_bar.Controls.Add(this.pictureBox2);
            this.panel_title_bar.Controls.Add(this.lbl_title);
            this.panel_title_bar.Controls.Add(this.btn_minimize);
            this.panel_title_bar.Controls.Add(this.btn_close);
            this.panel_title_bar.Location = new System.Drawing.Point(1, 1);
            this.panel_title_bar.Name = "panel_title_bar";
            this.panel_title_bar.Size = new System.Drawing.Size(610, 27);
            this.panel_title_bar.TabIndex = 46;
            this.panel_title_bar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_title_bar_MouseDown);
            this.panel_title_bar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_title_bar_MouseMove);
            this.panel_title_bar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_title_bar_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::SMLoader.Properties.Resources.smloadr_aux_favicon_v2;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(7, 3);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title.Font = new System.Drawing.Font("Roboto Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(36, 4);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(123, 18);
            this.lbl_title.TabIndex = 47;
            this.lbl_title.Text = "SMLoadr AUX 1.0.2";
            this.lbl_title.Click += new System.EventHandler(this.label6_Click);
            // 
            // btn_minimize
            // 
            this.btn_minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.BackgroundImage = global::SMLoader.Properties.Resources.minimize_button_up;
            this.btn_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_minimize.Location = new System.Drawing.Point(539, 0);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(27, 27);
            this.btn_minimize.TabIndex = 48;
            this.btn_minimize.TabStop = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            this.btn_minimize.MouseEnter += new System.EventHandler(this.btn_minimize_MouseEnter);
            this.btn_minimize.MouseLeave += new System.EventHandler(this.btn_minimize_MouseLeave);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BackgroundImage = global::SMLoader.Properties.Resources.close_button_up1;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_close.Location = new System.Drawing.Point(573, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(27, 27);
            this.btn_close.TabIndex = 47;
            this.btn_close.TabStop = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click_2);
            this.btn_close.MouseEnter += new System.EventHandler(this.btn_close_MouseEnter_1);
            this.btn_close.MouseLeave += new System.EventHandler(this.btn_close_MouseLeave_1);
            // 
            // btn_cmb
            // 
            this.btn_cmb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cmb.BackgroundImage")));
            this.btn_cmb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_cmb.FlatAppearance.BorderSize = 0;
            this.btn_cmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cmb.Location = new System.Drawing.Point(195, 140);
            this.btn_cmb.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cmb.Name = "btn_cmb";
            this.btn_cmb.Size = new System.Drawing.Size(122, 29);
            this.btn_cmb.TabIndex = 39;
            this.btn_cmb.UseVisualStyleBackColor = true;
            this.btn_cmb.Click += new System.EventHandler(this.btn_cmb_Click);
            this.btn_cmb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_cmb_MouseDown);
            this.btn_cmb.MouseEnter += new System.EventHandler(this.btn_cmb_MouseEnter);
            this.btn_cmb.MouseLeave += new System.EventHandler(this.btn_cmb_MouseLeave);
            this.btn_cmb.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_cmb_MouseUp);
            // 
            // pbx_artist
            // 
            this.pbx_artist.BackColor = System.Drawing.Color.Transparent;
            this.pbx_artist.BackgroundImage = global::SMLoader.Properties.Resources.empty_cover_v2;
            this.pbx_artist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbx_artist.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbx_artist.InitialImage")));
            this.pbx_artist.Location = new System.Drawing.Point(368, 140);
            this.pbx_artist.Margin = new System.Windows.Forms.Padding(4);
            this.pbx_artist.Name = "pbx_artist";
            this.pbx_artist.Size = new System.Drawing.Size(232, 232);
            this.pbx_artist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_artist.TabIndex = 14;
            this.pbx_artist.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SMLoader.Properties.Resources.result_field;
            this.pictureBox1.Location = new System.Drawing.Point(10, 177);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(349, 195);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // btn_settings
            // 
            this.btn_settings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_settings.BackgroundImage")));
            this.btn_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_settings.FlatAppearance.BorderSize = 0;
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.Location = new System.Drawing.Point(71, 36);
            this.btn_settings.Margin = new System.Windows.Forms.Padding(4);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(61, 28);
            this.btn_settings.TabIndex = 30;
            this.btn_settings.Text = "   ";
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            this.btn_settings.MouseEnter += new System.EventHandler(this.btn_settings_MouseEnter);
            this.btn_settings.MouseLeave += new System.EventHandler(this.btn_settings_MouseLeave);
            // 
            // btn_main
            // 
            this.btn_main.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_main.BackgroundImage")));
            this.btn_main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_main.FlatAppearance.BorderSize = 0;
            this.btn_main.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_main.Location = new System.Drawing.Point(10, 36);
            this.btn_main.Margin = new System.Windows.Forms.Padding(4);
            this.btn_main.Name = "btn_main";
            this.btn_main.Size = new System.Drawing.Size(61, 28);
            this.btn_main.TabIndex = 29;
            this.btn_main.UseVisualStyleBackColor = true;
            // 
            // btn_back
            // 
            this.btn_back.BackgroundImage = global::SMLoader.Properties.Resources.back_button_disabled;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_back.Enabled = false;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Location = new System.Drawing.Point(10, 142);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(24, 28);
            this.btn_back.TabIndex = 22;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            this.btn_back.Leave += new System.EventHandler(this.btn_back_Leave);
            this.btn_back.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_back_MouseDown);
            this.btn_back.MouseEnter += new System.EventHandler(this.btn_back_MouseEnter);
            this.btn_back.MouseLeave += new System.EventHandler(this.btn_back_MouseLeave);
            this.btn_back.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_back_MouseUp);
            // 
            // btn_preview
            // 
            this.btn_preview.BackColor = System.Drawing.Color.Transparent;
            this.btn_preview.BackgroundImage = global::SMLoader.Properties.Resources.play_button_up;
            this.btn_preview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_preview.Enabled = false;
            this.btn_preview.FlatAppearance.BorderSize = 0;
            this.btn_preview.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_preview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_preview.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_preview.Location = new System.Drawing.Point(368, 379);
            this.btn_preview.Margin = new System.Windows.Forms.Padding(0);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(232, 28);
            this.btn_preview.TabIndex = 18;
            this.btn_preview.UseVisualStyleBackColor = false;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            this.btn_preview.MouseEnter += new System.EventHandler(this.btn_preview_MouseEnter);
            this.btn_preview.MouseLeave += new System.EventHandler(this.btn_preview_MouseLeave);
            // 
            // btn_go
            // 
            this.btn_go.BackgroundImage = global::SMLoader.Properties.Resources.download_button_up;
            this.btn_go.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_go.FlatAppearance.BorderSize = 0;
            this.btn_go.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_go.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_go.Location = new System.Drawing.Point(10, 379);
            this.btn_go.Margin = new System.Windows.Forms.Padding(4);
            this.btn_go.Name = "btn_go";
            this.btn_go.Size = new System.Drawing.Size(348, 28);
            this.btn_go.TabIndex = 1;
            this.btn_go.UseVisualStyleBackColor = true;
            this.btn_go.Click += new System.EventHandler(this.btn_go_Click);
            this.btn_go.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_go_MouseDown);
            this.btn_go.MouseEnter += new System.EventHandler(this.btn_go_MouseEnter);
            this.btn_go.MouseLeave += new System.EventHandler(this.btn_go_MouseLeave);
            this.btn_go.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_go_MouseUp);
            // 
            // btn_search
            // 
            this.btn_search.BackgroundImage = global::SMLoader.Properties.Resources.searchbar_v2_button_up;
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Location = new System.Drawing.Point(10, 107);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(590, 27);
            this.btn_search.TabIndex = 13;
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            this.btn_search.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_search_MouseDown);
            this.btn_search.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_search_MouseUp);
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = global::SMLoader.Properties.Resources.result_field;
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel8.Controls.Add(this.btn_bitcoin_add);
            this.panel8.Controls.Add(this.btn_monero_add);
            this.panel8.Controls.Add(this.btn_ether_add);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Controls.Add(this.label3);
            this.panel8.Location = new System.Drawing.Point(1, 306);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(610, 118);
            this.panel8.TabIndex = 51;
            // 
            // btn_bitcoin_add
            // 
            this.btn_bitcoin_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_bitcoin_add.BackgroundImage = global::SMLoader.Properties.Resources.copy_bitcoin_button_up;
            this.btn_bitcoin_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_bitcoin_add.FlatAppearance.BorderSize = 0;
            this.btn_bitcoin_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_bitcoin_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bitcoin_add.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bitcoin_add.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_bitcoin_add.Location = new System.Drawing.Point(16, 74);
            this.btn_bitcoin_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_bitcoin_add.Name = "btn_bitcoin_add";
            this.btn_bitcoin_add.Size = new System.Drawing.Size(146, 32);
            this.btn_bitcoin_add.TabIndex = 23;
            this.btn_bitcoin_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_bitcoin_add.UseVisualStyleBackColor = false;
            this.btn_bitcoin_add.Click += new System.EventHandler(this.btn_bitcoin_add_Click);
            this.btn_bitcoin_add.MouseEnter += new System.EventHandler(this.btn_bitcoin_add_MouseEnter);
            this.btn_bitcoin_add.MouseLeave += new System.EventHandler(this.btn_bitcoin_add_MouseLeave);
            // 
            // btn_monero_add
            // 
            this.btn_monero_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_monero_add.BackgroundImage = global::SMLoader.Properties.Resources.copy_monero_button_up;
            this.btn_monero_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_monero_add.FlatAppearance.BorderSize = 0;
            this.btn_monero_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_monero_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_monero_add.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_monero_add.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_monero_add.Location = new System.Drawing.Point(442, 66);
            this.btn_monero_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_monero_add.Name = "btn_monero_add";
            this.btn_monero_add.Size = new System.Drawing.Size(150, 33);
            this.btn_monero_add.TabIndex = 22;
            this.btn_monero_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_monero_add.UseVisualStyleBackColor = false;
            this.btn_monero_add.Click += new System.EventHandler(this.btn_monero_add_Click);
            this.btn_monero_add.MouseEnter += new System.EventHandler(this.btn_monero_add_MouseEnter);
            this.btn_monero_add.MouseLeave += new System.EventHandler(this.btn_monero_add_MouseLeave);
            // 
            // btn_ether_add
            // 
            this.btn_ether_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_ether_add.BackgroundImage = global::SMLoader.Properties.Resources.copy_ethereum_button_up;
            this.btn_ether_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_ether_add.FlatAppearance.BorderSize = 0;
            this.btn_ether_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_ether_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ether_add.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ether_add.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btn_ether_add.Location = new System.Drawing.Point(231, 66);
            this.btn_ether_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ether_add.Name = "btn_ether_add";
            this.btn_ether_add.Size = new System.Drawing.Size(150, 40);
            this.btn_ether_add.TabIndex = 24;
            this.btn_ether_add.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ether_add.UseVisualStyleBackColor = false;
            this.btn_ether_add.Click += new System.EventHandler(this.btn_ether_add_Click);
            this.btn_ether_add.MouseEnter += new System.EventHandler(this.btn_ether_add_MouseEnter);
            this.btn_ether_add.MouseLeave += new System.EventHandler(this.btn_ether_add_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(172, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "Coded in Hell by Lucifer and Demons";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.label3.Location = new System.Drawing.Point(144, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(325, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "Set free some souls from hell today: Donate!";
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = global::SMLoader.Properties.Resources.downloadbar;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel7.Controls.Add(this.txb_download_folder);
            this.panel7.Location = new System.Drawing.Point(12, 178);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(424, 27);
            this.panel7.TabIndex = 50;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // txb_download_folder
            // 
            this.txb_download_folder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.txb_download_folder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_download_folder.Enabled = false;
            this.txb_download_folder.Location = new System.Drawing.Point(5, 3);
            this.txb_download_folder.Margin = new System.Windows.Forms.Padding(4);
            this.txb_download_folder.Multiline = true;
            this.txb_download_folder.Name = "txb_download_folder";
            this.txb_download_folder.ReadOnly = true;
            this.txb_download_folder.Size = new System.Drawing.Size(415, 22);
            this.txb_download_folder.TabIndex = 17;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::SMLoader.Properties.Resources.executablebar;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel6.Controls.Add(this.txb_SM_exe);
            this.panel6.Location = new System.Drawing.Point(12, 110);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(507, 27);
            this.panel6.TabIndex = 49;
            // 
            // txb_SM_exe
            // 
            this.txb_SM_exe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.txb_SM_exe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_SM_exe.Enabled = false;
            this.txb_SM_exe.Location = new System.Drawing.Point(4, 2);
            this.txb_SM_exe.Margin = new System.Windows.Forms.Padding(4);
            this.txb_SM_exe.Multiline = true;
            this.txb_SM_exe.Name = "txb_SM_exe";
            this.txb_SM_exe.ReadOnly = true;
            this.txb_SM_exe.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txb_SM_exe.Size = new System.Drawing.Size(499, 22);
            this.txb_SM_exe.TabIndex = 25;
            // 
            // btn_close2
            // 
            this.btn_close2.BackColor = System.Drawing.Color.Transparent;
            this.btn_close2.BackgroundImage = global::SMLoader.Properties.Resources.close_button_up1;
            this.btn_close2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_close2.Location = new System.Drawing.Point(574, 1);
            this.btn_close2.Name = "btn_close2";
            this.btn_close2.Size = new System.Drawing.Size(27, 27);
            this.btn_close2.TabIndex = 47;
            this.btn_close2.TabStop = false;
            this.btn_close2.Click += new System.EventHandler(this.btn_close2_Click_1);
            this.btn_close2.MouseEnter += new System.EventHandler(this.btn_close2_MouseEnter_1);
            this.btn_close2.MouseLeave += new System.EventHandler(this.btn_close2_MouseLeave_1);
            // 
            // btn_minimize2
            // 
            this.btn_minimize2.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimize2.BackgroundImage = global::SMLoader.Properties.Resources.minimize_button_up;
            this.btn_minimize2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_minimize2.Location = new System.Drawing.Point(540, 1);
            this.btn_minimize2.Name = "btn_minimize2";
            this.btn_minimize2.Size = new System.Drawing.Size(27, 27);
            this.btn_minimize2.TabIndex = 48;
            this.btn_minimize2.TabStop = false;
            this.btn_minimize2.Click += new System.EventHandler(this.btn_minimize2_Click);
            this.btn_minimize2.MouseEnter += new System.EventHandler(this.btn_minimize2_MouseEnter);
            this.btn_minimize2.MouseLeave += new System.EventHandler(this.btn_minimize2_MouseLeave);
            // 
            // panel_title_bar2
            // 
            this.panel_title_bar2.BackColor = System.Drawing.Color.White;
            this.panel_title_bar2.BackgroundImage = global::SMLoader.Properties.Resources.topbar_empty;
            this.panel_title_bar2.Controls.Add(this.pictureBox3);
            this.panel_title_bar2.Controls.Add(this.lbl_title2);
            this.panel_title_bar2.Location = new System.Drawing.Point(1, 1);
            this.panel_title_bar2.Name = "panel_title_bar2";
            this.panel_title_bar2.Size = new System.Drawing.Size(610, 27);
            this.panel_title_bar2.TabIndex = 47;
            this.panel_title_bar2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_title_bar2_MouseDown_1);
            this.panel_title_bar2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_title_bar2_MouseMove_1);
            this.panel_title_bar2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_title_bar2_MouseUp_1);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::SMLoader.Properties.Resources.smloadr_aux_favicon_v2;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(7, 3);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 47;
            this.pictureBox3.TabStop = false;
            // 
            // lbl_title2
            // 
            this.lbl_title2.AutoSize = true;
            this.lbl_title2.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title2.Font = new System.Drawing.Font("Roboto Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title2.ForeColor = System.Drawing.Color.White;
            this.lbl_title2.Location = new System.Drawing.Point(36, 4);
            this.lbl_title2.Name = "lbl_title2";
            this.lbl_title2.Size = new System.Drawing.Size(123, 18);
            this.lbl_title2.TabIndex = 47;
            this.lbl_title2.Text = "SMLoadr AUX 1.0.2";
            // 
            // btn_reset
            // 
            this.btn_reset.BackgroundImage = global::SMLoader.Properties.Resources.reset_button_up;
            this.btn_reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_reset.FlatAppearance.BorderSize = 0;
            this.btn_reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.Color.White;
            this.btn_reset.Location = new System.Drawing.Point(526, 244);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(4);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 33);
            this.btn_reset.TabIndex = 29;
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            this.btn_reset.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_reset_MouseDown);
            this.btn_reset.MouseEnter += new System.EventHandler(this.btn_reset_MouseEnter);
            this.btn_reset.MouseLeave += new System.EventHandler(this.btn_reset_MouseLeave);
            this.btn_reset.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_reset_MouseUp);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.button1.BackgroundImage = global::SMLoader.Properties.Resources.change_button_up;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(526, 106);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 26;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // btn_open_download_folder
            // 
            this.btn_open_download_folder.BackgroundImage = global::SMLoader.Properties.Resources.open_button_up;
            this.btn_open_download_folder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_open_download_folder.FlatAppearance.BorderSize = 0;
            this.btn_open_download_folder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_open_download_folder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_open_download_folder.ForeColor = System.Drawing.Color.White;
            this.btn_open_download_folder.Location = new System.Drawing.Point(526, 174);
            this.btn_open_download_folder.Margin = new System.Windows.Forms.Padding(4);
            this.btn_open_download_folder.Name = "btn_open_download_folder";
            this.btn_open_download_folder.Size = new System.Drawing.Size(75, 33);
            this.btn_open_download_folder.TabIndex = 19;
            this.btn_open_download_folder.UseVisualStyleBackColor = true;
            this.btn_open_download_folder.Click += new System.EventHandler(this.btn_open_download_folder_Click);
            this.btn_open_download_folder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_open_download_folder_MouseDown);
            this.btn_open_download_folder.MouseEnter += new System.EventHandler(this.btn_open_download_folder_MouseEnter);
            this.btn_open_download_folder.MouseLeave += new System.EventHandler(this.btn_open_download_folder_MouseLeave);
            this.btn_open_download_folder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_open_download_folder_MouseUp);
            // 
            // btn_download_folder
            // 
            this.btn_download_folder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.btn_download_folder.BackgroundImage = global::SMLoader.Properties.Resources.change_button_up1;
            this.btn_download_folder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_download_folder.FlatAppearance.BorderSize = 0;
            this.btn_download_folder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_download_folder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_download_folder.ForeColor = System.Drawing.Color.White;
            this.btn_download_folder.Location = new System.Drawing.Point(443, 174);
            this.btn_download_folder.Margin = new System.Windows.Forms.Padding(4);
            this.btn_download_folder.Name = "btn_download_folder";
            this.btn_download_folder.Size = new System.Drawing.Size(75, 33);
            this.btn_download_folder.TabIndex = 16;
            this.btn_download_folder.UseVisualStyleBackColor = false;
            this.btn_download_folder.Click += new System.EventHandler(this.btn_download_folder_Click);
            this.btn_download_folder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_download_folder_MouseDown);
            this.btn_download_folder.MouseEnter += new System.EventHandler(this.btn_download_folder_MouseEnter);
            this.btn_download_folder.MouseLeave += new System.EventHandler(this.btn_download_folder_MouseLeave);
            this.btn_download_folder.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_download_folder_MouseUp);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(71, 36);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 28);
            this.button2.TabIndex = 32;
            this.button2.Text = "   ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_tmain
            // 
            this.btn_tmain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_tmain.BackgroundImage")));
            this.btn_tmain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_tmain.FlatAppearance.BorderSize = 0;
            this.btn_tmain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_tmain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tmain.Location = new System.Drawing.Point(10, 36);
            this.btn_tmain.Margin = new System.Windows.Forms.Padding(4);
            this.btn_tmain.Name = "btn_tmain";
            this.btn_tmain.Size = new System.Drawing.Size(61, 28);
            this.btn_tmain.TabIndex = 31;
            this.btn_tmain.UseVisualStyleBackColor = true;
            this.btn_tmain.Click += new System.EventHandler(this.btn_tmain_Click);
            this.btn_tmain.MouseEnter += new System.EventHandler(this.btn_tmain_MouseEnter);
            this.btn_tmain.MouseLeave += new System.EventHandler(this.btn_tmain_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 425);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMLoadr AUX 1.0.1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Leave += new System.EventHandler(this.Form1_Leave);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel_normal.ResumeLayout(false);
            this.panel_normal.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ctm_options.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_loading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rb_artist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rb_album)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rb_track)).EndInit();
            this.panel_title_bar.ResumeLayout(false);
            this.panel_title_bar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_artist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize2)).EndInit();
            this.panel_title_bar2.ResumeLayout(false);
            this.panel_title_bar2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_quality;
        private System.Windows.Forms.Button btn_download_folder;
        private System.Windows.Forms.TabControl tabControl1;
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
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.ComponentModel.BackgroundWorker bgw_artist;
        private System.ComponentModel.BackgroundWorker bgw_album;
        private System.ComponentModel.BackgroundWorker bgw_track;
        private System.ComponentModel.BackgroundWorker bgw_check_version;
        private System.ComponentModel.BackgroundWorker bgw_track_double;
        private System.ComponentModel.BackgroundWorker bgw_album_double;
        private System.ComponentModel.BackgroundWorker bgw_chart;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_tmain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel_title_bar;
        private System.Windows.Forms.Button btn_cmb;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pbx_artist;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox rb_track;
        private System.Windows.Forms.PictureBox rb_album;
        private System.Windows.Forms.PictureBox rb_artist;
        private System.Windows.Forms.TextBox txb_search;
        private System.Windows.Forms.PictureBox pbx_loading;
        private System.Windows.Forms.ListBox lb_result;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_main;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.ComboBox cmb_limit_results;
        private System.Windows.Forms.RadioButton rbt_artist;
        private System.Windows.Forms.Button btn_preview;
        private System.Windows.Forms.Button btn_go;
        private System.Windows.Forms.RadioButton rbt_album;
        private System.Windows.Forms.RadioButton rbt_track;
       
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.PictureBox btn_close;
        private System.Windows.Forms.PictureBox btn_minimize;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel_title_bar2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbl_title2;
        private System.Windows.Forms.PictureBox btn_minimize2;
        private System.Windows.Forms.PictureBox btn_close2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.ContextMenuStrip ctm_options;
        private System.Windows.Forms.ToolStripMenuItem browseOnWebToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel_normal;
        private System.Windows.Forms.Label lbl_path;
    }
}


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
            this.btn_go = new System.Windows.Forms.Button();
            this.cmb_quality = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txb_search = new System.Windows.Forms.TextBox();
            this.lb_result = new System.Windows.Forms.ListBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.rbt_artist = new System.Windows.Forms.RadioButton();
            this.rbt_album = new System.Windows.Forms.RadioButton();
            this.rbt_track = new System.Windows.Forms.RadioButton();
            this.btn_search = new System.Windows.Forms.Button();
            this.pbx_artist = new System.Windows.Forms.PictureBox();
            this.btn_download_folder = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btn_preview = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.btn_reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_artist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_go
            // 
            this.btn_go.Location = new System.Drawing.Point(4, 313);
            this.btn_go.Margin = new System.Windows.Forms.Padding(4);
            this.btn_go.Name = "btn_go";
            this.btn_go.Size = new System.Drawing.Size(350, 29);
            this.btn_go.TabIndex = 1;
            this.btn_go.Text = "DOWNLOAD";
            this.btn_go.UseVisualStyleBackColor = true;
            this.btn_go.Click += new System.EventHandler(this.btn_go_Click);
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
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork_1);
            // 
            // txb_search
            // 
            this.txb_search.Location = new System.Drawing.Point(4, 38);
            this.txb_search.Margin = new System.Windows.Forms.Padding(4);
            this.txb_search.Name = "txb_search";
            this.txb_search.Size = new System.Drawing.Size(487, 27);
            this.txb_search.TabIndex = 5;
            this.txb_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txb_search_KeyDown);
            // 
            // lb_result
            // 
            this.lb_result.FormattingEnabled = true;
            this.lb_result.ItemHeight = 19;
            this.lb_result.Location = new System.Drawing.Point(4, 73);
            this.lb_result.Margin = new System.Windows.Forms.Padding(4);
            this.lb_result.Name = "lb_result";
            this.lb_result.Size = new System.Drawing.Size(350, 232);
            this.lb_result.TabIndex = 6;
            this.lb_result.SelectedIndexChanged += new System.EventHandler(this.lb_result_SelectedIndexChanged);
            // 
            // rbt_artist
            // 
            this.rbt_artist.AutoSize = true;
            this.rbt_artist.Checked = true;
            this.rbt_artist.Location = new System.Drawing.Point(13, 7);
            this.rbt_artist.Margin = new System.Windows.Forms.Padding(4);
            this.rbt_artist.Name = "rbt_artist";
            this.rbt_artist.Size = new System.Drawing.Size(64, 23);
            this.rbt_artist.TabIndex = 8;
            this.rbt_artist.TabStop = true;
            this.rbt_artist.Text = "Artist";
            this.rbt_artist.UseVisualStyleBackColor = true;
            this.rbt_artist.CheckedChanged += new System.EventHandler(this.rbt_artist_CheckedChanged);
            // 
            // rbt_album
            // 
            this.rbt_album.AutoSize = true;
            this.rbt_album.Location = new System.Drawing.Point(85, 7);
            this.rbt_album.Margin = new System.Windows.Forms.Padding(4);
            this.rbt_album.Name = "rbt_album";
            this.rbt_album.Size = new System.Drawing.Size(71, 23);
            this.rbt_album.TabIndex = 9;
            this.rbt_album.Text = "Album";
            this.rbt_album.UseVisualStyleBackColor = true;
            this.rbt_album.CheckedChanged += new System.EventHandler(this.rbt_album_CheckedChanged);
            // 
            // rbt_track
            // 
            this.rbt_track.AutoSize = true;
            this.rbt_track.Location = new System.Drawing.Point(164, 7);
            this.rbt_track.Margin = new System.Windows.Forms.Padding(4);
            this.rbt_track.Name = "rbt_track";
            this.rbt_track.Size = new System.Drawing.Size(63, 23);
            this.rbt_track.TabIndex = 12;
            this.rbt_track.Text = "Track";
            this.rbt_track.UseVisualStyleBackColor = true;
            this.rbt_track.CheckedChanged += new System.EventHandler(this.rbt_track_CheckedChanged);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(499, 38);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(95, 27);
            this.btn_search.TabIndex = 13;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // pbx_artist
            // 
            this.pbx_artist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbx_artist.Image = global::SMLoader.Properties.Resources.cd_icon_46229;
            this.pbx_artist.InitialImage = global::SMLoader.Properties.Resources.cd_icon_46229;
            this.pbx_artist.Location = new System.Drawing.Point(362, 73);
            this.pbx_artist.Margin = new System.Windows.Forms.Padding(4);
            this.pbx_artist.Name = "pbx_artist";
            this.pbx_artist.Size = new System.Drawing.Size(232, 232);
            this.pbx_artist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_artist.TabIndex = 14;
            this.pbx_artist.TabStop = false;
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
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(362, 263);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(226, 42);
            this.axWindowsMediaPlayer1.TabIndex = 17;
            // 
            // btn_preview
            // 
            this.btn_preview.BackColor = System.Drawing.Color.Transparent;
            this.btn_preview.Enabled = false;
            this.btn_preview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_preview.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_preview.Location = new System.Drawing.Point(362, 314);
            this.btn_preview.Margin = new System.Windows.Forms.Padding(0);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Size = new System.Drawing.Size(232, 29);
            this.btn_preview.TabIndex = 18;
            this.btn_preview.Text = "Preview Track";
            this.btn_preview.UseVisualStyleBackColor = false;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(609, 387);
            this.tabControl1.TabIndex = 19;
            // 
            // tabPage1
            // 
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
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(601, 355);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            this.tabPage2.Size = new System.Drawing.Size(601, 355);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.btn_ether_add.Location = new System.Drawing.Point(391, 321);
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
            this.btn_bitcoin_add.Location = new System.Drawing.Point(217, 321);
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
            this.btn_monero_add.Location = new System.Drawing.Point(43, 321);
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
            this.label3.Location = new System.Drawing.Point(139, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "Set free some souls from hell today: Donate!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(213, 279);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 386);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMLoadr AUX";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_artist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_go;
        private System.Windows.Forms.ComboBox cmb_quality;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txb_search;
        private System.Windows.Forms.ListBox lb_result;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
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
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_reset;
    }
}


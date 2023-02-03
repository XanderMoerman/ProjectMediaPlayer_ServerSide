
namespace WinAppMediaPlayerVersie2
{
    partial class frmServerMediaPlayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssMediaPlayer = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssTCPServer = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssTCPClient = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMediaPlayer = new System.Windows.Forms.TabPage();
            this.splitContMediaPlayer = new System.Windows.Forms.SplitContainer();
            this.pnlPlaylist = new System.Windows.Forms.Panel();
            this.lstPlaylistSongs = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.pnlKnoppen = new System.Windows.Forms.Panel();
            this.btnVerwijderPlayList = new System.Windows.Forms.Button();
            this.btnVoegToePlayList = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlAlleSongs = new System.Windows.Forms.Panel();
            this.lstAlleSongs = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnStop = new System.Windows.Forms.Button();
            this.BtnStart = new System.Windows.Forms.Button();
            this.btnVoegSongToe = new System.Windows.Forms.Button();
            this.tabServer = new System.Windows.Forms.TabPage();
            this.TxtMedling = new System.Windows.Forms.RichTextBox();
            this.ChbStartServer = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtIP = new System.Windows.Forms.TextBox();
            this.TxtPort = new System.Windows.Forms.TextBox();
            this.tabPlaylist = new System.Windows.Forms.TabPage();
            this.OfdFindSong = new System.Windows.Forms.OpenFileDialog();
            this.BgWorkerListener = new System.ComponentModel.BackgroundWorker();
            this.PnlConnect = new System.Windows.Forms.Panel();
            this.PnlCommunicatie = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnSendClient = new System.Windows.Forms.Button();
            this.TxtBericht = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCommunicatie = new System.Windows.Forms.RichTextBox();
            this.BtnVerbreekClient = new System.Windows.Forms.CheckBox();
            this.BgWorkerOntvang = new System.ComponentModel.BackgroundWorker();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabMediaPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContMediaPlayer)).BeginInit();
            this.splitContMediaPlayer.Panel1.SuspendLayout();
            this.splitContMediaPlayer.Panel2.SuspendLayout();
            this.splitContMediaPlayer.SuspendLayout();
            this.pnlPlaylist.SuspendLayout();
            this.pnlKnoppen.SuspendLayout();
            this.pnlAlleSongs.SuspendLayout();
            this.tabServer.SuspendLayout();
            this.PnlConnect.SuspendLayout();
            this.PnlCommunicatie.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssMediaPlayer,
            this.toolStripStatusLabel1,
            this.tssTCPServer,
            this.toolStripStatusLabel3,
            this.tssTCPClient});
            this.statusStrip1.Location = new System.Drawing.Point(0, 693);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1317, 26);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssMediaPlayer
            // 
            this.tssMediaPlayer.BackColor = System.Drawing.Color.Red;
            this.tssMediaPlayer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tssMediaPlayer.Name = "tssMediaPlayer";
            this.tssMediaPlayer.Size = new System.Drawing.Size(147, 20);
            this.tssMediaPlayer.Text = "Mediaplayer gestopt";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Lime;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(21, 20);
            this.toolStripStatusLabel1.Text = " ||";
            // 
            // tssTCPServer
            // 
            this.tssTCPServer.ForeColor = System.Drawing.Color.Red;
            this.tssTCPServer.Name = "tssTCPServer";
            this.tssTCPServer.Size = new System.Drawing.Size(151, 20);
            this.tssTCPServer.Text = "TCP/IP Server gestopt";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.ForeColor = System.Drawing.Color.Lime;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(17, 20);
            this.toolStripStatusLabel3.Text = "||";
            // 
            // tssTCPClient
            // 
            this.tssTCPClient.ForeColor = System.Drawing.Color.Red;
            this.tssTCPClient.Name = "tssTCPClient";
            this.tssTCPClient.Size = new System.Drawing.Size(151, 20);
            this.tssTCPClient.Text = "Client niet verbonden";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMediaPlayer);
            this.tabControl1.Controls.Add(this.tabServer);
            this.tabControl1.Controls.Add(this.tabPlaylist);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1317, 693);
            this.tabControl1.TabIndex = 1;
            // 
            // tabMediaPlayer
            // 
            this.tabMediaPlayer.Controls.Add(this.splitContMediaPlayer);
            this.tabMediaPlayer.Location = new System.Drawing.Point(4, 25);
            this.tabMediaPlayer.Name = "tabMediaPlayer";
            this.tabMediaPlayer.Padding = new System.Windows.Forms.Padding(3);
            this.tabMediaPlayer.Size = new System.Drawing.Size(1309, 664);
            this.tabMediaPlayer.TabIndex = 0;
            this.tabMediaPlayer.Text = "MediaPlayer";
            this.tabMediaPlayer.UseVisualStyleBackColor = true;
            // 
            // splitContMediaPlayer
            // 
            this.splitContMediaPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContMediaPlayer.Location = new System.Drawing.Point(3, 3);
            this.splitContMediaPlayer.Name = "splitContMediaPlayer";
            this.splitContMediaPlayer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContMediaPlayer.Panel1
            // 
            this.splitContMediaPlayer.Panel1.Controls.Add(this.pnlPlaylist);
            this.splitContMediaPlayer.Panel1.Controls.Add(this.splitter2);
            this.splitContMediaPlayer.Panel1.Controls.Add(this.pnlKnoppen);
            this.splitContMediaPlayer.Panel1.Controls.Add(this.splitter1);
            this.splitContMediaPlayer.Panel1.Controls.Add(this.pnlAlleSongs);
            // 
            // splitContMediaPlayer.Panel2
            // 
            this.splitContMediaPlayer.Panel2.Controls.Add(this.BtnStop);
            this.splitContMediaPlayer.Panel2.Controls.Add(this.BtnStart);
            this.splitContMediaPlayer.Panel2.Controls.Add(this.btnVoegSongToe);
            this.splitContMediaPlayer.Size = new System.Drawing.Size(1303, 658);
            this.splitContMediaPlayer.SplitterDistance = 495;
            this.splitContMediaPlayer.TabIndex = 1;
            // 
            // pnlPlaylist
            // 
            this.pnlPlaylist.Controls.Add(this.lstPlaylistSongs);
            this.pnlPlaylist.Controls.Add(this.label2);
            this.pnlPlaylist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPlaylist.Location = new System.Drawing.Point(561, 0);
            this.pnlPlaylist.Name = "pnlPlaylist";
            this.pnlPlaylist.Size = new System.Drawing.Size(742, 495);
            this.pnlPlaylist.TabIndex = 4;
            // 
            // lstPlaylistSongs
            // 
            this.lstPlaylistSongs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPlaylistSongs.FormattingEnabled = true;
            this.lstPlaylistSongs.ItemHeight = 16;
            this.lstPlaylistSongs.Location = new System.Drawing.Point(0, 16);
            this.lstPlaylistSongs.Name = "lstPlaylistSongs";
            this.lstPlaylistSongs.Size = new System.Drawing.Size(742, 479);
            this.lstPlaylistSongs.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Playlist:";
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(553, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(8, 495);
            this.splitter2.TabIndex = 3;
            this.splitter2.TabStop = false;
            // 
            // pnlKnoppen
            // 
            this.pnlKnoppen.BackColor = System.Drawing.SystemColors.Control;
            this.pnlKnoppen.Controls.Add(this.btnVerwijderPlayList);
            this.pnlKnoppen.Controls.Add(this.btnVoegToePlayList);
            this.pnlKnoppen.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlKnoppen.Location = new System.Drawing.Point(480, 0);
            this.pnlKnoppen.Name = "pnlKnoppen";
            this.pnlKnoppen.Size = new System.Drawing.Size(73, 495);
            this.pnlKnoppen.TabIndex = 2;
            // 
            // btnVerwijderPlayList
            // 
            this.btnVerwijderPlayList.Location = new System.Drawing.Point(10, 60);
            this.btnVerwijderPlayList.Name = "btnVerwijderPlayList";
            this.btnVerwijderPlayList.Size = new System.Drawing.Size(54, 36);
            this.btnVerwijderPlayList.TabIndex = 1;
            this.btnVerwijderPlayList.Text = "<<";
            this.btnVerwijderPlayList.UseVisualStyleBackColor = true;
            this.btnVerwijderPlayList.Click += new System.EventHandler(this.btnVerwijderPlayList_Click);
            // 
            // btnVoegToePlayList
            // 
            this.btnVoegToePlayList.Location = new System.Drawing.Point(10, 18);
            this.btnVoegToePlayList.Name = "btnVoegToePlayList";
            this.btnVoegToePlayList.Size = new System.Drawing.Size(54, 36);
            this.btnVoegToePlayList.TabIndex = 0;
            this.btnVoegToePlayList.Text = ">>";
            this.btnVoegToePlayList.UseVisualStyleBackColor = true;
            this.btnVoegToePlayList.Click += new System.EventHandler(this.btnVoegToePlayList_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(472, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(8, 495);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // pnlAlleSongs
            // 
            this.pnlAlleSongs.Controls.Add(this.lstAlleSongs);
            this.pnlAlleSongs.Controls.Add(this.label1);
            this.pnlAlleSongs.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAlleSongs.Location = new System.Drawing.Point(0, 0);
            this.pnlAlleSongs.Name = "pnlAlleSongs";
            this.pnlAlleSongs.Size = new System.Drawing.Size(472, 495);
            this.pnlAlleSongs.TabIndex = 0;
            // 
            // lstAlleSongs
            // 
            this.lstAlleSongs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstAlleSongs.FormattingEnabled = true;
            this.lstAlleSongs.ItemHeight = 16;
            this.lstAlleSongs.Location = new System.Drawing.Point(0, 16);
            this.lstAlleSongs.Name = "lstAlleSongs";
            this.lstAlleSongs.Size = new System.Drawing.Size(472, 479);
            this.lstAlleSongs.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alle Songs:";
            // 
            // BtnStop
            // 
            this.BtnStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BtnStop.Location = new System.Drawing.Point(673, 0);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(630, 159);
            this.BtnStop.TabIndex = 2;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = true;
            this.BtnStop.Click += new System.EventHandler(this.btnStopPlay_Click);
            // 
            // BtnStart
            // 
            this.BtnStart.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnStart.Location = new System.Drawing.Point(179, 0);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(494, 159);
            this.BtnStart.TabIndex = 1;
            this.BtnStart.Text = "Play";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.btnStartPlay_Click);
            // 
            // btnVoegSongToe
            // 
            this.btnVoegSongToe.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnVoegSongToe.Location = new System.Drawing.Point(0, 0);
            this.btnVoegSongToe.Name = "btnVoegSongToe";
            this.btnVoegSongToe.Size = new System.Drawing.Size(179, 159);
            this.btnVoegSongToe.TabIndex = 0;
            this.btnVoegSongToe.Text = "Song zoeken ...";
            this.btnVoegSongToe.UseVisualStyleBackColor = true;
            this.btnVoegSongToe.Click += new System.EventHandler(this.btnVoegSongToe_Click);
            // 
            // tabServer
            // 
            this.tabServer.Controls.Add(this.PnlCommunicatie);
            this.tabServer.Controls.Add(this.PnlConnect);
            this.tabServer.Location = new System.Drawing.Point(4, 25);
            this.tabServer.Name = "tabServer";
            this.tabServer.Padding = new System.Windows.Forms.Padding(3);
            this.tabServer.Size = new System.Drawing.Size(1309, 664);
            this.tabServer.TabIndex = 1;
            this.tabServer.Text = "TCP/IP Server";
            this.tabServer.UseVisualStyleBackColor = true;
            // 
            // TxtMedling
            // 
            this.TxtMedling.Location = new System.Drawing.Point(7, 159);
            this.TxtMedling.Name = "TxtMedling";
            this.TxtMedling.ReadOnly = true;
            this.TxtMedling.Size = new System.Drawing.Size(319, 477);
            this.TxtMedling.TabIndex = 6;
            this.TxtMedling.Text = "";
            // 
            // ChbStartServer
            // 
            this.ChbStartServer.Appearance = System.Windows.Forms.Appearance.Button;
            this.ChbStartServer.Location = new System.Drawing.Point(7, 59);
            this.ChbStartServer.Name = "ChbStartServer";
            this.ChbStartServer.Size = new System.Drawing.Size(319, 36);
            this.ChbStartServer.TabIndex = 5;
            this.ChbStartServer.Text = "Start Server";
            this.ChbStartServer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ChbStartServer.UseVisualStyleBackColor = true;
            this.ChbStartServer.CheckedChanged += new System.EventHandler(this.ChbStartServer_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "IP";
            // 
            // TxtIP
            // 
            this.TxtIP.Location = new System.Drawing.Point(41, 3);
            this.TxtIP.Name = "TxtIP";
            this.TxtIP.Size = new System.Drawing.Size(285, 22);
            this.TxtIP.TabIndex = 2;
            this.TxtIP.Text = "127.000.000.001";
            this.TxtIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtPort
            // 
            this.TxtPort.Location = new System.Drawing.Point(41, 31);
            this.TxtPort.Name = "TxtPort";
            this.TxtPort.Size = new System.Drawing.Size(285, 22);
            this.TxtPort.TabIndex = 1;
            this.TxtPort.Text = "50000";
            this.TxtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPlaylist
            // 
            this.tabPlaylist.Location = new System.Drawing.Point(4, 25);
            this.tabPlaylist.Name = "tabPlaylist";
            this.tabPlaylist.Size = new System.Drawing.Size(1305, 651);
            this.tabPlaylist.TabIndex = 2;
            this.tabPlaylist.Text = "PlayLijsten database";
            this.tabPlaylist.UseVisualStyleBackColor = true;
            // 
            // OfdFindSong
            // 
            this.OfdFindSong.FileName = "openFileDialog1";
            this.OfdFindSong.Filter = "mp3 files (*.mp3)|*.mp3|wav files (*.wav)|*.wav|mp4 files (*.mp4)|*.mp4";
            // 
            // BgWorkerListener
            // 
            this.BgWorkerListener.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgWorkerListener_DoWork);
            this.BgWorkerListener.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgWorkerListener_RunWorkerCompleted);
            // 
            // PnlConnect
            // 
            this.PnlConnect.Controls.Add(this.BtnVerbreekClient);
            this.PnlConnect.Controls.Add(this.label5);
            this.PnlConnect.Controls.Add(this.TxtIP);
            this.PnlConnect.Controls.Add(this.TxtMedling);
            this.PnlConnect.Controls.Add(this.TxtPort);
            this.PnlConnect.Controls.Add(this.ChbStartServer);
            this.PnlConnect.Controls.Add(this.label3);
            this.PnlConnect.Controls.Add(this.label4);
            this.PnlConnect.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlConnect.Location = new System.Drawing.Point(3, 3);
            this.PnlConnect.Name = "PnlConnect";
            this.PnlConnect.Size = new System.Drawing.Size(331, 658);
            this.PnlConnect.TabIndex = 7;
            // 
            // PnlCommunicatie
            // 
            this.PnlCommunicatie.Controls.Add(this.TxtCommunicatie);
            this.PnlCommunicatie.Controls.Add(this.label6);
            this.PnlCommunicatie.Controls.Add(this.TxtBericht);
            this.PnlCommunicatie.Controls.Add(this.BtnSendClient);
            this.PnlCommunicatie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlCommunicatie.Location = new System.Drawing.Point(334, 3);
            this.PnlCommunicatie.Name = "PnlCommunicatie";
            this.PnlCommunicatie.Size = new System.Drawing.Size(972, 658);
            this.PnlCommunicatie.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Medlingen Van Server";
            // 
            // BtnSendClient
            // 
            this.BtnSendClient.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnSendClient.Location = new System.Drawing.Point(0, 619);
            this.BtnSendClient.Name = "BtnSendClient";
            this.BtnSendClient.Size = new System.Drawing.Size(972, 39);
            this.BtnSendClient.TabIndex = 0;
            this.BtnSendClient.Text = "Stuur Bericht Naar Client";
            this.BtnSendClient.UseVisualStyleBackColor = true;
            this.BtnSendClient.Click += new System.EventHandler(this.BtnSendClient_Click);
            // 
            // TxtBericht
            // 
            this.TxtBericht.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TxtBericht.Location = new System.Drawing.Point(0, 597);
            this.TxtBericht.Name = "TxtBericht";
            this.TxtBericht.Size = new System.Drawing.Size(972, 22);
            this.TxtBericht.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label6.Location = new System.Drawing.Point(0, 579);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(972, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Bericht";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtCommunicatie
            // 
            this.TxtCommunicatie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtCommunicatie.Location = new System.Drawing.Point(0, 0);
            this.TxtCommunicatie.Name = "TxtCommunicatie";
            this.TxtCommunicatie.ReadOnly = true;
            this.TxtCommunicatie.Size = new System.Drawing.Size(972, 579);
            this.TxtCommunicatie.TabIndex = 3;
            this.TxtCommunicatie.Text = "Communicatie Tussen Client en Server:";
            // 
            // BtnVerbreekClient
            // 
            this.BtnVerbreekClient.Appearance = System.Windows.Forms.Appearance.Button;
            this.BtnVerbreekClient.Enabled = false;
            this.BtnVerbreekClient.Location = new System.Drawing.Point(8, 101);
            this.BtnVerbreekClient.Name = "BtnVerbreekClient";
            this.BtnVerbreekClient.Size = new System.Drawing.Size(319, 36);
            this.BtnVerbreekClient.TabIndex = 8;
            this.BtnVerbreekClient.Text = "Verbreek verbinding met client";
            this.BtnVerbreekClient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnVerbreekClient.UseVisualStyleBackColor = true;
            this.BtnVerbreekClient.CheckedChanged += new System.EventHandler(this.BtnVerbreekClient_CheckedChanged);
            // 
            // BgWorkerOntvang
            // 
            this.BgWorkerOntvang.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgWorkerOntvang_DoWork);
            this.BgWorkerOntvang.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgWorkerOntvang_RunWorkerCompleted);
            // 
            // frmServerMediaPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 719);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmServerMediaPlayer";
            this.Text = "MediaPlayer - Server";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmServerMediaPlayer_Load);
            this.Shown += new System.EventHandler(this.frmServerMediaPlayer_Shown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabMediaPlayer.ResumeLayout(false);
            this.splitContMediaPlayer.Panel1.ResumeLayout(false);
            this.splitContMediaPlayer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContMediaPlayer)).EndInit();
            this.splitContMediaPlayer.ResumeLayout(false);
            this.pnlPlaylist.ResumeLayout(false);
            this.pnlPlaylist.PerformLayout();
            this.pnlKnoppen.ResumeLayout(false);
            this.pnlAlleSongs.ResumeLayout(false);
            this.pnlAlleSongs.PerformLayout();
            this.tabServer.ResumeLayout(false);
            this.PnlConnect.ResumeLayout(false);
            this.PnlConnect.PerformLayout();
            this.PnlCommunicatie.ResumeLayout(false);
            this.PnlCommunicatie.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabMediaPlayer;
        private System.Windows.Forms.TabPage tabServer;
        private System.Windows.Forms.TabPage tabPlaylist;
        private System.Windows.Forms.SplitContainer splitContMediaPlayer;
        private System.Windows.Forms.Panel pnlPlaylist;
        private System.Windows.Forms.ListBox lstPlaylistSongs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel pnlKnoppen;
        private System.Windows.Forms.Button btnVerwijderPlayList;
        private System.Windows.Forms.Button btnVoegToePlayList;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel pnlAlleSongs;
        private System.Windows.Forms.ListBox lstAlleSongs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVoegSongToe;
        private System.Windows.Forms.OpenFileDialog OfdFindSong;
        private System.Windows.Forms.ToolStripStatusLabel tssMediaPlayer;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tssTCPServer;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel tssTCPClient;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtIP;
        private System.Windows.Forms.TextBox TxtPort;
        private System.Windows.Forms.CheckBox ChbStartServer;
        private System.Windows.Forms.RichTextBox TxtMedling;
        private System.ComponentModel.BackgroundWorker BgWorkerListener;
        private System.Windows.Forms.Panel PnlConnect;
        private System.Windows.Forms.Panel PnlCommunicatie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnSendClient;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtBericht;
        private System.Windows.Forms.RichTextBox TxtCommunicatie;
        private System.Windows.Forms.CheckBox BtnVerbreekClient;
        private System.ComponentModel.BackgroundWorker BgWorkerOntvang;
    }
}


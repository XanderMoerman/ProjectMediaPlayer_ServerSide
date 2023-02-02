using System;
using System.Drawing;
using System.Windows.Forms;
using WMPLib;
using System.IO;
using System.Net.Sockets;
using System.Net;

namespace WinAppMediaPlayerVersie2
{
    public partial class frmServerMediaPlayer : Form
    {
        public frmServerMediaPlayer()
        {
            InitializeComponent();
        }

        WindowsMediaPlayer Player = new WindowsMediaPlayer();
        TcpClient tcpClient; // verbinding met client
        TcpListener tcpListener; // wachten op client
        StreamReader Reader;
        StreamWriter Writer;
        private void frmServerMediaPlayer_Shown(object sender, EventArgs e)
        {
            pnlAlleSongs.Width = (splitContMediaPlayer.Panel1.Width - pnlKnoppen.Width) / 2;
        }

        private void frmServerMediaPlayer_Load(object sender, EventArgs e)
        {
            // playlist maken bij opstart
            Player.currentPlaylist = Player.newPlaylist("Klas", "");

            // checken voor songs
            string pad = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "muziek");
            if(!Directory.Exists(pad)) Directory.CreateDirectory(pad); // maak map als muziek map nog niet bestaat
            // loop door alle songs
            foreach(string file in Directory.GetFiles(pad))
            {
                // voeg toe aan list
                if (file.EndsWith(".mp3")) lstAlleSongs.Items.Add(Path.GetFileNameWithoutExtension(file));
            }
        }

        // afspelen
        private void btnStartPlay_Click(object sender, EventArgs e)
        {
            Player.controls.play();
            tssMediaPlayer.Text = "Mediaplayer actief";
            tssMediaPlayer.BackColor = Color.Green;
        }

        // stoppen
        private void btnStopPlay_Click(object sender, EventArgs e)
        {
            Player.controls.stop();
            tssMediaPlayer.Text = "Mediaplayer gestopt";
            tssMediaPlayer.BackColor = Color.Red;
        }

        private void btnVoegSongToe_Click(object sender, EventArgs e)
        {
            if(OfdFindSong.ShowDialog() == DialogResult.OK)
            {
                string SongFile = Path.GetFileNameWithoutExtension(OfdFindSong.FileName);
                // als de song nog niet in de list staat en de file bestaat
                if (!lstAlleSongs.Items.Contains(SongFile))
                {
                    lstAlleSongs.Items.Add(Path.GetFileNameWithoutExtension(OfdFindSong.FileName)); // voeg toe aan de lijst
                    //toevoegen aan de muziek map
                    string pad = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "muziek");
                    if (!Directory.Exists(pad)) Directory.CreateDirectory(pad); // maak map als muziek map nog niet bestaat
                    File.Copy(OfdFindSong.FileName, pad + "\\" + SongFile + ".mp3");
                }
            }
        }

        private void btnVoegToePlayList_Click(object sender, EventArgs e)
        {
            if (lstAlleSongs.SelectedIndex == -1) return; // als er niets geselecteerd is
            string pad = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "muziek");
            string Song = lstAlleSongs.SelectedItem.ToString();
            if (lstPlaylistSongs.Items.Contains(Song)) return; // als de song al bestaat
            lstPlaylistSongs.Items.Add(Song); // voeg toe aan de list
            Player.currentPlaylist.appendItem(Player.newMedia(Path.Combine(pad, Song + ".mp3")));
        }

        private void btnVerwijderPlayList_Click(object sender, EventArgs e)
        {
            if (lstPlaylistSongs.SelectedIndex == -1) return; // als er niets geselecteerd is
            string Song = lstPlaylistSongs.SelectedItem.ToString();
            if (lstPlaylistSongs.Items.Contains(Song)) lstPlaylistSongs.Items.Remove(Song); // als de song bestaat, verwijder
            Player.currentPlaylist.removeItem(Player.currentPlaylist.Item[lstPlaylistSongs.SelectedIndex +1]);
        }

        private void ChbStartServer_CheckedChanged(object sender, EventArgs e)
        {
            if(ChbStartServer.Checked) // als de checkbox ingedrukt is
            {
                // controle IP
                IPAddress ipadres;
                int poortNr;
                if (!IPAddress.TryParse(TxtIP.Text.Replace(" ", ""), out ipadres))
                {
                    TxtMedling.Text += "Ongeldig IP adres!\n";
                    TxtIP.Focus();
                    return;
                }
                if(!int.TryParse(TxtPort.Text, out poortNr))
                {
                    TxtMedling.Text += "Ongeldig poortnummer!\n";
                    TxtPort.Focus();
                    return;
                }

                // listener opzetten
                TxtMedling.Text += "Server Starten...\n";
                try
                {
                    tcpListener = new TcpListener(ipadres, poortNr);
                    tcpListener.Start();

                    // background worker opzetten
                    BgWorkerListener.WorkerSupportsCancellation = true;
                    BgWorkerListener.RunWorkerAsync();
                    TxtMedling.Text += "Server Opgestart\n";
                    ChbStartServer.Text = "Stop Server";
                }
                catch(Exception ex)
                {
                    TxtMedling.Text += "Error Tijdens Server Opstart\n";

                }
            }
        }
    }
}

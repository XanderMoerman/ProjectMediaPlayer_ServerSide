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

            // server communicatie disabelen
            PnlCommunicatie.Enabled = false;
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

                // versturen naar client
                try
                {
                    if (Writer != null)
                            Writer.WriteLine("SONGLISTADD " + SongFile);
                    }
                catch
                {
                    TxtMedling.AppendText("Kon niet verzenden. Check of er connectie is");
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

            // doorsturen naar client
            try
            {
                if (Writer != null)
                    Writer.WriteLine("PLAYLISTADD " + Song);
            }
            catch
            {
                TxtMedling.AppendText("Kon niet verzenden. Check of er connectie is");
            }
        }

        private void btnVerwijderPlayList_Click(object sender, EventArgs e)
        {
            if (lstPlaylistSongs.SelectedIndex == -1) return; // als er niets geselecteerd is
            string Song = lstPlaylistSongs.SelectedItem.ToString();
            if (lstPlaylistSongs.Items.Contains(Song)) lstPlaylistSongs.Items.Remove(Song); // als de song bestaat, verwijder
            Player.currentPlaylist.removeItem(Player.currentPlaylist.Item[lstPlaylistSongs.SelectedIndex +1]);

            // doorsturen naar client
            try
            {
                if(Writer != null)
                    Writer.WriteLine("PLAYLISTREMOVE " + Song);
            }
            catch
            {
                TxtMedling.AppendText("Kon niet verzenden. Check of er connectie is");
            }
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
                    TxtMedling.AppendText("Ongeldig IP adres\r\n");
                    TxtIP.Focus();
                    return;
                }
                if(!int.TryParse(TxtPort.Text, out poortNr))
                {
                    TxtMedling.AppendText("Ongeldig poortnummer\r\n");
                    TxtPort.Focus();
                    return;
                }

                // listener opzetten
                TxtMedling.AppendText("Server Starten\r\n");
                try
                {
                    tcpListener = new TcpListener(ipadres, poortNr);
                    tcpListener.Start();

                    // background worker opzetten
                    BgWorkerListener.WorkerSupportsCancellation = true;
                    BgWorkerListener.RunWorkerAsync();
                    TxtMedling.AppendText("Server Opgestart\r\n");
                    ChbStartServer.Text = "Stop Server";

                    // status
                    tssTCPServer.Text = "TCP/IP Server gestart";
                    tssTCPServer.ForeColor = Color.Green;
                }
                catch
                {
                    TxtMedling.Text += "Error Tijdens Server Opstart\n";
                }
            }

            // als de knop unchecked is
            else
            {
                if(tcpClient != null && tcpClient.Connected) // als er een client verbonden is
                {
                    // stopbericht naar client sturen
                    Writer.WriteLine("Disconnect");
                    BgWorkerOntvang.CancelAsync(); // stop backgroundworker
                }
                try // sever stoppen
                {
                    if(tcpListener != null)
                    {
                        // als er een client verbonden is
                        if (tcpClient != null && tcpClient.Connected) tcpClient.Close(); // close client
                        tcpListener.Stop();
                    }
                    ChbStartServer.Text = "Start Server";
                    TxtMedling.AppendText("Server gestopt!\r\n");

                    // status
                    tssTCPServer.Text = "TCP/IP Server gestopt";
                    tssTCPServer.ForeColor = Color.Red;

                    // panel communicatie
                    PnlCommunicatie.Enabled = false;
                    TxtIP.Focus();
                }
                catch
                {
                    MessageBox.Show("Server kan niet worden gestopt!");
                }
            }
        }

        private void BgWorkerListener_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            tcpClient = tcpListener.AcceptTcpClient(); // 1 client aanvaarden, hij zal wachten tot de client verbonden is
            // daarna zal RunWorkerCompleted runnen
        }

        private void BgWorkerListener_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            // listener moeten stoppen met wachten als de client verbonden is
            if(tcpClient != null && tcpClient.Connected)
            {
                // communicatie met client opzetten
                Writer = new StreamWriter(tcpClient.GetStream());
                Reader = new StreamReader(tcpClient.GetStream());
                Writer.AutoFlush = true;
                BgWorkerOntvang.WorkerSupportsCancellation = true;
                BgWorkerOntvang.RunWorkerAsync();
                BtnVerbreekClient.Enabled = true;
                TxtMedling.AppendText("Client is verbonden!\r\n");

                // client communicatie enabelen
                PnlCommunicatie.Enabled = true;
                TxtBericht.Focus();
                this.AcceptButton = BtnSendClient;

                //status
                tssTCPClient.Text = "Client verbonden";
                tssTCPClient.ForeColor = Color.Green;

                // doorsturen van alle titels
                foreach(string file in lstAlleSongs.Items)
                    Writer.WriteLine("SONGLISTADD " + file);

                // doorsturen van alle songs in de playlist
                foreach (string file in lstPlaylistSongs.Items)
                    Writer.WriteLine("PLAYLISTADD " + file);
            }
        }

        private void BgWorkerOntvang_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            string bericht = "";
            while (bericht != "Disconnect") // zolang de client verbonden is
            {
                try
                {
                    bericht = Reader.ReadLine();
                    if (bericht == "Disconnect") ; // break uit de while loop
                    else if (bericht == null) ;
                    else if (bericht.StartsWith("PLAYLISTADD")) // voeg toe aan playlist
                    {
                        Invoke(new MethodInvoker(delegate ()
                        {
                            string pad = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), "muziek");
                            string Song = bericht.Remove(0, 12);
                            if (!lstPlaylistSongs.Items.Contains(Song))// als de song nog niet bestaat
                            {
                                lstPlaylistSongs.Invoke(new MethodInvoker(delegate ()
                                {
                                    lstPlaylistSongs.Items.Add(Song); // voeg toe aan de list
                                }));
                                Player.currentPlaylist.appendItem(Player.newMedia(Path.Combine(pad, Song + ".mp3")));
                            }
                        }));
                    }
                    else if(bericht.StartsWith("PLAYLISTREMOVE"))
                    {
                        Invoke(new MethodInvoker(delegate ()
                        {
                            string Song = bericht.Remove(0, 15);
                            // als de song bestaat, verwijder
                            if (lstPlaylistSongs.Items.Contains(Song))
                            {
                                int index = lstPlaylistSongs.Items.IndexOf(Song);
                                lstPlaylistSongs.Items.Remove(Song);
                                Player.currentPlaylist.removeItem(Player.currentPlaylist.Item[index]);
                            }
                        }));
                    }
                    else if (bericht == "START-PLAYER")
                    {
                        Invoke(new MethodInvoker(delegate ()
                        {
                            Player.controls.play();
                            tssMediaPlayer.Text = "Mediaplayer actief";
                            tssMediaPlayer.BackColor = Color.Green;
                        }));
                    }
                    else if (bericht == "STOP-PLAYER")
                    {
                        Invoke(new MethodInvoker(delegate ()
                        {
                            Player.controls.stop();
                            tssMediaPlayer.Text = "Mediaplayer gestopt";
                            tssMediaPlayer.BackColor = Color.Red;
                        }));
                    }
                    else
                    {
                        TxtCommunicatie.Invoke(new MethodInvoker(delegate ()
                        {
                            TxtCommunicatie.AppendText(bericht + "\r\n");
                        }));
                    }
                }
                catch (Exception ex)
                {
                    TxtMedling.Invoke(new MethodInvoker(delegate ()
                    {
                        TxtMedling.AppendText("Kan bericht niet ontvangen.\r\n" + ex.Message.ToString() + "\r\n");
                    }));
                }
            }
        }

        private void BgWorkerOntvang_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            Writer.Close();
            Reader.Close();
            tcpClient.Close();
            TxtMedling.AppendText("Verbinding met de client is verbroken.\r\n");
            BtnVerbreekClient.Enabled = false;
            PnlCommunicatie.Enabled = false;

            // status
            tssTCPClient.Text = "Client niet verbonden";
            tssTCPClient.ForeColor = Color.Red;

            // opnieuw wachten tot een client verbind
            if (ChbStartServer.Checked)
                BgWorkerListener.RunWorkerAsync();
        }

        private void BtnSendClient_Click(object sender, EventArgs e)
        {
            try
            {
                Writer.WriteLine("SERVER >> " + TxtBericht.Text);
                TxtCommunicatie.AppendText("SERVER >> " + TxtBericht.Text + "\r\n");
            }
            catch
            {
                TxtMedling.AppendText("Bericht kon niet verzonden worden!\r\n");
            }
        }

        private void BtnVerbreekClient_CheckedChanged(object sender, EventArgs e)
        {
            Writer.WriteLine("Disconnect");
            tcpClient.Close();
        }

        private void frmServerMediaPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Writer != null)
                Writer.WriteLine("Disconnect");
        }
    }
}

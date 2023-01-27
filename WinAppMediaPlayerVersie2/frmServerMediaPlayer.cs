using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.IO;

namespace WinAppMediaPlayerVersie2
{
    public partial class frmServerMediaPlayer : Form
    {
        public frmServerMediaPlayer()
        {
            InitializeComponent();
        }

        WindowsMediaPlayer Player = new WindowsMediaPlayer();
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
        }

        // stoppen
        private void btnStopPlay_Click(object sender, EventArgs e)
        {
            Player.controls.stop();
        }
    }
}

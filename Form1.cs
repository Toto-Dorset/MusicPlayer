using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {

        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        string s;
        public Form1()
        {
            InitializeComponent();
            hide();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PlaylistButton_Click(object sender, EventArgs e)
        {
            presently();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hide();
        }

        private void hide()
        {
            PanelPlaylist.Visible = false;
        }

        private void presently()
        {
            if (PanelPlaylist.Visible == false)
            {
                PanelPlaylist.Visible = true;
            }
        }

        private void runmp3()
        {
            player.URL = s;
            player.controls.play();
        }

        private void icbtnmusic_Click(object sender, EventArgs e)
        {
            hide();
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);

                    System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
                    s = files[0];
                    runmp3();
                }
            }

            //OpenFileDialog dlg = new OpenFileDialog();
            //if(dlg.ShowDialog()==DialogResult.OK)
            //{
            //    s = dlg.FileName;
            //    runmp3();
            //}
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(player.playState== WMPLib.WMPPlayState.wmppsPlaying)
            {

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FavoritesButton_Click(object sender, EventArgs e)
        {
            LibraryPanel.Visible = false;
            FavoritesPanel.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LibraryPanel.Visible = true;
            FavoritesPanel.Visible = false;
        }

        
    }
}

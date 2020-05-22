using System;
using System.Windows.Forms;
using Needle;
using System.IO;

namespace Player
{
    public partial class Form1 : Form
    {
        MP3Player mplayer;
        public Form1()
        {
            InitializeComponent();
            mplayer = new MP3Player();
            mplayer.OpenFile+=new MP3Player.OpenFileEventHandler(mplayer_OpenFile);
            mplayer.PlayFile+=new MP3Player.PlayFileEventHandler(mplayer_PlayFile);
            mplayer.StopFile+=new MP3Player.StopFileEventHandler(mplayer_StopFile);
            mplayer.PauseFile+=new MP3Player.PauseFileEventHandler(mplayer_PauseFile);
        }

        void mplayer_OpenFile(Object sender, MP3Player.OpenFileEventArgs e)
        {
            trackBar1.Maximum = (int)(mplayer.AudioLength/1000);
            trackBar1.Value = 0;
            timer1.Enabled = false;
        }

        void mplayer_StopFile(Object sender, MP3Player.StopFileEventArgs e)
        {
            timer1.Enabled = false;
            trackBar1.Value = 0;
        }

        void mplayer_PauseFile(Object sender, MP3Player.PauseFileEventArgs e)
        {
            timer1.Enabled = false;
        }

        private void trackBar1_MouseUp(object sender, MouseEventArgs e)
        {
            mplayer.Seek((ulong)(trackBar1.Value * 1000));
        }

        void mplayer_PlayFile(Object sender, MP3Player.PlayFileEventArgs e)
        {
            trackBar1.Maximum = (int)(mplayer.AudioLength / 1000);
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            trackBar1.Value = (int)(mplayer.CurrentPosition/1000);
        }

        private void trackBar3_ValueChanged(object sender, EventArgs e)
        {
            mplayer.VolumeAll = trackBar3.Value;
        }

        private void trackBar2_ValueChanged(object sender, EventArgs e)
        {
            mplayer.Balance = trackBar2.Value;
        }

        private void trackBar5_ValueChanged(object sender, EventArgs e)
        {
            mplayer.VolumeTreble = trackBar5.Value;
        }

        private void trackBar4_ValueChanged(object sender, EventArgs e)
        {
            mplayer.VolumeBass = trackBar4.Value;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            mplayer.MuteAll = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            mplayer.IsLooping = checkBox2.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mplayer.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mplayer.Pause();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mplayer.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "mp3 files|*.mp3";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                button1.Text = Path.GetFileNameWithoutExtension(fd.FileName);
                mplayer.Open(fd.FileName);
            }
        }
    }
}
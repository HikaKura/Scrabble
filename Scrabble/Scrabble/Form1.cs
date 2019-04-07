using Scrabble.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scrabble
{
    public partial class Form1 : Form
    {
        Image Exit = Resources.ExitButton;
        Image Start = Resources.StartButton;
        Image Rules = Resources.RulesButton;
        Image Score = Resources.ScoreButton;
        private DateTime StartTime;
        public WMPLib.WindowsMediaPlayer WMP = new WMPLib.WindowsMediaPlayer();

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Exit;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Image = Start;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Image = Rules;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.Image = Score;
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;

            System.Media.SoundPlayer Audio;
            Audio = new System.Media.SoundPlayer(Properties.Resources.Dendy8bit);
            Audio.Load();
            Audio.PlayLooping();

            timer.Enabled = !timer.Enabled;
            StartTime = DateTime.Now;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Close();
            
            end = false;
            timer.Enabled = !timer.Enabled;
            label1.Text = end.ToString();
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsed = DateTime.Now - StartTime;

            // Начнем с дней, если больше 0.
            string text = "";

            // Преобразование миллисекунд в десятые доли секунды.
            int tenths = elapsed.Milliseconds / 100;

            // Запишите оставшееся время.
            text +=
                elapsed.Hours.ToString("00") + ":" +
                elapsed.Minutes.ToString("00") + ":" +
                elapsed.Seconds.ToString("00");

            label1.Text = text;
        }
    }
}

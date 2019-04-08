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
    public partial class MainForm : Form
    {

        public WMPLib.WindowsMediaPlayer WMP = new WMPLib.WindowsMediaPlayer();
        private DateTime StartTime;

        public MainForm()
        {
            InitializeComponent();
            System.Media.SoundPlayer Audio;
            Audio = new System.Media.SoundPlayer(Properties.Resources.Dendy8bit);
            Audio.Load();
            Audio.PlayLooping();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            DeleteComponent();
            PlayForm();
            record.Text = "0";
            timer.Enabled = !timer.Enabled;
            StartTime = DateTime.Now;
        }

        private void buttonToMenu_Click(object sender, EventArgs e)
        {
            DeleteComponent();
            InitializeComponent();
        }
        

        private void buttonRules_Click(object sender, EventArgs e)
        {
            DeleteComponent();
            RulesForm();
        }

        private void buttonScore_Click(object sender, EventArgs e)
        {
            DeleteComponent();
            ScoreForm();
        }

        private void buttonPlayer_Click(object sender, EventArgs e)
        {
            PlayerForm player = new PlayerForm(Convert.ToInt32(record.Text));
            player.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonRightPage_Click(object sender, EventArgs e)
        {
            if (page < 2)
            {
                page++;
                if (page == 1)
                {
                    OnePage();
                }
                else if (page == 2)
                {
                    TwoPage();
                }
                //else if (page == 3)
                //{
                //    ThreePage();
                //}
            }
        }

        private void buttonLeftPage_Click(object sender, EventArgs e)
        {
            if (page > 1)
            {
                page--;
                if (page == 1)
                {
                    OnePage();
                }
                else if (page == 2)
                {
                    TwoPage();
                }
                //else if (page == 3)
                //{
                //    ThreePage();
                //}
            }
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

            time.Text = text;
        }
    }
}

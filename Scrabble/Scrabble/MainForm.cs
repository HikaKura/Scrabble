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
        Image Exit = Resources.ExitButton;
        Image Start = Resources.StartButton;
        Image Rules = Resources.RulesButton;
        Image Score = Resources.ScoreButton;
        public WMPLib.WindowsMediaPlayer WMP = new WMPLib.WindowsMediaPlayer();

        public MainForm()
        {
            InitializeComponent();
            pictureBoxExit.Image = Exit;
            pictureBoxExit.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxStart.Image = Start;
            pictureBoxStart.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxRules.Image = Rules;
            pictureBoxRules.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxScore.Image = Score;
            pictureBoxScore.SizeMode = PictureBoxSizeMode.StretchImage;

            System.Media.SoundPlayer Audio;
            Audio = new System.Media.SoundPlayer(Properties.Resources.Dendy8bit);
            Audio.Load();
            Audio.PlayLooping();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            DeleteComponent();
            PlayForm();
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

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

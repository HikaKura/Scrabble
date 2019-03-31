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
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            PlayForm playForm = new PlayForm();
            if (!playForm.Visible)
                playForm.Show(this);
        }

        private void buttonRules_Click(object sender, EventArgs e)
        {
            RulesForm rulesForm = new RulesForm();
            if (!rulesForm.Visible)
                rulesForm.Show(this);
        }

        private void buttonScore_Click(object sender, EventArgs e)
        {
            ScoreForm scoreForm = new ScoreForm();
            if (!scoreForm.Visible)
                scoreForm.Show(this);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

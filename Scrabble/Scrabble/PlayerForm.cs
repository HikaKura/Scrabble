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
    public partial class PlayerForm : Form
    {
        public PlayerForm()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DeleteComponent();
            ScoreForm();
        }

        private void buttonToMenu_Click(object sender, EventArgs e)
        {
            DeleteComponent();
            MainForm();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            DeleteComponent();
       //     PlayForm();
        } 

        private void buttonRules_Click(object sender, EventArgs e)
        {
            DeleteComponent();
        //    RulesForm();
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

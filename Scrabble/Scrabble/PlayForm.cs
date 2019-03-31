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
    public partial class PlayForm : Form
    {
        MainForm mainForm = new MainForm();

        public PlayForm()
        {
            InitializeComponent();
        }

        private void buttonToMenu_Click(object sender, EventArgs e)
        {
            mainForm.Show();
        }
    }
}

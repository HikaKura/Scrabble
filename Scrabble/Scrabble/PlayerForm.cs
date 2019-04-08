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

namespace Scrabble
{
    public partial class PlayerForm : Form
    {
        private Dictionary<int, string> score = new Dictionary<int, string>();
        private Stack<string> stack = new Stack<string>();
        private int recordPlayer = 0;

        public PlayerForm(int recordPlayer)
        {
            InitializeComponent();
            this.recordPlayer = recordPlayer;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string player = "";

            if (textBox.Text.Count() > 0 && textBox.Text.Count() < 16)
            {
                if (!textBox.Text.Contains(" "))
                {
                    player = textBox.Text;
                    Close();
                    DeleteComponent();
                    string path = Environment.CurrentDirectory + "\\Score.txt";
                    List<string> list = new List<string>();
                    using (StreamReader sr = new StreamReader(path))
                    {
                        string line = "";
                        string str = "";
                        line = player + " " + recordPlayer;
                        list.Add(line);
                        while (!sr.EndOfStream)
                        {
                            line = sr.ReadLine();
                            list.Add(line);
                            for (int i = 1; i < list.Count; i++)
                            {
                                int score1 = Convert.ToInt32(list[i].Split(' ').Last());
                                int score2 = Convert.ToInt32(list[i - 1].Split(' ').Last());
                                int j = i;
                                while (score1 >= score2 && j > 0)
                                {
                                    str = list[j];
                                    list[j] = list[j - 1];
                                    list[j - 1] = str;
                                    j--;
                                    score1 = Convert.ToInt32(list[j].Split(' ').Last());
                                    if (j > 0)
                                    {
                                        score2 = Convert.ToInt32(list[j - 1].Split(' ').Last());
                                    }
                                }
                            }
                        }
                    }
                    using (StreamWriter sw = new StreamWriter(path))
                    {
                        foreach (string listplayer in list)
                        {
                            sw.WriteLine(listplayer);
                        }
                    }
                }
                else {
                    MessageBox.Show("Name must not contain spaces", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }               
            }
            else {
                MessageBox.Show("Name must be between 1 and 15 characters inclusive", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void buttonToMenu_Click(object sender, EventArgs e)
        {
            DeleteComponent();
            MainForm();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            DeleteComponent();
        }

        private void buttonRules_Click(object sender, EventArgs e)
        {
            DeleteComponent();
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

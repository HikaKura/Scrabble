﻿using System;
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

            if (textBox.Text.Count() > 0 && textBox.Text.Count() < 8)
            {
                if (!textBox.Text.Contains(" "))
                {
                    player = textBox.Text;
                    Close();
                    DeleteComponent();
                    //ScoreForm();
                    string path = Environment.CurrentDirectory + "\\Score.txt";
                    using (StreamReader sr = new StreamReader(path))
                    {
                        int key = 0;
                        int keymax = 0;
                        string line = "";
                        while (!sr.EndOfStream)
                        {
                            line = sr.ReadLine();
                            string[] words = line.Split(new char[] { ' ' });
                            key = Convert.ToInt32(words[1]);
                            if (key > keymax)
                            {
                                keymax = key;
                            }
                            score.Add(key, line);
                        }
                        string Player = player + " " + recordPlayer;
                        score.Add(recordPlayer, Player);
                        var sortedDict = new SortedDictionary<int, string>(score);
                        foreach (KeyValuePair<int, string> sort in sortedDict)
                        {
                            stack.Push(sort.Value);
                        }
                    }
                    using (StreamWriter sw = new StreamWriter(path))
                    {
                        foreach (KeyValuePair<int, string> Scores in score)
                        {
                            sw.WriteLine(stack.Pop());
                        }
                    }
                }
                else {
                    MessageBox.Show("Name must not contain spaces", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }               
            }
            else {
                MessageBox.Show("Name must be between 1 and 7 characters inclusive", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

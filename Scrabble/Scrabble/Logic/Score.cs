using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrabble.Logic
{
    class Score
    {
        Dictionary<String, int> Players;
        public Score()
        {
            try
            {
                using (StreamReader sr = new StreamReader("Score.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        String[] data = line.Split();
                        String player = data[0];
                        int score = Int32.Parse(data[1]);
                        Players[player] = score;
                    }
                }

            }
            catch (Exception)
            {
            }
        }
        public void Update(String player, int score)
        {
            if (Players[player] < score)
            {
                Players[player] = score;
                using (StreamWriter sr = new StreamWriter("Score"))
                {
                    foreach (var item in Players)
                    {
                        sr.WriteLine(item.Key + " " + item.Value);
                    }
                }
            }
        }
    }
}

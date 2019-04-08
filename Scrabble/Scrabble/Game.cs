using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scrabble
{
    struct Letter
    {
        public char letter;
        public int w, h;
        public Letter(int w, int h, char letter)
        {
            this.letter = letter;
            this.h = h;
            this.w = w;
        }
        public static int operator -(Letter a, Letter b)
        {
            return Math.Abs(a.w - b.w) + Math.Abs(a.h - b.h);
        }
    }
    struct Player
    {
        public static Random random = new Random();
        public String Name;
        public Char[] Letters;
        public bool[] Used;
        public int Score;
        public Player(String name, int letter_count)
        {
            Score = 0;
            Name = name;
            Letters = new char[letter_count];
            Used = new bool[letter_count];
        }
        public void Refill()
        {
            for (int i = 0; i < Letters.Length; i++)
            {
                Letters[i] = (char)((int)'a' + random.Next() % 26);
            }
        }
    }
    class Game
    {
        public static Game game = new Game();
        public Letter[,] Pole;
        public Player player;
        public Dictionary<char, int> dic;

        public List<Letter> word;

        public int turn;

        private Game()
        {
            dic = new Dictionary<char, int>();
            turn = 0;
            word = new List<Letter>();
            Pole = new Letter[15, 15];
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    Pole[i, j] = new Letter();
                    Pole[i, j].w = i;
                    Pole[i, j].h = j;
                }
            }
            player = new Player("Player", 7);
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    Pole[i, j].letter = default(char);
                    Pole[i, j].w = i;
                    Pole[i, j].h = j;
                }
            }
            dic.Add('a', 1);
            dic.Add('e', 1);
            dic.Add('i', 1);
            dic.Add('l', 1);
            dic.Add('n', 1);
            dic.Add('o', 1);
            dic.Add('r', 1);
            dic.Add('s', 1);
            dic.Add('t', 1);
            dic.Add('u', 1);
            dic.Add('d', 2);
            dic.Add('g', 2);
            dic.Add('b', 3);
            dic.Add('c', 3);
            dic.Add('m', 3);
            dic.Add('p', 3);
            dic.Add('f', 4);
            dic.Add('h', 4);
            dic.Add('v', 4);
            dic.Add('w', 4);
            dic.Add('y', 4);
            dic.Add('k', 5);
            dic.Add('j', 8);
            dic.Add('x', 8);
            dic.Add('q', 10);
            dic.Add('z', 10);
        }

        public void UpdateButtons()
        {
            player.Refill();
            PoleButtons.pb.UpdateButtons(player.Letters);
        }

        public bool PlaceLetter(int w, int h, char a)
        {
            if (Pole[w, h].letter == default(char))
            {
                Pole[w, h].letter = a;
            }
            return false;
        }

        public bool SelectLetter(int w, int h)
        {
            //буква существует в клетке
            if (Pole[w, h].letter != default(char))
            {
                int ind = word.FindIndex((Letter x) => { return x.h == h && x.w == w; });
                //буква есть в слове
                if (ind != -1)
                {
                    while (word.Count > ind)
                    {
                        PoleButtons.pb.ClearLetter(word[word.Count - 1].w, word[word.Count - 1].h);
                        word.RemoveAt(word.Count - 1);
                    }
                }
                else
                {
                    //буква соседняя с последней
                    if ((word.Count == 0) || ((word.Last<Letter>() - Pole[w, h]) == 1))
                    {
                        word.Add(Pole[w, h]);
                        return true;
                    }
                }
            }
            return false;
        }

        public void CheckWord(Label record)
        {
            String s = ""; int score = 0;

            foreach (var item in word)
            {
                s += item.letter;
                score += dic[item.letter];
            }
            if (Diction.FindWord(s))
            {
                
                record.Text = (Int32.Parse(record.Text) + score).ToString();
                SelectLetter(word[0].w, word[0].h);
            }
        }
    }
}

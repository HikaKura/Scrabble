using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public int Score;
        public Player(String name, int letter_count)
        {
            Score = 0;
            Name = name;
            Letters = new char[letter_count];
        }
        public void Refill()
        {
            for (int i = 0; i < Letters.Length; i++)
            {
                if (Letters[i] == default(char))
                {
                    Letters[i] = (char)((int)'A' + random.Next() % 33);
                }
            }
        }
    }
    class Game
    {
        public static Game game = new Game();
        public Letter[,] Pole;
        public Player[] Players;

        public List<Letter> word;

        public int turn;

        private Game()
        {
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
        }
        public void Start(String[] players) { 
            Players = new Player[players.Length];
            for (int i = 0; i < players.Length; i++)
            {
                Players[i] = new Player(players[i], 7);
                Players[i].Refill();
            }
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    Pole[i, j].letter = default(char);
                    Pole[i, j].w = i;
                    Pole[i, j].h = j;
                }
            }
        }

        public bool NextTurn()
        {
            turn = (turn + 1) % Players.Length;
            return false;
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

        public bool CheckWord()
        {
            return true;
        }

        public void Debug()
        {
            foreach (var player in Players)
            {
                Console.Out.WriteLine(player.Name);
            }
            Console.Out.WriteLine("turn:" + Players[turn].Name);
            for (int j = 0; j < Pole.GetLength(1); j++)
            {
                for (int i = 0; i < Pole.GetLength(0); i++)
                {
                    Console.Out.Write("" + Pole[j, i].letter + ' ');
                }
                Console.Out.WriteLine();
            }
            foreach (var letter in word)
            {
                Console.Out.Write(letter.letter);
            }
            Console.Out.WriteLine();
        }
    }
}

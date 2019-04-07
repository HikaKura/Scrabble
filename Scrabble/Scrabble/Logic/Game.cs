using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrabble.Logic
{
    class Game
    {
        public char[,] map;
        public enum Bonus
        {
            plus1,
            mul2,
            plus2,
            mul3,
            plus3
        }
        public Bonus[,] bonuses;
        public bool[,] select;
        public String Current_word;
        public String[] players;
        public char[,] letters;
        public int[] score;
        public int turn;

        public Game(int h, int w, String[] players)
        {
            map = new char[w, h];
            this.players = players;
            score = new int[players.Length];
            turn = 0;
        }

        public bool Add_letter(int w, int h, char a)
        {

            if (map[w, h] == default(char))
            {
                map[w, h] = a;
            }
            return true;
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Scrabble.Logic
{
    class Diction
    {
        private static Diction diction = new Diction();
        private SortedSet<String> dic = new SortedSet<string>();
        public Diction()
        {
            using (StreamReader sr = new StreamReader("Dictionary.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    dic.Add(line);
                }
            }
        }
        public static bool FindWord(String word)
        {
            return diction.dic.Contains(word);
        }
    }
}

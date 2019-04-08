using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Scrabble
{
    class Diction
    {
        public static Diction diction = new Diction();
        public SortedSet<String> dic = new SortedSet<string>();
        public Diction()
        {
            using (StreamReader sr = new StreamReader("Dictionary.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    dic.Add(line.ToLower());
                }
            }
        }
        public static bool FindWord(String word)
        {
            return diction.dic.Contains(word);
        }
    }
}
